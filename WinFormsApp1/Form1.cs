
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace WinFormsApp1
{

    public partial class Form1 : Form
    {


        SqlConnection con = new SqlConnection("server =DESKTOP-NEV17CC;DataBAse=Hospital ; Integrated Security=True ;");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from ADMIN where USER_NAME='" + textBox2.Text + "' and PASSWORD= '" + textBox1.Text + "'", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();

            }
            else
            {
                SqlDataAdapter ad1 = new SqlDataAdapter("select * from DOCTOR where USER_NAME='" + textBox2.Text + "' and PASSWORD= '" + textBox1.Text + "'", con);
                DataTable dt1 = new DataTable();
                ad1.Fill(dt1);
                if (dt1.Rows.Count > 0)

                {
                    Doctor doctor = new Doctor();
                    doctor.Show();
                }
                else
                {
                    SqlDataAdapter ad2 = new SqlDataAdapter("select * from NURSE where USER_NAME='" + textBox2.Text + "' and PASSWORD= '" + textBox1.Text + "'", con);
                    DataTable dt2 = new DataTable();
                    ad2.Fill(dt2);
                    if (dt2.Rows.Count > 0)
                        MessageBox.Show("user is here");
                    else
                    {
                        SqlDataAdapter ad3 = new SqlDataAdapter("select * from PATIENT where USER_NAME='" + textBox2.Text + "' and PASSWORD= '" + textBox1.Text + "'", con);
                        DataTable dt3 = new DataTable();
                        ad3.Fill(dt3);
                        if (dt3.Rows.Count > 0)
                        {
                            Patient patient = new Patient();
                            patient.Show();
                        }

                        else
                            MessageBox.Show("user not found");
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp s=new SignUp();
            s.Show();
        }
    }
}
