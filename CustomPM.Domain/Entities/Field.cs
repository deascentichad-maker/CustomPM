public class Field
{
    public Guid Id { get; set; }
    public Guid DatabaseId { get; set; }
    public string Name { get; set; } = default!;
    public FieldType Type { get; set; }
    public string? SettingsJson { get; set; }
    public int Order { get; set; }
    public DateTime? DeletedAt { get; set; }
}