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
    public partial class signup : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-IUKBVSC;Initial Catalog=EPL;Integrated Security=True;");

        public signup()
        {

            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_name_Click(object sender, EventArgs e)
        {
            
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    String CheckUsername = "SELECT * FROM userpassword WHERE username='" +UserName.Text.Trim() + "'";
                    using (SqlCommand checkUser = new SqlCommand(CheckUsername, connect)) { 
                    
                    SqlDataAdapter adapter= new SqlDataAdapter(checkUser);
                        DataTable table=new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(UserName.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else {

                            string insertData = "INSERT INTO userpassword (UserName, Password) VALUES (@Username, @Password,)";
                            DateTime date=DateTime.Today;
                            using (SqlCommand cmd = new SqlCommand(insertData,connect)) {
                                cmd.Parameters.AddWithValue("@UserName", UserName.Text.Trim());
                                cmd.Parameters.AddWithValue("@Password", password.Text.Trim());
                                
                                MessageBox.Show("Signed Up", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                this.Hide();
                                Form2 f2 = new Form2();
                                f2.ShowDialog();
                                f2 = null;
                                this.Show();



                            }

                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Connecting Data base:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    connect.Close();
                
                }
            
            }
           else if (textBox1.Text != password.Text)
            {
                MessageBox.Show("the password not the same as confirmation");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
