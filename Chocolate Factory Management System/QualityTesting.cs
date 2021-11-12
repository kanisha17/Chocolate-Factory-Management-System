﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Chocolate_Factory_Management_System
{
    public partial class QualityTesting : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public QualityTesting()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelFinalConclusionTest_Click(object sender, EventArgs e)
        {

        }

        private void labelTestedBy_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFinalConclusion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTestedBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNonCompliance_Click(object sender, EventArgs e)
        {

        }

        private void QualityTesting_Load(object sender, EventArgs e)
        {

        }

        private void cLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxFinalConclusion.Clear();
            textBoxLaboratoryTesting.Clear();
            textBoxNonCompliance.Clear();
            textBoxProductName.Clear();
            textBoxSampleDetails.Clear();
            textBoxTestedBy.Clear();
            checkedListBoxResult.ResetText();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand("insert into QualityTesting(SampleName,TestDate,SampleDetails,LaboratoryTesting,FinalConclusion,NonCompliance,TestedBy,Result) " +
                    "values(@samplename,@testdate,@sampledetails,@labtest,@final,@noncompliance,@testedby,@result)", connection);


                command.Parameters.AddWithValue("@samplename", textBoxProductName.Text);
                command.Parameters.AddWithValue("@testdate", dateTimePicker1.Text);
                command.Parameters.AddWithValue("sampledetails", textBoxSampleDetails.Text);
                command.Parameters.AddWithValue("@labtest", textBoxLaboratoryTesting.Text);
                command.Parameters.AddWithValue("@final", textBoxFinalConclusion.Text);
                command.Parameters.AddWithValue("@noncompliance",textBoxNonCompliance.Text);
                command.Parameters.AddWithValue("@testedby", textBoxTestedBy.Text);
                command.Parameters.AddWithValue("@result",checkedListBoxResult.Text);

                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Data Saved Successfully");
            }
            catch
            {
                MessageBox.Show("Data Not Saved".ToString());
            }
        }
    }
}
