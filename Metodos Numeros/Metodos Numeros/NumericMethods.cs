using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCalc;
using LiveCharts;
using System.Windows.Forms;
using NCalc.Domain;
using System.Runtime.CompilerServices;

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
        
        public static void Grafica(string funcion, int a, int b)
        {

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
