namespace WinFormsApp1
{
    partial class Manage_Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Patient));
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(484, 64);
            label1.Name = "label1";
            label1.Size = new Size(562, 46);
            label1.TabIndex = 9;
            label1.Text = "Select Record to Delete Or Update";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(1502, 910);
            button3.Name = "button3";
            button3.Size = new Size(0, 0);
            button3.TabIndex = 8;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(838, 910);
            button2.Name = "button2";
            button2.Size = new Size(0, 0);
            button2.TabIndex = 7;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(188, 910);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 6;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-9, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(0, 0);
            dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(493, 0);
            label2.Name = "label2";
            label2.Size = new Size(562, 46);
            label2.TabIndex = 14;
            label2.Text = "Select Record to Delete Or Update";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(1511, 846);
            button4.Name = "button4";
            button4.Size = new Size(171, 58);
            button4.TabIndex = 13;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Highlight;
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(847, 846);
            button5.Name = "button5";
            button5.Size = new Size(163, 58);
            button5.TabIndex = 12;
            button5.Text = "Edit";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Highlight;
            button6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(197, 846);
            button6.Name = "button6";
            button6.Size = new Size(170, 58);
            button6.TabIndex = 11;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 70);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1920, 708);
            dataGridView2.TabIndex = 10;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Manage_Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Manage_Patient";
            Text = "Manage_Patient";
            Load += Manage_Patient_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button button4;
        private Button button5;
        private Button button6;
        private DataGridView dataGridView2;
    }
}