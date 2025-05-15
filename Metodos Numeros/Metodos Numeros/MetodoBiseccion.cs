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
            if (Application.OpenForms["Form4"] == null)
            {
                btnGraficaBiseccion.Enabled = true;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DGVBiseccion.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            DGVBiseccion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVBiseccion.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCorrerBiseccion_Click(object sender, EventArgs e)
        {
            float num1, num2, num3;
            if (float.TryParse(txtErrorBiseccionGuna.Text, out num1) &&
                float.TryParse(txtParametroBBiseccionGuna.Text, out num2) &&
                float.TryParse(txtParametroABiseccionGuna.Text, out num3) &&
                !string.IsNullOrWhiteSpace(txtFuncionBiseccionGuna.Text))
            {
                
            }

            //No se donde poner el messagebox en caso de que no haya raiz en el intervalo 
            //Cambie el codigo y no se como invocar la grafica lolamento
            else
            {
                MensajeGuna1.Show();
            }
            if (txtFuncionBiseccionGuna.Text == string.Empty) return;
            if (txtParametroABiseccionGuna.Text == string.Empty) return;
            if (txtParametroBBiseccionGuna.Text == string.Empty) return;
            if (txtErrorBiseccionGuna.Text == string.Empty) return;
            DGVBiseccion.Rows.Clear();
            string mensaje = NumericMethods.Biseccion(txtFuncionBiseccionGuna.Text, Convert.ToDouble(txtParametroABiseccionGuna.Text), Convert.ToDouble(txtParametroBBiseccionGuna.Text), Convert.ToDouble(txtErrorBiseccionGuna.Text));
            foreach(string[] array in NumericMethods.ListaStrings)
            {
                DGVBiseccion.Rows.Add(array);
            }
            
        }


        private void btnGraficaBiseccion_Click(object sender, EventArgs e)
        {
            string funcion = txtFuncionBiseccionGuna.Text;  // 
            if (string.IsNullOrWhiteSpace(funcion))
            {
                MensajeGuna2.Show();
                return;
            }

            if (!double.TryParse(txtParametroABiseccionGuna.Text, out double a))
            {
                MensajeGuna3.Show();
                return;
            }

            if (!double.TryParse(txtParametroBBiseccionGuna.Text, out double b))
            {
                MensajeGuna4.Show();
                return;
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            AyudaB AyudaB = new AyudaB();
            AyudaB.Show();

        }

        private void DGVBiseccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtParametroBBiseccionGuna_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            Menu Menu = (Menu)Application.OpenForms["Menu"];
            if (Menu != null)
            {
                Menu.Show();
                this.Close();
                AyudaB AyudaB = new AyudaB();
                AyudaB.Close();
            }
        }
    }
}
