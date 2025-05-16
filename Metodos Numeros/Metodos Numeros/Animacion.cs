using NCalc.Domain;
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
    public partial class Animacion : Form
    {
        string funcion;
        double aInicial, bInicial, tolerancia;

       

        bool biseccion;
        public Animacion(string funcion, double aInicial, double bInicial, double tolerancia, bool biseccion)
        {
            this.funcion = funcion;
            this.aInicial = aInicial;
            this.bInicial = bInicial;
            this.tolerancia = tolerancia;
            this.biseccion = biseccion;
            InitializeComponent();
            
        }
        private async void Animacion_Load(object sender, EventArgs e)
        {
            await NumericMethods.AnimacionAsync(plotViewAnimacion, funcion, aInicial, bInicial, tolerancia,biseccion: biseccion);
        }
    }
}
