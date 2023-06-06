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

        public string GetValor(string nomeParametro)
        {
            string argumentosEmCaixaAlta = _argumentos.ToUpper();
            nomeParametro = nomeParametro.ToUpper();

            string nomeParametroComIgual = nomeParametro + "=";
            int tamanhoParametro = nomeParametroComIgual.Length;
            int indiceParametro = argumentosEmCaixaAlta.IndexOf(nomeParametroComIgual);
            
            string resultado = _argumentos.Substring(indiceParametro + tamanhoParametro);
            int indiceEComercial = resultado.IndexOf('&');

            if(indiceEComercial == -1){
                return resultado;
            }

            return resultado.Remove(indiceEComercial);

        }
    }
}