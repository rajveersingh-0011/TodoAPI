namespace Todo.Infrastructure.Persistence.Entities;

public abstract class BaseAuditableEntity : BaseEnity
{
    public string? CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}