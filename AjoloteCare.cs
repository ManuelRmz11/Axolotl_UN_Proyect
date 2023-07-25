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
    public partial class AjoloteCare : Form
    {
        private Timer timer;
        private Timer timer2;

        public AjoloteCare()
        {
            InitializeComponent();
            this.Load += AjoloteCare_Load;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            this.Hide();
            principal.Show();
        }

        private void AjoloteCare_Load(object sender, EventArgs e)
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
            label1.Invoke((MethodInvoker)(() => label1.Text ="NOMBRE COMÚN: Ajolote\r\n" +
            "NOMBRE CIENTÍFICO: Ambystoma mexicanum\r\n" +
            "TIPO: Anfibio\r\n" +
            "DIETA: Carnívoros\r\n" +
            "ESPERANZA DE VIDA EN LIBERTAD: 10 -15 años\r\n" + 
            "TAMAÑO: Hasta 30 cm\r\nPESO: 60 - 220 gr\r\n" +
            "ESTADO EN LA LISTA ROJA DE LA UICN: En peligro crítico\r\n" +
            "TENDENCIA DE LA POBLACIÓN ACTUAL: Decreciendo ")); 

            pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.Ajolote2));
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
           
        }
    }
}