using System;

namespace _05_ByteBank{
    class Program{
        static void Main(string[] args){
        
        Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
        ContaCorrente conta = new ContaCorrente(867, 86487454);

        Console.WriteLine(conta.Agencia);
        Console.WriteLine(conta.Numero);

        ContaCorrente contaDaGabriela = new ContaCorrente(844, 8569);
        Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

        }
    }
}