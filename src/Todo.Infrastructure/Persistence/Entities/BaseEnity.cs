namespace Todo.Infrastructure.Persistence.Entities;

public abstract class BaseEnity
{
    public Guid Id { get; set; } = Guid.NewGuid();
}
