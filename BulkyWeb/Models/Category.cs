namespace BulkyWeb.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    [Display( Name = "Category name")]
    public string Name { get; set; } = string.Empty;
    [Display(Name = "Display Order")]
    [Range(1,100, ErrorMessage ="Display Order must be in between 1-100 ")]
    public int DisplayOrder { get; set; }
}
