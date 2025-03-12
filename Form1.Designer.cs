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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            show_LinRegress = new CheckBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yInput).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)xInput).BeginInit();
            flowLayoutPanel3.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(formsPlot1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.7771F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.2229042F));
            tableLayoutPanel1.Size = new Size(913, 489);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(337, 389);
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
            tableLayoutPanel2.Size = new Size(337, 88);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_addPont
            // 
            btn_addPont.Dock = DockStyle.Fill;
            btn_addPont.Location = new Point(3, 3);
            btn_addPont.Name = "btn_addPont";
            btn_addPont.Size = new Size(162, 38);
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
            flowLayoutPanel2.Location = new Point(171, 47);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(163, 38);
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
            flowLayoutPanel1.Size = new Size(162, 38);
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
            btn_removePont.Location = new Point(171, 3);
            btn_removePont.Name = "btn_removePont";
            btn_removePont.Size = new Size(163, 38);
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
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(346, 398);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(564, 88);
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
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(346, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(564, 389);
            formsPlot1.TabIndex = 3;
            formsPlot1.MouseDown += formsPlot1_MouseDown;
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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 489);
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
    }
}
