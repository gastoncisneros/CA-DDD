using MediatR;

namespace ClearArchitecture.Domain.Primitives
{
    public record DomainEvent(Guid id) : INotification;
}
