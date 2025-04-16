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
    public partial class Manage_Patient : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-NEV17CC;DataBAse=Hospital ; Integrated Security=True ;");
        public Manage_Patient()
        {
            InitializeComponent();
            SqlDataAdapter ad = new SqlDataAdapter("select * from PATIENT", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void Manage_Patient_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from PATIENT where PATIENT_ID= '" + Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value) + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully");

            //reload the new data
            SqlDataAdapter ad = new SqlDataAdapter("select * from PATIENT", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Edit_Patient edit_Patient = new Edit_Patient();
            edit_Patient.textBox1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            edit_Patient.textBox2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            edit_Patient.textBox3.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            edit_Patient.textBox4.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            edit_Patient.textBox5.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            edit_Patient.textBox6.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            edit_Patient.textBox7.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            edit_Patient.Show();
        }
    }
}
