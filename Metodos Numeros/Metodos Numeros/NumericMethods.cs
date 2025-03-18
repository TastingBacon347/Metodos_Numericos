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

            if (!ReemplazarEInicializarFuncion(ref funcion))
                return listaStrings;

            if (!PrepararIntervalo(limiteA, limiteB))
                return listaStrings; 

            c = ObtenerValorDeCEnBiseccion();
            fc = EvaluarLaFuncion(c);
            errorActual = 0;
            string lado = (fa * fc > 0) ? "DER" : "IZQ";
            listaStrings.Add(ConstruirFila(a, b, c, fa, fb, fc, lado, "Null"));
            do
            {
                RealizarIteracionBiseccion(ref lado);
                listaStrings.Add(ConstruirFila(a, b, c, fa, fb, fc, lado, errorActual.ToString()));
            } while (errorActual >= error);

            return listaStrings;
        }
        public static List<string[]> ReglaFalsa(string funcion, double limiteA, double limiteB, double error)
        {
            List<string[]> listaStrings = new List<string[]>();

            if (!ReemplazarEInicializarFuncion(ref funcion))
                return listaStrings; 

            if (!PrepararIntervalo(limiteA, limiteB))
                return listaStrings;

            c = ObtenerValorDeCEnReglaFalsa();
            fc = EvaluarLaFuncion(c);
            errorActual = 0;
            string lado = (fa * fc > 0) ? "DER" : "IZQ";
            listaStrings.Add(ConstruirFila(a, b, c, fa, fb, fc, lado, "Null"));
            do
            {
                RealizarIteracionReglaFalsa(ref lado);
                listaStrings.Add(ConstruirFila(a, b, c, fa, fb, fc, lado, errorActual.ToString()));
            } while (errorActual >= error);

            return listaStrings;
        }

        // ---------------------------------------------------------------------
        // Métodos auxiliares para que el código sea más limpio y entendible
        /// <summary>
        /// Encapsula la iteración de la bisección (actualiza a, b, c, fc y calcula error).
        /// </summary>
        private static void RealizarIteracionBiseccion(ref string lado)
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
            lado = (fa * fc > 0) ? "DER" : "IZQ";
            CalcularErrorActual();
        }
        /// <summary>
        /// Reemplaza ^ por pow(), crea la expresión y la valida.
        /// </summary>
        /// 
        private static bool ReemplazarEInicializarFuncion(ref string funcion)
        {
            funcion = Regex.Replace(
                funcion,
                @"(\([^\)]+\)|[a-zA-Z0-9\.]+)\s*\^\s*([\-]?[0-9a-zA-Z\.]+)",
                "pow($1,$2)" // O Pow($1,$2) si tu NCalc lo prefiere
            );

            exp = new Expression(funcion);
            return EsExpresionValida();
        }

        /// <summary>
        /// Asigna a, b y evalúa fa, fb. Retorna false si no hay raíz en el intervalo (fa*fb >= 0).
        /// </summary>
        private static bool PrepararIntervalo(double limiteA, double limiteB)
        {
            a = limiteA;
            b = limiteB;
            fa = EvaluarLaFuncion(a);
            fb = EvaluarLaFuncion(b);
            return !NoExisteRaizEnElIntervalo();
        }

        /// <summary>
        /// Realiza 1 iteración de la Regla Falsa. Actualiza a, b, c, fc y errorActual.
        /// </summary>
        private static void RealizarIteracionReglaFalsa(ref string lado)
        {
            if (fa * fc > 0)
                a = c;
            else
                b = c;

            cAnterior = c;
            cAnterior = fc;
            fa = EvaluarLaFuncion(a);
            fb = EvaluarLaFuncion(b);
            c = ObtenerValorDeCEnReglaFalsa();
            fc = EvaluarLaFuncion(c);
            lado = (fa * fc > 0) ? "DER" : "IZQ";
            CalcularErrorActual();
        }

        /// <summary>
        /// Construye un arreglo de string con los valores de la iteración,
        /// para luego meterlo a la lista (List<string[]>).
        /// </summary>
        private static string[] ConstruirFila(
            double a, double b, double c,
            double fa, double fb, double fc,
            string lado, string error
        )
        {
            return new string[]
            {
            a.ToString(), b.ToString(), c.ToString(),
            fa.ToString(), fb.ToString(), fc.ToString(),
            lado, error
            };
        }

        /// <summary>
        /// Valida si hay error de sintaxis en la expresión. Para mayor robustez,
        /// podría hacer un Evaluate con un 'x' ficticio y ver si salta excepción.
        /// </summary>
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

        /// <summary>
        /// Verifica si fa*fb >= 0, lo que implica que no hay raíz (o hay múltiples) en [a,b].
        /// </summary>
        private static bool NoExisteRaizEnElIntervalo()
        {
            return fa * fb >= 0;
        }

        /// <summary>
        /// Evalúa la expresión actual en un valor 'parametro'.
        /// </summary>
        private static double EvaluarLaFuncion(double parametro)
        {
            exp.Parameters["x"] = parametro;
            return Convert.ToDouble(exp.Evaluate());
        }

        /// <summary>
        /// Fórmula de Regla Falsa: c = (a * fb - b * fa) / (fb - fa)
        /// </summary>
        private static double ObtenerValorDeCEnReglaFalsa()
        {
            return (a * fb - b * fa) / (fb - fa);
        }
        /// <summary>
        /// Regresa (a + b) / 2, la 'c' típica de bisección.
        /// </summary>
        private static double ObtenerValorDeCEnBiseccion()
        {
            return (a + b) / 2;
        }
        /// <summary>
        /// Calcula error con base en fcAnterior y fc, evitando división por cero.
        /// </summary>
        private static void CalcularErrorActual()
        {
            if (fc == 0)
                errorActual = 0;  // Raíz exacta
            else
                errorActual = Math.Abs((cAnterior - c) / c);
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
    }
}
