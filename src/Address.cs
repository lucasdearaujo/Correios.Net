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

using System;
using System.Linq;
using Correios.Net.Exceptions;

namespace Correios.Net
{
    /// <summary>
    ///     Modelo de endereço, todos os dados setados nessa classe
    ///     serão submetido as validações como pode ver.
    /// </summary>
    /// <see cref="http://volkoinen.github.com/Correios.Net" />
    /// <see cref="https://github.com/volkoinen/Correios.Net" />
    public class Address
    {
        private string _city;
        private string _district;
        private string _state;
        private string _street;
        private string _zip;

        /// <summary>
        ///     A validação para o CEP permite apenas strings de
        ///     oito nove digitos com ou sem máscara, apenas seguindo
        ///     os seguintes padroes: 99999999 ou 99999-999.
        /// </summary>
        /// <see cref="http://volkoinen.github.com/Correios.Net" />
        /// <see cref="https://github.com/volkoinen/Correios.Net" />
        public String Zip
        {
            get { return _zip; }
            set
            {
                if (value.Length != 8 && value.Length != 9)
                {
                    throw new InvalidArgumentException("O CEP informado é inválido.");
                }

                int count = value.Count(Char.IsDigit);

                if (count != 8)
                {
                    throw new InvalidArgumentException("O CEP informado é inválido.");
                }

                _zip = value;
            }
        }

        /// <summary>
        ///     A validação do endereço verifica apenas se o mesmo
        ///     tem um número de caracteres maior do que 500.
        /// </summary>
        /// <see cref="http://volkoinen.github.com/Correios.Net" />
        /// <see cref="https://github.com/volkoinen/Correios.Net" />
        public String Street
        {
            get { return _street; }
            set
            {
                if (value.Length > 500)
                {
                    throw new InvalidArgumentException("O tamanho da rua não pode exceder 500 caracteres.");
                }

                _street = value;
            }
        }

        /// <summary>
        ///     A validação do distrito verifica apenas se o valor informado
        ///     tem um tamanho de no máximo 500 caracteres.
        /// </summary>
        /// <see cref="http://volkoinen.github.com/Correios.Net" />
        /// <see cref="https://github.com/volkoinen/Correios.Net" />
        public String District
        {
            get { return _district; }
            set
            {
                if (value.Length > 500)
                {
                    throw new InvalidArgumentException("O tamanho do bairro não pode exceder 500 caracteres.");
                }

                _district = value;
            }
        }

        /// <summary>
        ///     A validação da ciade verifica apenas se o valor informado
        ///     tem um tamanho de no máximo 500 caracteres.
        /// </summary>
        /// <see cref="http://volkoinen.github.com/Correios.Net" />
        /// <see cref="https://github.com/volkoinen/Correios.Net" />
        public String City
        {
            get { return _city; }
            set
            {
                if (value.Length > 500)
                {
                    throw new InvalidArgumentException("O tamanho da cidade não pode exceder 500 caracteres.");
                }

                _city = value;
            }
        }

        /// <summary>
        ///     Verifica se o UF informado é
        /// </summary>
        /// <see cref="http://volkoinen.github.com/Correios.Net" />
        /// <see cref="https://github.com/volkoinen/Correios.Net" />
        public String State
        {
            get { return _state; }
            set
            {
                bool validState = false;

                string[] states =
                {
                    "AC",
                    "AL",
                    "AM",
                    "AP",
                    "BA",
                    "CE",
                    "DF",
                    "ES",
                    "GO",
                    "MA",
                    "MG",
                    "MS",
                    "MT",
                    "PA",
                    "PB",
                    "PE",
                    "PI",
                    "PR",
                    "RJ",
                    "RN",
                    "RO",
                    "RR",
                    "RS",
                    "SC",
                    "SE",
                    "SP",
                    "TO"
                };

                foreach (string state in states)
                {
                    if (value.ToUpper() == state)
                    {
                        validState = true;
                        _state = value.ToUpper();
                    }
                }

                if (!validState)
                {
                    throw new InvalidArgumentException(string.Format("A sigla {0} da unidade federativa informada é inválida.", _state));
                }
            }
        }

        /// <summary>
        ///     True quando for um cep único para toda a cidade.
        /// </summary>
        public Boolean UniqueZip { get; set; }
    }
}