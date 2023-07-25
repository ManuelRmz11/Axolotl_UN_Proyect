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
    public partial class AjoloteAdventures03 : Form
    {
        public AjoloteAdventures03()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AjoloteAdventures Form1 = new AjoloteAdventures();
            this.Hide();
            Form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true && checkBox8.Checked == true && checkBox10.Checked == true)
            {
                string information01 = "Felicidades, has logrado pasar la prueba :)";

                MessageBox.Show(information01);
            }

            string information = "Parece ser que hubo un error, intenta de nuevo :(";

            MessageBox.Show(information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
        }
    }
}
