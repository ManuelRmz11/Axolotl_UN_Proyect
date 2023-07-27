using System;
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
    public partial class AjoloteAdventure4 : Form
    {
        public AjoloteAdventure4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string information = "Científicamente conocido como Ambystoma " +
                "mexicanum, es la especie de ajolote de México más conocida. " +
                "En vida silvestre, presentan una coloración oscura, con " +
                "tonalidades marrones, verdes y grises que le permiten " +
                "camuflarse con el ambiente.";

            MessageBox.Show(information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string information = "Esta especie (Ambystoma rivulare), al " +
                "igual que la anterior, es endémica de México, particularmente " +
                "de los ríos cercanos al volcán Nevado de Toluca. Se caracteriza " +
                "por ser de color negro con manchas claras y labios y zona " +
                "ventral grises.";

            MessageBox.Show(information);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string information = "El ajolote de Alchichica (Ambystoma taylori) " +
                "tiene una distribución restringida a la laguna de Alchichica, a " +
                "2300 metros de altura sobre el nivel del mar, en el estado de Puebla, " +
                "México. Presenta una coloración amarilla característica con manchas " +
                "de color negro.";

            MessageBox.Show(information);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string information = "Esta especie(Ambystoma amblycephalum), también " +
                "endémica de México, presenta una cabeza dos veces mas larga que ancha. " +
                "Su coloración es oscura con la presencia de manchas color crema a lo " +
                "largo de su cuerpo.";

            MessageBox.Show(information);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AjoloteAdventures Form1 = new AjoloteAdventures();
            this.Hide();
            Form1.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string information = "Muchas gracias por acompañarnos en esta aventura," +
                "da click en Inicio para volver :)";

            MessageBox.Show(information);
        }
    }
}
