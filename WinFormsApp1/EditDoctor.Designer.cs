namespace WinFormsApp1
{
    partial class EditDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDoctor));
            textBox6 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            label6 = new Label();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(889, 311);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(315, 27);
            textBox6.TabIndex = 43;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(699, 311);
            label7.Name = "label7";
            label7.Size = new Size(40, 32);
            label7.TabIndex = 42;
            label7.Text = "ID";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = Color.White;
            button1.Location = new Point(977, 683);
            button1.Name = "button1";
            button1.Size = new Size(117, 39);
            button1.TabIndex = 41;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(699, 615);
            label6.Name = "label6";
            label6.Size = new Size(152, 32);
            label6.TabIndex = 40;
            label6.Text = "Department";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Surgery", "Bone and Joint", "Mental Health", "Heart Care", "Children's Care", "Cancer Care" });
            comboBox1.Location = new Point(889, 621);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(315, 28);
            comboBox1.TabIndex = 39;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(889, 561);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(315, 27);
            textBox5.TabIndex = 38;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(889, 506);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(315, 27);
            textBox4.TabIndex = 37;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(889, 457);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(315, 27);
            textBox3.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(699, 506);
            label5.Name = "label5";
            label5.Size = new Size(122, 32);
            label5.TabIndex = 35;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(699, 457);
            label4.Name = "label4";
            label4.Size = new Size(139, 32);
            label4.TabIndex = 34;
            label4.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(719, 561);
            label2.Name = "label2";
            label2.Size = new Size(59, 32);
            label2.TabIndex = 33;
            label2.Text = "Age";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(889, 409);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(315, 27);
            textBox2.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(699, 404);
            label3.Name = "label3";
            label3.Size = new Size(133, 32);
            label3.TabIndex = 31;
            label3.Text = "Last Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(889, 354);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 27);
            textBox1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(699, 354);
            label1.Name = "label1";
            label1.Size = new Size(137, 32);
            label1.TabIndex = 29;
            label1.Text = "First Name";
            // 
            // EditDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "EditDoctor";
            Text = "EditDoctor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label1;
        public TextBox textBox6;
        public ComboBox comboBox1;
        public TextBox textBox5;
        public TextBox textBox4;
        public TextBox textBox3;
        public TextBox textBox2;
        public TextBox textBox1;
    }
}