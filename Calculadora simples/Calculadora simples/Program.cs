using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posicao;
            double a, b;
            double resultado = 0;
            string operacao = Console.ReadLine();
            Console.WriteLine("Digite a operação desejada:");
        Inicio:
            if (operacao.IndexOf('*') > operacao.IndexOf('/'))
            {
                if (operacao.Contains('*'))
                {
                    posicao = operacao.IndexOf("*");
                    a = double.Parse(operacao.Substring(posicao - 1, 1));
                    b = double.Parse(operacao.Substring(posicao + 1, 1));
                    resultado = Operacoes.multiplicacao(a, b);
                    string c = operacao.Substring(posicao - 1, 3);
                    operacao = operacao.Replace(operacao.Substring(posicao - 1, 3), resultado.ToString());
                    goto Inicio;
                }
                else if (operacao.Contains('/'))
                {
                    posicao = operacao.IndexOf("/");
                    a = double.Parse(operacao.Substring(posicao - 1, 1));
                    b = double.Parse(operacao.Substring(posicao + 1, 1));
                    resultado = Operacoes.divisao(a, b);
                    operacao = operacao.Replace(operacao.Substring(posicao - 1, 3), resultado.ToString());
                    goto Inicio;
                }
                else if (operacao.Contains('+'))
                {
                    posicao = operacao.IndexOf("+");
                    a = double.Parse(operacao.Substring(posicao - 1, 1));
                    b = double.Parse(operacao.Substring(posicao + 1, 1));
                    resultado = Operacoes.soma(a, b);
                    operacao = operacao.Replace(operacao.Substring(posicao - 1, 3), resultado.ToString());
                    goto Inicio;
                }
                Console.WriteLine(resultado);
            }
            else
            {
                if (operacao.Contains('/'))
                {
                    posicao = operacao.IndexOf("/");
                    a = double.Parse(operacao.Substring(posicao - 1, 1));
                    b = double.Parse(operacao.Substring(posicao + 1, 1));
                    resultado = Operacoes.divisao(a, b);
                    operacao = operacao.Replace(operacao.Substring(posicao - 1, 3), resultado.ToString());
                    goto Inicio;
                }
                else if (operacao.Contains('*'))
                {
                    posicao = operacao.IndexOf("*");
                    a = double.Parse(operacao.Substring(posicao - 1, 1));
                    b = double.Parse(operacao.Substring(posicao + 1, 1));
                    resultado = Operacoes.multiplicacao(a, b);
                    string c = operacao.Substring(posicao - 1, 3);
                    operacao = operacao.Replace(operacao.Substring(posicao - 1, 3), resultado.ToString());
                    goto Inicio;
                }
                else if (operacao.Contains('+'))
                {
                    posicao = operacao.IndexOf("+");
                    a = double.Parse(operacao.Substring(posicao - 1, 1));
                    b = double.Parse(operacao.Substring(posicao + 1, 1));
                    resultado = Operacoes.soma(a, b);
                    operacao = operacao.Replace(operacao.Substring(posicao - 1, 3), resultado.ToString());
                    goto Inicio;
                }
                Console.WriteLine(resultado);
            }
        }
    }
}
