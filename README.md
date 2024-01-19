# TranslationService
## Overview
The .NET7 application is splitted into two main projects: 
- TranslationService.Api: simple rest Api that exposes a single Http POST endpoint at /translate path which serve the translated user text to the clients.
- TranslationService.Domain: encapsulates the business logic and the connection to the Cloud Translation API through the GoogleTranslationService and the Google.Cloud.Translation.V2 NuGet package.

## Debug
It can be run by IISExpress or Docker. IISExpress host the endpoint at https://localhost:44389 with the Swagger documentation of the Api.
The authentication to the Cloud Translation API requires a service account key. The json key path for the Google.Cloud.Translation.V2.TranslationClient is provided through the GOOGLE_APPLICATION_CREDENTIALS environment variable. Technical details can be found at https://developers.google.com/workspace/guides/create-credentials
