using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-SSU22PB9;Initial Catalog=EmployeeDb;Integrated Security=True;TrustServerCertificate=true");
            conn.Open();

            String username = txtUsername.Text;

            String password = txtPassword.Text;

            SqlCommand cnn = new SqlCommand("select Username,Password from logintab where Username='" + txtUsername.Text + "'and Password='" + txtPassword.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();
            da.Fill(table);
            if (table.Rows.Count > 0)
            {
                Employee em = new Employee();
                em.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            conn.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
