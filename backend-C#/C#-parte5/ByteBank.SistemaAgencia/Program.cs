using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia{
    class Program{
        static void Main(string[] args){
            string url = "pagina?argumentos";
            int indiceInterrogacao = url.IndexOf('?');

            string argumentos = url.Substring(indiceInterrogacao+1);

            Console.WriteLine(argumentos);

        }
    }
}