using System.ComponentModel.DataAnnotations;

namespace Template.Web.BindingModels;

public class LoginBindingModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    public bool RememberMe { get; set; } = true;
}
