namespace WinFormsApp1
{
    partial class Manage_Medicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Medicine));
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button4 = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1087, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(803, 494);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(1141, 623);
            button1.Name = "button1";
            button1.Size = new Size(141, 55);
            button1.TabIndex = 1;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(1438, 623);
            button2.Name = "button2";
            button2.Size = new Size(139, 55);
            button2.TabIndex = 2;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.ForeColor = Color.Cornsilk;
            button3.Location = new Point(1698, 623);
            button3.Name = "button3";
            button3.Size = new Size(150, 55);
            button3.TabIndex = 3;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Highlight;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(1053, 78);
            label1.Name = "label1";
            label1.Size = new Size(10, 499);
            label1.TabIndex = 4;
            label1.Text = " ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(431, 159);
            label2.Name = "label2";
            label2.Size = new Size(200, 35);
            label2.TabIndex = 5;
            label2.Text = "Medicine Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(431, 410);
            label3.Name = "label3";
            label3.Size = new Size(166, 35);
            label3.TabIndex = 6;
            label3.Text = "Manufacurer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(431, 316);
            label4.Name = "label4";
            label4.Size = new Size(197, 35);
            label4.TabIndex = 7;
            label4.Text = "Expiration Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.Location = new Point(431, 237);
            label5.Name = "label5";
            label5.Size = new Size(67, 35);
            label5.TabIndex = 8;
            label5.Text = "Cost";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(677, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(677, 237);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(293, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(677, 410);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(293, 27);
            textBox3.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(677, 316);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(293, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button4.ForeColor = Color.Cornsilk;
            button4.Location = new Point(658, 515);
            button4.Name = "button4";
            button4.Size = new Size(257, 55);
            button4.TabIndex = 13;
            button4.Text = "Add new Medicine";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.Location = new Point(428, 96);
            label6.Name = "label6";
            label6.Size = new Size(156, 35);
            label6.TabIndex = 14;
            label6.Text = "Medicine ID";
            label6.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(677, 104);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(293, 27);
            textBox4.TabIndex = 15;
            textBox4.Visible = false;
            // 
            // Manage_Medicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Manage_Medicine";
            Text = "Manage_Medicine";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Button button4;
        private Label label6;
        private TextBox textBox4;
    }
}