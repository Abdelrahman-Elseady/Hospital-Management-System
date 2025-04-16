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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void manageMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Medicine manage_Medicine = new Manage_Medicine();
            manage_Medicine.Show();
        }

        private void assignMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assign_Medicine assign = new Assign_Medicine();
            assign.Show();
        }

        private void medicalHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showMedicalHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medical_History medical_History = new Medical_History();
            medical_History.Show();
        }
    }
}
