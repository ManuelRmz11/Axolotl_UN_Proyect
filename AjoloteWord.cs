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
        private Timer timer;

        public AjoloteWord()
        {
            InitializeComponent();
            this.Load += AjoloteWord_Load;
        }

        private void AjoloteWord_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 5000;  // 5 segundos
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            label1.Invoke((MethodInvoker)(() => label1.Text = "El ajolote siempre ha causado una gran fascinación,\n" +
            " sobre todo, la primera vez que se llevó \n" +
            "la especie de México a París en 1864. Los europeos \n" +
            "de todo el continente comenzaron a criarlos, y ese fue el \n" +
            "comienzo de un robusto negocio que consistía en vender como mascota a\n" +
            " estos animales, que se reproducen fácilmente en cautiverio."));

            pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.Ajolote2));
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            this.Hide();
            principal.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            AjoloteWord2 aWord2 = new AjoloteWord2();
            this.Hide();
            aWord2.Show();
        }
    }
}