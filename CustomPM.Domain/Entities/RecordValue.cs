public class RecordValue
{
    public Guid RecordId { get; set; }
    public Guid FieldId { get; set; }

    public string? ValueText { get; set; }
    public decimal? ValueNumber { get; set; }
    public DateTime? ValueDate { get; set; }
    public bool? ValueBoolean { get; set; }
    public string? ValueJson { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}