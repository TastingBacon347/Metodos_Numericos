﻿using System;
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
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using OxyPlot.Annotations;


namespace Metodos_Numeros
{
    public static class NumericMethods
    {
        static Expression exp;
        static string funcionOriginal;
        static double a, b, fa, fb, c, fc, cAnterior, errorActual;
        static List<string[]> listaStrings = new List<string[]>();
        static double[][] valores;

        public static List<string[]> ListaStrings { get => listaStrings; }

        /// <summary>
        /// Calcula el polinomio interpolante de Newton y lo almacena en la lista de strings.
        /// </summary>

        public static string Newton(Point[] puntos)
        {
            ListaStrings.Clear();
            CalcularDiferenciaDividida(puntos);
            return ObtenerPolinomioNewton();
        }
        public static string ObtenerPolinomioNewtonSimplificado()
        {
            List<double> polinomio = new List<double> { 0 };

            for (int i = 0; i < ListaStrings.Count; i++)
            {
                if (i + 1 >= ListaStrings[0].Length)
                    break;

                double coef = Convert.ToDouble(ListaStrings[0][i + 1]);
                if (Math.Abs(coef) < 1e-10) continue;

                List<double> termino = new List<double> { 1 };

                for (int j = 0; j < i; j++)
                {
                    double xj = Convert.ToDouble(ListaStrings[j][0]);
                    termino = MultiplicarPolinomios(termino, new List<double> { -xj, 1 }); // (x - xj)
                }

                for (int k = 0; k < termino.Count; k++)
                    termino[k] *= coef;

                polinomio = SumarPolinomios(polinomio, termino);
            }

            return FormatoPolinomio(polinomio, "P(x)");
        }
        /// <summary>
        /// Obtiene la tabla de diferencias divididas a partir de la lista de strings.
        /// </summary>
        public static DataTable ObtenerTablaDiferenciasDivididas()
        {
            DataTable tabla = new DataTable();

            tabla.Columns.Add("x", typeof(double));
            tabla.Columns.Add("y", typeof(double));
            for (int i = 1; i < ListaStrings.Count; i++)
            {
                tabla.Columns.Add("f[" + i + "]", typeof(double));
            }

            for (int i = 0; i < ListaStrings.Count; i++)
            {
                DataRow fila = tabla.NewRow();
                fila[0] = ListaStrings[i][0];
                fila[1] = ListaStrings[i][1];
                for (int j = 1; j < ListaStrings.Count - i; j++)
                {
                    fila[j + 1] = ListaStrings[i][j + 1];
                }

                tabla.Rows.Add(fila);
            }
            return tabla;
        }

        /// <summary>
        /// Calcula el polinomio interpolante de Lagrange y lo almacena en la lista de strings.
        /// </summary>
        public static string Lagrange(Point[] puntos)
        {
            if (puntos.Length == 0)
                return "No se Ingresaron Puntos";
            ListaStrings.Clear();
            CalcularBasesPolinomicasLagrange(puntos);
            return ObtenerPolinomioLagrange();
        }
        /// <summary>
        /// Obtiene el polinomio interpolante de Lagrange simplificado, sumando los términos y_i * L_i(x).
        /// </summary>
        public static string ObtenerPolinomioLagrangeSimplificado()
        {
            List<double> polinomioFinal = new List<double>();

            for (int i = 0; i < ListaStrings.Count; i++)
            {
                double yi = Convert.ToDouble(ListaStrings[i][1]);
                string LiExpandido = ListaStrings[i][4];

                // Obtener coeficientes desde string
                List<double> coeficientes = ExtraerCoeficientesDesdeString(LiExpandido);

                // Multiplicar por y_i
                for (int j = 0; j < coeficientes.Count; j++)
                    coeficientes[j] *= yi;

                // Sumar al polinomio final
                polinomioFinal = SumarPolinomios(polinomioFinal, coeficientes);
            }

            return FormatoPolinomio(polinomioFinal, "L(x)");
        }

        /// <summary>
        /// Genera un DataTable con las bases polinómicas de Lagrange en varias formas.
        /// </summary>
        public static DataTable ObtenerTablaBasesLagrange()
        {
            DataTable tabla = new DataTable();

            // Columnas
            tabla.Columns.Add("x", typeof(double));
            tabla.Columns.Add("y", typeof(double));
            tabla.Columns.Add("L(x) fracciones", typeof(string));
            tabla.Columns.Add("L(x) simplificado", typeof(string));
            tabla.Columns.Add("L(x) expandido", typeof(string));

            for (int i = 0; i < ListaStrings.Count; i++)
            {
                DataRow fila = tabla.NewRow();

                fila["x"] = Convert.ToDouble(ListaStrings[i][0]);
                fila["y"] = Convert.ToDouble(ListaStrings[i][1]);
                fila["L(x) fracciones"] = ListaStrings[i][2];
                fila["L(x) simplificado"] = ListaStrings[i][3];
                fila["L(x) expandido"] = ListaStrings[i][4];

                tabla.Rows.Add(fila);
            }
            return tabla;
        }

        /// <summary>
        /// Calcula la raiz de una funcion mediante el metodo numerico de Biseccion.
        /// </summary>
        public static string Biseccion(string funcion, double limiteA, double limiteB, double error)
        {
            ListaStrings.Clear();
            if (error <= 0)
                return "El Error Debe Ser Mayor a 0";

            EjecutarBiseccion(funcion, limiteA, limiteB, error);

            if (ListaStrings.Count == 0)
                return "No se Encontro una Raiz en el Intervalo Proporcionado";

            string[] ultima = ListaStrings.Last();
            string resultado = ultima[2]; // c
            string errorFinal = ultima[7]; // error

            if (errorFinal == "Null" || double.TryParse(errorFinal, out double err) && err == 0)
                return $"Se Encontro Raiz Exacta\rRaiz: {resultado}\rError Final: {errorFinal}";
            else
                return $"Se Encontro Una Aproximacion\rRaiz: {resultado}\rError Final: {errorFinal}";
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
            foreach (string[] array in listaStrings)
            {
                DataRow fila = tabla.NewRow();
                for (int i = 0; i < array.Length; i++)
                {
                    fila[i] = array[i];
                }
                tabla.Rows.Add(fila);
            }
            return tabla;
        }
        /// <summary>
        /// Calcula la raiz de una funcion mediante el metodo numerico de Regla Falsa.
        /// </summary>
        public static string ReglaFalsa(string funcion, double limiteA, double limiteB, double error)
        {
            ListaStrings.Clear();
            if (error <= 0)
                return "El Error Debe Ser Mayor a 0";

            EjecutarReglaFalsa(funcion, limiteA, limiteB, error);

            if (ListaStrings.Count == 0)
                return "No se Encontro una Raiz en el Intervalo Proporcionado";

            string[] ultima = ListaStrings.Last();
            string resultado = ultima[2]; // c
            string errorFinal = ultima[7]; // error

            if (errorFinal == "Null" || double.TryParse(errorFinal, out double err) && err == 0)
                return $"Se Encontro Raiz Exacta\rRaiz: {resultado}\rError Final: {errorFinal}";
            else
                return $"Se Encontro Una Aproximacion\rRaiz: {resultado}\rError Final: {errorFinal}";
        }

        /// <summary>
        /// Obtiene la tabla de bisección a partir de la lista de strings.
        /// </summary>
        public static DataTable ObtenerTablaReglaFalsa()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("a", typeof(string));
            tabla.Columns.Add("b", typeof(string));
            tabla.Columns.Add("c", typeof(string));
            tabla.Columns.Add("f(a)", typeof(string));
            tabla.Columns.Add("f(b)", typeof(string));
            tabla.Columns.Add("f(c)", typeof(string));
            tabla.Columns.Add("Lado", typeof(string));
            tabla.Columns.Add("Error", typeof(string));
            foreach (string[] array in listaStrings)
            {
                DataRow fila = tabla.NewRow();
                for (int i = 0; i < array.Length; i++)
                {
                    fila[i] = array[i];
                }
                tabla.Rows.Add(fila);
            }
            return tabla;
        }
        /// <summary>
        /// Grafica la función (expresión) usando OxyPlot en el rango [inicio, fin].
        /// </summary>
        public static PlotView Grafica(string funcion, double limiteA, double limiteB)
        {
            PlotView plotView = new PlotView();
            plotView.Dock = DockStyle.Fill;
            funcionOriginal = funcion;
            if (!ReemplazarEInicializarFuncion(ref funcion))
                return null;
            a = limiteA;
            b = limiteB;
            LineSeries linea = new LineSeries();

            if (a > b)
            {
                (b, a) = (a, b);
            }
            for (double i = a; i < b; i += 0.01)
            {
                linea.Points.Add(new DataPoint(i, EvaluarLaFuncion(i)));
            }

            PlotModel modelo = new PlotModel { Title = funcionOriginal };
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
            linea.Title = funcionOriginal;
            linea.Color = OxyColors.Blue;
            linea.StrokeThickness = 2;
            return plotView;
        }
        /// <summary>
        ///     Genera una gráfica del polinomio interpolante a partir de los puntos dados.
        /// </summary>
        public static PlotView GraficarPolinomioInterpolante(Point[] puntos, bool usarNewton = false)
        {
            List<double> coef;
            string polinomio;
            if (usarNewton)
            {
                polinomio = ObtenerPolinomioNewtonSimplificado();
            }
            else
            {
                polinomio = ObtenerPolinomioLagrangeSimplificado();

            }
            coef = ExtraerCoeficientesDesdeString(polinomio);


            double minX = puntos.Min(p => p.X);
            double maxX = puntos.Max(p => p.X);
            double paso = (maxX - minX) / 100.0;


            PlotView plotView = new PlotView { Dock = DockStyle.Fill };
            LineSeries serie = new LineSeries { Title = "Interpolante", StrokeThickness = 2, Color = OxyColors.SteelBlue };

            for (double x = minX; x <= maxX; x += paso)
                serie.Points.Add(new DataPoint(x, EvaluarPolinomio(coef, x)));


            ScatterSeries puntosOriginales = new ScatterSeries
            {
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerFill = OxyColors.Red,
                Title = "Puntos"
            };

            foreach (var p in puntos)
                puntosOriginales.Points.Add(new ScatterPoint(p.X, p.Y));


            PlotModel modelo = new PlotModel { Title = "Polinomio Interpolante" };
            modelo.Series.Add(serie);
            modelo.Series.Add(puntosOriginales);
            modelo.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Title = "x", Minimum = minX, Maximum = maxX });
            modelo.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = "y" });

            plotView.Model = modelo;
            return plotView;
        }
        /// <summary>
        /// Animación de la bisección o regla falsa.
        /// </summary>
        public static async Task AnimacionAsync(
            PlotView plotView,
            string funcion,
            double aInicial,
            double bInicial,
            double error,
            int delayMs = 1000,
            bool biseccion = true)
        {
            // Ejecutar el método para llenar ListaStrings
            if (biseccion)
                EjecutarBiseccion(funcion, aInicial, bInicial, error);
            else
                EjecutarReglaFalsa(funcion, aInicial, bInicial, error);

            if (ListaStrings.Count == 0 || plotView == null || plotView.IsDisposed)
                return;

            // Crear modelo base
            var modelo = new PlotModel { Title = $"Animación {(biseccion ? "Bisección" : "Regla Falsa")}" };
            var serieFuncion = new LineSeries { Title = "f(x)", Color = OxyColors.Blue };

            double aG = aInicial, bG = bInicial;
            for (double x = aG; x <= bG; x += 0.01)
                serieFuncion.Points.Add(new DataPoint(x, EvaluarLaFuncion(x)));

            modelo.Series.Add(serieFuncion);

            var xAxis = new LinearAxis { Position = AxisPosition.Bottom, Title = "x", Minimum = aG, Maximum = bG };
            var yAxis = new LinearAxis { Position = AxisPosition.Left, Title = "f(x)" };
            modelo.Axes.Add(xAxis);
            modelo.Axes.Add(yAxis);

            // Línea horizontal en y = 0 (eje X)
            modelo.Annotations.Add(new LineAnnotation
            {
                Type = LineAnnotationType.Horizontal,
                Y = 0,
                Color = OxyColors.Black,
                LineStyle = LineStyle.Solid,
                StrokeThickness = 1
            });

            plotView.Invoke(new Action(() =>
            {
                if (!plotView.IsDisposed)
                    plotView.Model = modelo;
            }));

            for (int i = 0; i < ListaStrings.Count; i++)
            {
                if (plotView == null || plotView.IsDisposed || !plotView.IsHandleCreated)
                    break;

                string[] fila = ListaStrings[i];

                double aVal = double.Parse(fila[0]);
                double bVal = double.Parse(fila[1]);
                double cVal = double.Parse(fila[2]);
                double fcVal = double.Parse(fila[biseccion ? 4 : 5]);
                string errorStr = fila.Last();

                // Limpiar anteriores
                var seriesAEliminar = modelo.Series.Where(s =>
                    s is ScatterSeries ||
                    (s is LineSeries l && (
                        l.Color == OxyColors.Gray ||
                        l.Color == OxyColors.Red || l.Color == OxyColors.Green
                    )))
                      .ToList();

                foreach (var serie in seriesAEliminar)
                    modelo.Series.Remove(serie);

                var annotationsAEliminar = modelo.Annotations.Where(a =>
                a is TextAnnotation ||
                (a is LineAnnotation la && (
                la.Y == fcVal || la.Color == OxyColors.DarkOrange
                )))
                    .ToList();

                foreach (var annotation in annotationsAEliminar)
                    modelo.Annotations.Remove(annotation);

                // Punto c
                var punto = new ScatterSeries
                {
                    MarkerType = MarkerType.Circle,
                    MarkerFill = OxyColors.Red,
                    MarkerSize = 5
                };
                punto.Points.Add(new ScatterPoint(cVal, fcVal));
                modelo.Series.Add(punto);

                // Línea vertical en c
                var lineaC = new LineSeries { Color = OxyColors.Gray, StrokeThickness = 1 };
                lineaC.Points.Add(new DataPoint(cVal, -10));
                lineaC.Points.Add(new DataPoint(cVal, 10));
                modelo.Series.Add(lineaC);

                // Línea horizontal en f(c)
                modelo.Annotations.Add(new LineAnnotation
                {
                    Type = LineAnnotationType.Horizontal,
                    Y = fcVal,
                    Color = OxyColors.DarkOrange,
                    LineStyle = LineStyle.Dot,
                    StrokeThickness = 1
                });

                // Zoom dinámico al intervalo actual (debe hacerse antes de agregar las líneas)
                double margenX = (bVal - aVal) * 0.1;
                double margenY = Math.Max(1, Math.Abs(fcVal) * 1.5);
                xAxis.Minimum = aVal - margenX;
                xAxis.Maximum = bVal + margenX;
                yAxis.Minimum = fcVal - margenY;
                yAxis.Maximum = fcVal + margenY;

                // Línea vertical en a (todo el alto visible)
                var lineaA = new LineSeries { Color = OxyColors.Red, StrokeThickness = 2 };
                lineaA.Points.Add(new DataPoint(aVal, yAxis.Minimum));
                lineaA.Points.Add(new DataPoint(aVal, yAxis.Maximum));
                modelo.Series.Add(lineaA);

                // Línea vertical en b (todo el alto visible)
                var lineaB = new LineSeries { Color = OxyColors.Green, StrokeThickness = 2 };
                lineaB.Points.Add(new DataPoint(bVal, yAxis.Minimum));
                lineaB.Points.Add(new DataPoint(bVal, yAxis.Maximum));
                modelo.Series.Add(lineaB);


                // Texto
                var texto = new TextAnnotation
                {
                    Text = $"Iteración {i + 1}\nc = {cVal:0.#####}\nf(c) = {fcVal:0.#####}\nError = {errorStr}",
                    TextPosition = new DataPoint(cVal, fcVal),
                    Stroke = OxyColors.Transparent,
                    TextHorizontalAlignment = OxyPlot.HorizontalAlignment.Left,
                    TextVerticalAlignment = VerticalAlignment.Top,
                    FontSize = 12
                };
                modelo.Annotations.Add(texto);

                // Zoom dinámico al intervalo actual
                margenX = (bVal - aVal) * 0.1;
                margenY = Math.Max(1, Math.Abs(fcVal) * 1.5);
                xAxis.Minimum = aVal - margenX;
                xAxis.Maximum = bVal + margenX;
                yAxis.Minimum = fcVal - margenY;
                yAxis.Maximum = fcVal + margenY;

                plotView.Invoke(new Action(() =>
                {
                    if (!plotView.IsDisposed)
                        plotView.Model.InvalidatePlot(true);
                }));

                await Task.Delay(delayMs);
            }
        }


        // -------------------------------------------------------------
        //                     MÉTODOS AUXILIARES
        // -------------------------------------------------------------

        /// <summary>
        /// Evalúa la función en un punto x.
        /// </summary>
        private static double EvaluarPolinomio(List<double> coeficientes, double x)
        {
            double resultado = 0;
            for (int i = 0; i < coeficientes.Count; i++)
            {
                resultado += coeficientes[i] * Math.Pow(x, i);
            }
            return resultado;
        }

        /// <summary>
        /// Extrae los coeficientes de un polinomio dado en forma de cadena.
        /// </summary>
        private static List<double> ExtraerCoeficientesDesdeString(string polinomioStr)
        {
            int igualIndex = polinomioStr.IndexOf('=');
            string expresion = polinomioStr.Substring(igualIndex + 1).Trim();

            var coeficientes = new Dictionary<int, double>();
            expresion = expresion.Replace("-", "+-");
            string[] terminos = expresion.Split('+');

            foreach (string t in terminos)
            {
                if (string.IsNullOrWhiteSpace(t)) continue;

                string termino = t.Trim();
                double coef;
                int grado;

                if (termino.Contains("x^"))
                {
                    var partes = termino.Split(new[] { "x^" }, StringSplitOptions.None);
                    coef = partes[0] == "-" ? -1 : (partes[0] == "" ? 1 : Convert.ToDouble(partes[0]));
                    grado = int.Parse(partes[1]);
                }
                else if (termino.Contains("x"))
                {
                    coef = termino == "-x" ? -1 : (termino == "x" ? 1 : Convert.ToDouble(termino.Replace("x", "")));
                    grado = 1;
                }
                else
                {
                    coef = Convert.ToDouble(termino);
                    grado = 0;
                }

                if (!coeficientes.ContainsKey(grado))
                    coeficientes[grado] = 0;
                coeficientes[grado] += coef;
            }

            int maxGrado = coeficientes.Count > 0 ? coeficientes.Keys.Max() : 0;
            var lista = new List<double>(new double[maxGrado + 1]);
            foreach (var kv in coeficientes)
                lista[kv.Key] = kv.Value;

            return lista;
        }


        /// <summary>
        /// Devuelve el polinomio interpolante de Lagrange sin simplificar, en forma de suma de términos y_i * L_i(x).
        /// </summary>
        private static string ObtenerPolinomioLagrange()
        {
            StringBuilder polinomio = new StringBuilder("L(x) = ");

            for (int i = 0; i < ListaStrings.Count; i++)
            {
                string yi = ListaStrings[i][1];
                string LiExpandido = ListaStrings[i][4];

                int igualIndex = LiExpandido.IndexOf('=');
                string expresionLi = LiExpandido.Substring(igualIndex + 1).Trim();

                if (i > 0)
                    polinomio.Append(" + ");

                polinomio.Append($"{yi}*({expresionLi})");
            }

            return polinomio.ToString();
        }
        /// <summary>
        /// Obtiene el polinomio interpolante de Newton en forma de cadena.
        /// </summary>
        private static string ObtenerPolinomioNewton()
        {
            StringBuilder polinomio = new StringBuilder("P(x) = ");
            polinomio.Append(ListaStrings[0][1]);

            for (int i = 2; i < ListaStrings[0].Length; i++)
            {
                double coef = Convert.ToDouble(ListaStrings[0][i]);
                if (coef == 0) continue;

                string termino = coef >= 0 ? " + " : " - ";
                polinomio.Append(termino + Math.Abs(coef).ToString("0.######"));

                for (int j = 1; j < i; j++)
                {
                    double valor = Convert.ToDouble(ListaStrings[j - 1][0]);
                    polinomio.Append(valor == 0 ? "(x)" : valor < 0 ? "(x + " + Math.Abs(valor).ToString("0.######") + ")" : "(x - " + Math.Abs(valor).ToString("0.######") + ")");
                }
            }

            return polinomio.ToString();
        }
        /// <summary>
        /// Calcula los Valores para la Diferencia Dividida utilizada en la representación de Newton del polinomio interpolante.
        /// </summary>

        private static void CalcularDiferenciaDividida(Point[] puntos)
        {
            valores = new double[puntos.Length][];
            for (int i = 0; i < puntos.Length; i++)
            {
                valores[i] = new double[puntos.Length];
                valores[i][0] = puntos[i].Y;
                ListaStrings.Add(new string[puntos.Length + 1]);
                ListaStrings[i][0] = puntos[i].X.ToString();
                ListaStrings[i][1] = puntos[i].Y.ToString();
            }
            for (int j = 1; j < puntos.Length; j++)
            {
                for (int i = 0; i < puntos.Length - j; i++)
                {
                    valores[i][j] = (valores[i + 1][j - 1] - valores[i][j - 1]) / (puntos[i + j].X - puntos[i].X);
                    ListaStrings[i][j + 1] = Math.Round(valores[i][j], 6).ToString("0.######");
                }
            }
        }
        /// <summary>
        /// Calcula las bases polinomicas de Lagrange a partir de los puntos dados y las almacena en la lista.
        /// </summary>
        private static void CalcularBasesPolinomicasLagrange(Point[] puntos)
        {
            for (int i = 0; i < puntos.Length; i++)
            {
                StringBuilder LiFraccionado = new StringBuilder($"L{i}(x) = ");
                StringBuilder numeradorBuilder = new StringBuilder();
                double denominadorTotal = 1.0;

                List<double> polinomioNumerador = new List<double> { 1 };

                bool primerTermino = true;
                for (int j = 0; j < puntos.Length; j++)
                {
                    if (j == i) continue;

                    double xi = puntos[i].X;
                    double xj = puntos[j].X;
                    double denominador = xi - xj;

                    denominadorTotal *= denominador;

                    string termFraccion = $"(x - {xj}) / ({xi} - {xj})";
                    if (!primerTermino)
                    {
                        LiFraccionado.Append(" * ");
                        numeradorBuilder.Append("*");
                    }

                    LiFraccionado.Append(termFraccion);
                    numeradorBuilder.Append($"(x - {xj})");

                    polinomioNumerador = MultiplicarPolinomios(
                        polinomioNumerador,
                        new List<double> { -xj, 1 }
                    );

                    primerTermino = false;
                }


                for (int d = 0; d < polinomioNumerador.Count; d++)
                    polinomioNumerador[d] /= denominadorTotal;

                string[] fila = new string[5];
                fila[0] = puntos[i].X.ToString();
                fila[1] = puntos[i].Y.ToString();
                fila[2] = LiFraccionado.ToString();
                fila[3] = $"L{i}(x) = {numeradorBuilder} / {denominadorTotal}";
                fila[4] = FormatoPolinomio(polinomioNumerador, $"L{i}(x)");

                ListaStrings.Add(fila);
            }
        }
        /// <summary>
        /// Multiplica dos polinomios representados como listas de coeficientes.
        /// </summary>
        private static List<double> MultiplicarPolinomios(List<double> p1, List<double> p2)
        {
            var resultado = new double[p1.Count + p2.Count - 1];

            for (int i = 0; i < p1.Count; i++)
                for (int j = 0; j < p2.Count; j++)
                    resultado[i + j] += p1[i] * p2[j];

            return new List<double>(resultado);
        }
        /// <summary>
        /// Suma dos polinomios representados como listas de coeficientes.
        /// </summary>
        private static List<double> SumarPolinomios(List<double> p1, List<double> p2)
        {
            int len = Math.Max(p1.Count, p2.Count);
            var resultado = new List<double>(new double[len]);

            for (int i = 0; i < len; i++)
            {
                double a = i < p1.Count ? p1[i] : 0;
                double b = i < p2.Count ? p2[i] : 0;
                resultado[i] = a + b;
            }

            return resultado;
        }
        /// <summary>
        /// Formatea el polinomio para su visualización.
        /// </summary>
        private static string FormatoPolinomio(List<double> coef, string nombre)
        {
            var sb = new StringBuilder();
            sb.Append($"{nombre} = ");

            bool primero = true;
            for (int i = coef.Count - 1; i >= 0; i--)
            {
                double c = coef[i];
                if (Math.Abs(c) < 1e-5) continue;
                if (!primero)
                    sb.Append(c >= 0 ? " +" : " -");
                else if (c < 0)
                    sb.Append("-");

                double absC = Math.Abs(c);
                if (i == 0)
                    sb.Append($"{absC:0.#####}");
                else if (i == 1)
                    sb.Append(absC == 1 ? "x" : $"{absC:0.#####}x");
                else
                    sb.Append(absC == 1 ? $"x^{i}" : $"{absC:0.#####}x^{i}");

                primero = false;
            }

            return sb.ToString();
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
        private static string[] ConstruirFilaReglaFalsa(
            double a, double b, double c,
            double fa, double fb, double fc,
            string lado, string error
        )
        {
            return new string[]
            {
            a.ToString("0.######"), b.ToString("0.######"), c.ToString("0.######"),
            fa.ToString("0.######"), fb.ToString("0.######"), fc.ToString("0.######"),
            lado, error
            };
        }
        /// <summary>
        /// Construye un arreglo de string con los valores de la iteración,
        /// para luego meterlo a la lista (List<string[]>).
        /// </summary>
        private static string[] ConstruirFilaBiseccion(
            double a, double b, double c,
            double fa, double fc, double fafc,
            string lado, string error
        )
        {
            return new string[]
            {
            a.ToString("0.######"), b.ToString("0.######"), c.ToString("0.######"),
            fa.ToString("0.######"), fc.ToString("0.######"), fafc.ToString("0.######"),
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


        /// <summary>
        ///  Ejecuta el método de bisección.
        /// </summary>
        private static void EjecutarBiseccion(string funcion, double limiteA, double limiteB, double error)
        {
            ListaStrings.Clear();

            if (!ReemplazarEInicializarFuncion(ref funcion)) return;
            if (!PrepararIntervalo(limiteA, limiteB)) return;

            c = ObtenerValorDeCEnBiseccion();
            fc = EvaluarLaFuncion(c);
            errorActual = 0;

            string lado = (fa * fc > 0) ? "DER" : "IZQ";
            ListaStrings.Add(ConstruirFilaBiseccion(a, b, c, fa, fc, fa * fc, lado, "Null"));

            if (SeEncontroRaizExacta()) return;

            do
            {
                RealizarIteracionBiseccion(ref lado);
                ListaStrings.Add(ConstruirFilaBiseccion(a, b, c, fa, fc, fa * fc, lado, errorActual.ToString("0.######")));
            }
            while (errorActual >= error);
        }
        /// <summary>
        ///  Ejecuta el método de Regla Falsa.
        /// </summary>
        private static void EjecutarReglaFalsa(string funcion, double limiteA, double limiteB, double error)
        {
            ListaStrings.Clear();

            if (!ReemplazarEInicializarFuncion(ref funcion)) return;
            if (!PrepararIntervalo(limiteA, limiteB)) return;

            c = ObtenerValorDeCEnReglaFalsa();
            fc = EvaluarLaFuncion(c);
            errorActual = 0;

            string lado = (fa * fc > 0) ? "DER" : "IZQ";
            ListaStrings.Add(ConstruirFilaReglaFalsa(a, b, c, fa, fb, fc, lado, "Null"));

            if (SeEncontroRaizExacta()) return;

            do
            {
                RealizarIteracionReglaFalsa(ref lado);
                ListaStrings.Add(ConstruirFilaReglaFalsa(a, b, c, fa, fb, fc, lado, errorActual.ToString("0.######")));
            }
            while (errorActual >= error);
        }

    }
}
