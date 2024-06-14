namespace Financial.Core.Requests.Transactions;

public class GetTransactionByIdRequest: Request
{
    public uint Id { get; set; }
}