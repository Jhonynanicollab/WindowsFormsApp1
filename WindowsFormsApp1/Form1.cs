using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Este es el evento del botón
        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario
            Form2 nuevaVentana = new Form2();

            // Mostrarla
            nuevaVentana.Show();

            // (Opcional) Ocultar esta ventana actual:
            this.Hide();
     
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
