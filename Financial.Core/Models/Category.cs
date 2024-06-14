namespace Financial.Core.Models;

public class Category
{
    public uint Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string UserId { get; set; } = String.Empty;
}