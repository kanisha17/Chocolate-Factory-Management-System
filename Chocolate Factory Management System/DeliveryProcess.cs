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
    public partial class DeliveryProcess : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        OleDbCommand command;
        public DeliveryProcess()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\Access\ChocolateFactory17.accdb;Persist Security Info=False;";

        }

        private void DeliveryProcess_Load(object sender, EventArgs e)
        {

        }

        private void labelDeliveryProcess_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
    }
}