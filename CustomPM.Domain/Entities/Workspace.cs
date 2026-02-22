public class Workspace
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public Guid OwnerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}