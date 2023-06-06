using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        public string URL { get;}
        private readonly string _argumentos;
        public ExtratorValorDeArgumentosURL(string url)
        {
            if(String.IsNullOrEmpty(url)){
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio", nameof(url));
            }

            URL = url;

            int indiceInterrogacao = URL.IndexOf('?');
            _argumentos = URL.Substring(indiceInterrogacao + 1);
        }

        public string GetValor(string nomeParametro){
            return "";
        }
    }
}