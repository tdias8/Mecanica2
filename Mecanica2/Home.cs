﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mecanica2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void menuCliente_Click(object sender, EventArgs e)
        {

        }

        private void menuCliente_Click_1(object sender, EventArgs e)
        {
            ClienteView cliente = new ClienteView();
            cliente.Show();
        }
    }
}
