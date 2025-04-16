namespace WinFormsApp1
{
    partial class Add_Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Appointment));
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(661, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(519, 160);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 7;
            label1.Text = "Patient ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(523, 208);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 8;
            label2.Text = "Admin ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(523, 260);
            label3.Name = "label3";
            label3.Size = new Size(126, 32);
            label3.TabIndex = 9;
            label3.Text = "Doctor ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(533, 310);
            label4.Name = "label4";
            label4.Size = new Size(67, 32);
            label4.TabIndex = 10;
            label4.Text = "Date";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(523, 362);
            label5.Name = "label5";
            label5.Size = new Size(96, 32);
            label5.TabIndex = 11;
            label5.Text = "Statues";
            label5.Click += label5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(661, 166);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(661, 266);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 28);
            comboBox2.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(661, 315);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(661, 367);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(690, 447);
            button1.Name = "button1";
            button1.Size = new Size(133, 44);
            button1.TabIndex = 18;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Add_Appointment
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
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Add_Appointment";
            Text = "Add_Appointment";
            Load += Add_Appointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private Button button1;
    }
}