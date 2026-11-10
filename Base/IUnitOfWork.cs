namespace Base;

public partial interface IUnitOfWork
{
    Task<T?> Get<T>(Guid id, QueryFlags flags = QueryFlags.None, CancellationToken ct = default) where T : Entity;
    void Add<T>(T entity) where T : Entity;
    void Remove<T>(T entity) where T : Entity;
    void Raise(IDomainEvent domainEvent);
    Task BeginTransaction(CancellationToken ct = default);
    Task CommitTransaction(CancellationToken ct = default);
    Task RollbackTransaction(CancellationToken ct = default);
    Task<int> SaveChanges(CancellationToken ct = default);
}