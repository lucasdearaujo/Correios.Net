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
