using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Appointment_List : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-NEV17CC;DataBAse=Hospital ; Integrated Security=True ;");

        public Appointment_List()
        {
            InitializeComponent();
            SqlDataAdapter d = new SqlDataAdapter("select * from DOCTOR", con);
            DataTable dt = new DataTable();
            d.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "DOCTOR_ID";
            comboBox1.ValueMember = "DOCTOR_ID";


            SqlDataAdapter d1 = new SqlDataAdapter("select * from PATIENT", con);
            DataTable dt1 = new DataTable();
            d1.Fill(dt1);
            comboBox2.DataSource = dt1;
            comboBox2.DisplayMember = "PATIENT_ID";
            comboBox3.ValueMember = "PATIENT_ID";

            SqlDataAdapter d2 = new SqlDataAdapter("select * from APPOINTMENT", con);
            DataTable dt2 = new DataTable();
            d2.Fill(dt2);
            comboBox3.DataSource = dt2;
            comboBox3.DisplayMember = "DATE";
            comboBox3.ValueMember = "DATE";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from APPOINTMENT WHERE DOCTOR_ID='" + Convert.ToInt32(comboBox1.Text) + "'", con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from APPOINTMENT WHERE DOCTOR_ID='" + Convert.ToInt32(comboBox1.Text) + "'  and PATIENT_ID='"+Convert.ToInt32(comboBox2.Text)+"' and DATE='"+Convert.ToDateTime( comboBox3.Text).ToString("yyyy-MM-dd") + "'", con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}


