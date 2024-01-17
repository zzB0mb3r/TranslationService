# TranslationService
## Overview
The Net7 backend is divided into two main projects: Domain and Api. It can be run by starting the Api project. Application is hosted at https://localhost:7164/ and Swagger UI offer an overview of the endpoint exposed.

## Domain Project
The Domain project encapsulates the business logic and interaction with external Google Cloud Translation service. A service account key is used to authenticate with the Google API and the json path for the authentication needs to be provided through the environemnt variable GOOGLE_APPLICATION_CREDENTIALS to run it locally. In case of need I can provide a key.

## Api Project
The Api project exposes an endpoint to serve translation requests from the TranslationUI. It use the services provided by the Domain project to translate user text.
