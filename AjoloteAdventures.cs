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
    public partial class AjoloteAdventures : Form
    {
        public AjoloteAdventures()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            this.Hide();
            principal.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AjoloteAdventures Form1 = new AjoloteAdventures();
            this.Hide();
            Form1.Show();
        }
    }
}
