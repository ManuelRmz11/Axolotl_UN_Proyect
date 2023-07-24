using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axolotl_UN_Proyect
{
    public partial class AjoloteWord : Form
    {
        private Timer timer;
        private Timer timer2;

        public AjoloteWord()
        {
            InitializeComponent();
            this.Load += AjoloteWord_Load;
        }

        private void AjoloteWord_Load(object sender, EventArgs e)
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
            label1.Invoke((MethodInvoker)(() => label1.Text = "El ajolote es un anfibio endémico de México \n" +
            " que tiene una gran capacidad regenerativa y\n" +
            " puede regenerar extremidades perdidas y partes\n " +
            "dañadas de órganos internos como el cerebro,\n" +
            " corazón y médula espinal. Esta capacidad ha \n" +
            "despertado un gran interés científico y podría \n" +
            "ayudar a desarrollar técnicas para la regeneración\n" +
            " de tejidos humanos. Sin embargo, el ajolote \n" +
            "está en peligro crítico de extinción debido a \n" +
            "la contaminación de su hábitat, la caza para\n" +
            " consumo humano y la introducción de especies\n " +
            "exóticas en su ambiente."));

            pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.Ajolote2));
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            label1.Invoke((MethodInvoker)(() => label1.Text = "El hábitat natural del ajolote \n" +
            "es el lago de Xochimilco, cerca de la Ciudad de México. Desafortunadamente,\n" +
            " su conservación se encuentra en riesgo debido a la contaminación \n" +
            "de su hábitat, la caza para consumo humano y la introducción\n" +
            " de especies exóticas en su ambiente1. \n" +
            "Para proteger al ajolote y su hábitat natural, \n" +
            "se están llevando a cabo diversas medidas de\n" +
            " conservación. Por ejemplo, se está trabajando \n" +
            "en la chinampa refugio en Xochimilco para proporcionar \n" +
            "canales aislados y agua con un mayor grado de limpieza.\n" +
            " También se está trabajando en refugios temporales fuera de\n" +
            " su hábitat natural, como en la Cantera Oriente de la UNAM.\n" +
            " Además, existen programas estratégicos como el Programa\n" +
            " de Acción para la Conservación de las Especies (PACE)\n" +
            " y la Unidad de Manejo de Vida Silvestre (UMA), \n" +
            "cuyos objetivos principales son prevenir y \n" +
            "reducir la vulnerabilidad en las especies \n" +
            "y sus hábitats y asegurar su conservación"));
            pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.Ajolote3));
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