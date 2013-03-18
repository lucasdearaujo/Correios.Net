using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Correios.Net.Exceptions
{
    class InvalidArgumentException : Exception
    {
        public InvalidArgumentException(string message)
            : base(message)
        {
        }
    }
}
