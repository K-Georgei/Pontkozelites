using ScottPlot;
using ScottPlot.Plottables;
using System.ComponentModel;
using System.Diagnostics;
using Color = System.Drawing.Color;

namespace Kozelites
{
    public partial class Form1 : Form
    {
        public BindingList<Pont2D> pontok;

        public Random rand;

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

        public InsertFunction insertFunction;
        public string selectedFunction;
        public bool isNoiseEnabled;
        public float noise;
        public int maxIter;



        public Form1()
        {
            InitializeComponent();

            insertFunction = new InsertFunction();

            rand = new Random();

            isNoiseEnabled = insertFunction.checkBox1.Checked;
            noise = (float)(insertFunction.trackBar1.Value * rand.NextDouble());

            xInput.Maximum = decimal.MaxValue;
            xInput.Minimum = decimal.MinValue;
            yInput.Maximum = decimal.MaxValue;
            yInput.Minimum = decimal.MinValue;

            pontok = new BindingList<Pont2D>(); // Ez automatikusan frissíti a DataGridView-t
            dataGridView1.DataSource = pontok;

            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            toolTip1.SetToolTip(button1, $"Menj a {tabPage3.Name} fülre");
            toolTip2.SetToolTip(HeatmapCheck, $"Menj a {tabPage2.Name} fülre");

            ShowA0A1.Text = $"a0: 0,     a1: 0";


            maxIter = (int)insertFunction.MaxIterations.Value;


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
            //formsPlot1.Plot.Axes.AutoScale();
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

                //formsPlot1.Plot.Axes.AutoScale();
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

                //refreshGraph(tmp);
                return tmp;
            }
            else
            {
                return null;
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

            a0 = (x2sum * ysum - xsum * xysum) / (n * x2sum - (xsum * xsum));
            a1 = (n * xysum - xsum * ysum) / (n * x2sum - (xsum * xsum));

            ShowA0A1.Text = $"a0: {a0},     a1: {a1}";

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
            // Start és end koordináták az egyeneshez

            double startX = minX;
            double endX = maxX;
            double startY = a1 * minX + a0;
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

        private void Heatmap(LinePlot line)
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
                normpont[i].PointColor = color;
            }


            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.WhiteSmoke);
                float size = 20f;
                float radius = size / 2;

                foreach (var point in normpont)
                {
                    float x = Math.Clamp(point.X - radius, 0, gridWidth - size);
                    float y = Math.Clamp(point.Y - radius, 0, gridHeight - size);

                    g.FillEllipse(new SolidBrush(point.PointColor), x, y, size, size);
                }

                bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
                bitmap.Save("heatmap.bmp");
                Debug.WriteLine("Heatmap saved as heatmap.bmp");

                pictureBox1.BackgroundImage = bitmap;
            }

        }

        private Color GetHeatmapColor(float error, float min, float max)
        {
            // a hiba hozzárendeélése a színhez HSV színtérben
            float hue = (error - min) / (max - min) * 360;
            float saturation = 1.0f; // Full saturation
            float value = 1.0f; // Full brightness

            // Convert HSV to RGB
            return ColorFromHSV(hue, saturation, value);
        }

        private Color ColorFromHSV(float hue, float saturation, float value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            float f = hue / 60 - (float)Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }

        [Obsolete("Rbg színtér nem felelt meg a színinterpolációnak", true)]
        private Color GetHeatmapColora(float error, float min, float max)
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
                if (Math.Abs(min - error) / ratio < Math.Abs(max - error) / ratio)
                {
                    g = Math.Clamp((int)((1 - ratio * 2) * 255), 0, 255);
                    r = Math.Clamp((int)((1 - ratio) * 255), 0, 255);
                }
                else
                {
                    r = Math.Clamp((int)((1 - ratio * 2) * 255), 0, 255);
                    g = Math.Clamp((int)((1 - ratio) * 255), 0, 255);
                }


                return Color.FromArgb(128, r, g, b);
            }
        }

        private void show_LinRegress_CheckedChanged(object sender, EventArgs e)
        {
            if (show_LinRegress.Checked && pontok.Count < 2)
            {
                MessageBox.Show("Több adatpontra van szükség!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                show_LinRegress.Checked = false;
                refreshGraph(pontok.ToList());
            }
            else
            {
                CalculateLinRegression();

            }
        }

        private void HeatmapCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (HeatmapCheck.Checked && pontok.Count < 2)
            {
                MessageBox.Show("Nincs elég adat a heatmap megjelenítéséhez", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HeatmapCheck.Checked = false;
            }
            else if (HeatmapCheck.Checked && pontok.Count >= 2)
            {
                Heatmap(CalculateLinRegression());
                tabControl1.SelectedTab = tabPage2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YOut.Text = $"{(decimal)a1 * SolveForX_numeric.Value + (decimal)a0}";
            XOut.Text = $"{(decimal)(SolveForY_numeric.Value - (decimal)a0) / (decimal)a1}";
        }

        #region InsertFunction
        private void RandomPonts()
        {
            for (int i = 0; i < maxIter; i++)
            {
                AddPont(rand.Next(-10, 10), rand.Next(-10, 10));
            }
        }

        private void AbsPonts()
        {

            if (isNoiseEnabled)
            {
                for (int i = maxIter; i > -1; i--)
                {
                    noise = (float)(insertFunction.trackBar1.Value * rand.NextDouble());
                    AddPont(-i + noise, i + noise);

                    if (i != 0) // Nullát csak egyszer rajzoljuk
                    {
                        AddPont(Math.Abs(-i + noise), Math.Abs(i + noise));
                    }
                }
            }
            else
            {
                for (int i = maxIter; i > -1; i--)
                {
                    AddPont(-i, i);

                    if (i != 0) // Nullát csak egyszer rajzoljuk
                    {
                        AddPont(Math.Abs(-i), Math.Abs(i));
                    }
                }
            }

        }

        private void Logaritmic()
        {
            if (isNoiseEnabled)
            {
                for (int i = 1; i < maxIter; i++)
                {
                    noise = (float)(insertFunction.trackBar1.Value * rand.NextDouble());
                    AddPont(i, (float)Math.Log(i + noise));
                }
            }
            else
            {
                for (int i = 1; i < maxIter; i++)
                {
                    AddPont(i, (float)Math.Log(i));
                }
            }


        }

        private void Exponencialis()
        {
            if (isNoiseEnabled)
            {
                for (int i = 1; i < maxIter; i++)
                {
                    noise = (float)(insertFunction.trackBar1.Value * rand.NextDouble());
                    AddPont(i, (float)Math.Exp(i + noise));
                }
            }
            else
            {
                for (int i = 1; i < maxIter; i++)
                {
                    AddPont(i, (float)Math.Exp(i));
                }
            }

        }

        private void Hatvany(float fokszam)
        {
            if (isNoiseEnabled)
            {
                for (int i = -maxIter; i < maxIter+1; i++)
                {
                    noise = (float)(insertFunction.trackBar1.Value * rand.NextDouble());
                    AddPont(i, (float)Math.Pow(i + noise, fokszam));
                }
            }
            else
            {
                for (int i = -maxIter; i < maxIter+1; i++)
                {
                    AddPont(i, (float)Math.Pow(i, fokszam));
                }
            }

        }

        private void Hanyados()
        {
            if (isNoiseEnabled)
            {
                for (int i = 1; i < maxIter; i++)
                {
                    noise = (float)(insertFunction.trackBar1.Value * rand.NextDouble());
                    AddPont(i, (float)1 / i+noise);
                }
            }
            else
            {
                for (int i = 1; i < maxIter; i++)
                {
                    AddPont(i, (float)1/i);
                }
            }
        }

        private void Gyok()
        {
            if (isNoiseEnabled)
            {
                for (int i = 0; i < maxIter; i++)
                {
                    noise = (float)(insertFunction.trackBar1.Value * rand.NextDouble());
                    AddPont(i, (float)Math.Sqrt(i + noise));
                }
            }
            else
            {
                for (int i = 0; i < maxIter; i++)
                {
                    AddPont(i, (float)Math.Sqrt(i));
                }
            }
        }

        private void Sinus()
        {
            if (isNoiseEnabled)
            {
                for (int i = 0; i < maxIter; i++)
                {
                    noise = (float)(insertFunction.trackBar1.Value * rand.NextDouble());
                    AddPont(i, (float)Math.Sin(i + noise));
                }
            }
            else
            {
                for (int i = 0; i < maxIter; i++)
                {
                    AddPont(i, (float)Math.Sin(i));
                }
            }


        }

        private void Cosinus()
        {
            if (isNoiseEnabled)
            {
                for (int i = 0; i < maxIter; i++)
                {
                    noise = (float)(insertFunction.trackBar1.Value * rand.NextDouble());
                    AddPont(i, (float)Math.Sin(i + noise));
                }
            }
            else
            {
                for (int i = 0; i < maxIter; i++)
                {
                    AddPont(i, (float)Math.Cos(i));
                }
            }
        }


        #endregion

        private void Scatter_points_Click(object sender, EventArgs e)
        {
            insertFunction.ShowDialog();
            insertFunction.AcceptButton = insertFunction.InsertScatter_points;

            if (insertFunction.DialogResult == DialogResult.OK)
            {
                selectedFunction = insertFunction.FunctionsList.SelectedItem.ToString();
                maxIter = (int)insertFunction.MaxIterations.Value;
                isNoiseEnabled = insertFunction.checkBox1.Checked;
                noise = (float)(insertFunction.trackBar1.Value * rand.NextDouble());

                if (string.IsNullOrEmpty(selectedFunction))
                {
                    MessageBox.Show("Kérlek válassz egy függvényt a listából", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                

                switch (selectedFunction)
                {
                    case "Sin":
                        Sinus();
                        break;

                    case "Cos":
                        Cosinus();
                        break;

                    case "Hányados":
                        Hanyados();
                        break;

                    case "Másodfokú":
                        Hatvany(2);
                        break;

                    case "Harmadfokú":
                        Hatvany(3);
                        break;

                    case "Gyök":
                        Gyok(); // Próbáltam hatvány (1/2) és hatvány 0.5-öt is, de nem mûködött
                        break;

                    case "Exponenciális":
                        Exponencialis();
                        break;

                    case "Logaritmus":
                        Logaritmic();
                        break;

                    case "Abszolútérték":
                        AbsPonts();
                        break;

                    case "Véletlenszerû":
                        RandomPonts();
                        break;

                    default:
                        MessageBox.Show("Ismeretlen függvény", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            pontok.Clear();
            HeatmapCheck.Checked = false;
            show_LinRegress.Checked = false;
            checkBox2.Checked = false;
            UpdatePlot();
        }


    }
}

