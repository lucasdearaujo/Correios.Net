using System;

namespace Correios.Net.Interfaces.Http
{
    public interface IRequestProfile
    {
        String Url { get; set; }
        String DataToPost { get; set; }
        String Method { get; set; }
        String ContentType { get; set; }
    }
}
