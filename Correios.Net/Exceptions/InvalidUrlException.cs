namespace Correios.Net.Exceptions
{
    /// <summary>
    /// Exception que será lançada quando uma url informada
    /// for inválida.
    /// </summary>
    [System.Serializable]
    public class InvalidUrlException : System.Exception
    {
        public InvalidUrlException(string message)
            : base(message) { }
    }
}
