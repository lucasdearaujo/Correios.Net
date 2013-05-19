using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Correios.Net.Models
{
    /// <summary>
    /// Modelo de endereço
    /// </summary>
    [Serializable]
    public class Endereco : Interfaces.Models.IEndereco
    {
        private string cep;
        private string rua;
        private string bairro;
        private string cidade;
        private string estado;

        /// <summary>
        /// CEP do Endereço
        /// </summary>
        /// <exception cref="InvalidEnderecoPropertyException"/> 
        public String Cep
        {
            get
            {
                return cep;
            }
            set
            {
                if (!Regex.IsMatch(value, @"^([0-9]{5})\-([0-9]{3})$"))
                    throw new Exceptions.InvalidEnderecoPropertyException("O CEP informado é inválido.");

                cep = value;
            }
        }

        /// <summary>
        /// Nome completo da rua
        /// </summary>
        /// <exception cref="InvalidEnderecoPropertyException"/>
        public String Rua
        {
            get
            {
                return rua;
            }
            set
            {
                if (value.Length > 100)
                    throw new Exceptions.InvalidEnderecoPropertyException("O nome da rua informado é muito grande");

                rua = value;
            }
        }

        /// <summary>
        /// Nome do bairro
        /// </summary>
        /// <exception cref="InvalidEnderecoPropertyException"/>
        public String Bairro
        {
            get
            {
                return bairro;
            }
            set
            {
                if (value.Length > 100)
                    throw new Exceptions.InvalidEnderecoPropertyException("O nome do bairro informado é muito grande");

                bairro = value;
            }
        }

        /// <summary>
        /// Nome do bairro
        /// </summary>
        /// <exception cref="InvalidEnderecoPropertyException"/>
        public String Cidade
        {
            get
            {
                return cidade;
            }
            set
            {
                if (value.Length > 100)
                    throw new Exceptions.InvalidEnderecoPropertyException("O nome da cidade informado é muito grande");

                cidade = value;
            }
        }

        /// <summary>
        /// UF do Estado. Se inserido minúnsculo será retornado
        /// como maiúsculo para manter o padrão.
        /// </summary>
        /// <exception cref="InvalidEnderecoPropertyException"/>
        public String Estado
        {
            get
            {
                return estado;
            }
            set
            {
                String[] estados = 
                {
                    "AC", // Acre
                    "AL", // Alagoas
                    "AM", // Amazonas
                    "AP", // Amapá
                    "BA", // Bahia
                    "CE", // Ceará
                    "DF", // Distrito Federal
                    "ES", // Espirito Santo
                    "GO", // Goiás
                    "MA", // Maranhão
                    "MG", // Minas Gerais
                    "MS", // Mato Grosso do Sul
                    "MT", // Mato Grosso
                    "PA", // Para
                    "PB", // Paraiba
                    "PE", // Pernambuco
                    "PI", // Piaui
                    "PR", // Paraná
                    "RJ", // Rio de Janeiro
                    "RN", // Rio Grande do Norte
                    "RO", // Rondonia
                    "RR", // Roraima
                    "RS", // Rio Grande do Sul
                    "SC", // Santa Catarina
                    "SE", // Sergipe
                    "SP", // São Paulo
                    "TO"  // Tocantins
                };

                if (!estados.Contains(value.ToUpper()))
                    throw new Exceptions.InvalidEnderecoPropertyException("O UF informado é inválido.");

                estado = value.ToUpper();
            }
        }
    }
}
