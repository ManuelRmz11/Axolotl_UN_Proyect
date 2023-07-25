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
    public partial class AjoloteAdventures01 : Form
    {
        public AjoloteAdventures01()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            AjoloteAdventures02 Form1 = new AjoloteAdventures02();
            this.Hide();
            Form1.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AjoloteAdventures Form1 = new AjoloteAdventures();
            this.Hide();
            Form1.Show();
        }
    }
}
