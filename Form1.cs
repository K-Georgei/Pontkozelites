using System.Windows.Forms;

namespace Kozelites
{
    public partial class Form1 : Form
    {
        public List<Pont2D> pontok;


        public Form1()
        {
            InitializeComponent();
            pontok = new List<Pont2D>
            {
                new Pont2D("A", 10, 20),
                new Pont2D("B", 30, 40),
                new Pont2D("C", 50, 60)
            };

            dataGridView1.DataSource = pontok;

            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoResizeColumns();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pont2D pont2D = new Pont2D("p1", 100, 100);
            pontok.Add(pont2D);

            dataGridView1.DataSource = null;  // Elõször töröljük a jelenlegi adatforrást
            dataGridView1.DataSource = pontok;  // Majd beállítjuk a frissített listát
            dataGridView1.AutoResizeColumns(); // Oszlopok automatikus újraméretezése

            drawEllipsze(pont2D);

        }

        private void drawEllipsze(Pont2D pont)
        {
            using (Graphics g = pictureBox1.CreateGraphics())
            {
                g.Clear(Color.White);
                g.FillEllipse(Brushes.CornflowerBlue, pont.X, pont.Y, 10,10);
                g.DrawString(pont.Name, new Font("Arial", 12), new SolidBrush(Color.Black), pont.X,pont.Y+4);
            }
        }
       
    }
}
