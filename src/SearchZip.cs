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

using Correios.Net.Http;

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
    public class SearchZip
    {

        /// <summary>
        /// Realiza a busca do endereço a partir do cep no site dos correios
        /// </summary>
        /// <param name="zip">Cep utilizado para busca</param>
        /// <returns>Address</returns>
        public static Address GetAddress(string zip)
        {
            const string url = "http://m.correios.com.br/movel/buscaCepConfirma.do";
            string dataToPost = "cepEntrada=" + zip + "&tipoCep=&cepTemp=&metodo=buscarCep";
            const string method = "POST";
            const string contentType = "application/x-www-form-urlencoded";

            var request =
                new Request(url, dataToPost, method, contentType);

            Response response = request.Send();
            return response.ToAddress();
        }

    }
}
