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
    }
}
