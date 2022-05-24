namespace Identity.Domain.Base.Exceptions
{
    public class InvalidDomainDataException : BaseDomainException
    {
        public InvalidDomainDataException()
        {

        }
        public InvalidDomainDataException(string message) : base(message)
        {

        }
    }
}
