using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1270.50;
            int valor = (int)salario;

            Console.WriteLine(valor);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;

            Console.WriteLine(total);

            //É uma variavel do tipo int, porem com tamanho de 16bits
            short valor3 = 12;

            //Variavel int com tamanho de 32bits
            int valor4 = 12;

            //É uma variavel do tipo int, porem com tamanho de 64bits
            long valor5 = 12;

            float valor6 = 12.4f;
        }
    }
}