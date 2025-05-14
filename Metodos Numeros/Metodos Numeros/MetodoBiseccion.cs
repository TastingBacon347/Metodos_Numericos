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

        private void Form2_Load(object sender, EventArgs e)
        {
            DGVBiseccion.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            DGVBiseccion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVBiseccion.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }


        private void btnCorrerBiseccion_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtErrorBiseccionGuna.Text, out _))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }
            if (!float.TryParse(txtParametroBBiseccionGuna.Text, out _))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }
            if(!float.TryParse(txtParametroABiseccionGuna.Text, out _))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }
            if(string.IsNullOrWhiteSpace(txtFuncionBiseccionGuna.Text))
            {
                MensajeGunaFuncionValida.Show();
                return;
            }
            DGVBiseccion.Rows.Clear();
            string mensaje = NumericMethods.Biseccion(txtFuncionBiseccionGuna.Text, Convert.ToDouble(txtParametroABiseccionGuna.Text), Convert.ToDouble(txtParametroBBiseccionGuna.Text), Convert.ToDouble(txtErrorBiseccionGuna.Text));

            foreach (string[] array in NumericMethods.ListaStrings)
            {
                DGVBiseccion.Rows.Add(array);
            }
            MensajeGunaResultado.Text = mensaje;
            MensajeGunaResultado.Show();
        }


        private void btnGraficaBiseccion_Click(object sender, EventArgs e)
        {
            string funcion = txtFuncionBiseccionGuna.Text;  // 
            if (string.IsNullOrWhiteSpace(funcion))
            {
                MensajeGunaFuncionValida.Show();
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

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            AyudaB AyudaB = new AyudaB();
            AyudaB.Show();

        }


        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            Menu Menu = (Menu)Application.OpenForms["Menu"];
            if (Menu != null)
            {
                Menu.Show();
                this.Close();
            }
        }
    }
}
