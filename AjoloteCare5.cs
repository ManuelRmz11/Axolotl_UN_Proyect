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
    public partial class AjoloteCare5 : Form
    {
        private string[] textos = { "Hábitat adecuado:\r\n " +
                "\r\nEl ajolote necesita un acuario espacioso con\r\n " +
                "agua limpia y bien oxigenada. Asegúrate de proporcionar\r\n" +
                " suficiente espacio para que nade y se sienta cómodo. Un acuario\r\n " +
                "de unos 40 litros es un buen punto de partida para un solo ajolote.\r\n",

                "Temperatura y agua:\r\n " +
                "\r\nLa temperatura del agua debe mantenerse\r\n" +
                " entre 16-20°C, ya que son animales acuáticos de climas templados. \r\n" +
                "Utiliza un calentador y un termómetro para asegurarte de mantener la \r\n" +
                "temperatura adecuada. Además, utiliza un filtro para mantener el agua \r\n" +
                "limpia y libre de contaminantes.",

                "Escondites: \r\n" +
                "\r\nLos ajolotes disfrutan de tener \r\n" +
                "lugares para esconderse, como rocas, plantas\r\n" +
                " acuáticas o refugios artificiales. Esto les\r\n " +
                "proporciona seguridad y reduce el estrés.",

                "Alimentación:\r\n" +
                "\r\nLos ajolotes son carnívoros y se alimentan principalmente\r\n" +
                " de pequeños animales acuáticos, como gusanos, insectos,\r\n" +
                "crustáceos y peces pequeños. Puedes alimentarlos con alimentos\r\n" +
                " vivos o congelados, como lombrices de tierra, daphnia, camarones\r\n " +
                "y peces pequeños.",

                "Cuidado del agua:\r\n " +
                "\r\nEs importante mantener la calidad del agua óptima \r\n" +
                "para la salud del ajolote. Realiza cambios parciales de agua \r\n" +
                "regularmente y asegúrate de que los niveles de \r\n" +
                "amoníaco y nitritos sean bajos." ,

                "Evita tocarlos:\r\n" +
                " \r\nLos ajolotes tienen una delicada piel que es\r\n" +
                " fácilmente dañable. Evita tocarlos con las manos\r\n " +
                "desnudas y, si necesitas manejarlos, utiliza siempre\r\n" +
                " manos mojadas y suaves." ,

                "Compatibilidad:\r\n" +
                "\r\nLos ajolotes son animales solitarios, \r\n" +
                "}así que mantén un solo ajolote por acuario \r\n" +
                "para evitar peleas y estrés." ,

                "Veterinario especializado: \r\n" +
                "\r\nSiempre es recomendable buscar\r\n" +
                " un veterinario con experiencia en animales acuáticos o en el \r\n" +
                "cuidado de ajolotes si notas algún signo de enfermedad\r\n" +
                " o comportamiento anormal. " ,

                " El ajolote es una especie en peligro de extinción en su\r\n" +
                " hábitat natural, por lo que nunca debes recolectar ajolotes \r\n" +
                "de la naturaleza para tenerlos como mascotas. En lugar de eso,\r\n " +
                "busca ajolotes criados en cautiverio por criadores\r\n" +
                " responsables y legalmente establecidos.",

                "Tener un ajolote como mascota es una responsabilidad \r\n" +
                "que debe tomarse en serio, así que asegúrate de\r\n" +
                " estar preparado para cuidar de ellos adecuadamente.\r\n"};

        private Image[] images = { Properties.Resources.Ac51,
                                   Properties.Resources.Ac52,
                                   Properties.Resources.Ac53,
                                   Properties.Resources.Ac54,
                                   Properties.Resources.Ac55,
                                   Properties.Resources.Ac56,
                                   Properties.Resources.Ac57,
                                   Properties.Resources.Ac58,
                                   Properties.Resources.Ac9,
                                   Properties.Resources.Ac510,// Replace "Image1" with your image resources' names
                                   // ... (add other images corresponding to the text entries)
                                 };

        private int currentIndex = 0;
        private Timer timer;

        public AjoloteCare5()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 10000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualiza el texto del label con el texto actual y luego incrementa el índice para el siguiente texto
            label1.Text = textos[currentIndex];

            // Actualiza la imagen del PictureBox con la imagen actual
            pictureBox1.Image = images[currentIndex];


            // Incrementa el índice asegurándose de que no exceda la longitud del arreglo
            currentIndex = (currentIndex + 1) % textos.Length;
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Detiene el Timer antes de regresar a la pantalla anterior (si es necesario)
            timer.Stop();

            AjoloteCare principal = new AjoloteCare();
            this.Hide();
            principal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjoloteCare6 principal = new AjoloteCare6();
            this.Hide();
            principal.Show();
        }
    }
}
