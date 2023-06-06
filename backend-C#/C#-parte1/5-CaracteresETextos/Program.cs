using System;

namespace _5_CaracteresETextos{
    class Program{
        static void Main(string[] args){
            char letra = 'a'; 
            Console.WriteLine(letra);

            char valor = (char)65;
            Console.WriteLine(valor);

            string texto = "Alura cursos online de tecnologia";
            Console.WriteLine(texto);

            texto = texto + 2020;
            Console.WriteLine(texto);
        }
    }
}