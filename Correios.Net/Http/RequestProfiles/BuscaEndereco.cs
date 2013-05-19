using System;

namespace Correios.Net.Http.RequestProfiles
{
    public class BuscaEndereco : Interfaces.Http.IRequestProfile
    {
        public String Url { get; set; }
        public String DataToPost { get; set; }
        public String Method { get; set; }
        public String ContentType { get; set; }

        public BuscaEndereco()
        {
            Url = "http://m.correios.com.br/movel/buscaCepConfirma.do";
            DataToPost = "cepEntrada={0}&tipoCep=&cepTemp=&metodo=buscarCep";
            Method = "POST";
            ContentType = "application/x-www-form-urlencoded";
        }
    }
}
