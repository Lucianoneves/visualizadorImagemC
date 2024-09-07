
using System;
using System.Windows.Forms;

namespace VisualizadorImagenC;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Selecione uma Imagem";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Carrega a imagem no PictureBox
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = null;

        }
    }
