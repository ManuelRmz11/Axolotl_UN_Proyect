﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axolotl_UN_Proyect
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            string information = "Universidad del Norte" + Environment.NewLine +
                                 "Integrantes:" + Environment.NewLine +
                                 "Manuel Ramírez - 44290" + Environment.NewLine +
                                 "Ulises del Villar - 44289" + Environment.NewLine +
                                 "Andony Reyna - 44796";

            MessageBox.Show(information, "Acerca de Nosotros", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo de la aplicación :c", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
