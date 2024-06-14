using System.ComponentModel.DataAnnotations;

namespace Financial.Core.Requests.Categories;

public class CreateCategoryRequest: Request
{
    [Required(ErrorMessage = "Invalid title")]
    [MaxLength(80, ErrorMessage = "The title must contain less than x characters")]
    public string Title { get; set; } = String.Empty;
    
    [Required(ErrorMessage = "Invalid description")]
    public string Description { get; set; } = String.Empty;
}