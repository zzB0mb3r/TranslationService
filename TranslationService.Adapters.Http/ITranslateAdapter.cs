namespace TranslationService.Adapters.Http;

public interface ITranslateAdapter
{
    Task<string> TranslateAsync(string originalText, int originalLanguage, int targetLanguage);
}
