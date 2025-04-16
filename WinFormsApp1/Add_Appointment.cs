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

namespace WinFormsApp1
{
    public partial class Add_Appointment : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-NEV17CC;DataBAse=Hospital ; Integrated Security=True ;");

        public Add_Appointment()
        {
            InitializeComponent();
            SqlDataAdapter d = new SqlDataAdapter("select * from DOCTOR", con);
            DataTable dt = new DataTable();
            d.Fill(dt);

            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "DOCTOR_ID";
            comboBox2.ValueMember = "DOCTOR_ID";

            SqlDataAdapter d1 = new SqlDataAdapter("select * from PATIENT", con);
            DataTable dt1 = new DataTable();
            d1.Fill(dt1);
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "PATIENT_ID";
            comboBox1.ValueMember = "PATIENT_ID";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Add_Appointment_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO APPOINTMENT (PATIENT_ID, DOCTOR_ID, ADMIN_ID, DATE, STATUES) VALUES (@param1, @param2, @param3, @param4, @param5)", con);
            cmd.Parameters.AddWithValue("@param1", Convert.ToInt32(comboBox1.Text));
            cmd.Parameters.AddWithValue("@param2", Convert.ToInt32(comboBox2.Text));
            cmd.Parameters.AddWithValue("@param3", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@param4", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@param5", textBox2.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Added Successfully");
        }
    }
}
