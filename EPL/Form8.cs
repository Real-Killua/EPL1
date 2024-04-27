using Microsoft.EntityFrameworkCore.Query.ExpressionVisitors.Internal;
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
    public partial class Form8 : Form
    {
        private SqlConnection connection;
        private string connectionString = @"Data Source=DESKTOP-IUKBVSC;Initial Catalog=EPL;Integrated Security=True;";
        public Form8()
        {
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ePLDataSet5.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.ePLDataSet5.Table);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

           
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                
                if (row.IsNewRow)
                    continue;

                
                string Number = row.Cells["NumberDataGridViewTextBoxColumn"].Value.ToString();
                string Team = row.Cells["TeamDataGridViewTextBoxColumn"].Value.ToString();
                string MP = row.Cells["MPDataGridViewTextBoxColumn"].Value.ToString();
                string W = row.Cells["WDataGridViewTextBoxColumn"].Value.ToString();
                string D = row.Cells["DDataGridViewTextBoxColumn"].Value.ToString();
                string L = row.Cells["LDataGridViewTextBoxColumn"].Value.ToString();
                string Pts = row.Cells["PtsDataGridViewTextBoxColumn"].Value.ToString();

                
                string query = "INSERT INTO [Table] (Number, Team, MP, W, D, L, Pts) VALUES (@Number, @Team, @MP, @W, @D, @L, @Pts)";
                SqlCommand cmd = new SqlCommand(query, connection);

               
                cmd.Parameters.AddWithValue("@Number", Number);
                cmd.Parameters.AddWithValue("@Team", Team);
                cmd.Parameters.AddWithValue("@MP", MP);
                cmd.Parameters.AddWithValue("@W", W);
                cmd.Parameters.AddWithValue("@D", D);
                cmd.Parameters.AddWithValue("@L", L);
                cmd.Parameters.AddWithValue("@Pts", Pts);

                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string Number = row.Cells["NumberDataGridViewTextBoxColumn"].Value.ToString();
                string Team = row.Cells["TeamDataGridViewTextBoxColumn"].Value.ToString();
                string MP = row.Cells["MPDataGridViewTextBoxColumn"].Value.ToString();
                string W = row.Cells["WDataGridViewTextBoxColumn"].Value.ToString();
                string D = row.Cells["DDataGridViewTextBoxColumn"].Value.ToString();
                string L = row.Cells["LDataGridViewTextBoxColumn"].Value.ToString();
                string Pts = row.Cells["PtsDataGridViewTextBoxColumn"].Value.ToString();

                
                string query = "DELETE FROM [Table] WHERE Number = @Number AND Team = @Team AND MP = @MP AND W = @W AND D = @D AND L = @L AND Pts = @Pts";
                SqlCommand cmd = new SqlCommand(query, connection);

               
                cmd.Parameters.AddWithValue("@Number", Number);
                cmd.Parameters.AddWithValue("@Team", Team);
                cmd.Parameters.AddWithValue("@MP", MP);
                cmd.Parameters.AddWithValue("@W", W);
                cmd.Parameters.AddWithValue("@D", D);
                cmd.Parameters.AddWithValue("@L", L);
                cmd.Parameters.AddWithValue("@Pts", Pts);

                
                cmd.ExecuteNonQuery();
            }

            connection.Close();

        }
    }
}
