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
    public partial class AjoloteCare5 : Form
    {
        private string[] textos = { "Texto 1", "Texto 2", "Texto 3", "Texto 4", "Texto 5" };
        private int currentIndex = 0;
        private Timer timer;

        public AjoloteCare5()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 10000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualiza el texto del label con el texto actual y luego incrementa el índice para el siguiente texto
            label1.Text = textos[currentIndex];

            // Incrementa el índice asegurándose de que no exceda la longitud del arreglo
            currentIndex = (currentIndex + 1) % textos.Length;
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Detiene el Timer antes de regresar a la pantalla anterior (si es necesario)
            timer.Stop();

            // Agrega aquí el código para regresar a la pantalla anterior

        }
    }
}
