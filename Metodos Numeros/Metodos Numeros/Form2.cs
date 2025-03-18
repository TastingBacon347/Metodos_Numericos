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
            btnCorrerBiseccion.Visible = false;
            lblError1.Visible = false;
            txtErrorBiseccion.Visible = false;
            DGVBiseccion.Visible = false;
            lblNo.Visible = false;
        }

        private void btnVerficarBiseccion_Click(object sender, EventArgs e)
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
    }
}
