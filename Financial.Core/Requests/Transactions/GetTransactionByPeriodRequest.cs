using System.ComponentModel.DataAnnotations;

namespace Financial.Core.Requests.Transactions;

public class GetTransactionByPeriodRequest: PagedRequest
{
    public DateTime? StartDate { get; set; }

    public DateTime? EndPeriod { get; set; }
}