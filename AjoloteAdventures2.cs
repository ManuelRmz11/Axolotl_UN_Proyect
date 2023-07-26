using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axolotl_UN_Proyect
{
    public partial class AjoloteAdventures2 : Form
    {
        public AjoloteAdventures2()
        {
            InitializeComponent();
        }

        private void btnCabeza_Click(object sender, EventArgs e)
        {
            string information = "Tiene una cabeza grande";

            MessageBox.Show(information);
        }

        private void btnPatas_Click(object sender, EventArgs e)
        {
            string information = "Tiene patas con dedos planos y puntiagudos";

            MessageBox.Show(information);
        }

        private void btnParpados_Click(object sender, EventArgs e)
        {
            string information = "No tiene parpados moviles";

            MessageBox.Show(information);
        }

        private void AjoloteAdventures2_Load(object sender, EventArgs e)
        {
            btnAceptar.Focus();
        }

        private void btnBranqueas_Click(object sender, EventArgs e)
        {
            string information = "Tiene 3 pares de branqueas";

            MessageBox.Show(information);
        }

        private void btnHocico_Click(object sender, EventArgs e)
        {
            string information = "Hocico ancho y aplanado";

            MessageBox.Show(information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string information = "Ojos amarillo iridiscente";

            MessageBox.Show(information);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string information = "Hay un boton escondido, encuentralo para continuar";

            MessageBox.Show(information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string information = "El boton se encuentra en el fondo del mar :)";

            MessageBox.Show(information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string information = "Iridiscente: Brillo radiante mostrado por la materia que " +
                "produce un cambio de color dependiendo del ángulo de visión y del de iluminación.";

            MessageBox.Show(information);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            AjoloteAdventure3 Form1 = new AjoloteAdventure3();
            this.Hide();
            Form1.Show();
        }
    }
}
