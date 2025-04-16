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
    public partial class Assign_Medicine : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-NEV17CC;DataBAse=Hospital ; Integrated Security=True ;");

        public Assign_Medicine()
        {
            InitializeComponent();
            SqlDataAdapter d1 = new SqlDataAdapter("select * from PATIENT", con);
            DataTable dt1 = new DataTable();
            d1.Fill(dt1);
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "PATIENT_ID";
            comboBox1.ValueMember = "PATIENT_ID";

            SqlDataAdapter d2 = new SqlDataAdapter("select * from MEDICINE", con);
            DataTable dt2 = new DataTable();
            d2.Fill(dt2);
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "MEDICINE_ID";
            comboBox2.ValueMember = "MEDICINE_ID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into TAKES values ('"+Convert.ToInt32( comboBox1.Text)+"','"+ Convert.ToInt32(comboBox2.Text)+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Assigned Successfully");

        }
    }
}
