using System;

namespace Correios.Net.Interfaces.Models
{
    /// <summary>
    /// Interface de endereço à ser implementada. 
    /// </summary>
    public interface IEndereco
    {
        String Cep { get; set; }
        String Rua { get; set; }
        String Bairro { get; set; }
        String Cidade { get; set; }
        String Estado { get; set; }
    }
}
