namespace EPL
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.homeTeamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayTeamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ePLDataSet2 = new EPL.EPLDataSet2();
            this.matchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ePLDataSet1 = new EPL.EPLDataSet1();
            this.matchesTableAdapter = new EPL.EPLDataSet1TableAdapters.MatchesTableAdapter();
            this.matchesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.matchesTableAdapter1 = new EPL.EPLDataSet2TableAdapters.MatchesTableAdapter();
            this.ePLDataSet = new EPL.EPLDataSet();
            this.ePLDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePLDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePLDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePLDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::EPL.Properties.Resources._5f6d22108705953_6038ce33e1226;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(272, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::EPL.Properties.Resources._5f6d22108705953_6038ce33e1226;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(154, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Match";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::EPL.Properties.Resources._5f6d22108705953_6038ce33e1226;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(28, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 37);
            this.button3.TabIndex = 13;
            this.button3.Text = "Remove Match";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::EPL.Properties.Resources._5f6d22108705953_6038ce33e1226;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(0, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.homeTeamDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.awayTeamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.matchesBindingSource2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.Size = new System.Drawing.Size(301, 200);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // homeTeamDataGridViewTextBoxColumn
            // 
            this.homeTeamDataGridViewTextBoxColumn.DataPropertyName = "HomeTeam";
            this.homeTeamDataGridViewTextBoxColumn.HeaderText = "HomeTeam";
            this.homeTeamDataGridViewTextBoxColumn.Name = "homeTeamDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // awayTeamDataGridViewTextBoxColumn
            // 
            this.awayTeamDataGridViewTextBoxColumn.DataPropertyName = "AwayTeam";
            this.awayTeamDataGridViewTextBoxColumn.HeaderText = "AwayTeam";
            this.awayTeamDataGridViewTextBoxColumn.Name = "awayTeamDataGridViewTextBoxColumn";
            // 
            // matchesBindingSource2
            // 
            this.matchesBindingSource2.DataMember = "Matches";
            this.matchesBindingSource2.DataSource = this.ePLDataSet2;
            // 
            // ePLDataSet2
            // 
            this.ePLDataSet2.DataSetName = "EPLDataSet2";
            this.ePLDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matchesBindingSource
            // 
            this.matchesBindingSource.DataMember = "Matches";
            this.matchesBindingSource.DataSource = this.ePLDataSet1;
            // 
            // ePLDataSet1
            // 
            this.ePLDataSet1.DataSetName = "EPLDataSet1";
            this.ePLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matchesTableAdapter
            // 
            this.matchesTableAdapter.ClearBeforeFill = true;
            // 
            // matchesBindingSource1
            // 
            this.matchesBindingSource1.DataMember = "Matches";
            this.matchesBindingSource1.DataSource = this.ePLDataSet1;
            // 
            // matchesTableAdapter1
            // 
            this.matchesTableAdapter1.ClearBeforeFill = true;
            // 
            // ePLDataSet
            // 
            this.ePLDataSet.DataSetName = "EPLDataSet";
            this.ePLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ePLDataSetBindingSource
            // 
            this.ePLDataSetBindingSource.DataSource = this.ePLDataSet;
            this.ePLDataSetBindingSource.Position = 0;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EPL.Properties.Resources._5f6d22108705953_6038ce33e1226;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 374);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePLDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePLDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePLDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EPLDataSet1 ePLDataSet1;
        private System.Windows.Forms.BindingSource matchesBindingSource;
        private EPLDataSet1TableAdapters.MatchesTableAdapter matchesTableAdapter;
        private System.Windows.Forms.BindingSource matchesBindingSource1;
        private EPLDataSet2 ePLDataSet2;
        private System.Windows.Forms.BindingSource matchesBindingSource2;
        private EPLDataSet2TableAdapters.MatchesTableAdapter matchesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeTeamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayTeamDataGridViewTextBoxColumn;
        private EPLDataSet ePLDataSet;
        private System.Windows.Forms.BindingSource ePLDataSetBindingSource;
    }
}