using System;

namespace Lab2Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorFracionado = 4.7;
            int valorInteiro1 = (int)valorFracionado;
            int valorInteiro2 = Convert.ToInt32(valorFracionado);
            Console.WriteLine("Conversao explicita = " + valorInteiro1); Console.WriteLine("Conversao metodo Convert = " + valorInteiro2);

        }
    }
}
