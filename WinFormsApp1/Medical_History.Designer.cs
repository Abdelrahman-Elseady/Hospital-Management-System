namespace WinFormsApp1
{
    partial class Medical_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medical_History));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(805, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(833, 424);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(309, 180);
            label1.Name = "label1";
            label1.Size = new Size(131, 35);
            label1.TabIndex = 1;
            label1.Text = "Patient ID";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(504, 187);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 28);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(411, 302);
            button1.Name = "button1";
            button1.Size = new Size(126, 45);
            button1.TabIndex = 3;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Medical_History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Medical_History";
            Text = "Medical_History";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
    }
}