namespace Base;

public partial interface IUoW
{
    Task<T?> Get<T>(Guid id, QueryFlags flags = QueryFlags.None, CancellationToken ct = default) where T : Entity;
    Task<T[]> GetMany<T>(Guid[] ids, QueryFlags flags, CancellationToken ct) where T : Entity;
    void Add<T>(T entity) where T : Entity;
    void Remove<T>(T entity) where T : Entity;
    Task<int> SaveChanges(CancellationToken ct = default);
}