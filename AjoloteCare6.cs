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

            int dado1 = random.Next(1, 7);
            int dado2 = random.Next(1, 7);
            int dado3 = random.Next(1, 7);


            txtd1.Text = dado1.ToString();
            txtd2.Text = dado2.ToString();
            txtd3.Text = dado3.ToString();


            picdado1.Image = GetDiceImage(dado1);
            picdado2.Image = GetDiceImage(dado2);
            picdado3.Image = GetDiceImage(dado3);


            int sumaDados = dado1 + dado2 + dado3;
            if (sumaDados == 7 || sumaDados == 11 || (dado1 == dado2 && dado1 == dado3))
            {
                lbldado.Text = "¡GANASTE!";
            }
            else
            {
                lbldado.Text = "Sigue participando!";
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtd1.Clear();
            txtd2.Clear();
            txtd3.Clear();
            txtd1.Focus();

            lbldado.Text = null;
    
            picdado1.Image = Image.FromFile("ajolote.gif");
            picdado2.Image = Image.FromFile("ajolote.gif");
            picdado3.Image = Image.FromFile("ajolote.gif");
        }

        private Image GetDiceImage(int value)
        {
            string imageName = "care" + value + ".png";
                return Image.FromFile(imageName);
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

        }
    }
}