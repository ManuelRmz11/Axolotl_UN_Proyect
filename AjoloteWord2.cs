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
        private PictureBox firstBox;
        private PictureBox secondBox;

        public AjoloteWord2()
        {
            InitializeComponent();
        }

        private void AjoloteWord2_Load(object sender, EventArgs e)
        {
            InicializarTablero();
        }

        private void InicializarTablero()
        {
            foreach (var pictureBox in this.Controls)
            {
                if (pictureBox is PictureBox pb)
                {
                    pb.Image = Properties.Resources.AtrasMemorama;
                    pb.Click += PictureBox_Click;
                }
            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            List<Image> images = new List<Image>
            {
                Properties.Resources.MAjolote1,
                Properties.Resources.MAjolote2,
                Properties.Resources.MAjolote3,
                Properties.Resources.MAjolote4,
                Properties.Resources.MAjolote5,
                Properties.Resources.MAjolote6,
                Properties.Resources.MAjolote1,
                Properties.Resources.MAjolote2,
                Properties.Resources.MAjolote3,
                Properties.Resources.MAjolote4,
                Properties.Resources.MAjolote5,
                Properties.Resources.MAjolote6
            };

            Random rng = new Random();
            images = images.OrderBy(i => rng.Next()).ToList();

            int index = 0;
            foreach (var pictureBox in this.Controls)
            {
                if (pictureBox is PictureBox pb)
                {
                    pb.Tag = images[index++];
                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedBox = sender as PictureBox;

            if (clickedBox != null && clickedBox.Image != Properties.Resources.AtrasMemorama)
            {
                // Evitar hacer clic en una carta que ya está abierta
                return;
            }

            if (firstBox == null)
            {
                firstBox = clickedBox;
                firstBox.Image = firstBox.Tag as Image;
            }
            else if (secondBox == null && clickedBox != firstBox)
            {
                secondBox = clickedBox;
                secondBox.Image = secondBox.Tag as Image;

                if (firstBox.Image != null && firstBox.Image.Equals(secondBox.Image))
                {
                    MessageBox.Show("Información sobre el ajolote de la imagen");
                    firstBox = null;
                    secondBox = null;
                }
                else
                {
                    // Ocultar las imágenes después de un corto retraso
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
    }
}