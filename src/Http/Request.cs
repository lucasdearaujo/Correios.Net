using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Correios.Net.Http
{
    class Request
    {
        public string Url { get; set; }
        public string DataToSend { get; set; }
        public string Method { get; set; }

        /// <summary>
        /// Construtor, responsável por construir a requisição
        /// que será enviada para o site dos correios.
        /// </summary>
        /// 
        /// <param name="url">Url que será acessada</param>
        /// <param name="dataToSend">Dados que serão enviados</param>
        /// <param name="method">Método da requisição</param>
        public Request(string url, string dataToSend, string method)
        {
            this.Url = url;
            this.DataToSend = dataToSend;
            this.Method = method;
        }

        /// <summary>
        /// Envia a requisição construida através dos parâmetros
        /// passados para o construtor para o servidor e retorna
        /// a resposta recebida.
        /// </summary>
        /// 
        /// <returns>Response</returns>
        public Response Send()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.Url);
            request.Method = this.Method;
            byte[] postBytes = Encoding.ASCII.GetBytes(this.DataToSend);

            request.GetRequestStream()
                .Write(postBytes, 0, postBytes.Length);

            string responseText = new StreamReader(request.GetResponse().GetResponseStream()).ReadToEnd();

            return new Response(responseText);
        }
    }
}
