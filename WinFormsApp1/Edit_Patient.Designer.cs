namespace WinFormsApp1
{
    partial class Edit_Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Patient));
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox7 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(953, 657);
            button1.Name = "button1";
            button1.Size = new Size(131, 51);
            button1.TabIndex = 25;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(754, 578);
            label6.Name = "label6";
            label6.Size = new Size(122, 32);
            label6.TabIndex = 24;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(750, 530);
            label5.Name = "label5";
            label5.Size = new Size(139, 32);
            label5.TabIndex = 23;
            label5.Text = "User Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(754, 481);
            label4.Name = "label4";
            label4.Size = new Size(97, 32);
            label4.TabIndex = 22;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(782, 428);
            label3.Name = "label3";
            label3.Size = new Size(59, 32);
            label3.TabIndex = 21;
            label3.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(754, 370);
            label2.Name = "label2";
            label2.Size = new Size(133, 32);
            label2.TabIndex = 20;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(750, 325);
            label1.Name = "label1";
            label1.Size = new Size(137, 32);
            label1.TabIndex = 19;
            label1.Text = "First Name";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(909, 578);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(244, 27);
            textBox6.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(909, 530);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(244, 27);
            textBox5.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(909, 481);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(244, 27);
            textBox4.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(909, 433);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 27);
            textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(909, 375);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 27);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(909, 325);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 27);
            textBox1.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(909, 273);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(244, 27);
            textBox7.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(754, 273);
            label7.Name = "label7";
            label7.Size = new Size(127, 32);
            label7.TabIndex = 27;
            label7.Text = "Patient ID";
            // 
            // Edit_Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Edit_Patient";
            Text = "Edit_Patient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        public Label label6;
        public Label label5;
        public Label label4;
        public Label label3;
        public Label label2;
        public Label label1;
        public TextBox textBox6;
        public TextBox textBox5;
        public TextBox textBox4;
        public TextBox textBox3;
        public TextBox textBox2;
        public TextBox textBox1;
        private Label label7;
        public TextBox textBox7;
    }
}