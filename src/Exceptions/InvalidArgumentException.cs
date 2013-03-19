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

namespace Correios.Net.Exceptions
{
    /// <summary>
    /// Exception Personalizada utilizada na validação dos dados
    /// de entrada(parâmetros) utilizados na Correios.Net.
    /// </summary>
    class InvalidArgumentException : Exception
    {
        public InvalidArgumentException(string message)
            : base(message)
        {
        }
    }
}
