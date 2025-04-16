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

    public partial class Edit_Patient : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-NEV17CC;DataBAse=Hospital ; Integrated Security=True ;");

        public Edit_Patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE PATIENT SET FIRST_NAME=@FirstName, LAST_NAME=@LastName, AGE=@Age, GENDER=@Gender, USER_NAME=@UserName, PASSWORD=@Password WHERE PATIENT_ID=@PatientId", con))
            {
                cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                cmd.Parameters.AddWithValue("@LastName", textBox2.Text);
                cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(textBox3.Text));
                cmd.Parameters.AddWithValue("@Gender", textBox4.Text);
                cmd.Parameters.AddWithValue("@UserName", textBox5.Text);
                cmd.Parameters.AddWithValue("@Password", textBox6.Text);
                cmd.Parameters.AddWithValue("@PatientId", Convert.ToInt32(textBox7.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("edited successfully");
            }

           
           

        }
    }
}
