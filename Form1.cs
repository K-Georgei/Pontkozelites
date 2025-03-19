using ScottPlot;
using ScottPlot.Plottables;
using System.ComponentModel;
using System.Diagnostics;
using static System.Windows.Forms.AxHost;
using Color = System.Drawing.Color;

namespace Kozelites
{
    public partial class Form1 : Form
    {
        private readonly DataService _dataService;
        private readonly PlotService _plotService;
        private readonly HeatmapService _heatmapService;

        public BindingList<Pont2D> pontok;

        public Random rand;

        private PointInserter _pointInserter;

        public float minX;
        public float minY;
        public float maxX;
        public float maxY;


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

            _pointInserter = new PointInserter(rand, insertFunction, pontok, AddPont, maxIter);
            _dataService = new DataService();
            _plotService = new PlotService(formsPlot1);
            _heatmapService = new HeatmapService(_dataService, _plotService);

            zInput.Enabled = false;


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
                _plotService.RefreshGraph(pontok.ToList());
            }
            else
            {
                MessageBox.Show("Nincs mit eltávolítani!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void AddPont(float x, float y)
        {
            pontok.Add(new Pont2D(x, y));
            _dataService.SetValues(pontok, out minX, out minY, out maxX, out maxY, out a0, out a1);
            _plotService.RefreshGraph(pontok.ToList());
            ShowA0A1.Text = $"a0: {_dataService.GetA0()},     a1: {_dataService.GetA1()}";

        }
        #endregion


        private void show_LinRegress_CheckedChanged(object sender, EventArgs e)
        {
            if (show_LinRegress.Checked && pontok.Count < 2)
            {
                MessageBox.Show("Több adatpontra van szükség!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                show_LinRegress.Checked = false;
                _plotService.RefreshGraph(pontok.ToList());
            }
            else if (!show_LinRegress.Checked)
            {
                _plotService.RefreshGraph(pontok.ToList());
            }
            else
            {
                var line = _plotService.CalculateLinRegression(minX, maxX, a0, a1);
                ScottPlot.Colormaps.Viridis colormap = new();

                LinePlot a = formsPlot1.Plot.Add.Line
                (
                    x1: line.Start.X,
                    y1: line.Start.Y,
                    x2: line.End.X,
                    y2: line.End.Y

                );

                a.Color = Generate.RandomColor(colormap);
                a.LineWidth = 2;
                a.LinePattern = LinePattern.Solid;

                Debug.WriteLine($"Line start: ({line.Start.X}, {line.Start.Y}) end: ({line.End.X}, {line.End.Y})");

                formsPlot1.Refresh();

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
                _heatmapService.GenerateHeatmap(formsPlot1, pictureBox1, pontok, a0, a1);
                tabControl1.SelectedTab = tabPage2;
            }
            else
            {
                _plotService.RefreshGraph(pontok.ToList());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YOut.Text = $"{(decimal)a1 * SolveForX_numeric.Value + (decimal)a0}";
            XOut.Text = $"{(decimal)(SolveForY_numeric.Value - (decimal)a0) / (decimal)a1}";
        }

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
                        _pointInserter.GenerateSinPoints(isNoiseEnabled);
                        break;

                    case "Cos":
                        _pointInserter.GenerateCosPoints(isNoiseEnabled);
                        break;

                    case "Hányados":
                        _pointInserter.GenerateQuotientPoints(isNoiseEnabled);
                        break;

                    case "Másodfokú":
                        _pointInserter.GeneratePowPoints(2, isNoiseEnabled);
                        break;

                    case "Harmadfokú":
                        _pointInserter.GeneratePowPoints(3, isNoiseEnabled);
                        break;

                    case "Gyök":
                        _pointInserter.GenerateSqrtPoints(isNoiseEnabled); // Próbáltam hatvány (1/2) és hatvány 0.5-öt is, de nem mûködött
                        break;

                    case "Exponenciális":
                        _pointInserter.GenerateExpPoints(isNoiseEnabled);
                        break;

                    case "Logaritmus":
                        _pointInserter.GenerateLogPoints(isNoiseEnabled); // c# log e alapú
                        break;

                    case "Abszolútérték":
                        _pointInserter.GenerateAbsPoints(isNoiseEnabled);
                        break;

                    case "Véletlenszerû":
                        _pointInserter.GenerateScatterPoints();
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
            _plotService.RefreshGraph(pontok.ToList());
        }

        private void Enable3D_CheckedChanged(object sender, EventArgs e)
        {
            if (Enable3D.Checked)
            {
                formsPlot1.Visible = false;
                zInput.Enabled = true;
            }
            else
            {
                zInput.Enabled = false;
                formsPlot1.Visible = true;
            }
        }
    }
}

