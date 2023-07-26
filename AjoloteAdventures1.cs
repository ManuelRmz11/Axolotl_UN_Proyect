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
    public partial class AjoloteAdventures1 : Form
    {
        public AjoloteAdventures1()
        {
            InitializeComponent();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AjoloteAdventures Form1 = new AjoloteAdventures();
            this.Hide();
            Form1.Show();
        }

        private void AjoloteAdventures1_Load(object sender, EventArgs e)
        {
            btnAceptar.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AjoloteAdventures2 Form1 = new AjoloteAdventures2();
            this.Hide();
            Form1.Show();
        }
    }
}
