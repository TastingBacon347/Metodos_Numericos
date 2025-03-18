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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBiseccion_Click_1(object sender, EventArgs e)
        {
            Form2 nuevaVentana = new Form2();
            nuevaVentana.ShowDialog(); // Bloquea Form1 hasta que Form2 se cierre
        }

        private void btnReglaFalsa_Click_1(object sender, EventArgs e)
        {
            Form3 nuevaVentana = new Form3();
            nuevaVentana.Show();
        }

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
