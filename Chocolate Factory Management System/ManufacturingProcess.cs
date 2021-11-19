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
using System.IO;


namespace Chocolate_Factory_Management_System
{
    public partial class ManufacturingProcess : Form
    {
        private OleDbConnection connection = new OleDbConnection();
      //  OleDbCommand command;

        public ManufacturingProcess()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ManufacturingProcess_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select *from ProductDetails";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                   comboBoxProductName.Items.Add(reader["ProductName"].ToString());
                }
                connection.Close();
            }
            catch
            {
                
            }

        }

        private void buttonSEARCH_Click(object sender, EventArgs e)
        {
            if (comboBoxProductName.SelectedItem == null)
            {

            }
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "select ProductID from ProductDetails where ProductName='" + comboBoxProductName.Text + "';";
                    command.CommandText = query;
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string p = (string)reader["ProductID"].ToString();
                        textBoxSEARCH.Text = p;

                    }
                    connection.Close();
                }
                catch
                {
                    
                }


                int a = 1;
                int b = 2;
                int c = 3;
                int d = 4;
                int e1 = 5;
                int f = 6;
                int g = 7;
                try
                {

                    int search = Convert.ToInt32(textBoxSEARCH.Text);
                    if (search == c)
                    {
                        textBoxFermenting.BackColor = System.Drawing.Color.Red;
                    }
                    else if (search == e1)
                    {
                        textBoxDrying.BackColor = System.Drawing.Color.Red;
                    }
                    else if (search == a)
                    {
                        textBoxRoasting.BackColor = System.Drawing.Color.Red;
                    }
                    else if (search == d)
                    {
                        textBoxCracking.BackColor = System.Drawing.Color.Red;
                    }
                    else if (search == f)
                    {
                        textBoxGrinding.BackColor = System.Drawing.Color.Red;
                    }
                    else if (search == c)
                    {
                        textBoxTempering.BackColor = System.Drawing.Color.Red;
                    }
                    else if (search == g)
                    {
                        textBoxMoulding.BackColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        textBoxWrapping.BackColor = System.Drawing.Color.Red;
                    }

                }
                catch
                {
                    MessageBox.Show("Enter a valid input");
                }
            }
            void resetControls()
            {
                textBoxWrapping.BackColor = System.Drawing.Color.White;
                textBoxTempering.BackColor = System.Drawing.Color.White;
                textBoxRoasting.BackColor = System.Drawing.Color.White;
                textBoxMoulding.BackColor = System.Drawing.Color.White;
                textBoxGrinding.BackColor = System.Drawing.Color.White;
                textBoxFermenting.BackColor = System.Drawing.Color.White;
                textBoxDrying.BackColor = System.Drawing.Color.White;
                textBoxCracking.BackColor = System.Drawing.Color.White;
            }



        }

        private void comboBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
