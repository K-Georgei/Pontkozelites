namespace Kozelites
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_addPont = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            yInput = new NumericUpDown();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            xInput = new NumericUpDown();
            btn_removePont = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            checkBox2 = new CheckBox();
            show_LinRegress = new CheckBox();
            HeatmapCheck = new CheckBox();
            groupBox1 = new GroupBox();
            flowLayoutPanel7 = new FlowLayoutPanel();
            Scatter_points = new Button();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            tabPage3 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label3 = new Label();
            SolveForX_numeric = new NumericUpDown();
            label4 = new Label();
            XOut = new TextBox();
            label7 = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label5 = new Label();
            SolveForY_numeric = new NumericUpDown();
            label6 = new Label();
            YOut = new TextBox();
            label8 = new Label();
            ShowA0A1 = new Label();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            flowLayoutPanel8 = new FlowLayoutPanel();
            label9 = new Label();
            zInput = new NumericUpDown();
            Enable3D = new CheckBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yInput).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)xInput).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SolveForX_numeric).BeginInit();
            flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SolveForY_numeric).BeginInit();
            flowLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)zInput).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.2381363F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.7618637F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.7771F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.2229042F));
            tableLayoutPanel1.Size = new Size(1159, 525);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(414, 418);
            dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 136F));
            tableLayoutPanel2.Controls.Add(btn_addPont, 0, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 1, 1);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(btn_removePont, 1, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel8, 2, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 427);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(414, 95);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_addPont
            // 
            btn_addPont.Dock = DockStyle.Fill;
            btn_addPont.Location = new Point(3, 3);
            btn_addPont.Name = "btn_addPont";
            btn_addPont.Size = new Size(133, 41);
            btn_addPont.TabIndex = 0;
            btn_addPont.Text = "Hozzáadás";
            btn_addPont.UseVisualStyleBackColor = true;
            btn_addPont.Click += btn_addPont_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(yInput);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(142, 50);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(133, 42);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 3;
            label2.Text = "Y:";
            // 
            // yInput
            // 
            yInput.Location = new Point(3, 18);
            yInput.Name = "yInput";
            yInput.Size = new Size(120, 23);
            yInput.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(xInput);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 50);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(133, 42);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 3;
            label1.Text = "X:";
            // 
            // xInput
            // 
            xInput.Location = new Point(3, 18);
            xInput.Name = "xInput";
            xInput.Size = new Size(120, 23);
            xInput.TabIndex = 4;
            // 
            // btn_removePont
            // 
            btn_removePont.Dock = DockStyle.Fill;
            btn_removePont.Location = new Point(142, 3);
            btn_removePont.Name = "btn_removePont";
            btn_removePont.Size = new Size(133, 41);
            btn_removePont.TabIndex = 5;
            btn_removePont.Text = "Eltávolítás";
            btn_removePont.UseVisualStyleBackColor = true;
            btn_removePont.Click += btn_removePont_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(checkBox2);
            flowLayoutPanel3.Controls.Add(show_LinRegress);
            flowLayoutPanel3.Controls.Add(HeatmapCheck);
            flowLayoutPanel3.Controls.Add(Enable3D);
            flowLayoutPanel3.Controls.Add(groupBox1);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(423, 427);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(733, 95);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(3, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(183, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "kattintásra hozzáadott pontok";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // show_LinRegress
            // 
            show_LinRegress.AutoSize = true;
            show_LinRegress.Location = new Point(192, 3);
            show_LinRegress.Name = "show_LinRegress";
            show_LinRegress.Size = new Size(176, 19);
            show_LinRegress.TabIndex = 3;
            show_LinRegress.Text = "Lineáris Regresszió mutatása";
            show_LinRegress.UseVisualStyleBackColor = true;
            show_LinRegress.CheckedChanged += show_LinRegress_CheckedChanged;
            // 
            // HeatmapCheck
            // 
            HeatmapCheck.AutoSize = true;
            HeatmapCheck.Location = new Point(374, 3);
            HeatmapCheck.Name = "HeatmapCheck";
            HeatmapCheck.Size = new Size(130, 19);
            HeatmapCheck.TabIndex = 4;
            HeatmapCheck.Text = "Hő térkép mutatása";
            HeatmapCheck.UseVisualStyleBackColor = true;
            HeatmapCheck.CheckedChanged += HeatmapCheck_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel7);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(3, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 52);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(Scatter_points);
            flowLayoutPanel7.Controls.Add(button1);
            flowLayoutPanel7.Controls.Add(button2);
            flowLayoutPanel7.Dock = DockStyle.Fill;
            flowLayoutPanel7.Location = new Point(3, 19);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(409, 30);
            flowLayoutPanel7.TabIndex = 0;
            // 
            // Scatter_points
            // 
            Scatter_points.Location = new Point(3, 3);
            Scatter_points.Name = "Scatter_points";
            Scatter_points.Size = new Size(130, 23);
            Scatter_points.TabIndex = 6;
            Scatter_points.Text = "Függvény Beszúrása";
            Scatter_points.UseVisualStyleBackColor = true;
            Scatter_points.Click += Scatter_points_Click;
            // 
            // button1
            // 
            button1.Location = new Point(139, 3);
            button1.Name = "button1";
            button1.Size = new Size(102, 23);
            button1.TabIndex = 4;
            button1.Text = "Old meg X és Y";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(247, 3);
            button2.Name = "button2";
            button2.Size = new Size(134, 23);
            button2.TabIndex = 7;
            button2.Text = "Minden pont törlése";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(423, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 418);
            panel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(733, 418);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(formsPlot1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(725, 390);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Grafikon";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(3, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(719, 384);
            formsPlot1.TabIndex = 3;
            formsPlot1.MouseDown += formsPlot1_MouseDown;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(725, 390);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Heatmap";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(719, 384);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(725, 390);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "(X;Y) értékre való megoldás";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(flowLayoutPanel6, 0, 0);
            tableLayoutPanel3.Controls.Add(ShowA0A1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(719, 384);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel6.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel6.Dock = DockStyle.Fill;
            flowLayoutPanel6.Location = new Point(3, 3);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(713, 186);
            flowLayoutPanel6.TabIndex = 5;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label3);
            flowLayoutPanel4.Controls.Add(SolveForX_numeric);
            flowLayoutPanel4.Controls.Add(label4);
            flowLayoutPanel4.Controls.Add(XOut);
            flowLayoutPanel4.Controls.Add(label7);
            flowLayoutPanel4.Dock = DockStyle.Top;
            flowLayoutPanel4.Location = new Point(3, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(420, 51);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 0;
            label3.Text = "X:";
            // 
            // SolveForX_numeric
            // 
            SolveForX_numeric.Location = new Point(26, 3);
            SolveForX_numeric.Name = "SolveForX_numeric";
            SolveForX_numeric.Size = new Size(120, 23);
            SolveForX_numeric.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 0);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 3;
            label4.Text = "=";
            // 
            // XOut
            // 
            XOut.Location = new Point(173, 3);
            XOut.Name = "XOut";
            XOut.Size = new Size(100, 23);
            XOut.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(279, 0);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 4;
            label7.Text = "X=(y-a0)/a1";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label5);
            flowLayoutPanel5.Controls.Add(SolveForY_numeric);
            flowLayoutPanel5.Controls.Add(label6);
            flowLayoutPanel5.Controls.Add(YOut);
            flowLayoutPanel5.Controls.Add(label8);
            flowLayoutPanel5.Dock = DockStyle.Top;
            flowLayoutPanel5.Location = new Point(3, 60);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(420, 55);
            flowLayoutPanel5.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 0;
            label5.Text = "Y:";
            // 
            // SolveForY_numeric
            // 
            SolveForY_numeric.Location = new Point(26, 3);
            SolveForY_numeric.Name = "SolveForY_numeric";
            SolveForY_numeric.Size = new Size(120, 23);
            SolveForY_numeric.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(152, 0);
            label6.Name = "label6";
            label6.Size = new Size(15, 15);
            label6.TabIndex = 3;
            label6.Text = "=";
            // 
            // YOut
            // 
            YOut.Location = new Point(173, 3);
            YOut.Name = "YOut";
            YOut.Size = new Size(100, 23);
            YOut.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(279, 0);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 4;
            label8.Text = "Y=a1*x+a0";
            // 
            // ShowA0A1
            // 
            ShowA0A1.AutoSize = true;
            ShowA0A1.Dock = DockStyle.Top;
            ShowA0A1.Location = new Point(3, 192);
            ShowA0A1.Name = "ShowA0A1";
            ShowA0A1.Size = new Size(713, 15);
            ShowA0A1.TabIndex = 6;
            ShowA0A1.Text = "label7";
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Controls.Add(label9);
            flowLayoutPanel8.Controls.Add(zInput);
            flowLayoutPanel8.Location = new Point(281, 50);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(130, 42);
            flowLayoutPanel8.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(17, 15);
            label9.TabIndex = 3;
            label9.Text = "Z:";
            // 
            // zInput
            // 
            zInput.Location = new Point(3, 18);
            zInput.Name = "zInput";
            zInput.Size = new Size(120, 23);
            zInput.TabIndex = 4;
            // 
            // Enable3D
            // 
            Enable3D.AutoSize = true;
            Enable3D.Location = new Point(510, 3);
            Enable3D.Name = "Enable3D";
            Enable3D.Size = new Size(119, 19);
            Enable3D.TabIndex = 9;
            Enable3D.Text = "3D engedélyezése";
            Enable3D.UseVisualStyleBackColor = true;
            Enable3D.CheckedChanged += Enable3D_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 525);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yInput).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)xInput).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            flowLayoutPanel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SolveForX_numeric).EndInit();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SolveForY_numeric).EndInit();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)zInput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private NumericUpDown yInput;
        private NumericUpDown xInput;
        private Button btn_addPont;
        private Button btn_removePont;
        private FlowLayoutPanel flowLayoutPanel3;
        private CheckBox checkBox2;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private CheckBox show_LinRegress;
        private CheckBox HeatmapCheck;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private TabPage tabPage3;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label3;
        private NumericUpDown SolveForX_numeric;
        private Label label4;
        private TextBox XOut;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label5;
        private NumericUpDown SolveForY_numeric;
        private Label label6;
        private TextBox YOut;
        private Button button1;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label ShowA0A1;
        private Label label7;
        private Label label8;
        private Button Scatter_points;
        private Button button2;
        private ToolTip toolTip3;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel7;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label label9;
        private NumericUpDown zInput;
        private CheckBox Enable3D;
    }
}
