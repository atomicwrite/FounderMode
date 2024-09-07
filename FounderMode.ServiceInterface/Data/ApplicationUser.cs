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
[EnumAsInt]
public enum GermanyTaxProficiency
{
    IsVatTheNameOfAClub=0, // "VAT? Is That a New Diet?"
    BrexitLevel=1, //VAT has something to do with "pounds" and "tea."
    HopingItLikeItaly=2, //Thinks they can casually wave away tax paperwork with a shrug and a glass of wine
    FrenchBureaucracySurvivor=3, //Knows their way around forms, but keeps looking for the Service Public to help with their German taxes.
    AustrianBureaucrat=4, //Might as well be in Vienna; they can navigate the intricate maze of taxes and bureaucracy easily 
    ActuallyLivesInGermany=5, // Actual German
    GermanTaxAuditor=6 //"German Tax Sensei"
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