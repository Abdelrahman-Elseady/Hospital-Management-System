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
    public partial class Add_Patient : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-NEV17CC;DataBAse=Hospital ; Integrated Security=True ;");

        public Add_Patient()
        {
            InitializeComponent();
        }

        private void Add_Patient_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into PATIENT values ('"+textBox1.Text+"' , '"+textBox2.Text+"','"+Convert.ToInt32( textBox3.Text)+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"' )",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Patient Added Successfully");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }
    }
}
