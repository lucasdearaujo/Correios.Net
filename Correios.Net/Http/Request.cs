using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Text;
using System.Reflection;
using Correios.Net.Models;

namespace Correios.Net.Http
{
    /// <summary>
    /// Classe responsável por enviar uma requisição para o site
    /// dos correios 
    /// </summary>
    /// <example>
    public class Request <T> : Interfaces.Http.IRequest
        where T: Interfaces.Http.IRequestProfile
    {
        private String Url { get; set; }
        private String DataToPost { get; set; }
        private String Method { get; set; }
        private String ContentType { get; set; }
        private String RawResponse { get; set; }

        /// <summary>
        /// Construtor da requisição
        /// </summary>
        public Request(Endereco endereco)
        {
            Assembly assemblyOfT = Assembly.GetAssembly(typeof(T));
            var requestProf = (Interfaces.Http.IRequestProfile)assemblyOfT.CreateInstance(typeof(T).FullName);

            // Define o CEP na requisição que será enviada se
            // estiver buscando um endereço por CEP
            if(typeof(T) == typeof(RequestProfiles.BuscaEndereco))
                this.DataToPost = String.Format(requestProf.DataToPost, endereco.Cep);

            this.Url = requestProf.Url;
            this.Method = requestProf.Method;
            this.ContentType = requestProf.ContentType;
        }

        /// <summary>
        /// Envia a requisição
        /// </summary>
        /// <returns></returns>
        public Request<T> Send()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.Url);
            request.Method = this.Method;
            request.ContentType = this.ContentType;
            byte[] postBytes = Encoding.ASCII.GetBytes(this.DataToPost);

            request.GetRequestStream().Write(postBytes, 0, postBytes.Length);

            this.RawResponse = new StreamReader(request.GetResponse().GetResponseStream(), Encoding.GetEncoding("ISO-8859-1")).ReadToEnd();

            return this;
        }
    }
}
