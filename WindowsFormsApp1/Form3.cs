using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using System.IO;



namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private FilterInfoCollection dispositivos;
        private VideoCaptureDevice camara;
        private string ecuacionActual = "";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (dispositivos.Count > 0)
            {
                camara = new VideoCaptureDevice(dispositivos[0].MonikerString);
                camara.NewFrame += new NewFrameEventHandler(Capturar);
                camara.Start();
            }
            else
            {
                MessageBox.Show("No se detectó cámara.");
            }
        }

        private void Capturar(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bmp;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (camara != null && camara.IsRunning)
            {
                camara.SignalToStop();
            }
        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    Bitmap bitmap = new Bitmap(pictureBox1.Image);

                    string rutaTessdata = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tessdata");


                    using (var engine = new TesseractEngine(rutaTessdata, "eng", EngineMode.Default))
                    {
                        using (var pix = PixConverter.ToPix(bitmap))
                        using (var page = engine.Process(pix))

                        {
                            string textoDetectado = page.GetText().Trim();
                            lblDetectado.Text = textoDetectado;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay imagen para escanear.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en OCR: " + ex.Message);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string numero = lblDetectado.Text.Trim();

            if (!string.IsNullOrEmpty(numero))
            {
                ecuacionActual += numero;
                lblEcuacion.Text = "Ecuación actual: " + ecuacionActual;
            }
            else
            {
                MessageBox.Show("Primero escanea un número.");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string expresion = ecuacionActual.Replace("π", Math.PI.ToString());
                var resultado = new DataTable().Compute(expresion, null);
                MessageBox.Show("Resultado: " + resultado.ToString(), "Resultado");
            }
            catch
            {
                MessageBox.Show("Error al calcular la ecuación.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ecuacionActual = "";
            lblEcuacion.Text = "Ecuación actual:";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.Show();
            this.Close();
        }

        // Eventos sin uso actual
        private void label1_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void lblEcuacion_Click(object sender, EventArgs e) { }
        private void lblDetectado_Click(object sender, EventArgs e) { }
    }
}
