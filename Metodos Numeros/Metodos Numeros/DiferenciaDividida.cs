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
    public partial class DiferenciasDivididas : Form
    {
        private List<Point> puntos = new List<Point>();

        public DiferenciasDivididas()
        {
            InitializeComponent();
            ConfigurarInterfaz();
        }

        private void ConfigurarInterfaz()
        {

            DataGridViewTextBoxColumn columnX = new DataGridViewTextBoxColumn();
            columnX.HeaderText = "X";
            columnX.Name = "X";

            DataGridViewTextBoxColumn columnY = new DataGridViewTextBoxColumn();
            columnY.HeaderText = "Y";
            columnY.Name = "Y";

            DGVEntrada.Columns.Add(columnX);
            DGVEntrada.Columns.Add(columnY);

            // Agregar eventos
            btnAgregarPuntoG.Click += btnAgregarPuntoG_Click;
            btnCalcularG.Click += btnCalcularG_Click;
            btnLimpiarG.Click += btnLimpiarG_Click;
        }

        private void DGVEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnAgregarPuntoG_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(txtX.Text);
                double y = Convert.ToDouble(txtY.Text);

                // Verificar si ya existe un punto con la misma X
                bool existeX = false;
                foreach (DataGridViewRow row in DGVEntrada.Rows)
                {
                    if (row.Cells[0].Value != null && Convert.ToDouble(row.Cells[0].Value) == x)
                    {
                        existeX = true;
                        break;
                    }
                }

                if (existeX)
                {
                    MessageBox.Show("Ya existe un punto con el mismo valor de X. Los valores de X deben ser únicos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DGVEntrada.Rows.Add(x, y);

                txtX.Clear();
                txtY.Clear();
                txtX.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLimpiarG_Click(object sender, EventArgs e)
        {
            DGVEntrada.Rows.Clear();
            DGVDiferenciaDividida.DataSource = null;
            txtPolinomio.Clear();
            puntos.Clear();
        }

        private void btnCalcularG_Click(object sender, EventArgs e)
        {
            try
            {
                puntos.Clear();
                foreach (DataGridViewRow row in DGVEntrada.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        double x = Convert.ToDouble(row.Cells[0].Value);
                        double y = Convert.ToDouble(row.Cells[1].Value);
                        puntos.Add(new Point((int)(x * 1), (int)(y * 1)));
                    }
                }

                if (puntos.Count < 2)
                {
                    MessageBox.Show("Se necesitan al menos 2 puntos para calcular las diferencias divididas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Point[] puntosArray = puntos.ToArray();

                //DataTable resultado = CalculadoraDiferenciaDividida.CalcularDiferenciaDividida(puntosArray);
                string res = NumericMethods.Newton(puntosArray);
                DataTable resultado = NumericMethods.ObtenerTablaDiferenciasDivididas();
                if (resultado != null)
                {
                    DGVDiferenciaDividida.DataSource = resultado;

                    //string polinomio = CalculadoraDiferenciaDividida.ObtenerPolinomio(puntosArray);
                    string polinomio = NumericMethods.ObtenerPolinomioNewtonSimplificado();
                    txtPolinomio.Text = polinomio;
                }
                else
                {
                    MessageBox.Show("No se pudo calcular las diferencias divididas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresarG_Click(object sender, EventArgs e)
        {
            Menu Menu = (Menu)Application.OpenForms["Menu"];
            if (Menu != null)
            {
                Menu.Show();
                this.Close();
            }
        }
    }
    // Clase para manejar el método de Diferencia Dividida
    //public class CalculadoraDiferenciaDividida
    //{
    //    private static double[][] valores;

    //    public static DataTable CalcularDiferenciaDividida(Point[] puntos)
    //    {
    //        if (puntos.Length == 0)
    //            return null;

    //        valores = new double[puntos.Length][];
    //        for (int i = 0; i < puntos.Length; i++)
    //        {
    //            valores[i] = new double[puntos.Length];
    //            valores[i][0] = puntos[i].Y;
    //        }

    //        for (int j = 1; j < puntos.Length; j++)
    //        {
    //            for (int i = 0; i < puntos.Length - j; i++)
    //            {
    //                valores[i][j] = (valores[i + 1][j - 1] - valores[i][j - 1]) / (puntos[i + j].X - puntos[i].X);
    //            }
    //        }

    //        DataTable tabla = new DataTable();

    //        tabla.Columns.Add("x", typeof(double));
    //        tabla.Columns.Add("f(x)", typeof(double));
    //        for (int i = 1; i < puntos.Length; i++)
    //        {
    //            tabla.Columns.Add("f[" + i + "]", typeof(double));
    //        }

    //        for (int i = 0; i < puntos.Length; i++)
    //        {
    //            DataRow fila = tabla.NewRow();
    //            fila[0] = puntos[i].X;

    //            for (int j = 0; j < puntos.Length - i; j++)
    //            {
    //                fila[j + 1] = Math.Round(valores[i][j], 6);
    //            }

    //            tabla.Rows.Add(fila);
    //        }

    //        return tabla;
    //    }

    //    public static string ObtenerPolinomio(Point[] puntos)
    //    {
    //        if (puntos.Length == 0)
    //            return "No hay puntos para interpolar";

    //        StringBuilder polinomio = new StringBuilder();
    //        polinomio.Append(valores[0][0].ToString("0.######"));

    //        for (int i = 1; i < puntos.Length; i++)
    //        {
    //            double coef = valores[0][i];
    //            if (coef == 0) continue;

    //            string termino = coef >= 0 ? " + " : " - ";
    //            polinomio.Append(termino + Math.Abs(coef).ToString("0.######"));

    //            for (int j = 0; j < i; j++)
    //            {
    //                polinomio.Append("(x - " + puntos[j].X.ToString("0.######") + ")");
    //            }
    //        }

    //        return polinomio.ToString();
    //    }
    //}
    
}
