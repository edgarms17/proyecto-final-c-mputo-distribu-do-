﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Compra_Venta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Form Usuario = new Form();
            Usuario.Show();
            this.Hide();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Form Producto = new Form();
            Producto.Show();
            this.Hide();
        }
    }
}