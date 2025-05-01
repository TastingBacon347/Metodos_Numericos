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
            tabControl1.SelectedTab = tabPageMetodos;
            
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageCreditos;
            containerControl1.BackColor = Color.FromArgb(192, 192, 255);
            containerControl2.BackColor = Color.FromArgb(192, 192, 255);
            containerControl3.BackColor = Color.FromArgb(192, 192, 255);
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
    }
}
