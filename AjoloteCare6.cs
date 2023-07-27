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
    public partial class AjoloteCare6 : Form
    {
        public AjoloteCare6()
        {
            InitializeComponent();
        }

        private void btnlanzar_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int ajolote1 = random.Next(1, 7);
            int ajolote2 = random.Next(1, 7);
            int ajolote3 = random.Next(1, 7);


            txtd1.Text = ajolote1.ToString();
            txtd2.Text = ajolote2.ToString();
            txtd3.Text = ajolote3.ToString();


            picAjol1.Image = GetDiceImage(ajolote1);
            picAjol2.Image = GetDiceImage(ajolote2);
            picAjol3.Image = GetDiceImage(ajolote3);


            int sumaAjolote = ajolote1 + ajolote2 + ajolote3;
            if (sumaAjolote == 7 || sumaAjolote == 11 || (ajolote1 == ajolote2 && ajolote1 == ajolote3))
            {
                lblAjolote.Text = "¡GANASTE!, Gracias por jugar";
            }
            else
            {
                lblAjolote.Text = "Sigue participando!";
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtd1.Clear();
            txtd2.Clear();
            txtd3.Clear();
            txtd1.Focus();

            lblAjolote.Text = null;

            picAjol1.Image = Properties.Resources.ajolote;
            picAjol2.Image = Properties.Resources.ajolote;
            picAjol3.Image = Properties.Resources.ajolote;
        }

        private Image GetDiceImage(int value)
        {
            string imageName = "care" + value;
            return (Image)Properties.Resources.ResourceManager.GetObject(imageName);
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            AjoloteCare principal = new AjoloteCare();
            this.Hide();
            principal.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GRACIAS POR LLEGAR HASTA EL FINAL (F._.F)", "CERRANDO");

            FormPrincipal principal = new FormPrincipal();
            this.Hide();
            principal.Show();
        }
    }
}