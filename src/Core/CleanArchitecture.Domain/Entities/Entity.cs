namespace CleanArchitecture.Domain.Entities;

public abstract class Entity
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdateOn { get; set; }

    public Entity()
    {
        Id = Guid.NewGuid();
    }
}