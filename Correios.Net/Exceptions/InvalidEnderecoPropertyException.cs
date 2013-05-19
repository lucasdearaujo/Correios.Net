namespace Correios.Net.Exceptions
{
    /// <summary>
    /// Exception que será lançada quando alguma propriedade
    /// da classe Endereco for detectada como inválida.
    /// </summary>
    /// <see cref="Endereco"/>
    [System.Serializable]
    public class InvalidEnderecoPropertyException : System.Exception
    {
        public InvalidEnderecoPropertyException(string message)
            : base(message) { }
    }
}
