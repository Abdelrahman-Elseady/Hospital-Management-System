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
    public partial class Manage_Doctor : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-NEV17CC;DataBAse=Hospital ; Integrated Security=True ;");

        public Manage_Doctor()
        {
            InitializeComponent();
            SqlDataAdapter ad = new SqlDataAdapter("select * from DOCTOR", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from DOCTOR where DOCTOR_ID= '" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully");

            //reload the new data
            SqlDataAdapter ad = new SqlDataAdapter("select * from DOCTOR", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditDoctor editDoctor = new EditDoctor();
            editDoctor.textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            editDoctor.textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            editDoctor.textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            editDoctor.textBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            editDoctor.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            editDoctor.textBox6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            editDoctor.comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            editDoctor.Show();
            

        }
    }
}
