namespace WinFormsApp1
{
    partial class Add_Dcoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Dcoctor));
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(561, 257);
            label1.Name = "label1";
            label1.Size = new Size(137, 32);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(751, 257);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 27);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(561, 307);
            label3.Name = "label3";
            label3.Size = new Size(133, 32);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(751, 312);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(315, 27);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(581, 464);
            label2.Name = "label2";
            label2.Size = new Size(59, 32);
            label2.TabIndex = 5;
            label2.Text = "Age";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(561, 360);
            label4.Name = "label4";
            label4.Size = new Size(139, 32);
            label4.TabIndex = 6;
            label4.Text = "User Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(561, 409);
            label5.Name = "label5";
            label5.Size = new Size(122, 32);
            label5.TabIndex = 7;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(751, 360);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(315, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(751, 409);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(315, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(751, 464);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(315, 27);
            textBox5.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Surgery", "Bone and Joint", "Mental Health", "Heart Care", "Children's Care", "Cancer Care" });
            comboBox1.Location = new Point(751, 524);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(315, 28);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(561, 518);
            label6.Name = "label6";
            label6.Size = new Size(152, 32);
            label6.TabIndex = 12;
            label6.Text = "Department";
            label6.Click += label6_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = Color.White;
            button1.Location = new Point(839, 586);
            button1.Name = "button1";
            button1.Size = new Size(117, 39);
            button1.TabIndex = 13;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Add_Dcoctor
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
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
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Add_Dcoctor";
            Text = "Add_Dcoctor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private Label label6;
        private Button button1;
    }
}