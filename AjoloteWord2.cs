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
        // Lista de PictureBoxes
        private List<PictureBox> pictureBoxes;

        // Lista de nombres de imágenes para las cartas boca arriba
        private List<string> imageNames;

        // Diccionario para almacenar qué imagen está en cada PictureBox
        private Dictionary<PictureBox, string> imageDict;

        // Variables para almacenar la primera y segunda selección del usuario
        private PictureBox firstPick;
        private PictureBox secondPick;

        public AjoloteWord2()
        {
            InitializeComponent();

            // Inicializar lista de PictureBoxes
            pictureBoxes = new List<PictureBox>()
            {
                pBox1,
                pBox2,
                pBox3,
                pBox4,
                pBox5,
                pBox6,
                pBox7,
                pBox8,
                pBox9,
                pBox10,
                pBox11,
                pBox12
            };

            // Inicializar lista de nombres de imágenes para las cartas boca arriba
            imageNames = new List<string>()
            {
                "MAjolote1",
                "MAjolote2",
                "MAjolote3",
                "MAjolote4",
                "MAjolote5",
                "MAjolote6"
            };

            // Duplicar lista de nombres de imágenes para tener dos copias de cada imagen
            imageNames.AddRange(imageNames);

            // Inicializar diccionario de imágenes
            imageDict = new Dictionary<PictureBox, string>();

            // Asignar evento Click a cada PictureBox
            foreach (PictureBox pb in pictureBoxes)
            {
                pb.Click += Pb_Click;
            }

            // Iniciar juego automáticamente
            btnJugar_Click(this, EventArgs.Empty);
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            // Habilitar todos los PictureBoxes
            foreach (PictureBox pb in pictureBoxes)
            {
                pb.Enabled = true;
            }

            // Revolver lista de nombres de imágenes
            Random rng = new Random();
            int n = imageNames.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = imageNames[k];
                imageNames[k] = imageNames[n];
                imageNames[n] = value;
            }

            // Asignar una imagen a cada PictureBox y mostrar la imagen de la carta boca abajo
            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                imageDict[pictureBoxes[i]] = imageNames[i];
                pictureBoxes[i].Image = Properties.Resources.AtrasMemorama;
            }

            // Reiniciar selecciones del usuario
            firstPick = null;
            secondPick = null;
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            // Obtener el PictureBox que fue seleccionado
            PictureBox pb = (PictureBox)sender;

            // Si es la primera selección del usuario
            if (firstPick == null)
            {
                firstPick = pb;

                // Mostrar la imagen correspondiente al nombre almacenado en el diccionario
                switch (imageDict[pb])
                {
                    case "MAjolote1":
                        pb.Image = Properties.Resources.MAjolote1;
                        break;
                    case "MAjolote2":
                        pb.Image = Properties.Resources.MAjolote2;
                        break;
                    case "MAjolote3":
                        pb.Image = Properties.Resources.MAjolote3;
                        break;
                    case "MAjolote4":
                        pb.Image = Properties.Resources.MAjolote4;
                        break;
                    case "MAjolote5":
                        pb.Image = Properties.Resources.MAjolote5;
                        break;
                    case "MAjolote6":
                        pb.Image = Properties.Resources.MAjolote6;
                        break;
                }
            }
            // Si es la segunda selección del usuario
            else if (secondPick == null && pb != firstPick)
            {
                secondPick = pb;

                // Mostrar la imagen correspondiente al nombre almacenado en el diccionario
                switch (imageDict[pb])
                {
                    case "MAjolote1":
                        pb.Image = Properties.Resources.MAjolote1;
                        break;
                    case "MAjolote2":
                        pb.Image = Properties.Resources.MAjolote2;
                        break;
                    case "MAjolote3":
                        pb.Image = Properties.Resources.MAjolote3;
                        break;
                    case "MAjolote4":
                        pb.Image = Properties.Resources.MAjolote4;
                        break;
                    case "MAjolote5":
                        pb.Image = Properties.Resources.MAjolote5;
                        break;
                    case "MAjolote6":
                        pb.Image = Properties.Resources.MAjolote6;
                        break;
                }

                // Verificar si las imágenes son iguales
                if (imageDict[firstPick] == imageDict[secondPick])
                {
                    // Mostrar información sobre la imagen encontrada
                    switch (imageDict[firstPick])
                    {
                        case "MAjolote1":
                            MessageBox.Show("Información sobre MAjolote1");
                            break;
                        case "MAjolote2":
                            MessageBox.Show("Información sobre MAjolote2");
                            break;
                        case "MAjolote3":
                            MessageBox.Show("Información sobre MAjolote3");
                            break;
                        case "MAjolote4":
                            MessageBox.Show("Información sobre MAjolote4");
                            break;
                        case "MAjolote5":
                            MessageBox.Show("Información sobre MAjolote5");
                            break;
                        case "MAjolote6":
                            MessageBox.Show("Información sobre MAjolote6");
                            break;
                    }

                    // Deshabilitar los PictureBoxes que fueron seleccionados correctamente
                    firstPick.Enabled = false;
                    secondPick.Enabled = false;

                    // Reiniciar selecciones del usuario
                    firstPick = null;
                    secondPick = null;
                }
                else
                {
                    // Esperar un momento antes de voltear las cartas de nuevo
                    Task.Delay(1000).ContinueWith(t =>
                    {
                        firstPick.Image = Properties.Resources.AtrasMemorama;
                        secondPick.Image = Properties.Resources.AtrasMemorama;

                        // Reiniciar selecciones del usuario
                        firstPick = null;
                        secondPick = null;
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnJugar_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            this.Hide();
            principal.Show();
        }
    }
}
