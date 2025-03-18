using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc.Domain;
using System.Windows.Forms.Integration;

namespace Metodos_Numeros
{
    public partial class Form5 : Form
    {
        private string funcion;
        private double inicio;
        private double fin;

        public Form5(string funcion, double inicio, double fin)
        {
            InitializeComponent();

            // Asigna los valores recibidos
            this.funcion = funcion;
            this.inicio = inicio;
            this.fin = fin;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Cuando se carga Form5, genera la gráfica
            NumericMethods.Grafica(funcion, inicio, fin, cartesianChart2);
        }
    }
}
