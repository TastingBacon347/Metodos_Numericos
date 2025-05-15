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
using System.CodeDom.Compiler;
using System.Drawing;
using System.Text;
using System.Data;


namespace Metodos_Numeros
{
    public static class NumericMethods
    {
        static Expression exp;
        static double a, b, fa, fb, c, fc, cAnterior, errorActual;
        static List<string[]> listaStrings = new List<string[]>();
        static double[][] valores;

        public static List<string[]> ListaStrings { get => listaStrings;}
        public static DataTable ObtenerTablaNewton()
        {
            DataTable tabla = new DataTable();

            tabla.Columns.Add("x", typeof(double));
            tabla.Columns.Add("f(x)", typeof(double));
            for (int i = 1; i < valores.Length; i++)
            {
                tabla.Columns.Add("f[" + i + "]", typeof(double));
            }

            for (int i = 0; i < valores.Length; i++)
            {
                DataRow fila = tabla.NewRow();
                fila[0] = valores[i];

                for (int j = 0; j < valores.Length - i; j++)
                {
                    fila[j + 1] = Math.Round(valores[i][j], 6);
                }

                tabla.Rows.Add(fila);
            }

            return tabla;
        }
        /// <summary>
        /// Obtiene la tabla de bisección a partir de la lista de strings.
        /// </summary>
        public static DataTable ObtenerTablaBiseccion()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("a", typeof(string));
            tabla.Columns.Add("b", typeof(string));
            tabla.Columns.Add("c", typeof(string));
            tabla.Columns.Add("f(a)", typeof(string));
            tabla.Columns.Add("f(c)", typeof(string));
            tabla.Columns.Add("f(a) * f(c)", typeof(string));
            tabla.Columns.Add("Lado", typeof(string));
            tabla.Columns.Add("Error", typeof(string));
            foreach(string[] array in listaStrings)
            {
                DataRow fila = tabla.NewRow();
                for(int i = 0; i < array.Length; i++)
                {
                    fila[i] = array[i];
                }
                tabla.Rows.Add(fila);
            }   
            return tabla;
        }

        /// <summary>
        /// Calcula el polinomio interpolante de Newton y lo almacena en la lista de strings.
        /// </summary>

        public static string Newton(Point[] puntos)
        {
            ListaStrings.Clear();
            if (puntos.Length == 0)
                return "No se Ingresaron Puntos";
            DiferenciaDividida(puntos);

            return "Valores Calculados";
        }

        public static string Lagrange(Point[] puntos, double x)
        {
            if (puntos.Length == 0)
                return "No se Ingresaron Puntos";
            double resultado = 0;
            for (int i = 0; i < puntos.Length; i++)
            {
                double termino = puntos[i].Y;
                for (int j = 0; j < puntos.Length; j++)
                {
                    if (i != j)
                    {
                        termino *= (x - puntos[j].X) / (puntos[i].X - puntos[j].X);
                    }
                }
                resultado += termino;
            }
            return resultado.ToString();
        }

        /// <summary>
        /// Calcula la raiz de una funcion mediante el metodo numerico de Biseccion.
        /// </summary>
        public static string Biseccion(string funcion, double limiteA, double limiteB, double error)
        {
            ListaStrings.Clear();
            if(error <= 0)
                return "El Error Debe Ser Mayor a 0";

            funcion = funcion.ToLower();
            if (!ReemplazarEInicializarFuncion(ref funcion))
                return "La Funcion Ingresada No Tiene la Sintaxis Correcta";

            if (!PrepararIntervalo(limiteA, limiteB))
                return "No se Encontro una Raiz en el Intervalo Proporcionado"; 

            c = ObtenerValorDeCEnBiseccion();
            fc = EvaluarLaFuncion(c);
            errorActual = 0;
            string lado = (fa * fc > 0) ? "DER" : "IZQ";
            ListaStrings.Add(ConstruirFila(a, b, c, fa, fb, fc, lado, "Null"));
            if(SeEncontroRaizExacta())
                return string.Format("Se Encontro Raiz Exacta\rRaiz: {0}\rError Final: {1}", c, errorActual);
            do
            {
                RealizarIteracionBiseccion(ref lado);
                ListaStrings.Add(ConstruirFila(a, b, c, fa, fb, fc, lado, Math.Round(errorActual, 6).ToString()));
            } while (errorActual >= error);
            if(SeEncontroRaizExacta())
                return string.Format("Se Encontro Raiz Exacta\rRaiz: {0}\rError Final: {1}", c, errorActual);
            return string.Format("Se Encontro Una Aproximacion\rRaiz: {0}\rError Final: {1}", c, errorActual);
        }
        /// <summary>
        /// Calcula la raiz de una funcion mediante el metodo numerico de Regla Falsa.
        /// </summary>
        public static string ReglaFalsa(string funcion, double limiteA, double limiteB, double error)
        {
            ListaStrings.Clear();
            if (error <= 0)
                return "El Error Debe Ser Mayor a 0";

            funcion = funcion.ToLower();
            if (!ReemplazarEInicializarFuncion(ref funcion))
                return "La Funcion Ingresada No Tiene la Sintaxis Correcta";

            if (!PrepararIntervalo(limiteA, limiteB))
                return "No se Encontro una Raiz en el Intervalo Proporcionado";

            c = ObtenerValorDeCEnReglaFalsa();
            fc = EvaluarLaFuncion(c);
            errorActual = 0;
            string lado = (fa * fc > 0) ? "DER" : "IZQ";
            ListaStrings.Add(ConstruirFila(a, b, c, fa, fb, fc, lado, "Null"));
            if (SeEncontroRaizExacta())
                return string.Format("Se Encontro Raiz Exacta\rRaiz: {0}\rError Final: {1}", c, errorActual);
            do
            {
                RealizarIteracionReglaFalsa(ref lado);
                ListaStrings.Add(ConstruirFila(a, b, c, fa, fb, fc, lado, Math.Round(errorActual, 6).ToString()));
            } while (errorActual >= error);
            if (SeEncontroRaizExacta())
                return string.Format("Se Encontro Raiz Exacta\rRaiz: {0}\rError Final: {1}", c, errorActual);
            return string.Format("Se Encontro Una Aproximacion\rRaiz: {0}\rError Final: {1}", c, errorActual);
        }
        /// <summary>
        /// Grafica la función (expresión) usando OxyPlot en el rango [inicio, fin].
        /// </summary>
        public static PlotView Grafica(string funcion, double limiteA, double limiteB)
        {
            PlotView plotView = new PlotView();
            plotView.Dock = DockStyle.Fill;
            if (!ReemplazarEInicializarFuncion(ref funcion))
                return null;
            a = limiteA;
            b = limiteB;
            LineSeries linea = new LineSeries();

            if (a > b)
            {
                (b, a) = (a, b);
            }
            for (double i = a; i < b; i+=0.01)
            {
                linea.Points.Add(new DataPoint(i, EvaluarLaFuncion(i)));
            }

            PlotModel modelo = new PlotModel { Title = funcion };
            modelo.Series.Add(linea);

            var xAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,    
                Title = "Eje X",                 
                Minimum = a,              
                Maximum = b,                     
                MajorStep = 1,                     
                MinorStep = 0.5                    
            };

            var yAxis = new LinearAxis
            {
                Position = AxisPosition.Left, 
                Title = "Eje Y",              
                Minimum = -2,                      
                Maximum = 2,                      
                MajorStep = 1,                      
                MinorStep = 0.5                     
            };
            xAxis.MajorGridlineStyle = LineStyle.Solid;   
            xAxis.MinorGridlineStyle = LineStyle.Dot;      
            xAxis.MajorGridlineThickness = 1;              
            xAxis.MinorGridlineThickness = 0.5;            

            xAxis.AxislineStyle = LineStyle.Solid;
            xAxis.AxislineColor = OxyColors.Black;
            xAxis.TitleFontWeight = FontWeights.Bold;
            xAxis.TitleFontSize = 14;

            yAxis.MajorGridlineStyle = LineStyle.Solid;
            yAxis.MinorGridlineStyle = LineStyle.Dot;
            yAxis.MajorGridlineThickness = 1;
            yAxis.MinorGridlineThickness = 0.5;

            yAxis.AxislineStyle = LineStyle.Solid;
            yAxis.AxislineColor = OxyColors.Black;
            yAxis.TitleFontWeight = FontWeights.Bold;
            yAxis.TitleFontSize = 14;

            modelo.Axes.Add(xAxis);
            modelo.Axes.Add(yAxis);
            plotView.Model = modelo;
            linea.Title = funcion;
            linea.Color = OxyColors.Blue;
            linea.StrokeThickness = 2;
            return plotView;
        }

        // -------------------------------------------------------------
        //                     MÉTODOS AUXILIARES
        // -------------------------------------------------------------
        /// <summary>
        /// Obtiene el polinomio interpolante en forma de cadena.
        /// </summary>

        public static string ObtenerPolinomio(Point[] puntos)
        {
            if (puntos.Length == 0)
                return "No hay puntos para interpolar";

            StringBuilder polinomio = new StringBuilder();
            polinomio.Append(valores[0][0].ToString("0.######"));

            for (int i = 1; i < puntos.Length; i++)
            {
                double coef = valores[0][i];
                if (coef == 0) continue;

                string termino = coef >= 0 ? " + " : " - ";
                polinomio.Append(termino + Math.Abs(coef).ToString("0.######"));

                for (int j = 0; j < i; j++)
                {
                    polinomio.Append("(x - " + puntos[j].X.ToString("0.######") + ")");
                }
            }

            return polinomio.ToString();
        }
        /// <summary>
        /// Calcula los Valores para la Diferencia Dividida utilizada en la representación de Newton del polinomio interpolante.
        /// </summary>

        private static void DiferenciaDividida(Point[] puntos)
        {
            valores = new double[puntos.Length][];
            for (int i = 0; i < puntos.Length; i++)
            {
                valores[i] = new double[puntos.Length];
                valores[i][0] = puntos[i].Y;
                ListaStrings.Add(new string[puntos.Length+1]);
                ListaStrings[i][0] = puntos[i].X.ToString();
                ListaStrings[i][1] = puntos[i].Y.ToString();
            }
            for (int j = 1; j < puntos.Length; j++)
            {
                for (int i = 0; i < puntos.Length - j; i++)
                {
                    valores[i][j] = (valores[i + 1][j - 1] - valores[i][j - 1]) / (puntos[i + j].X - puntos[i].X);
                    ListaStrings[i][j + 1] = valores[i][j].ToString();
                }
            }
        }

        /// <summary>
        /// Regresa True si se encontro una raiz exacta.
        /// </summary>
        private static bool SeEncontroRaizExacta()
        {
            return fc == 0;
        }
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
                @"e\s*\^\s*(\(?-?\s*[\dx]+\)?)",
                "Exp($1)",
                RegexOptions.IgnoreCase
            );
            funcion = Regex.Replace(
                funcion,
                @"sin\s*(\(?\s*[\dx]+\)?)",
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
            return ExisteRaizEnElIntervalo();
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
            Math.Round(a, 6).ToString(), Math.Round(b, 6).ToString(), Math.Round(c, 6).ToString(),
            Math.Round(fa, 6).ToString(), Math.Round(fb, 6).ToString(), Math.Round(fc, 6).ToString(),
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
        private static bool ExisteRaizEnElIntervalo()
        {
            return fa * fb <= 0;
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
