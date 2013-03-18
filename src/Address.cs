using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Correios.Net.Exceptions;

namespace Correios.Net
{
    /// <summary>
    /// Modelo de endereço, todos os dados setados nessa classe
    /// serão submetido as validações como pode ver.
    /// </summary>
    /// 
    /// <see cref="http://volkoinen.github.com/Correios.Net"/>
    /// <see cref="https://github.com/volkoinen/Correios.Net"/>
    class Address
    {
        private string _Cep;
        private string _Street;
        private string _City;
        private string _State;

        /// <summary>
        /// A validação para o CEP permite apenas strings de
        /// oito nove digitos com ou sem máscara, apenas seguindo
        /// os seguintes padroes: 99999999 ou 99999-999.
        /// </summary>
        /// 
        /// <see cref="http://volkoinen.github.com/Correios.Net"/>
        /// <see cref="https://github.com/volkoinen/Correios.Net"/>
        public String Cep
        {
            get
            {
                return this._Cep;
            }
            set
            {
                int count = 0;

                if (value.Length != 8 && value.Length != 9)
                    throw new InvalidArgumentException("O CEP informado é inválido.");

                foreach (char c in value)
                    if (Char.IsDigit(c))
                        count++;

                if(count != 8)
                    throw new InvalidArgumentException("O CEP informado é inválido.");

                this._Cep = value;
            }
        }

        /// <summary>
        /// A validação do endereço verifica apenas se o mesmo
        /// tem um número de caracteres maior do que 500.
        /// </summary>
        /// 
        /// <see cref="http://volkoinen.github.com/Correios.Net"/>
        /// <see cref="https://github.com/volkoinen/Correios.Net"/>
        public String Street
        {
            get
            {
                return this._Street;
            }
            set
            {
                if (value.Length > 500)
                    throw new InvalidArgumentException("O tamanho da rua não pode exceder 500 caracteres.");

                this._Street = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// 
        /// <see cref="http://volkoinen.github.com/Correios.Net"/>
        /// <see cref="https://github.com/volkoinen/Correios.Net"/>
        public String City
        {
            get
            {
                return this._City;
            }
            set
            {
                if (value.Length > 500)
                    throw new InvalidArgumentException("O tamanho da cidade não pode exceder 500 caracteres.");

                this._City = value;
            }
        }


    }
}
