using System.ComponentModel.DataAnnotations;

namespace FounderMode.Models.AccountViewModels;

public class ExternalLoginViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}