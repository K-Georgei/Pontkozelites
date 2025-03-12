using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using ScottPlot;
using ScottPlot.DataGenerators;
using ScottPlot.WinForms;

namespace Kozelites
{
    public partial class Form1 : Form
    {
        public BindingList<Pont2D> pontok;


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

                Debug.WriteLine($"x:{coords.X} y:{coords.Y}");

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

        private void Normalize(List<Pont2D> pontok)
        {
            List<Pont2D> tmp = new List<Pont2D>();

            if (pontok.Count > 1)
            {
                float minX = pontok.Min(p => p.X);
                float minY = pontok.Min(p => p.Y);
                float maxX = pontok.Max(p => p.X);
                float maxY = pontok.Max(p => p.Y);

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

        private void CalculateRegression()
        {
            float xsum = 0;
            float ysum = 0;
            float x2sum = 0;
            float xysum = 0;


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                xsum += Convert.ToSingle(dataGridView1[1, i]);
            }
            
            float a0 = 0; // ((x^2) * y) - (x * (x * y))/(x^2-xi)
            float a1 = 0;

            


            
        }


    }
}

