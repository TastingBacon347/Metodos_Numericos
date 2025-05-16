using NCalc.Domain;
using OxyPlot.WindowsForms;
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
    public partial class Metodo_De_Biseccion: Form
    {


        public Metodo_De_Biseccion()
        {
            InitializeComponent();

        }

        private void guna2ImageButtonRegresar_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Grafica"]?.Close();
            Application.OpenForms["Animacion"]?.Close();
            Menu Menu = (Menu)Application.OpenForms["Menu"];
            if (Menu != null)
            {
                Menu.Show();
                Close();
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AyudaB"] == null)
            {
                AyudaB AyudaB = new AyudaB();
                AyudaB.Show();
            }
        }

        private void Metodo_De_Biseccion_Load(object sender, EventArgs e)
        {
            DGVBiseccion.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            DGVBiseccion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVBiseccion.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void btnCorrer_Click(object sender, EventArgs e)
        {
            string funcion = txtFuncionBiseccionGuna.Text;
            if (string.IsNullOrWhiteSpace(funcion))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }
            if (!double.TryParse(txtParametroABiseccionGuna.Text, out double a))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }
            if (!double.TryParse(txtParametroBBiseccionGuna.Text, out double b))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }

            if (!double.TryParse(txtErrorBiseccionGuna.Text, out double error))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }

            string mensaje = NumericMethods.Biseccion(funcion, a, b, error);
            DGVBiseccion.Visible = true;
            DGVBiseccion.DataSource = NumericMethods.ObtenerTablaBiseccion();
            MensajeGunaResultado.Text = mensaje;
            MensajeGunaResultado.Show();
        }
        private void btnAnimacion_Click(object sender, EventArgs e)
        {
            string funcion = txtFuncionBiseccionGuna.Text;
            if (string.IsNullOrWhiteSpace(funcion))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }
            if (!double.TryParse(txtParametroABiseccionGuna.Text, out double a))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }
            if (!double.TryParse(txtParametroBBiseccionGuna.Text, out double b))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }

            if (!double.TryParse(txtErrorBiseccionGuna.Text, out double error))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }
            if (Application.OpenForms["Animacion"] == null)
            {
                Animacion Animacion = new Animacion(funcion, a, b, error, 1000);
                Animacion.Show();
            }
            else
            {
                Application.OpenForms["Animacion"].Close();
                Animacion Animacion = new Animacion(funcion, a, b, error, 1000);
                Animacion.Show();
            }
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            string funcion = txtFuncionBiseccionGuna.Text;
            if (string.IsNullOrWhiteSpace(funcion))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }

            if (!double.TryParse(txtParametroABiseccionGuna.Text, out double a))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }

            if (!double.TryParse(txtParametroBBiseccionGuna.Text, out double b))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }
            if (Application.OpenForms["Grafica"] == null)
            {
                Grafica grafica = new Grafica();
                grafica.Controls.Add(NumericMethods.Grafica(funcion, a, b));
                grafica.Show();
            }
        }
    }
}
