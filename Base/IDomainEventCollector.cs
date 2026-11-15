namespace Base;

public interface IDomainEventCollector
{
    void Collect(IDomainEvent domainEvent);
}