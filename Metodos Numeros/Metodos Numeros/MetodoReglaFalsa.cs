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
            txtErrorReglaFGuna.Visible = false;
            DGVReglaFalsa.Visible = false;
        }

        private void btnGraficaBiseccion_Click(object sender, EventArgs e)
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

            
        }

        private void btnCorrerReglaFalsa_Click(object sender, EventArgs e)
        {
            float num1, num2, num3;
            if (float.TryParse(txtErrorReglaFGuna.Text, out num1) &&
                float.TryParse(txtParametroBReglaFGuna.Text, out num2) &&
                float.TryParse(txtParametroAReglaFGuna.Text, out num3) &&
                !string.IsNullOrWhiteSpace(txtFuncionReglaFGuna.Text))
            {
                
            }
            //No se donde poner el messagebox en caso de que no haya raiz en el intervalo 
            //Cambie el codigo y no se como invocar la grafica lolamento
            else
            {
                MensajeGuna1.Show();
            }
            if (txtFuncionReglaFGuna.Text == string.Empty) return;
            if (txtParametroAReglaFGuna.Text == string.Empty) return;
            if (txtParametroBReglaFGuna.Text == string.Empty) return;
            if (txtErrorReglaFGuna.Text == string.Empty) return;
            DGVReglaFalsa.Rows.Clear();
            string mensaje = NumericMethods.ReglaFalsa(txtFuncionReglaFGuna.Text, Convert.ToDouble(txtParametroAReglaFGuna.Text), Convert.ToDouble(txtParametroBReglaFGuna.Text), Convert.ToDouble(txtErrorReglaFGuna.Text));
            foreach (string[] array in NumericMethods.ListaStrings)
            {
                DGVReglaFalsa.Rows.Add(array);
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AyudaD AyudaD = new AyudaD();
            AyudaD.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Menu Menu = (Menu)Application.OpenForms["Menu"];
            if (Menu != null)
            {
                Menu.Show();
                this.Close();
                AyudaD AyudaD = new AyudaD();
                AyudaD.Close();
            }

        }
    }
}
