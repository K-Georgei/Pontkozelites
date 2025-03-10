using System.ComponentModel;
using System.Windows.Forms;

namespace Kozelites
{
    public partial class Form1 : Form
    {
        public List<Pont2D> pontok;
        public Graphics g;

        public Form1()
        {
            InitializeComponent();
            xInput.Maximum = decimal.MaxValue;
            yInput.Maximum = decimal.MaxValue;
            g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            pontok = new List<Pont2D>();


            dataGridView1.DataSource = pontok;

            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoResizeColumns();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_addPont_Click(object sender, EventArgs e)
        {
            Pont2D pont2D = new Pont2D((float)xInput.Value, (float)yInput.Value);
            AddPont(pont2D);
        }

        private void AddPont(Pont2D pont)
        {
            pontok.Add(pont);
            dataGridView1.DataSource = null;        // Elõször töröljük a jelenlegi adatforrást
            dataGridView1.DataSource = pontok;      // Majd beállítjuk a frissített listát
            dataGridView1.AutoResizeColumns();      // Oszlopok automatikus újraméretezése
            drawEllipsze(pont);
        }

        private void drawEllipsze(Pont2D pont)
        {
            g.FillEllipse(Brushes.CornflowerBlue, pont.X, pont.Y, 10, 10);
            //g.DrawString(pont.Name, new Font("Arial", 12), new SolidBrush(Color.Black), pont.X, pont.Y + 4); majd késõbb hogy show point name
            
        }

      

      
    }
}
