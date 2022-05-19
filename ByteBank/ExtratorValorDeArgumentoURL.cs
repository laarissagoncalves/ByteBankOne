using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ExtratorValorDeArgumentoURL
    {
        private readonly string _argumentos;
        public string URL { get; }

        public ExtratorValorDeArgumentoURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException(url);
            }

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);

            URL = url;
        }

        //moedaOrigem=real&moedaDestino=dolar
        //MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR
        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper(); //VALOR
            string argumentoEmCaixaAlto = _argumentos.ToUpper(); //MOEDAORIGEM=REAL$MOEDADESTINO=DOLAR

            string termo = nomeParametro + "="; //moedaDestino=
            int indiceTermo = argumentoEmCaixaAlto.IndexOf(termo); //x

            string resultado = _argumentos.Substring(indiceTermo + termo.Length); //dolar
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);
        }
    }
}
