using System.ComponentModel.DataAnnotations;

namespace Financial.Core.Requests.Categories;

public class GetCategoryByIdRequest: Request
{
    [Required (ErrorMessage = "Invalid Id")]
    public uint Id { get; set; }
}