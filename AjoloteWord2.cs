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
    public partial class AjoloteWord2 : Form
    {
        // Variables para almacenar los PictureBox seleccionados
        private PictureBox firstBox;  // Primer PictureBox seleccionado
        private PictureBox secondBox; // Segundo PictureBox seleccionado

        public AjoloteWord2()
        {
            InitializeComponent();

            // Al inicializar el formulario, se establecen las imágenes y eventos de clic para cada PictureBox
            for (int i = 1; i <= 12; i++)
            {
                // Buscar el PictureBox en el formulario con el nombre "pBox" + i
                PictureBox pictureBox = this.Controls.Find("pBox" + i, true).FirstOrDefault() as PictureBox;
                if (pictureBox != null)
                {
                    // Establecer la imagen "AtrasMemorama" para cada PictureBox
                    pictureBox.Image = Properties.Resources.AtrasMemorama;

                    // Asignar el evento de clic a cada PictureBox
                    pictureBox.Click += PictureBox_Click;
                }
            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            // Lista de imágenes de ajolotes que se utilizarán en el juego
            List<Image> images = new List<Image>
            {
                // Se agregan aquí las imágenes de ajolotes (MAjolote1, MAjolote2, etc.)
            };

            // Mezclar aleatoriamente las imágenes utilizando el algoritmo de Fisher-Yates
            Random rng = new Random();
            int n = images.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Image value = images[k];
                images[k] = images[n];
                images[n] = value;
            }

            // Asignar las imágenes mezcladas a los PictureBox en el formulario
            for (int i = 0; i < images.Count; i++)
            {
                PictureBox pictureBox = this.Controls.Find("pBox" + (i + 1), true).FirstOrDefault() as PictureBox;
                if (pictureBox != null)
                    pictureBox.Tag = images[i]; // Utilizamos el Tag del PictureBox para almacenar la imagen
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // Evento de clic para los PictureBox

            PictureBox clickedBox = sender as PictureBox;

            // Si el PictureBox ya está abierto (mostrando la imagen del ajolote), no hacer nada al hacer clic
            if (clickedBox != null && clickedBox.Image != Properties.Resources.AtrasMemorama)
            {
                return;
            }

            if (firstBox == null)
            {
                // Si no hay ningún PictureBox seleccionado previamente, almacenar este como el primer PictureBox seleccionado
                firstBox = clickedBox;
                firstBox.Image = firstBox.Tag as Image; // Mostrar la imagen del ajolote
            }
            else if (secondBox == null && clickedBox != firstBox)
            {
                // Si ya se seleccionó un PictureBox y este no es igual al primero, almacenar este como el segundo PictureBox seleccionado
                secondBox = clickedBox;
                secondBox.Image = secondBox.Tag as Image; // Mostrar la imagen del ajolote

                // Comprobar si las imágenes de ambos PictureBox seleccionados son iguales (coinciden)
                if (firstBox.Image != null && firstBox.Image.Equals(secondBox.Image))
                {
                    // Si las imágenes coinciden, mostrar un mensaje y limpiar las selecciones
                    MessageBox.Show("Información sobre el ajolote de la imagen");
                    firstBox = null;
                    secondBox = null;
                }
                else
                {
                    // Si las imágenes no coinciden, ocultar las imágenes después de un corto retraso (1 segundo)
                    var timer = new Timer();
                    timer.Interval = 1000;
                    timer.Tick += (s, args) =>
                    {
                        firstBox.Image = Properties.Resources.AtrasMemorama;
                        secondBox.Image = Properties.Resources.AtrasMemorama;
                        firstBox = null;
                        secondBox = null;
                        timer.Stop();
                    };
                    timer.Start();
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            this.Hide();
            principal.Show();
        }
    }
}