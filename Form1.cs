using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using ScottPlot;
using ScottPlot.DataGenerators;
using ScottPlot.Plottables;
using ScottPlot.WinForms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Color = System.Drawing.Color;

namespace Kozelites
{
    public partial class Form1 : Form
    {
        public BindingList<Pont2D> pontok;

        public float minX;
        public float minY;
        public float maxX;
        public float maxY;

        public float xsum;
        public float ysum;
        public float x2sum;
        public float xysum;
        public int n;

        public float a0;
        public float a1;

        public Bitmap bg;

        public Form1()
        {
            InitializeComponent();
            xInput.Maximum = decimal.MaxValue;
            xInput.Minimum = decimal.MinValue;
            yInput.Maximum = decimal.MaxValue;
            yInput.Minimum = decimal.MinValue;

            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";


            pontok = new BindingList<Pont2D>(); // Ez automatikusan frissíti a DataGridView-t
            dataGridView1.DataSource = pontok;

            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void formsPlot1_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkBox2.Checked && e.Button == MouseButtons.Left)
            {
                Coordinates coords = formsPlot1.Plot.GetCoordinates(e.X, e.Y);

                AddPont((float)coords.X, (float)coords.Y);

                Debug.WriteLine($"Currently added {coords.ToString()}");

            }
        }

        #region Add/Remove
        private void btn_addPont_Click(object sender, EventArgs e)
        {
            AddPont((float)xInput.Value, (float)yInput.Value);
        }

        private void btn_removePont_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                pontok.RemoveAt(index);
                UpdatePlot();
            }
            else
            {
                MessageBox.Show("Nincs mit eltávolítani!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void AddPont(float x, float y)
        {
            pontok.Add(new Pont2D(x, y));
            SetValues();
            UpdatePlot();
        }
        #endregion
        #region Update/Refresh
        private void UpdatePlot()
        {
            formsPlot1.Plot.Clear();
            foreach (var p in pontok)
            {
                formsPlot1.Plot.Add.Scatter(p.X, p.Y);

            }
            formsPlot1.Plot.Axes.AutoScale();
            formsPlot1.Refresh();
        }

        private void refreshGraph(List<Pont2D> pontok)
        {
            formsPlot1.Plot.Clear();

            if (pontok.Count > 1)
            {
                foreach (Pont2D p in pontok)
                {
                    formsPlot1.Plot.Add.Scatter(p.X, p.Y);
                }

                formsPlot1.Plot.Axes.AutoScale();
            }
            formsPlot1.Refresh();
        }

        #endregion

        private List<Pont2D> Normalize(List<Pont2D> pontok, int width = 1, int height = 1)
        {
            List<Pont2D> tmp = new List<Pont2D>();

            if (pontok.Count > 1)
            {
                float padding = 0.0001f;
                if (maxX - minX == 0)
                {
                    maxX += padding;
                    minX -= padding;
                }
                if (maxY - minY == 0)
                {
                    maxY += padding;
                    minY -= padding;
                }

                foreach (var p in pontok)
                {
                    float normX = (p.X - minX) / (maxX - minX) * width;
                    float normY = (p.Y - minY) / (maxY - minY) * height;
                    //TODO a pontok nevét frissíteni
                    tmp.Add(new Pont2D(normX, normY));
                }

                refreshGraph(tmp);
                return tmp;
            }
            else
            {
                MessageBox.Show("Nincs elegendõ adat", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBox1.Checked = false;
                return null;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Normalize(pontok.ToList());
            }
            else
            {
                refreshGraph(pontok.ToList());
            }
        }

        private void SetValues()
        {
            minX = pontok.Min(p => p.X);
            minY = pontok.Min(p => p.Y);
            maxX = pontok.Max(p => p.X);
            maxY = pontok.Max(p => p.Y);

            xsum = pontok.Sum(p => p.X);
            ysum = pontok.Sum(p => p.Y);
            x2sum = pontok.Sum(p => p.X2);
            xysum = pontok.Sum(p => p.XY);

            n = pontok.Count;

            a0 = (x2sum * ysum - xsum * xysum) / (n * x2sum - xsum);
            a1 = (n * xysum - xsum * ysum) / (n * x2sum - xsum);

        }


        private List<float> CalculateError()
        {
            float d = 0.0f;
            List<float> errors = new List<float>();

            foreach (Pont2D p in pontok)
            {
                d = (float)Math.Pow(p.Y - (a1 * p.X + a0), 2);
                errors.Add(d);
            }

            return errors;
        }

        private LinePlot CalculateLinRegression()
        {
            if (pontok.Count < 2)
            {
                MessageBox.Show("Több adatpontra van szükség!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Start és end koordináták az egyeneshez
            double startX = minX;
            double startY = a1 * minX + a0;

            double endX = maxX;
            double endY = a1 * maxX + a0;

            Debug.WriteLine($"Line start: ({startX}, {startY}) end: ({endX}, {endY})");

            // ScottPlot vonal rajzolása
            LinePlot line = formsPlot1.Plot.Add.Line(
                x1: startX,
                y1: startY,
                x2: endX,
                y2: endY
            );

            // Stílus beállítások
            ScottPlot.Colormaps.Viridis colormap = new();
            line.Color = Generate.RandomColor(colormap);
            line.LineWidth = 2;
            line.LinePattern = LinePattern.Solid;

            // Frissítés
            formsPlot1.Refresh();
            return line;

        }

        private void Heatmap(LinePlot line) // params: LinePlot line, float a1, float a0
        {

            Size frame = formsPlot1.Size;
            int gridWidth = frame.Width;
            int gridHeight = frame.Height;
            Bitmap bitmap = new Bitmap(gridWidth, gridHeight);

            List<Pont2D> normpont = Normalize(pontok.ToList(), gridWidth, gridHeight);
            List<float> errors = CalculateError();

            float nearest = errors.Min();
            float furhest = errors.Max();
            
            Debug.WriteLine($"Nearest: {nearest}, Furhest: {furhest}\n");

            for (int i = 0; i < normpont.Count; i++)
            {
                float error = errors[i];
                Color color = GetHeatmapColor(error, nearest, furhest);
                Debug.WriteLine($"{error}, {color}");
                normpont[i].PointColor = color; // Assign color to Pont2D instance
            }


            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.Black);
                foreach (var point in normpont)
                {
                    // Use point.PointColor to set the color for drawing
                    g.FillEllipse(new SolidBrush(point.PointColor), point.X, point.Y, 20f, 20f);
                }

              

                bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
                bitmap.Save("heatmap.bmp"); // Mentés
                Debug.WriteLine("Heatmap saved as heatmap.bmp");

                pictureBox1.BackgroundImage = bitmap;
            }
        }

        private Color GetHeatmapColor(float error, float min, float max)
        {
            int r = 0;
            int g = 0;
            int b = 0;
            if (error == min)
            {
                r = 0;
                g = 255;
                return Color.FromArgb(r, g, b);
            }
            else if (error == max)
            {
                r = 255;
                g = 0;
                return Color.FromArgb(r, g, b);
            }
            else
            {
                float ratio = (error - min) / (max - min);
                r = Math.Clamp((int)(ratio * 255), 0, 255);
                g = Math.Clamp((int)((1 - ratio) * 255), 0, 255);
                return Color.FromArgb(r, g, b);
            }
        }




        private void show_LinRegress_CheckedChanged(object sender, EventArgs e)
        {
            if (show_LinRegress.Checked)
            {
                CalculateLinRegression();
            }
            else
            {
                refreshGraph(pontok.ToList());
            }
        }

        private void HeatmapCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (HeatmapCheck.Checked)
            {
                Heatmap(CalculateLinRegression());
            }
            else
            {

            }
        }

        private void track_min_Scroll(object sender, EventArgs e)
        {
            label6.Text = $"{Math.Round(track_min.Value / 101.0, 4)}";
        }
        private void track_mid_Scroll(object sender, EventArgs e)
        {
            label8.Text = $"{Math.Round(track_mid.Value / 101.0, 4)}";
        }

        private void track_max_Scroll(object sender, EventArgs e)
        {
            label7.Text = $"{Math.Round(track_max.Value / 101.0, 4)}";
        }

        

        private void RecalcImg_btn_Click(object sender, EventArgs e)
        {
            Heatmap(CalculateLinRegression());
        }
    }
}

