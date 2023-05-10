using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_simples
{
    internal static class Operacoes
    {
        public static double soma(double a, double b) 
        { 
            return a+b; 
        }

        public static double multiplicacao(double a, double b)
        {
            return a*b;
        }

        public static double divisao(double a,double b)
        {
            double resultado2;
            resultado2 = a / b;
            return resultado2;
        }
    }
}
