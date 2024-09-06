using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using ServiceStack.DataAnnotations;

namespace FounderMode.ServiceInterface.Data;

[EnumAsInt]
public enum PreferredIde
{
    NeoVim = 0,
    CursorAi = 1,
    JetBrains = 3,
    VsCode = 4,
    Notepad = 5,
    VisualStudio = 6,
}

public class ApplicationUser : IdentityUser
{
    [MaxLength(512)] public string? FirstName { get; set; }
    [MaxLength(512)] public string? LastName { get; set; }
    [MaxLength(512)] public string? DisplayName { get; set; }
    [MaxLength(512)] public string? ProfileUrl { get; set; }
    [MaxLength(512)] public string? FacebookUserId { get; set; }

    public PreferredIde PreferredIde { get; set; }


    public decimal CocaineTolerance { get; set; }
    [MaxLength(512)] public string? GoogleUserId { get; set; }
    [MaxLength(512)] public string? GoogleProfilePageUrl { get; set; }
    [MaxLength(512)] public string? MicrosoftUserId { get; set; }
}