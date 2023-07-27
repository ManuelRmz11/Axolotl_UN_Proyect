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
    public partial class AjoloteCare4 : Form
    {
        public AjoloteCare4()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AjoloteCare principal = new AjoloteCare();
            this.Hide();
            principal.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // Opción seleccionada es correcta.
            MessageBox.Show("¡Respuesta correcta!","Acertaste");

            AjoloteCare5 principal = new AjoloteCare5();
            this.Hide();
            principal.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // Opción seleccionada es incorrecta.
            MessageBox.Show("Respuesta incorrecta. Inténtalo nuevamente.", "Que mal");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // Opción seleccionada es incorrecta.
            MessageBox.Show("Respuesta incorrecta. Inténtalo nuevamente.", "Que mal");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            this.Hide();
            principal.Show();
        }
    }
}
