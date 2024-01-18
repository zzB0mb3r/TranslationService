using System.ComponentModel.DataAnnotations;

namespace TranslationService.Domain.Models;

public class TranslationModel
{
    [Required]
    public required string OriginalLanguage { get; set; }

    [Required]
    public required string OriginalText { get; set; }

    [Required]
    public required string TargetLanguage { get; set; }

    public string? TargetText { get; set; }
}
