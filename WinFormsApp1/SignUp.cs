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
    public partial class SignUp : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-NEV17CC;DataBAse=Hospital ; Integrated Security=True ;");

        public SignUp()
        {
            InitializeComponent();
            SqlDataAdapter d = new SqlDataAdapter("select * from DEPARTMENT", con);
            DataTable dt = new DataTable();
            d.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "DEP_NAME";
            comboBox1.ValueMember = "DEP_ID";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO ADMIN (FIRST_NAME, LAST_NAME, USER_NAME, PASSWORD) VALUES (@value1, @value2, @value3, @value4)", con))
                {
                    
                    cmd.Parameters.AddWithValue("@value1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@value2", textBox2.Text);
                    cmd.Parameters.AddWithValue("@value3", textBox3.Text);
                    cmd.Parameters.AddWithValue("@value4", textBox4.Text);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                }
                MessageBox.Show("singed up successfully");
            }

            if (checkBox2.Checked) 
            {
                int depId = comboBox1.SelectedIndex + 1;

                using (SqlCommand cmd = new SqlCommand("INSERT INTO DOCTOR (DEP_ID, FIRST_NAME, LAST_NAME, AGE, USER_NAME, PASSWORD) VALUES (@DepId, @FirstName, @LastName, @Age, @UserName, @Password)", con))
                {
                    cmd.Parameters.AddWithValue("@DepId", depId);
                    cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@LastName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(textBox5.Text));
                    cmd.Parameters.AddWithValue("@UserName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox4.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Signed up successfully");

            }

            if (checkBox3.Checked)
            {
                int a=comboBox1.SelectedIndex + 1;
                using (SqlCommand cmd = new SqlCommand("INSERT INTO NURSE (DEP_ID, FIRST_NAME, LAST_NAME, USER_NAME, PASSWORD,AGE) VALUES (@value,@value1, @value2, @value3, @value4,@value5)", con))
                {
                    cmd.Parameters.AddWithValue("@value", a);
                    cmd.Parameters.AddWithValue("@value1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@value2", textBox2.Text);
                    cmd.Parameters.AddWithValue("@value3", textBox3.Text);
                    cmd.Parameters.AddWithValue("@value4", textBox4.Text);
                    cmd.Parameters.AddWithValue("@value5",Convert.ToInt32( textBox5.Text));



                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                MessageBox.Show("singed up successfully");
            }

            if (checkBox4.Checked)
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO PATIENT (FIRST_NAME, LAST_NAME, AGE, GENDER, USER_NAME, PASSWORD) VALUES (@value1, @value2, @value3, @value4, @value5, @value6)", con))
                {

                    cmd.Parameters.AddWithValue("@value1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@value2", textBox2.Text);
                    cmd.Parameters.AddWithValue("@value3", textBox5.Text);
                    cmd.Parameters.AddWithValue("@value4", textBox6.Text);
                    cmd.Parameters.AddWithValue("@value5", textBox3.Text);
                    cmd.Parameters.AddWithValue("@value6", textBox4.Text);



                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                MessageBox.Show("singed up successfully");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
