﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPL
{
    public partial class Form7 : Form
    {
   
        public Form7()
        {
            InitializeComponent();


        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ePLDataSet4.Matches' table. You can move, or remove it, as needed.
            this.matchesTableAdapter.Fill(this.ePLDataSet4.Matches);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
