﻿using System;

namespace Lab2Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringInteiro = "123456789"; int valorStringInteiro;
            bool conversao1 = Int32.TryParse(stringInteiro, out valorStringInteiro); 
            Console.WriteLine("Conversão efetuada:" + conversao1 + " Valor: " + valorStringInteiro);

            string stringInteiroGrande = "999999999999999999999999999999999999999999999"; 
            int valorStringInteiroGrande;
            bool conversao2 = Int32.TryParse(stringInteiroGrande, out valorStringInteiroGrande); 
            Console.WriteLine("Conversão efetuada:" + conversao2 + " Valor: " + valorStringInteiroGrande); 
            string stringLetras = "abc";
            double valorStringLetras;
            bool conversao3 = Double.TryParse(stringLetras, out valorStringLetras); Console.WriteLine("Conversão efetuada:" + conversao3 + " Valor: " + valorStringLetras);

        }
    }
}
