using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Dcoctor f = new Add_Dcoctor();
            f.Show();

        }

        private void manageDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Doctor manage = new Manage_Doctor();
            manage.Show();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Patient f = new Add_Patient();
            f.Show();
        }

        private void managePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Patient manage = new Manage_Patient();
            manage.Show();
        }

        private void addAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Appointment f = new Add_Appointment();
            f.Show();
        }

        private void appointmentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Appointment_List f = new Appointment_List();
            f.Show();
        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
