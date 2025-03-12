using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ScottPlot;
using ScottPlot.DataGenerators;
using ScottPlot.Plottables;
using ScottPlot.WinForms;
using static System.Windows.Forms.AxHost;
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


        private Pont2D GetMin(List<Pont2D> pontlista)
        {
            float minX = pontok.Min(p => p.X);
            float minY = pontok.Min(p => p.Y);

            return new Pont2D(minX, minY);

        }

        private Pont2D GetMax(List<Pont2D> pontlista)
        {
            float maxX = pontok.Max(p => p.X);
            float maxY = pontok.Max(p => p.Y);

            return new Pont2D(maxX, maxY);
        }


        private void Normalize(List<Pont2D> pontok)
        {
            List<Pont2D> tmp = new List<Pont2D>();

            if (pontok.Count > 1)
            {

                // Add a small padding to avoid division by zero and ensure scaling works
                float padding = 0.0001f; // Minimal padding to handle identical values
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
                    float normX = (p.X - minX) / (maxX - minX);
                    float normY = (p.Y - minY) / (maxY - minY);
                    //TODO a pontok nevét frissíteni
                    tmp.Add(new Pont2D(normX, normY));
                }

                refreshGraph(tmp);
            }
            else
            {
                MessageBox.Show("Nincs elegendõ adat", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBox1.Checked = false;
                return;
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

        private Bitmap Heatmap(LinePlot line, float a1, float a0)
        {
            if (pontok.Count < 2 && !show_LinRegress.Checked)
            {
                MessageBox.Show("Több adatpontra van szükség vagy nem kapcsoltad be a lineáris regresszó mutatását!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Size frame = formsPlot1.Size;
            Bitmap bitmap = new Bitmap(frame.Width, frame.Height);
            double d = 0;

            double maxD = pontok.Max(p => Math.Pow(p.Y - (a1 * p.X + a0), 2));

            using (Graphics g = Graphics.FromImage(bitmap)) 
            {
                g.Clear(Color.Transparent);

                foreach (Pont2D p in pontok)
                {
                    d = Math.Pow(p.Y - (a1 * p.X + a0), 2);
                    Color color = GetColor(d/maxD);

                    int px = (int)((p.X - minX)/(maxX - minX) * (frame.Width - 1));
                    int py = (int)((p.Y - minY)/(maxY - minY) * (frame.Height - 1));

                    int blobsize = 20;
                    using (Brush brush = new SolidBrush(color)) 
                    {
                        g.FillEllipse(brush, px - blobsize/2, py - blobsize/2, blobsize, blobsize);
                    }
                }
            }
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            bitmap.Save("asd.bmp");
            Debug.WriteLine("saved bitmap");

            return bitmap;
        }


        private Color GetColor(double value)
        {
            value = Math.Clamp(value, 0, 1);

            int r = (int)(255 * Math.Min(2 * value, 1));
            int g = (int)(255 * Math.Min(2 * (1 - value), 1));
            int b = 50;

            return Color.FromArgb(100,r, g, b);
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
            bg = Heatmap(CalculateLinRegression(), a1, a0);
            
            if (HeatmapCheck.Checked)
            {

            }
            else
            {

            }
        }
    }
}

