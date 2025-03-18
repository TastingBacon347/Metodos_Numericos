using System;
using System.Collections.Generic;
using System.Linq;
using NCalc;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System.Windows.Forms;


namespace Metodos_Numeros
{
    public static class NumericMethods
    {
        static Expression exp;
        static double a, b, fa, fb, c, fc, fcAnterior, errorActual;
        public static void Biseccion(string funcion, double limiteA, double limiteB, double error, DataGridView dataGridView)
        {
            exp = new Expression(funcion);
            if (!EsExpresionValida()) return;
            a = limiteA;
            b = limiteB;
            fa = EvaluarLaFuncion(a);
            fb = EvaluarLaFuncion(b);
            if (NoExisteRaizEnElIntervalo()) return;
            exp = new Expression(funcion);
            c = ObtenerValorDeCEnBiseccion();
            fcAnterior = EvaluarLaFuncion(c);
            errorActual = 0;
            dataGridView.Rows.Add(a, b, c, fa, fb, fc, "Null");
            do
            {
                fa = EvaluarLaFuncion(a);
                fb = EvaluarLaFuncion(b);
                c = ObtenerValorDeCEnBiseccion();
                fc = EvaluarLaFuncion(c);
                if (fa * fc > 0)
                {
                    a = c;
                }
                else
                {
                    b = c;
                }
                CalcularErrorActual();
                fcAnterior = fc;
                dataGridView.Rows.Add(a, b, c, fa, fb, fc, errorActual);
            } while (errorActual >= error);
        }
        public static void ReglaFalsa(string funcion, int limiteA, int limiteB, float error, DataGridView dataGridView)
        {
            exp = new Expression(funcion);
            if (!EsExpresionValida()) return;
            a = limiteA;
            b = limiteB;
            fa = EvaluarLaFuncion(a);
            fb = EvaluarLaFuncion(b);
            if (NoExisteRaizEnElIntervalo()) return;
            exp = new Expression(funcion);
            c = ObtenerValorDeCEnReglaFalsa();
            fcAnterior = EvaluarLaFuncion(c);
            errorActual = 0;
            dataGridView.Rows.Add(a, b, c, fa, fb, fc, "Null");
            do
            {
                fa = EvaluarLaFuncion(a);
                fb = EvaluarLaFuncion(b);
                c = ObtenerValorDeCEnBiseccion();
                fc = EvaluarLaFuncion(c);
                if (fa * fc > 0)
                {
                    a = c;
                }
                else
                {
                    b = c;
                }
                CalcularErrorActual();
                fcAnterior = fc;
                dataGridView.Rows.Add(a, b, c, fa, fb, fc, errorActual);
            } while (errorActual >= error);
        }
        private static void CalcularErrorActual()
        {
            errorActual = fc != 0 ? Math.Abs((fcAnterior - fc) / fc) : Math.Abs((fcAnterior - fc) / (fc + 0.01));
        }
        private static double ObtenerValorDeCEnReglaFalsa()
        {
            return (a * fb - b * fa) / (fb - fa);
        }
        private static double ObtenerValorDeCEnBiseccion()
        {
            return (a + b) / 2;
        }
        
        private static bool NoExisteRaizEnElIntervalo()
        {
            return fa * fb >= 0;
        }
        private static double EvaluarLaFuncion(double parametro)
        {
            exp.Parameters["x"] = parametro;
            return Convert.ToDouble(exp.Evaluate());
        }

        public static void Grafica(string funcion, double a, double b, LiveCharts.WinForms.CartesianChart chart)
        { 
            exp = new Expression(funcion);
            if (!EsExpresionValida())
                return;
            chart.Series.Clear();
            chart.AxisX.Clear();
            chart.AxisY.Clear();
            ChartValues<double> valoresY = new ChartValues<double>();
            List<double> valoresX = new List<double>();

            double paso = (b - a) / 100.0; 

            for (double x = a; x <= b; x += paso)
            {
                double y = EvaluarLaFuncion(x);
                valoresX.Add(x);
                valoresY.Add(y);
            }

            chart.Series.Add(new LineSeries
            {
                Title = $"f(x) = {funcion}",
                Values = valoresY,
                PointGeometry = null
            });

            chart.AxisX.Add(new Axis
            {
                Title = "X",
                Labels = valoresX.Select(v => v.ToString("F2")).ToArray(),
                Separator = new LiveCharts.Wpf.Separator { Step = 10 }
            });

            chart.AxisY.Add(new Axis
            {
                Title = "Y"
            });
        }
        private static bool EsExpresionValida()
        {
            try
            {
                exp.Parameters["x"] = 1;
                var result = exp.Evaluate();  
                return !exp.HasErrors();        
            }
            catch
            {
                return false;                 
            }
        }
    }
}
