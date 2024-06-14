using Financial.Core.Enums;

namespace Financial.Core.Models;

public class Transaction
{
    public uint Id { get; set; }
    public string Title { get; set; } = String.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? PaidOrRedivedAt { get; set; }

    public ETransactionType Type { get; set; }
    public decimal Amount { get; set; }
    
    public long CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public string UserId { get; set; } = string.Empty;
}