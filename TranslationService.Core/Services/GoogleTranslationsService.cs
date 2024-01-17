using Google.Cloud.Translation.V2;

namespace TranslationService.Domain.Services
{
    public class GoogleTranslationsService : ITranslationsService
    {
        public async Task<Models.TranslationModel> TranslateAsync(Models.TranslationModel model)
        {
            TranslationClient client = TranslationClient.Create();
            var result = await client.TranslateTextAsync(model.OriginalText, model.TargetLanguage, model.OriginalLanguage);
            model.TargetText = result.TranslatedText;
            
            return model;
        }
    }
}
