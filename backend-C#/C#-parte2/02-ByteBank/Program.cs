using System;

namespace _02_ByteBank{
    class Program{
        static void Main(string[] args){
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);
            contaDoBruno.sacar(50);
            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.depositar(500);    
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            contaDoBruno.transferir(200, contaDaGabriela);
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);
        }
    }
}