using System.ComponentModel.DataAnnotations;

public class SearchModel
{
    [Required]
    [StringLength(20, MinimumLength = 3, ErrorMessage = "Search term should be between {2} and {1} characters long.")]
    public string Name { get; set; }
}

public class AddModel
{
    [Required]
    [StringLength(255, MinimumLength = 3, ErrorMessage = "Name should be between {2} and {1} characters long.")]
    public string Name { get; set; }
}
