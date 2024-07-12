using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp3
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            this.KeyPreview=true;
            this.KeyDown += button7_KeyDown;
            this.KeyDown += button3_KeyDown;
            this.KeyDown += button1_KeyDown;
            this.KeyDown += button5_KeyDown;
            this.KeyDown += button6_KeyDown;
            this.KeyDown += button8_KeyDown;
            this.KeyDown += btnSave_KeyDown;
            this.KeyDown += button4_KeyDown;

            FillComboSearchCode();


        }

        

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-SSU22PB9;Initial Catalog=EmployeeDb;Integrated Security=True;Trustservercertificate=true"); 


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
           //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            GetEmpList();

        }

        public void FillComboSearchCode()
        {
            string connectionString = "Data Source=LAPTOP-SSU22PB9;Initial Catalog=EmployeeDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=true"; // Replace with your actual connection string
            string query = "SELECT Name FROM Role"; // Replace with your actual SQL query

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    comboBox1.DataSource = dataTable;
                    comboBox1.DisplayMember = "Name"; // Replace with the column name you want to display
                    comboBox1.ValueMember = "Id"; // Replace with the column name for the value
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        
        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // New 

            textBox1.Text = "";
            comboBox1.Text = "";
            richTextBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            comboBox4.Text = "";
            richTextBox2.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";

        }



        private void button2_Click_1(object sender, EventArgs e)
        {   
            // Insert - save

            int Id = int.Parse(textBox1.Text);
            string Role = comboBox1.Text, Address = richTextBox1.Text, EmpGroup = comboBox2.Text;
            string SubGroup = comboBox3.Text, PhoneNo = textBox3.Text, EMail = textBox4.Text, PanNo = textBox6.Text;
            string PFNo = textBox7.Text, PayType = textBox8.Text, BankAccNo = textBox9.Text, BankName = textBox10.Text;
            DateTime JoinDate = DateTime.Parse(dateTimePicker1.Text);
            DateTime ResDate = DateTime.Parse(dateTimePicker2.Text);
            Decimal OpnBal = Decimal.Parse(textBox11.Text);
            string DrCr = comboBox4.Text, Note = richTextBox2.Text; Name = textBox2.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("exec Insert_Save '" + Id +"','"+ Role + "','"+ Address + "','"+ EmpGroup +"','"+ SubGroup +"','"+ PhoneNo +"','"+ EMail +"','"+ PanNo + "','"+ PFNo +"','" + PayType + "','" + BankAccNo + "','" + BankName + "','" + JoinDate + "','" + ResDate + "','" + OpnBal + "','" + DrCr + "','" + Note + "','" + Name + "'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("succesfully inserted...");
            GetEmpList();
        }

        void GetEmpList()
        {
            //getlist in Gridview

            SqlCommand cmd = new SqlCommand("exec ListEmp",con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           //dateTimePicker1.CustomFormat = "dd-MM-yyyy ";


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           //dateTimePicker2.CustomFormat = "dd-MM-yyyy ";
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Update - Modify

            int Id = int.Parse(textBox1.Text);
            string Role = comboBox1.Text, Address = richTextBox1.Text, EmpGroup = comboBox2.Text;
            string SubGroup = comboBox3.Text, PhoneNo = textBox3.Text, EMail = textBox4.Text, PanNo = textBox6.Text;
            string PFNo = textBox7.Text, PayType = textBox8.Text, BankAccNo = textBox9.Text, BankName = textBox10.Text;
            Decimal OpnBal = Decimal.Parse(textBox11.Text);
            string DrCr = comboBox4.Text, Note = richTextBox2.Text; Name = textBox2.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("exec Update_Emp '" + Id + "','" + Role + "','" + Address + "','" + EmpGroup + "','" + SubGroup + "','" + PhoneNo + "','" + EMail + "','" + PanNo + "','" + PFNo + "','" + PayType + "','" + BankAccNo + "','" + BankName + "','" + OpnBal + "','" + DrCr + "','" + Note + "','" + Name + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("succesfully Updated...");
            GetEmpList();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Delete

            if (MessageBox.Show(" Are you sure to Delete?..", " Delete Document ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int Id = int.Parse(textBox1.Text);
                con.Open();
                SqlCommand cmd = new SqlCommand("exec Delete_Emp '" + Id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("succesfully Deleted...");
                GetEmpList();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Search by name 

            string Name = textBox5.Text;
            SqlCommand cmd = new SqlCommand("exec Search_Emp '" + Name + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //deletelist
            if (MessageBox.Show(" Are you sure to Delete All ?..", " Delete Document ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                con.Open();
                SqlCommand cmd = new SqlCommand("exec Delete_list ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("succesfully Deleted List...");
                GetEmpList();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {    
            // Exit

            DialogResult result = MessageBox.Show(" Are you sure you wish to Exit? ", " Exit Application ", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //cancle 

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button7_KeyDown(object sender, KeyEventArgs e)
        {
            // Esc press key for exit
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show(" Are you sure you wish to Exit? ", " Exit Application ", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            // F3 press for cancle
            if (e.KeyCode == Keys.F3)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();

            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            // F1 press for New

            if (e.KeyCode == Keys.F1)
            {
                textBox1.Text = "";
                comboBox1.Text = "";
                richTextBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                comboBox4.Text = "";
                richTextBox2.Text = "";
                textBox2.Text = "";
                textBox5.Text = "";

            }

        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
            // F7 press for Delete
            if (e.KeyCode == Keys.F7)
            {
                if (MessageBox.Show(" Are you sure to Delete?..", " Delete Document ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int Id = int.Parse(textBox1.Text);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("exec Delete_Emp '" + Id + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("succesfully Deleted...");
                    GetEmpList();
                }

            }
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            // F8 press for DeleteList
            if (e.KeyCode == Keys.F8)
            {
                if (MessageBox.Show(" Are you sure to Delete All ??", " Delete Document ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("exec Delete_list ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("succesfully Deleted List...");
                    GetEmpList();
                }
            }
        }

        private void button8_KeyDown(object sender, KeyEventArgs e)
        {
            // F6 press for Search by Name

            if (e.KeyCode == Keys.F6)
            {
                string Name = textBox5.Text;
                SqlCommand cmd = new SqlCommand("exec Search_Emp '" + Name + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            // F2 press for Search by Save

            if (e.KeyCode == Keys.F2)
            {
                int Id = int.Parse(textBox1.Text);
                string Role = comboBox1.Text, Address = richTextBox1.Text, EmpGroup = comboBox2.Text;
                string SubGroup = comboBox3.Text, PhoneNo = textBox3.Text, EMail = textBox4.Text, PanNo = textBox6.Text;
                string PFNo = textBox7.Text, PayType = textBox8.Text, BankAccNo = textBox9.Text, BankName = textBox10.Text;
                DateTime JoinDate = DateTime.Parse(dateTimePicker1.Text);
                DateTime ResDate = DateTime.Parse(dateTimePicker2.Text);
                Decimal OpnBal = Decimal.Parse(textBox11.Text);
                string DrCr = comboBox4.Text, Note = richTextBox2.Text; Name = textBox2.Text;
                con.Open();
                SqlCommand cmd = new SqlCommand("exec Insert_Save '" + Id + "','" + Role + "','" + Address + "','" + EmpGroup + "','" + SubGroup + "','" + PhoneNo + "','" + EMail + "','" + PanNo + "','" + PFNo + "','" + PayType + "','" + BankAccNo + "','" + BankName + "','" + JoinDate + "','" + ResDate + "','" + OpnBal + "','" + DrCr + "','" + Note + "','" + Name + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("succesfully inserted...");
                GetEmpList();

            }

        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            // F5 press for Search by Update

            if (e.KeyCode == Keys.F5)
            {   
                int Id = int.Parse(textBox1.Text);
                string Role = comboBox1.Text, Address = richTextBox1.Text, EmpGroup = comboBox2.Text;
                string SubGroup = comboBox3.Text, PhoneNo = textBox3.Text, EMail = textBox4.Text, PanNo = textBox6.Text;
                string PFNo = textBox7.Text, PayType = textBox8.Text, BankAccNo = textBox9.Text, BankName = textBox10.Text;
                Decimal OpnBal = Decimal.Parse(textBox11.Text);
                string DrCr = comboBox4.Text, Note = richTextBox2.Text; Name = textBox2.Text;
                con.Open();
                SqlCommand cmd = new SqlCommand("exec Update_Emp '" + Id + "','" + Role + "','" + Address + "','" + EmpGroup + "','" + SubGroup + "','" + PhoneNo + "','" + EMail + "','" + PanNo + "','" + PFNo + "','" + PayType + "','" + BankAccNo + "','" + BankName + "','" + OpnBal + "','" + DrCr + "','" + Note + "','" + Name + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("succesfully Updated...");
                GetEmpList();
            }
        }
    }
}
