using MediatR;

namespace Identity.Domain.Base
{
    public class BaseDomainEvent : INotification
    {
        public DateTime CreationDate { get; protected set; }

        public BaseDomainEvent()
        {
            CreationDate = DateTime.Now;
        }
    }
}