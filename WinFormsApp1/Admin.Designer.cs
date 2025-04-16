namespace WinFormsApp1
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            menuStrip1 = new MenuStrip();
            doctorsToolStripMenuItem = new ToolStripMenuItem();
            addDoctorToolStripMenuItem = new ToolStripMenuItem();
            manageDoctorToolStripMenuItem = new ToolStripMenuItem();
            patientToolStripMenuItem = new ToolStripMenuItem();
            addPatientToolStripMenuItem = new ToolStripMenuItem();
            managePatientToolStripMenuItem = new ToolStripMenuItem();
            appointmentToolStripMenuItem = new ToolStripMenuItem();
            addAppointmentToolStripMenuItem = new ToolStripMenuItem();
            appointmentListToolStripMenuItem = new ToolStripMenuItem();
            existToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { doctorsToolStripMenuItem, patientToolStripMenuItem, appointmentToolStripMenuItem, existToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // doctorsToolStripMenuItem
            // 
            doctorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addDoctorToolStripMenuItem, manageDoctorToolStripMenuItem });
            doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            doctorsToolStripMenuItem.Size = new Size(69, 24);
            doctorsToolStripMenuItem.Text = "Doctor";
            doctorsToolStripMenuItem.Click += doctorsToolStripMenuItem_Click;
            // 
            // addDoctorToolStripMenuItem
            // 
            addDoctorToolStripMenuItem.Name = "addDoctorToolStripMenuItem";
            addDoctorToolStripMenuItem.Size = new Size(196, 26);
            addDoctorToolStripMenuItem.Text = "Add Doctor";
            addDoctorToolStripMenuItem.Click += addDoctorToolStripMenuItem_Click;
            // 
            // manageDoctorToolStripMenuItem
            // 
            manageDoctorToolStripMenuItem.Name = "manageDoctorToolStripMenuItem";
            manageDoctorToolStripMenuItem.Size = new Size(196, 26);
            manageDoctorToolStripMenuItem.Text = "Manage Doctor";
            manageDoctorToolStripMenuItem.Click += manageDoctorToolStripMenuItem_Click;
            // 
            // patientToolStripMenuItem
            // 
            patientToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addPatientToolStripMenuItem, managePatientToolStripMenuItem });
            patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            patientToolStripMenuItem.Size = new Size(68, 24);
            patientToolStripMenuItem.Text = "Patient";
            // 
            // addPatientToolStripMenuItem
            // 
            addPatientToolStripMenuItem.Name = "addPatientToolStripMenuItem";
            addPatientToolStripMenuItem.Size = new Size(195, 26);
            addPatientToolStripMenuItem.Text = "Add Patient";
            addPatientToolStripMenuItem.Click += addPatientToolStripMenuItem_Click;
            // 
            // managePatientToolStripMenuItem
            // 
            managePatientToolStripMenuItem.Name = "managePatientToolStripMenuItem";
            managePatientToolStripMenuItem.Size = new Size(195, 26);
            managePatientToolStripMenuItem.Text = "Manage Patient";
            managePatientToolStripMenuItem.Click += managePatientToolStripMenuItem_Click;
            // 
            // appointmentToolStripMenuItem
            // 
            appointmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addAppointmentToolStripMenuItem, appointmentListToolStripMenuItem });
            appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            appointmentToolStripMenuItem.Size = new Size(111, 24);
            appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // addAppointmentToolStripMenuItem
            // 
            addAppointmentToolStripMenuItem.Name = "addAppointmentToolStripMenuItem";
            addAppointmentToolStripMenuItem.Size = new Size(224, 26);
            addAppointmentToolStripMenuItem.Text = "Add Appointment";
            addAppointmentToolStripMenuItem.Click += addAppointmentToolStripMenuItem_Click;
            // 
            // appointmentListToolStripMenuItem
            // 
            appointmentListToolStripMenuItem.Name = "appointmentListToolStripMenuItem";
            appointmentListToolStripMenuItem.Size = new Size(224, 26);
            appointmentListToolStripMenuItem.Text = "Appointment List";
            appointmentListToolStripMenuItem.Click += appointmentListToolStripMenuItem_Click;
            // 
            // existToolStripMenuItem
            // 
            existToolStripMenuItem.Name = "existToolStripMenuItem";
            existToolStripMenuItem.Size = new Size(53, 24);
            existToolStripMenuItem.Text = "Exist";
            existToolStripMenuItem.Click += existToolStripMenuItem_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(menuStrip1);
            ForeColor = Color.Chocolate;
            MainMenuStrip = menuStrip1;
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem doctorsToolStripMenuItem;
        private ToolStripMenuItem addDoctorToolStripMenuItem;
        private ToolStripMenuItem deleteDoctorToolStripMenuItem;
        private ToolStripMenuItem patientToolStripMenuItem;
        private ToolStripMenuItem addPatientToolStripMenuItem;
        private ToolStripMenuItem appointmentToolStripMenuItem;
        private ToolStripMenuItem addAppointmentToolStripMenuItem;
        private ToolStripMenuItem existToolStripMenuItem;
        private ToolStripMenuItem manageDoctorToolStripMenuItem;
        private ToolStripMenuItem managePatientToolStripMenuItem;
        private ToolStripMenuItem appointmentListToolStripMenuItem;
    }
}