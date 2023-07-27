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
    public partial class AjoloteCare3 : Form
    {
        private Timer timer;
        private Timer timer2;
        public AjoloteCare3()
        {
            InitializeComponent();
            this.Load += AjoloteCare3_Load;
        }
        private void AjoloteCare3_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 10000;  // 10 segundos
            timer.Tick += Timer_Tick;
            timer.Start();

            timer2 = new Timer();
            timer2.Interval = 20000;  // 20 segundos
            timer2.Tick += Timer2_Tick;
            timer2.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            label1.Invoke((MethodInvoker)(() => label1.Text = "Los ajolotes han fascinado al público\r\n" +
            " durante mucho tiempo, más aún cuando fueron traídos por\r\n" +
            " primera vez de México a París en 1864 . \r\n" +
            "Los europeos de todo el continente comenzaron a criar salamandras,\r\n" +
            "el comienzo de un fuerte comercio de mascotas en los animales,\r\n" +
            " que se reproducen fácilmente en cautiverio.\r\n "));

            pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.Ajolote2));
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();

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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            this.Hide();
            principal.Show();
        }
    }
}
