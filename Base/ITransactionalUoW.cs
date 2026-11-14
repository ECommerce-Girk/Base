namespace Base;

public partial interface ITransactionalUoW : IUoW
{
    Task BeginTransaction(CancellationToken ct = default);
    Task CommitTransaction(CancellationToken ct = default);
    Task RollbackTransaction(CancellationToken ct = default);
}