using System.Text.Json.Serialization;

namespace Financial.Core.Responses;

public class Response<TData>
{
    private int _statusCode = Configuration.DefaultStatusCode;

    public string? Message { get; set; }

    public TData? Data { get; set; }

    [JsonIgnore]
    public bool IsSuccess => _statusCode is >= 200 and <= 299;
    
    public Response(TData? data,
                    int code = Configuration.DefaultStatusCode,
                    string? message = null)
    {
        Data = data;
        _statusCode = code;
        Message = message;
    }
    
    [JsonConstructor]
    public Response() => _statusCode = Configuration.DefaultStatusCode;
}