using System;

namespace Lab2Exercicio4
{
    class Program
    {
        static void Main()
        {
            int i = 10; float f = 0;
            f = i; //conversão implícita, sem perda de dados. System.Console.WriteLine(f);
            f = 0.5F;
            i = (int)f; //conversão explícita, com perda de dados. System.Console.WriteLine(i);

        }
    }
}
