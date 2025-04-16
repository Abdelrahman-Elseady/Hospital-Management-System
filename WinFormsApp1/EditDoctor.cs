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
    public partial class EditDoctor : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-NEV17CC;DataBAse=Hospital ; Integrated Security=True ;");

        public EditDoctor()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 1;

            using (SqlCommand cmd = new SqlCommand("UPDATE DOCTOR SET FIRST_NAME=@FirstName, LAST_NAME=@LastName, AGE=@Age, DEP_ID=@DepId, USER_NAME=@UserName, PASSWORD=@Password WHERE DOCTOR_ID=@DoctorId", con))
            {
                cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                cmd.Parameters.AddWithValue("@LastName", textBox2.Text);
                cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(textBox5.Text));
                cmd.Parameters.AddWithValue("@DepId", a);
                cmd.Parameters.AddWithValue("@UserName", textBox3.Text);
                cmd.Parameters.AddWithValue("@Password", textBox4.Text);
                cmd.Parameters.AddWithValue("@DoctorId", Convert.ToInt32(textBox6.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Edited successfully");

   
            

            
        }

    }
}
