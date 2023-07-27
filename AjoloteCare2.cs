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
    public partial class AjoloteCare2 : Form
    {
        
        public AjoloteCare2()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AjoloteCare principal = new AjoloteCare();
            this.Hide();
            principal.Show();
        }

        private void btnAvanzar_Click(object sender, EventArgs e) 
        {
            AjoloteCare3 principal = new AjoloteCare3();
            this.Hide();
            principal.Show();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {

            bool isCheckBox4Correct = checkBox4.Checked;
            bool isCheckBox5Correct = checkBox5.Checked;
            bool isCheckBox11Correct = checkBox11.Checked;
            // los checkbox correctos son checkBox4,checkBox5,checkBox11
            if ((isCheckBox4Correct && !checkBox3.Checked && !checkBox2.Checked && !checkBox1.Checked)
                && (isCheckBox5Correct && !checkBox6.Checked && !checkBox7.Checked && !checkBox8.Checked)
                && (isCheckBox11Correct && !checkBox9.Checked && !checkBox10.Checked && !checkBox12.Checked))
            {
                MessageBox.Show("Acertaste, Avancemos", "Genial");

                AjoloteCare3 principal = new AjoloteCare3();
                this.Hide();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Opción incorrecta, inténtalo de nuevo", "Ups");
            }
        }
    }
}
