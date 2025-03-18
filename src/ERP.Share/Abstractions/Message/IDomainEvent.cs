using MediatR;

namespace ERP.Share.Abstractions.Message;

public interface IDomainEvent : INotification
{
    public Ulid Id { get; init; }
}
