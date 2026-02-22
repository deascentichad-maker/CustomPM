public class Record
{
    public Guid Id { get; set; }
    public Guid DatabaseId { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }

    public ICollection<RecordValue> Values { get; set; } = new List<RecordValue>();
}