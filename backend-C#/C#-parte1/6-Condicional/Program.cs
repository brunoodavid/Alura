using System;

namespace _6_Condicional{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Testando Condicionais!");

            int idade = 16;
            int quantidadePessoas = 1;
            bool acompanhado = quantidadePessoas >= 2;

            if(idade >= 18 || acompanhado == true){
                Console.WriteLine("Pode entrar!");
            } else {
                Console.WriteLine("Não pode entrar!");
            }
        }
    }
}