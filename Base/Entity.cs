namespace Base;

public class Entity
{
    public Guid Id { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
}