using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kozelites
{
    public partial class InsertFunction : Form
    {
        public InsertFunction()
        {
            InitializeComponent();
            InsertScatter_points.DialogResult = DialogResult.OK;

        }

        private void Scatter_points_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                trackBar1.Enabled = true;
            }
            if (!checkBox1.Checked)
            {
                trackBar1.Enabled = false;
                trackBar1.Value = trackBar1.Minimum;
            }
        }
    }
}
