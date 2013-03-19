using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Correios.Net.Http
{
    class Response
    {
        public String Text { get; set; }

        public Response(string responseText)
        {
            this.Text = responseText;
        }

        public Address ToAddress()
        {
            return new Address();
        }
    }
}
