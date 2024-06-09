using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearArchitecture.Domain.Primitives
{
    public abstract class AggregateRoot
    {
        private readonly List<DomainEvent> _domainEvents = new List<DomainEvent>();

        public ICollection<DomainEvent> GetDomainEvents() => _domainEvents;

        protected void Raise(DomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }
    }
}
