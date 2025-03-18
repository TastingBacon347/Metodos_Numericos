using System;
using System.Collections.Generic;
using System.Linq;
using NCalc;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Metodos_Numeros
{
    public static class NumericMethods
    {
        static Expression exp;
        static double a, b, fa, fb, c, fc, cAnterior, errorActual;
        public static List<string[]> Biseccion(string funcion, double limiteA, double limiteB, double error)
        {
            List<string[]> listaStrings = new List<string[]>();
            funcion = Regex.Replace(funcion, @"(\([^\)]+\)|[a-zA-Z0-9\.]+)\s*\^\s*([\-]?[0-9a-zA-Z\.]+)", "Pow($1,$2)");
            exp = new Expression(funcion);
            if (!EsExpresionValida()) return listaStrings;
            a = limiteA;
            b = limiteB;
            fa = EvaluarLaFuncion(a);
            fb = EvaluarLaFuncion(b);
            if (NoExisteRaizEnElIntervalo()) return listaStrings;
            c = ObtenerValorDeCEnBiseccion();
            fc = EvaluarLaFuncion(c);
            errorActual = 0;
            string lado = fa * fc > 0 ? "DER" : "IZQ";
            listaStrings.Add(new string[] { a.ToString(), b.ToString(), c.ToString(), fa.ToString(), fb.ToString(), fc.ToString(), lado, "Null" });
            do
            {
                if (fa * fc > 0)
                {
                    a = c;
                }
                else
                {
                    b = c;
                }
                cAnterior = c;
                fa = EvaluarLaFuncion(a);
                fb = EvaluarLaFuncion(b);
                c = ObtenerValorDeCEnBiseccion();
                fc = EvaluarLaFuncion(c);
                if (fa * fc > 0)
                {
                    lado = "DER";
                }
                else
                {
                    lado = "IZQ";
                }
                CalcularErrorActual();
                listaStrings.Add(new string[] { a.ToString(), b.ToString(), c.ToString(), fa.ToString(), fb.ToString(), fc.ToString(), lado, errorActual.ToString() });
            } while (errorActual >= error);
            return listaStrings;
        }
        public static List<string[]> ReglaFalsa(string funcion, double limiteA, double limiteB, double error)
        {
            List<string[]> listaStrings = new List<string[]>();
            funcion = Regex.Replace(funcion, @"(\([^\)]+\)|[a-zA-Z0-9\.]+)\s*\^\s*([\-]?[0-9a-zA-Z\.]+)", "Pow($1,$2)");
            exp = new Expression(funcion);
            if (!EsExpresionValida()) return listaStrings;
            a = limiteA;
            b = limiteB;
            fa = EvaluarLaFuncion(a);
            fb = EvaluarLaFuncion(b);
            if (NoExisteRaizEnElIntervalo()) return listaStrings;
            c = ObtenerValorDeCEnReglaFalsa();
            fc = EvaluarLaFuncion(c);
            errorActual = 0;
            string lado = fa * fc > 0 ? "DER" : "IZQ";
            listaStrings.Add(new string[] { a.ToString(), b.ToString(), c.ToString(), fa.ToString(), fb.ToString(), fc.ToString(), lado, "Null" });
            do
            {
                if (fa * fc > 0)
                {
                    a = c;
                }
                else
                {
                    b = c;
                }
                cAnterior = c;
                fa = EvaluarLaFuncion(a);
                fb = EvaluarLaFuncion(b);
                c = ObtenerValorDeCEnReglaFalsa();
                fc = EvaluarLaFuncion(c);
                if (fa * fc > 0)
                {
                    lado = "DER";
                }
                else
                {
                    lado = "IZQ";
                }
                CalcularErrorActual(); 
                listaStrings.Add(new string[] { a.ToString(), b.ToString(), c.ToString(), fa.ToString(), fb.ToString(), fc.ToString(), lado, errorActual.ToString() });
            } while (errorActual >= error);
            return listaStrings;
        }
        private static void CalcularErrorActual()
        {
            errorActual = fc != 0 ? Math.Abs((cAnterior - c) / c) : 0;
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
                return true;        
            }
            catch
            {
                return false;                 
            }
        }
    }
}
