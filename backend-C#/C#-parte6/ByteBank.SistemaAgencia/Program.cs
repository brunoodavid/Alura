using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia{
    class Program{
        static void Main(string[] args){
            //string url = "pagina?argumentos";
            // int indiceInterrogacao = url.IndexOf('?');

            // string argumentos = url.Substring(indiceInterrogacao+1);

            // Console.WriteLine(argumentos);
            // Console.ReadLine();

            string url = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            
            ExtratorValorDeArgumentosURL extrador = new ExtratorValorDeArgumentosURL(url);

            string valor = extrador.GetValor("moedaOrigem");
            Console.WriteLine("Valor da moedaOrigem: " + valor);

            string valorMoedaDestino = extrador.GetValor("MOEDADestino");
            Console.WriteLine("Valor da moedaDestino : " + valorMoedaDestino);

            string valorEmReal = extrador.GetValor("Valor");
            Console.WriteLine("Valor: " + valorEmReal);





        }
    }
}