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
    public partial class Metodo_De_Regla_Falsa: Form
    {
        public Metodo_De_Regla_Falsa()
        {
            InitializeComponent();
            this.AcceptButton = btnCorrerMetodo;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DGVReglaFalsa.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            DGVReglaFalsa.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            DGVReglaFalsa.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }
        
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AyudaD AyudaD = new AyudaD();
            AyudaD.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
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

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            string funcion = txtFuncionReglaFGuna.Text;  // 
            if (string.IsNullOrWhiteSpace(funcion))
            {
                MensajeGuna2.Show();
                return;
            }

            if (!double.TryParse(txtParametroAReglaFGuna.Text, out double a))
            {
                MensajeGuna3.Show();
                return;
            }

            if (!double.TryParse(txtParametroBReglaFGuna.Text, out double b))
            {
                MensajeGuna4.Show();
                return;
            }
            if (Application.OpenForms["Grafica"] == null)
            {
                Grafica grafica = new Grafica();
                grafica.Controls.Add(NumericMethods.Grafica(funcion, a, b));
                grafica.Show();
            }
        }

        private void btnCorrerMetodo_Click(object sender, EventArgs e)
        {
            string funcion = txtFuncionReglaFGuna.Text;
            if (string.IsNullOrWhiteSpace(funcion))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }
            if (!double.TryParse(txtParametroAReglaFGuna.Text, out double a))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }
            if (!double.TryParse(txtParametroBReglaFGuna.Text, out double b))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }

            if (!double.TryParse(txtErrorReglaFGuna.Text, out double error))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }

            string mensaje = NumericMethods.ReglaFalsa(funcion, a, b, error);
            DGVReglaFalsa.Visible = true;
            DGVReglaFalsa.DataSource = NumericMethods.ObtenerTablaReglaFalsa();
            MensajeGunaResultado.Text = mensaje;
            MensajeGunaResultado.Show();
            btnGrafica.Visible = true;
            btnAnimacion.Visible = true;
        }

        private void btnAnimacion_Click(object sender, EventArgs e)
        {
            string funcion = txtFuncionReglaFGuna.Text;
            if (string.IsNullOrWhiteSpace(funcion))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }
            if (!double.TryParse(txtParametroAReglaFGuna.Text, out double a))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }
            if (!double.TryParse(txtParametroBReglaFGuna.Text, out double b))
            {
                MensajeGunaDatosFaltantes.Show();
                return;
            }

            if (!double.TryParse(txtErrorReglaFGuna.Text, out double error))
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

        //float num1, num2, num3;
        //if (float.TryParse(txtErrorReglaFGuna.Text, out num1) &&
        //    float.TryParse(txtParametroBReglaFGuna.Text, out num2) &&
        //    float.TryParse(txtParametroAReglaFGuna.Text, out num3) &&
        //    !string.IsNullOrWhiteSpace(txtFuncionReglaFGuna.Text))
        //{

        //}
        //else
        //{
        //    MensajeGuna1.Show();
        //}
        //if (txtFuncionReglaFGuna.Text == string.Empty) return;
        //if (txtParametroAReglaFGuna.Text == string.Empty) return;
        //if (txtParametroBReglaFGuna.Text == string.Empty) return;
        //if (txtErrorReglaFGuna.Text == string.Empty) return;
        //DGVReglaFalsa.Rows.Clear();
        //string mensaje = NumericMethods.ReglaFalsa(txtFuncionReglaFGuna.Text, Convert.ToDouble(txtParametroAReglaFGuna.Text), Convert.ToDouble(txtParametroBReglaFGuna.Text), Convert.ToDouble(txtErrorReglaFGuna.Text));
        //foreach (string[] array in NumericMethods.ListaStrings)
        //{
        //    DGVReglaFalsa.Rows.Add(array);
        //}
        //btnGrafica.Visible = true;
        //btnAnimacion.Visible = true;
    }
}
