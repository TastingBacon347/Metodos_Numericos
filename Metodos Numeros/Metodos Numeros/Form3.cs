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
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DGVReglaFalsa.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            DGVReglaFalsa.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            DGVReglaFalsa.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void btnVerificarReglaFalsa_Click(object sender, EventArgs e)
        {
            btnCorrerReglaFalsa.Visible = true;
            lblError2.Visible = true;
            txtErrorReglaFalsa.Visible = true;
            DGVReglaFalsa.Visible = true;
            lblNo2.Visible = true;
        }

        private void btnRegreso2_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"]; 
            if (form1 != null)
            {
                form1.Show(); 
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
            

        }

        private void btnCorrerReglaFalsa_Click(object sender, EventArgs e)
        {
            if (txtFuncionReglaFalsa.Text == string.Empty) return;
            if (txtParametroAReglaFalsa.Text == string.Empty) return;
            if (txtParametroBReglaFalsa.Text == string.Empty) return;
            if (txtErrorReglaFalsa.Text == string.Empty) return;
            DGVReglaFalsa.Rows.Clear();
            List<string[]> lista = NumericMethods.ReglaFalsa(txtFuncionReglaFalsa.Text, Convert.ToDouble(txtParametroAReglaFalsa.Text), Convert.ToDouble(txtParametroBReglaFalsa.Text), Convert.ToDouble(txtErrorReglaFalsa.Text));
            foreach (string[] array in lista)
            {
                DGVReglaFalsa.Rows.Add(array);
            }
        }
    }
}
