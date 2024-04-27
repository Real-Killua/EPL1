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

namespace EPL
{
    public partial class Form2 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-IUKBVSC;Initial Catalog=EPL;Integrated Security=True;");

        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
          
          this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void signin_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signup f3 = new signup();
            f3.ShowDialog();
            f3 = null;
            this.Show();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {

            if (UserName.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please Fill The Blank Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (UserName.Text == "admin" || UserName.Text == "Admin" && password.Text == "admin" || password.Text == "Admin")
            {
                this.Hide();
                Form5 f5 = new Form5();
                f5.ShowDialog();
                f5 = null;
                this.Show();

            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try {
                        connect.Open();
                        string selectData = "SELECT * FROM userpassword WHERE username= @UserName AND password= @Password";
                        using (SqlCommand cmd = new SqlCommand(selectData,connect)) {
                            cmd.Parameters.AddWithValue("@UserName", UserName.Text);
                            cmd.Parameters.AddWithValue("@Password", password.Text);
                            SqlDataAdapter adapter=new SqlDataAdapter(cmd);
                            DataTable table=new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged In Successfully ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Form4 f4 = new Form4();
                                f4.ShowDialog();
                                f4 = null;
                                this.Show();
                            }
                            else {

                                MessageBox.Show("Wrong Username/Password" , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                            }
                        
                        
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       

                    }
                    finally { 
                    connect.Close();
                    
                    }
                
                
                }

                
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            f4 = null;
            this.Show();
        }
    }
}
