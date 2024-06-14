using System.ComponentModel.DataAnnotations;

namespace Financial.Core.Requests.Categories;

public class UpdateCategoryRequest: Request
{
    [Required(ErrorMessage = "Invalid Id")]
    public uint Id { get; set; }
    
    [Required(ErrorMessage = "Invalid title")]
    [MaxLength(80, ErrorMessage = "The title must contain less than x characters")]
    public string Title { get; set; } = String.Empty;
    
    [Required(ErrorMessage = "Invalid description")]
    public string Description { get; set; } = String.Empty;
}