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
    public partial class Form2: Form
    {


        public Form2()
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
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            if (form1 != null)
            {
                form1.Show(); 
                this.Close(); 
            }
        }

        private void btnCorrerBiseccion_Click(object sender, EventArgs e)
        {
            float num1, num2, num3;
            if (float.TryParse(txtErrorBiseccion.Text, out num1) &&
                float.TryParse(txtParametroBBiseccion.Text, out num2) &&
                float.TryParse(txtParametroABiseccion.Text, out num3) &&
                !string.IsNullOrWhiteSpace(txtFuncionBiseccion.Text))
            {
                lblNo.Visible = false;
            }
            else
            {
                lblNo.Visible = true;
            }
            if (txtFuncionBiseccion.Text == string.Empty) return;
            if (txtParametroABiseccion.Text == string.Empty) return;
            if (txtParametroBBiseccion.Text == string.Empty) return;
            if (txtErrorBiseccion.Text == string.Empty) return;
            DGVBiseccion.Rows.Clear();
            string mensaje = NumericMethods.Biseccion(txtFuncionBiseccion.Text, Convert.ToDouble(txtParametroABiseccion.Text), Convert.ToDouble(txtParametroBBiseccion.Text), Convert.ToDouble(txtErrorBiseccion.Text));
            foreach(string[] array in NumericMethods.ListaStrings)
            {
                DGVBiseccion.Rows.Add(array);
            }
            MessageBox.Show(mensaje, "Metodo Biseccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnGraficaBiseccion_Click(object sender, EventArgs e)
        {

            Form4 nuevaVentana = new Form4();
            nuevaVentana.Show();

        }

    }
}
