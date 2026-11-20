namespace Base;

public interface ICollector
{
    void Collect(IDomainEvent domainEvent);
}