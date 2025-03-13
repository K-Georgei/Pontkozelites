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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            show_LinRegress = new CheckBox();
            HeatmapCheck = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            RecalcImg_btn = new Button();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            tabPage2 = new TabPage();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel3 = new TableLayoutPanel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label5 = new Label();
            track_mid = new TrackBar();
            label8 = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label4 = new Label();
            track_max = new TrackBar();
            label7 = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label3 = new Label();
            track_min = new TrackBar();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yInput).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)xInput).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)track_mid).BeginInit();
            flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)track_max).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)track_min).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5684547F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.4315453F));
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
            tableLayoutPanel1.Size = new Size(1159, 489);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(429, 389);
            dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btn_addPont, 0, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 1, 1);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(btn_removePont, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 398);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(429, 88);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_addPont
            // 
            btn_addPont.Dock = DockStyle.Fill;
            btn_addPont.Location = new Point(3, 3);
            btn_addPont.Name = "btn_addPont";
            btn_addPont.Size = new Size(208, 38);
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
            flowLayoutPanel2.Location = new Point(217, 47);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(209, 38);
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
            yInput.Location = new Point(26, 3);
            yInput.Name = "yInput";
            yInput.Size = new Size(120, 23);
            yInput.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(xInput);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 47);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(208, 38);
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
            xInput.Location = new Point(26, 3);
            xInput.Name = "xInput";
            xInput.Size = new Size(120, 23);
            xInput.TabIndex = 4;
            // 
            // btn_removePont
            // 
            btn_removePont.Dock = DockStyle.Fill;
            btn_removePont.Location = new Point(217, 3);
            btn_removePont.Name = "btn_removePont";
            btn_removePont.Size = new Size(209, 38);
            btn_removePont.TabIndex = 5;
            btn_removePont.Text = "Eltávolítás";
            btn_removePont.UseVisualStyleBackColor = true;
            btn_removePont.Click += btn_removePont_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(checkBox1);
            flowLayoutPanel3.Controls.Add(checkBox2);
            flowLayoutPanel3.Controls.Add(show_LinRegress);
            flowLayoutPanel3.Controls.Add(HeatmapCheck);
            flowLayoutPanel3.Controls.Add(numericUpDown1);
            flowLayoutPanel3.Controls.Add(RecalcImg_btn);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(438, 398);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(718, 88);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(115, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Normalizát nézet";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(124, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(183, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "kattintásra hozzáadott pontok";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // show_LinRegress
            // 
            show_LinRegress.AutoSize = true;
            show_LinRegress.Location = new Point(313, 3);
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
            HeatmapCheck.Location = new Point(495, 3);
            HeatmapCheck.Name = "HeatmapCheck";
            HeatmapCheck.Size = new Size(130, 19);
            HeatmapCheck.TabIndex = 4;
            HeatmapCheck.Text = "Hő térkép mutatása";
            HeatmapCheck.UseVisualStyleBackColor = true;
            HeatmapCheck.CheckedChanged += HeatmapCheck_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(3, 28);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // RecalcImg_btn
            // 
            RecalcImg_btn.Location = new Point(129, 28);
            RecalcImg_btn.Name = "RecalcImg_btn";
            RecalcImg_btn.Size = new Size(75, 23);
            RecalcImg_btn.TabIndex = 6;
            RecalcImg_btn.Text = "calcImg";
            RecalcImg_btn.UseVisualStyleBackColor = true;
            RecalcImg_btn.Click += RecalcImg_btn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(438, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 389);
            panel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(718, 389);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(formsPlot1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(710, 361);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(3, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(704, 355);
            formsPlot1.TabIndex = 3;
            formsPlot1.MouseDown += formsPlot1_MouseDown;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(710, 361);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Size = new Size(704, 355);
            splitContainer1.SplitterDistance = 234;
            splitContainer1.SplitterWidth = 10;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(flowLayoutPanel6, 0, 2);
            tableLayoutPanel3.Controls.Add(flowLayoutPanel5, 0, 1);
            tableLayoutPanel3.Controls.Add(flowLayoutPanel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tableLayoutPanel3.Size = new Size(234, 355);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(label5);
            flowLayoutPanel6.Controls.Add(track_mid);
            flowLayoutPanel6.Controls.Add(label8);
            flowLayoutPanel6.Dock = DockStyle.Fill;
            flowLayoutPanel6.Location = new Point(3, 245);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(228, 107);
            flowLayoutPanel6.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 0;
            label5.Text = "mid";
            // 
            // track_mid
            // 
            track_mid.Location = new Point(3, 18);
            track_mid.Maximum = 101;
            track_mid.Minimum = 1;
            track_mid.Name = "track_mid";
            track_mid.Size = new Size(226, 45);
            track_mid.TabIndex = 2;
            track_mid.Value = 1;
            track_mid.Scroll += track_mid_Scroll;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 66);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 3;
            label8.Text = "label8";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label4);
            flowLayoutPanel5.Controls.Add(track_max);
            flowLayoutPanel5.Controls.Add(label7);
            flowLayoutPanel5.Dock = DockStyle.Fill;
            flowLayoutPanel5.Location = new Point(3, 124);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(228, 115);
            flowLayoutPanel5.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 0;
            label4.Text = "max";
            // 
            // track_max
            // 
            track_max.Location = new Point(3, 18);
            track_max.Maximum = 101;
            track_max.Minimum = 1;
            track_max.Name = "track_max";
            track_max.Size = new Size(226, 45);
            track_max.TabIndex = 2;
            track_max.Value = 1;
            track_max.Scroll += track_max_Scroll;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 66);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 3;
            label7.Text = "label7";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label3);
            flowLayoutPanel4.Controls.Add(track_min);
            flowLayoutPanel4.Controls.Add(label6);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(3, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(228, 115);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 0;
            label3.Text = "min";
            // 
            // track_min
            // 
            track_min.Location = new Point(3, 18);
            track_min.Maximum = 101;
            track_min.Minimum = 1;
            track_min.Name = "track_min";
            track_min.Size = new Size(226, 45);
            track_min.TabIndex = 2;
            track_min.Value = 1;
            track_min.Scroll += track_min_Scroll;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 66);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 3;
            label6.Text = "label6";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 355);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 489);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)track_mid).EndInit();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)track_max).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)track_min).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private CheckBox show_LinRegress;
        private CheckBox HeatmapCheck;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel3;
        private TrackBar track_mid;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label5;
        private TrackBar track_max;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label4;
        private TrackBar track_min;
        private PictureBox pictureBox1;
        private NumericUpDown numericUpDown1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button RecalcImg_btn;
    }
}
