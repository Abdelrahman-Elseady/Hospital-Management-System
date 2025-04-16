namespace WinFormsApp1
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            menuStrip1 = new MenuStrip();
            medicineToolStripMenuItem = new ToolStripMenuItem();
            manageMedicineToolStripMenuItem = new ToolStripMenuItem();
            assignMedicineToolStripMenuItem = new ToolStripMenuItem();
            medicalHistoryToolStripMenuItem = new ToolStripMenuItem();
            showMedicalHistoryToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { medicineToolStripMenuItem, medicalHistoryToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // medicineToolStripMenuItem
            // 
            medicineToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageMedicineToolStripMenuItem, assignMedicineToolStripMenuItem });
            medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            medicineToolStripMenuItem.Size = new Size(84, 24);
            medicineToolStripMenuItem.Text = "Medicine";
            // 
            // manageMedicineToolStripMenuItem
            // 
            manageMedicineToolStripMenuItem.Name = "manageMedicineToolStripMenuItem";
            manageMedicineToolStripMenuItem.Size = new Size(211, 26);
            manageMedicineToolStripMenuItem.Text = "Manage Medicine";
            manageMedicineToolStripMenuItem.Click += manageMedicineToolStripMenuItem_Click;
            // 
            // assignMedicineToolStripMenuItem
            // 
            assignMedicineToolStripMenuItem.Name = "assignMedicineToolStripMenuItem";
            assignMedicineToolStripMenuItem.Size = new Size(211, 26);
            assignMedicineToolStripMenuItem.Text = "Assign Medicine";
            assignMedicineToolStripMenuItem.Click += assignMedicineToolStripMenuItem_Click;
            // 
            // medicalHistoryToolStripMenuItem
            // 
            medicalHistoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showMedicalHistoryToolStripMenuItem });
            medicalHistoryToolStripMenuItem.Name = "medicalHistoryToolStripMenuItem";
            medicalHistoryToolStripMenuItem.Size = new Size(127, 24);
            medicalHistoryToolStripMenuItem.Text = "Medical History";
            medicalHistoryToolStripMenuItem.Click += medicalHistoryToolStripMenuItem_Click;
            // 
            // showMedicalHistoryToolStripMenuItem
            // 
            showMedicalHistoryToolStripMenuItem.Name = "showMedicalHistoryToolStripMenuItem";
            showMedicalHistoryToolStripMenuItem.Size = new Size(238, 26);
            showMedicalHistoryToolStripMenuItem.Text = "show Medical History ";
            showMedicalHistoryToolStripMenuItem.Click += showMedicalHistoryToolStripMenuItem_Click;
            // 
            // Doctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Doctor";
            Text = "Doctor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem medicineToolStripMenuItem;
        private ToolStripMenuItem manageMedicineToolStripMenuItem;
        private ToolStripMenuItem assignMedicineToolStripMenuItem;
        private ToolStripMenuItem medicalHistoryToolStripMenuItem;
        private ToolStripMenuItem showMedicalHistoryToolStripMenuItem;
    }
}