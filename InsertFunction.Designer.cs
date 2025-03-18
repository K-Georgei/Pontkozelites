namespace Kozelites
{
    partial class InsertFunction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            flowLayoutPanel7 = new FlowLayoutPanel();
            FunctionsList = new ComboBox();
            checkBox1 = new CheckBox();
            trackBar1 = new TrackBar();
            MaxIterations = new NumericUpDown();
            InsertScatter_points = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox3 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxIterations).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel7);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 134);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Függvény kiválasztása";
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(FunctionsList);
            flowLayoutPanel7.Controls.Add(checkBox1);
            flowLayoutPanel7.Controls.Add(trackBar1);
            flowLayoutPanel7.Dock = DockStyle.Fill;
            flowLayoutPanel7.Location = new Point(3, 19);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(372, 112);
            flowLayoutPanel7.TabIndex = 0;
            // 
            // FunctionsList
            // 
            FunctionsList.FormattingEnabled = true;
            FunctionsList.Items.AddRange(new object[] { "Sin", "Cos", "Hányados", "Másodfokú", "Harmadfokú", "Gyök", "Exponenciális", "Logaritmus", "Abszolútérték", "Véletlenszerű" });
            FunctionsList.Location = new Point(3, 3);
            FunctionsList.Name = "FunctionsList";
            FunctionsList.Size = new Size(366, 23);
            FunctionsList.TabIndex = 5;
            FunctionsList.Text = "Válassz egy függvényt";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 32);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Zaj hozzáadása";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // trackBar1
            // 
            trackBar1.Dock = DockStyle.Bottom;
            trackBar1.Enabled = false;
            trackBar1.Location = new Point(3, 57);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(366, 45);
            trackBar1.TabIndex = 7;
            trackBar1.Value = 1;
            // 
            // MaxIterations
            // 
            MaxIterations.Location = new Point(3, 3);
            MaxIterations.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            MaxIterations.Name = "MaxIterations";
            MaxIterations.Size = new Size(366, 23);
            MaxIterations.TabIndex = 7;
            MaxIterations.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // InsertScatter_points
            // 
            InsertScatter_points.Dock = DockStyle.Top;
            InsertScatter_points.Location = new Point(3, 3);
            InsertScatter_points.Name = "InsertScatter_points";
            InsertScatter_points.Size = new Size(75, 23);
            InsertScatter_points.TabIndex = 6;
            InsertScatter_points.Text = "Beszúrás";
            InsertScatter_points.UseVisualStyleBackColor = true;
            InsertScatter_points.Click += Scatter_points_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 57.37705F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42.62295F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 116F));
            tableLayoutPanel1.Size = new Size(384, 361);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(378, 98);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Maximum iterációs lépések";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(MaxIterations);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(372, 76);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowLayoutPanel2);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 247);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(378, 111);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hozzáadás";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(InsertScatter_points);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 19);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(372, 89);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // InsertFunction
            // 
            AcceptButton = InsertScatter_points;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(tableLayoutPanel1);
            Name = "InsertFunction";
            Text = "InsertFunction";
            groupBox1.ResumeLayout(false);
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxIterations).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox3;
        private FlowLayoutPanel flowLayoutPanel2;
        public ComboBox FunctionsList;
        public NumericUpDown MaxIterations;
        public Button InsertScatter_points;
        public CheckBox checkBox1;
        public TrackBar trackBar1;
    }
}