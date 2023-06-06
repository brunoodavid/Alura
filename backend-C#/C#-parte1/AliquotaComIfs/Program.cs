using System;

namespace AliquotaComIfs
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("O IR é de 7.5% e pode deduzir na declaração o valor de R$ 142");
            }
            else if (salario <= 3751.0)
            {
                Console.WriteLine("O IR é de 15% e pode deduzir R$ 350");
            }
            else if (salario <= 4664.00)
            {
                Console.WriteLine("O IR é de 22.5% e pode deduzir R$ 636.");
            }
        }
    }
}
