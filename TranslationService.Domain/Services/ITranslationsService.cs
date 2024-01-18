using TranslationService.Domain.Models;

namespace TranslationService.Domain.Services;

public interface ITranslationsService
{
    Task<TranslationModel> TranslateAsync(TranslationModel model);
}
