namespace WinFormsApp1
{
    partial class Appointment_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment_List));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(475, 329);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 0;
            label1.Text = "Doctor ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(485, 474);
            label2.Name = "label2";
            label2.Size = new Size(127, 32);
            label2.TabIndex = 1;
            label2.Text = "Patient ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(506, 552);
            label3.Name = "label3";
            label3.Size = new Size(67, 32);
            label3.TabIndex = 2;
            label3.Text = "Date";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(898, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(810, 504);
            dataGridView1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(633, 335);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(633, 474);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 28);
            comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(633, 558);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(200, 28);
            comboBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(680, 397);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(663, 671);
            button2.Name = "button2";
            button2.Size = new Size(111, 47);
            button2.TabIndex = 8;
            button2.Text = "Show";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Appointment_List
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Appointment_List";
            Text = "Appointment_List";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button1;
        private Button button2;
    }
}