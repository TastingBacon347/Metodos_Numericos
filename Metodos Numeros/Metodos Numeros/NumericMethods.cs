using System;
using System.Collections.Generic;
using System.Linq;
using NCalc;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using OxyPlot.Axes;
using OxyPlot.WindowsForms;
using OxyPlot;
using OxyPlot.Series;


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
        /// <summary>
        /// Grafica la función (expresión) usando OxyPlot en el rango [inicio, fin].
        /// </summary>
        public static void Grafica(string funcion, double inicio, double fin, PlotView plotView)
        {
            if (!ReemplazarEInicializarFuncion(ref funcion))
                return;

            // Inicializa la expresión
            exp = new Expression(funcion);

            // Construimos un nuevo modelo de OxyPlot
            var plotModel = new PlotModel
            {
                Title = $"Función: {funcion}"
            };

            // Agregamos ejes al modelo
            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "X"
            });
            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Y"
            });

            // Creamos la serie de línea
            var serie = new LineSeries
            {
                Title = $"f(x) = {funcion}",
                StrokeThickness = 2
            };

            // Definimos la cantidad de puntos o el paso
            int cantidadPuntos = 100;
            double paso = (fin - inicio) / cantidadPuntos;

            // Generamos los puntos en el rango [inicio, fin]
            if (paso == 0) paso = 0.01; // Evitar división por cero si inicio=fin

            // Si el rango va al revés, ajustamos paso para avanzar correctamente
            if (fin < inicio) paso = -Math.Abs(paso);

            for (double x = inicio; (paso > 0 && x <= fin) || (paso < 0 && x >= fin); x += paso)
            {
                double y = EvaluarLaFuncion(x);
                serie.Points.Add(new DataPoint(x, y));
            }

            // Agregamos la serie al modelo
            plotModel.Series.Add(serie);

            // Finalmente, asignamos el modelo resultante al PlotView
            plotView.Model = plotModel;
        }

        // -------------------------------------------------------------
        //                     MÉTODOS AUXILIARES
        // -------------------------------------------------------------


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
                @"e\s*\^\s*(.+)|e\s*\^\s*[\dx]+",
                "Exp($1)",
                RegexOptions.IgnoreCase
            );
            funcion = Regex.Replace(
                funcion,
                @"sin\s*(.+)|sin\s*[\dx]+",
                "Sin($1)",
                RegexOptions.IgnoreCase
            );
            funcion = Regex.Replace(
                funcion,
                @"(\)|[\.]+)\s*([\(\dx])",
                "$1 * $2"
            );
            funcion = Regex.Replace(
                funcion,
                @"(x)\s*(\d)",
                "$1 * $2"
            );
            funcion = Regex.Replace(
                funcion,
                @"(\d)\s*(x)",
                "$1 * $2"
            );
            funcion = Regex.Replace(
                funcion,
                @"(\([^\)]+\)|[a-zA-Z0-9\.]+)\s*\^\s*(\([^\)]+\)|[\-]?[0-9a-zA-Z\.]+)",
                "Pow($1,$2)"
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
                errorActual = 0;
            else
                errorActual = Math.Abs((cAnterior - c) / c);
        }

    }
}
