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
    public partial class Forms1: Form
    {
        public Forms1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBiseccion_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = MetodoBiseccion;
        }

        private void btnReglaFalsa_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = MetodoReglaFalsa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton Verificar Metodo Biseccion
            //Si los parametros no arrojan raiz que muestr el lblNo
            //Si los parametros si arrojan raiz
            // Y ps poner que hasta que se no llenen los campos de parametros
            //y funcion que no se active este boton xd
            btnCorrerBiseccion.Visible = true;
            lblError1.Visible = true;
            txtErrorBiseccion.Visible = true;
            DGVBiseccion.Visible = true;
            lblNo.Visible = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = PaginaPrincipal;
            btnCorrerBiseccion.Visible = false;
            lblError1.Visible = false;
            txtErrorBiseccion.Visible = false;
            DGVBiseccion.Visible = false;
            lblNo.Visible = false;
        }

        private void btnRegreso2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = PaginaPrincipal;
            btnCorrerReglaFalsa.Visible = false;
            lblError2.Visible = false;
            txtErrorReglaFalsa.Visible = false;
            DGVReglaFalsa.Visible = false;
            lblNo2.Visible = false;
        }

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnCorrerReglaFalsa.Visible = true;
            lblError2.Visible = true;
            txtErrorReglaFalsa.Visible = true;
            DGVReglaFalsa.Visible = true;
            lblNo2.Visible = true;
        }
    }
}
