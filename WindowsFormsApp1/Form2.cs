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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarCaracter("0");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AgregarCaracter("1");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AgregarCaracter("2");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AgregarCaracter("3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AgregarCaracter("4");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            AgregarCaracter("5");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            AgregarCaracter("6");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            AgregarCaracter("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AgregarCaracter("8");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            AgregarCaracter("9");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            AgregarCaracter("0");
        }
        private void button12_Click(object sender, EventArgs e)
        {
            AgregarCaracter(".");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AgregarCaracter("=");
        }
        private void button14_Click(object sender, EventArgs e)
        {
            AgregarCaracter("+");
        }
        private void button15_Click(object sender, EventArgs e)
        {
            AgregarCaracter("-");
        }
        private void button16_Click(object sender, EventArgs e)
        {
            AgregarCaracter("*");
        }
        private void button17_Click(object sender, EventArgs e)
        {
            AgregarCaracter("|");
        }
        private void button18_Click(object sender, EventArgs e)
        {
            AgregarCaracter("(");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            AgregarCaracter(")");
        }
        private void button20_Click(object sender, EventArgs e)
        {
            AgregarCaracter("π");
        }
        private void button21_Click(object sender, EventArgs e)
        {
            AgregarCaracter("°");
        }
        private void button22_Click(object sender, EventArgs e)
        {
            AgregarCaracter("△");
        }
        private void button23_Click(object sender, EventArgs e)
        {
            AgregarCaracter("▢");
        }
        private void button24_Click(object sender, EventArgs e)
        {
            AgregarCaracter("◯");
        }
        private void button25_Click(object sender, EventArgs e)
        {
            AgregarCaracter("Area");
        }
        private void button26_Click(object sender, EventArgs e)
        {
            AgregarCaracter("Perimetro");
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 ventanaPrincipal = new Form1();
            ventanaPrincipal.Show();
            this.Close();
        }

        private void AgregarCaracter(string caracter)
        {
            lblEcuacion.Text += caracter;
        }
        private void lblEcuacion_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar lógica si necesitas que algo suceda al hacer clic en lblEcuacion

        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            lblEcuacion.Text = "";
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (lblEcuacion.Text.Length > 0)
                lblEcuacion.Text = lblEcuacion.Text.Substring(0, lblEcuacion.Text.Length - 1);
        }

    }

}
