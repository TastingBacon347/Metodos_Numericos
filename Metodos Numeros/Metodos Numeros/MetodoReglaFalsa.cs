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

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DGVReglaFalsa.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            DGVReglaFalsa.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            DGVReglaFalsa.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }
        private void btnRegreso2_Click(object sender, EventArgs e)
        {
            Menu Menu = (Menu)Application.OpenForms["Menu"];
            if (Menu != null)
            {
                Menu.Show();
                this.Close();
            }
            btnCorrerReglaFalsa.Visible = false;
            lblError2.Visible = false;
            txtErrorReglaFalsa.Visible = false;
            DGVReglaFalsa.Visible = false;
            lblNo2.Visible = false;
        }

        private void btnGraficaBiseccion_Click(object sender, EventArgs e)
        {
            string funcion = txtFuncionReglaFalsa.Text;  // 
            if (string.IsNullOrWhiteSpace(funcion))
            {
                MessageBox.Show("Ingresa una función válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtParametroAReglaFalsa.Text, out double a))
            {
                MessageBox.Show("Valor de inicio inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtParametroBReglaFalsa.Text, out double b))
            {
                MessageBox.Show("Valor de fin inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
        }

        private void btnCorrerReglaFalsa_Click(object sender, EventArgs e)
        {
            float num1, num2, num3;
            if (float.TryParse(txtErrorReglaFalsa.Text, out num1) &&
                float.TryParse(txtParametroBReglaFalsa.Text, out num2) &&
                float.TryParse(txtParametroAReglaFalsa.Text, out num3) &&
                !string.IsNullOrWhiteSpace(txtFuncionReglaFalsa.Text))
            {
                lblNo2.Visible = false;
            }
            else
            {
                lblNo2.Visible = true;
            }
            if (txtFuncionReglaFalsa.Text == string.Empty) return;
            if (txtParametroAReglaFalsa.Text == string.Empty) return;
            if (txtParametroBReglaFalsa.Text == string.Empty) return;
            if (txtErrorReglaFalsa.Text == string.Empty) return;
            DGVReglaFalsa.Rows.Clear();
            string mensaje = NumericMethods.ReglaFalsa(txtFuncionReglaFalsa.Text, Convert.ToDouble(txtParametroAReglaFalsa.Text), Convert.ToDouble(txtParametroBReglaFalsa.Text), Convert.ToDouble(txtErrorReglaFalsa.Text));
            foreach (string[] array in NumericMethods.ListaStrings)
            {
                DGVReglaFalsa.Rows.Add(array);
            }
            MessageBox.Show(mensaje, "Metodo Regla Falsa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
