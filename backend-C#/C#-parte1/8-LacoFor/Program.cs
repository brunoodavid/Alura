using System;

namespace _8_LacoFor{
    class Program{
        static void Main(string[] args){
            double valorInvestido = 1000;

            for(int contadorMes = 1; contadorMes <= 12; contadorMes++){
                valorInvestido = valorInvestido + (valorInvestido * 0.0036);
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$ " + valorInvestido);
            }
        }
    }
}