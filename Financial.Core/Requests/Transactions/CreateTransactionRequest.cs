using System.ComponentModel.DataAnnotations;
using Financial.Core.Enums;

namespace Financial.Core.Requests.Transactions;

public class CreateTransactionRequest: Request
{
    [Required(ErrorMessage = "Invalid type")]
    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;
    
    [Required(ErrorMessage = "Invalid amount")]
    public decimal Amount { get; set; }  
    
    [Required(ErrorMessage = "Invalid category")]
    public uint CategoryId { get; set; }
    
    [Required(ErrorMessage = "Invalid date")]
    public DateTime? PaidOrRecievedAt { get; set; }
}