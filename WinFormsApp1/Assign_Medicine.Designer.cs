namespace WinFormsApp1
{
    partial class Assign_Medicine
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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(995, 236);
            label1.Name = "label1";
            label1.Size = new Size(131, 35);
            label1.TabIndex = 0;
            label1.Text = "Patient ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(995, 301);
            label2.Name = "label2";
            label2.Size = new Size(149, 35);
            label2.TabIndex = 1;
            label2.Text = "Medicne ID";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1192, 243);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1192, 310);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(239, 28);
            comboBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1227, 407);
            button1.Name = "button1";
            button1.Size = new Size(159, 60);
            button1.TabIndex = 4;
            button1.Text = "Assign";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Assign_Medicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Assign_Medicine";
            Text = "Assign_Medicine";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
    }
}