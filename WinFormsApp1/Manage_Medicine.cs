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
    public partial class Manage_Medicine : Form
    {

        SqlConnection con = new SqlConnection("server =DESKTOP-NEV17CC;DataBAse=Hospital ; Integrated Security=True ;");

        public Manage_Medicine()
        {
            InitializeComponent();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from MEDICINE ", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into MEDICINE values ('" + textBox1.Text + "','" + Convert.ToDouble(textBox2.Text) + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + textBox3.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added Successfully");

            SqlDataAdapter adapter = new SqlDataAdapter("select * from MEDICINE ", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from MEDICINE where MEDICINE_ID='" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            SqlDataAdapter adapter = new SqlDataAdapter("select * from MEDICINE ", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label6.Visible = true;
            textBox4.Visible = true;
            button4.Enabled = false;
            textBox4.Enabled = false;

            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update MEDICINE set MEDICINE_NAME='" + textBox1.Text + "' ,COST='" + Convert.ToInt32(textBox2.Text) + "' ,EXPIRATION_DATE='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',MANUFACTURER='" + textBox3.Text + "' where MEDICINE_ID='" + Convert.ToInt32(textBox4.Text) + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully");


            SqlDataAdapter adapter = new SqlDataAdapter("select * from MEDICINE ", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
