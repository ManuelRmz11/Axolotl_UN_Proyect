using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private Timer timer; // Temporizador para cambiar el contenido después de cierto tiempo
        private Timer timer2; // Temporizador para cambiar el contenido después de otro tiempo

        public AjoloteWord()
        {
            InitializeComponent();
            this.Load += AjoloteWord_Load;
        }

        private void AjoloteWord_Load(object sender, EventArgs e)
        {
            // Configuración del primer temporizador
            timer = new Timer();
            timer.Interval = 10000;  // 10 segundos
            timer.Tick += Timer_Tick; // Evento que se ejecutará cada vez que pase el tiempo establecido
            timer.Start(); // Iniciar el temporizador

            // Configuración del segundo temporizador
            timer2 = new Timer();
            timer2.Interval = 20000;  // 20 segundos
            timer2.Tick += Timer2_Tick; // Evento que se ejecutará cada vez que pase el tiempo establecido
            timer2.Start(); // Iniciar el temporizador
        }

        // Evento que se ejecuta cuando pasa el tiempo del primer temporizador
        private void Timer_Tick(object sender, EventArgs e)  
        {
            timer.Stop();// Detener el temporizador para evitar que se repita continuamente

            // Actualizar el texto en el label con información sobre el ajolote
            label1.Invoke((MethodInvoker)(() => label1.Text = "El ajolote es un anfibio endémico de México \n" +
            " que tiene una gran capacidad regenerativa y\n" +
            " puede regenerar extremidades perdidas y partes\n " +
            "dañadas de órganos internos como el cerebro,\n" +
            " corazón y médula espinal.\n " +
            "Esta capacidad ha despertado un gran interés científico y podría \n" +
            "ayudar a desarrollar técnicas para la regeneración de tejidos humanos.\n" +
            "Sin embargo, el ajolote está en peligro crítico de extinción debido a \n" +
            "la contaminación de su hábitat, la caza para consumo humano y la\n" +
            "introducción de especies exóticas en su ambiente."));

            // Actualizar la imagen en el pictureBox con una imagen relacionada al ajolote
            pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.Ajolote2));
        }

        // Evento que se ejecuta cuando pasa el tiempo del segundo temporizador
        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop(); // Detener el temporizador para evitar que se repita continuamente

            // Actualizar el texto en el label con otra información sobre el ajolote
            label1.Invoke((MethodInvoker)(() => label1.Text = "El hábitat natural del ajolote \n" +
            "es el lago de Xochimilco, cerca de la Ciudad de México. " +
            "Desafortunadamente, su conservación se encuentra en " +
            "riesgo debido a la contaminación de su hábitat, la caza" +
            "para consumo humano y la introducción de especies exóticas" +
            "en su ambiente1. Para proteger al ajolote y su hábitat natural,\n" +
            "se están llevando a cabo diversas medidas de\n" +
            "conservación. Por ejemplo, se está trabajando \n" +
            "en la chinampa refugio en Xochimilco para proporcionar \n" +
            "canales aislados y agua con un mayor grado de limpieza.\n" +
            "También se está trabajando en refugios temporales fuera de\n" +
            "su hábitat natural, como en la Cantera Oriente de la UNAM.\n" +
            "Además, existen programas estratégicos como el Programa\n" +
            "de Acción para la Conservación de las Especies (PACE)\n" +
            "y la Unidad de Manejo de Vida Silvestre (UMA), \n" +
            "cuyos objetivos principales son prevenir y \n" +
            "reducir la vulnerabilidad en las especies \n" +
            "y sus hábitats y asegurar su conservación"));

            // Actualizar la imagen en el pictureBox con otra imagen relacionada al ajolote
            pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.Ajolote3));
        }


        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            // Cerrar la ventana actual y mostrar la ventana principal
            FormPrincipal principal = new FormPrincipal();
            this.Hide();
            principal.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Cerrar la ventana actual y mostrar la siguiente ventana
            AjoloteWord2 aWord2 = new AjoloteWord2();
            this.Hide();
            aWord2.Show();
        }
    }
}