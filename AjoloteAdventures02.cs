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
    public partial class AjoloteAdventures02 : Form
    {
        public AjoloteAdventures02()
        {
            InitializeComponent();
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            AjoloteAdventures03 Form1 = new AjoloteAdventures03();
            this.Hide();
            Form1.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AjoloteAdventures01 Form1 = new AjoloteAdventures01();
            this.Hide();
            Form1.Show();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
