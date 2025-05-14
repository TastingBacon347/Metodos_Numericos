using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Numeros
{
    public partial class Menu: Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBiseccion_Click_1(object sender, EventArgs e)
        {
            

        }

        private void btnReglaFalsa_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tabPageMenu_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Metodo_De_Biseccion nuevaVentana = new Metodo_De_Biseccion();
            nuevaVentana.Show();
            this.Hide();
            
        }

        private void btnReglaFalsa_Click(object sender, EventArgs e)
        {
            Metodo_De_Regla_Falsa nuevaVentana = new Metodo_De_Regla_Falsa();
            nuevaVentana.Show();
            this.Hide();
        }

        private void btnDiferenciasDivididas_Click(object sender, EventArgs e)
        {
            DiferenciaDividida diferenciaDividida = new DiferenciaDividida();
            diferenciaDividida.Show();
            this.Hide();
        }

        private void btnIMetodos_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageMetodos;

            Random rand = new Random();


            Color color1 = Color.FromArgb(255, rand.Next(150, 256), rand.Next(150, 256), rand.Next(150, 256));
            Color color2 = Color.FromArgb(255, rand.Next(150, 256), rand.Next(150, 256), rand.Next(150, 256));


            PanelMetodos.FillColor = color1;
            PanelMetodos.FillColor2 = color2;
            PanelMenu.FillColor = color1;
            PanelMenu.FillColor2 = color2;
        }

        private void btnICreditos_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageCreditos;

            Random rand = new Random();

            Color color1 = Color.FromArgb(255, rand.Next(150, 256), rand.Next(150, 256), rand.Next(150, 256));
            Color color2 = Color.FromArgb(255, rand.Next(150, 256), rand.Next(150, 256), rand.Next(150, 256));


            PanelCreditos.FillColor = color1;
            PanelCreditos.FillColor2 = color2;
            PanelMenu.FillColor = color1;
            PanelMenu.FillColor2 = color2;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
