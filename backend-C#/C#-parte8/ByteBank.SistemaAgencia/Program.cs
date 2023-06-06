using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Comparadores;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);
            idades.AdicionarVarios(1, 23, 4, 435, 65756, 45);

            idades.Sort();
            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            var nomes = new List<String>();

            nomes.AdicionarVarios("Vinicius", "Gisele", "Mayra", "Gremio");

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            var contas = new List<ContaCorrente>(){
                new ContaCorrente(456, 2222222),
                new ContaCorrente(234, 3333333),
                new ContaCorrente(235, 5555555),
                new ContaCorrente(789, 2222222),
                new ContaCorrente(123, 1111111),
                new ContaCorrente(543, 4444444),
            };

            //contas.Sort();
            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            var contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);

            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Conta número: {conta.Numero}, ag. {conta.Agencia}");
            }
        }
    }
}