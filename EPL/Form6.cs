using EPL.EPLDataSet2TableAdapters;
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

namespace EPL
{
    public partial class Form6 : Form
    {
        private SqlConnection connection;
        private string connectionString = @"Data Source=DESKTOP-IUKBVSC;Initial Catalog=EPL;Integrated Security=True;";
        public Form6()
        {
            connection = new SqlConnection(connectionString);
            InitializeComponent();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            // Assuming dataGridView1 is the name of your DataGridView control
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Skip the row if it's the new row for data entry
                if (row.IsNewRow)
                    continue;

                // Retrieve values from DataGridView cells
                string homeTeam = row.Cells["homeTeamDataGridViewTextBoxColumn"].Value.ToString();
                string time = row.Cells["timeDataGridViewTextBoxColumn"].Value.ToString();
                string awayTeam = row.Cells["awayTeamDataGridViewTextBoxColumn"].Value.ToString();

                // SQL query to insert data into Matches table
                string query = "INSERT INTO Matches (HomeTeam, Time, AwayTeam) VALUES (@HomeTeam, @Time, @AwayTeam)";
                SqlCommand cmd = new SqlCommand(query, connection);

                // Add parameters and set their values
                cmd.Parameters.AddWithValue("@HomeTeam", homeTeam);
                cmd.Parameters.AddWithValue("@Time", time);
                cmd.Parameters.AddWithValue("@AwayTeam", awayTeam);

                // Execute the query
                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

       

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ePLDataSet2.Matches' table. You can move, or remove it, as needed.
            this.matchesTableAdapter1.Fill(this.ePLDataSet2.Matches);
            // TODO: This line of code loads data into the 'ePLDataSet1.Matches' table. You can move, or remove it, as needed.


        }





        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
             
                if (row.IsNewRow)
                    continue;

                
                string homeTeam = row.Cells["homeTeamDataGridViewTextBoxColumn"].Value.ToString();
                string time = row.Cells["timeDataGridViewTextBoxColumn"].Value.ToString();
                string awayTeam = row.Cells["awayTeamDataGridViewTextBoxColumn"].Value.ToString();

                
                string query = "DELETE FROM Matches WHERE HomeTeam = @HomeTeam AND Time = @Time AND AwayTeam = @AwayTeam";
                SqlCommand cmd = new SqlCommand(query, connection);

                
                cmd.Parameters.AddWithValue("@HomeTeam", homeTeam);
                cmd.Parameters.AddWithValue("@Time", time);
                cmd.Parameters.AddWithValue("@AwayTeam", awayTeam);

                
                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            }

        }
    }

        

        
    

