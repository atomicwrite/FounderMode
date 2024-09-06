using System.ComponentModel.DataAnnotations;

namespace FounderMode.Models.AccountViewModels;

public class ForgotPasswordViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}