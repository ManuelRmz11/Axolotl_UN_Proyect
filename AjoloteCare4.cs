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

        private void button1_Click(object sender, EventArgs e)
        {

            AjoloteCare4 principal = new AjoloteCare4();
            this.Hide();
            principal.Show();
        }
    }
}
