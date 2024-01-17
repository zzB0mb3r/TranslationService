using Google.Cloud.Translation.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationService.Adapters.Http
{
    public class GoogleTranslateAdapter : ITranslateAdapter
    {
        public async Task<string> TranslateAsync(string text, int originalLanguage, int targetLanguage)
        {
            // Use HttpClient or any other HTTP client library to make API calls
            // Implement the logic to call the Google Translate API
            // Return the translated text
            //var client = TranslationClient.Create();
            //var response = client.TranslateText(text, LanguageCodes.Turkish, LanguageCodes.English);

            return "Translated text from Google API";
        }
    }
}
