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
    public partial class AjoloteAdventure3 : Form
    {
        public AjoloteAdventure3()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AjoloteAdventures2 Form1 = new AjoloteAdventures2();
            this.Hide();
            Form1.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AjoloteAdventure4 Form1 = new AjoloteAdventure4();
            this.Hide();
            Form1.Show();
        }
    }
}
