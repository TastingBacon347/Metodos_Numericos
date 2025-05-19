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
    public partial class Lagrange : Form
    {
        private List<Point> puntos = new List<Point>();
        private bool graficaAbierta = false;
        public Lagrange()
        {
            InitializeComponent();
            ConfigurarInterfaz();
            DGVLagrange.ScrollBars = ScrollBars.Both;
            DGVLagrange.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        private void ConfigurarInterfaz()
        {
            DGVEntrada.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVLagrange.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewTextBoxColumn columnX = new DataGridViewTextBoxColumn();
            columnX.HeaderText = "X";
            columnX.Name = "X";

            DataGridViewTextBoxColumn columnY = new DataGridViewTextBoxColumn();
            columnY.HeaderText = "Y";
            columnY.Name = "Y";

            DGVEntrada.Columns.Add(columnX);
            DGVEntrada.Columns.Add(columnY);

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
                string polinomio = NumericMethods.Lagrange(puntosArray);
                DataTable resultado = NumericMethods.ObtenerTablaBasesLagrange();
                if (resultado != null)
                {
                    DGVLagrange.DataSource = resultado;
                    string polinomioSimplificado = NumericMethods.ObtenerPolinomioLagrangeSimplificado();
                    txtPolinomio.Text = polinomio;
                    txtPoliSimp.Text = polinomioSimplificado;
                    graficaAbierta = true;
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

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            if (!graficaAbierta)
            {
                return;
            }
            if (Application.OpenForms["Grafica"] == null)
            {
                Grafica grafica = new Grafica();
                grafica.Controls.Add(NumericMethods.GraficarPolinomioInterpolante(puntos.ToArray()));
                grafica.Show();
            }
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

        private void btnLimpiarG_Click(object sender, EventArgs e)
        {
            DGVEntrada.Rows.Clear();
            DGVLagrange.DataSource = null;
            txtPolinomio.Clear();
            puntos.Clear();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Grafica"]?.Close();
            Menu Menu = (Menu)Application.OpenForms["Menu"];
            if (Menu != null)
            {
                Menu.Show();
                this.Close();
            }
        }

        private void Lagrange_Load(object sender, EventArgs e)
        {

        }
    }
}
