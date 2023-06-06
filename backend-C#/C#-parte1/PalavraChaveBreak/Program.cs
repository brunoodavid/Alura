using System;

namespace PalavraChaveBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
            {
                for (int contadorColunas = 0; contadorColunas < 10; contadorColunas++)
                {
                    Console.Write("*");
                    if (contadorColunas >= contadorLinhas)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
    	    */

            /*
            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                for (int contador = 0; contador <= 10; contador++)
                {
                    Console.Write(multiplicador + " * " + contador + " = " + multiplicador * contador);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            */

            /*
            for(int cont = 1; cont < 100; cont++){
                if(cont % 3 == 0){
                    Console.WriteLine("O número " + cont + " é divisivel por 3");
                }
            }
            */

            int fatorial = 1;
            for (int i = 1; i < 4; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }
        }
    }
}