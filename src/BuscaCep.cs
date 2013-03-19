using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Correios.Net
{
    /// <summary>
    /// Classe responsável por permitir a busca de um endereço
    /// através de um número CEP utilizando os serviços disponibilizados
    /// no site dos correios para consulta.
    /// </summary>
    /// 
    /// <see cref="http://volkoinen.github.com/Correios.Net"/>
    /// <see cref="https://github.com/volkoinen/Correios.Net"/>
    class BuscaCep
    {

        /// <summary>
        /// Realiza a busca do endereço a partir do cep no site dos correios
        /// </summary>
        /// <param name="cep">Cep utilizado para busca</param>
        /// <returns>Address</returns>
        public static Address GetAddress(string cep)
        {
            string url = "http://m.correios.com.br/movel/buscaCepConfirma.do";
            string dataToPost = "cepEntrada=" + cep + "&tipoCep=&cepTemp=&metodo=buscarCep";
            string method = "POST";

            Correios.Net.Http.Request request =
                new Correios.Net.Http.Request(url, dataToPost, method);

            Correios.Net.Http.Response response = request.Send();
            return response.ToAddress();
        }

    }
}
