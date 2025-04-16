namespace WinFormsApp1
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            button1 = new Button();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(926, 638);
            button1.Name = "button1";
            button1.Size = new Size(133, 44);
            button1.TabIndex = 29;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(897, 558);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(897, 506);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 27;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(897, 457);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 28);
            comboBox2.TabIndex = 26;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(897, 398);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(759, 553);
            label5.Name = "label5";
            label5.Size = new Size(96, 32);
            label5.TabIndex = 24;
            label5.Text = "Statues";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(769, 501);
            label4.Name = "label4";
            label4.Size = new Size(67, 32);
            label4.TabIndex = 23;
            label4.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(759, 451);
            label3.Name = "label3";
            label3.Size = new Size(126, 32);
            label3.TabIndex = 22;
            label3.Text = "Doctor ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(759, 398);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 20;
            label1.Text = "Patient ID";
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Patient";
            Text = "Patient";
            Load += Patient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}