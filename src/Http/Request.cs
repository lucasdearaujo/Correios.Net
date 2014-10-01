// Correios.Net - Biblioteca de comunicação com o site dos correios.
// Copyright (C) 2013  Lucas Andrade de Araújo <lucasdearaujo@icloud.com>

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// any later version.

// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

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
        public string ContentType { get; set; }

        /// <summary>
        /// Construtor, responsável por construir a requisição
        /// que será enviada para o site dos correios.
        /// </summary>
        /// 
        /// <param name="url">Url que será acessada</param>
        /// <param name="dataToSend">Dados que serão enviados</param>
        /// <param name="method">Método da requisição</param>
        /// <param name="contentType">Tipo do dado enviado para o servidor</param>
        public Request(string url, string dataToSend, string method, string contentType)
        {
            this.Url = url;
            this.DataToSend = dataToSend;
            this.Method = method;
            this.ContentType = contentType; 
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
            var request = (HttpWebRequest)WebRequest.Create(this.Url);
            request.Method = this.Method;
            request.ContentType = this.ContentType;
            byte[] postBytes = Encoding.ASCII.GetBytes(this.DataToSend);

            request.GetRequestStream()
                .Write(postBytes, 0, postBytes.Length);

            string responseText = new StreamReader(request.GetResponse().GetResponseStream(), Encoding.GetEncoding("ISO-8859-1")).ReadToEnd();

            return new Response(responseText);
        }
    }
}
