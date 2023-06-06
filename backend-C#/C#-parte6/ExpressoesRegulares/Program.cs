using System.Text.RegularExpressions;

namespace ExpressoesRegulares{
    class Program{
        static void Main(string[] args){
            //string padrao = "[123456789][123456789][123456789][123456789][-][123456789][123456789][123456789][123456789]";
            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string texto = "Meu número é: 23423453";

            Match match = Regex.Match(texto, padrao);
            Console.WriteLine(match.Value);
        }
    }
}
