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
    public partial class Medical_History : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-NEV17CC;DataBAse=Hospital ; Integrated Security=True ;");

        public Medical_History()
        {
            InitializeComponent();
            SqlDataAdapter adapter = new SqlDataAdapter("select FIRST_NAME,LAST_NAME,DIAGNOSIS,DATE_RECORDED from PATIENT p,MEDICAL_HISTORY m where p.PATIENT_ID=m.PATIENT_ID ", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;


            SqlDataAdapter d1 = new SqlDataAdapter("select * from PATIENT", con);
            DataTable dt1 = new DataTable();
            d1.Fill(dt1);
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "PATIENT_ID";
            comboBox1.ValueMember = "PATIENT_ID";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   

            SqlDataAdapter dt = new SqlDataAdapter("select FIRST_NAME,LAST_NAME,DIAGNOSIS,DATE_RECORDED from PATIENT p,MEDICAL_HISTORY m where p.PATIENT_ID=m.PATIENT_ID and p.PATIENT_ID='" + Convert.ToInt32(comboBox1.Text) + "'", con);
            DataTable dataTable = new DataTable();
            dt.Fill(dataTable);
            dataGridView1.DataSource=dataTable;
        }
    }
}
