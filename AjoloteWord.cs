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
    public partial class AjoloteWord : Form
    {
        public AjoloteWord()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            this.Hide();
            principal.Show();
        }
    }
}
