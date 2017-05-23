# .IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.AnalyzeAPI

All URIs are relative to *https://localhost/natural-language-understanding/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Analyze**](AnalyzeAPI.md#analyze) | **POST** /v1/analyze | Analyze text, HTML, or a public webpage.
[**AnalyzeGet**](AnalyzeAPI.md#analyzeget) | **GET** /v1/analyze | Analyze text, HTML, or a public webpage.


<a name="analyze"></a>
# **Analyze**
> AnalysisResults Analyze (Parameters parameters)

Analyze text, HTML, or a public webpage.

Analyzes text, HTML, or a public webpage with one or more text analysis features.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.Model;

namespace Example
{
    public class AnalyzeExample
    {
        public void main()
        {
            
            var apiInstance = new AnalyzeAPI();
            var parameters = new Parameters(); // Parameters | An object containing request parameters. The `features` object and one of the `text`, `html`, or `url` attributes are required. (optional) 

            try
            {
                // Analyze text, HTML, or a public webpage.
                AnalysisResults result = apiInstance.Analyze(parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyzeAPI.Analyze: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parameters** | [**Parameters**](Parameters.md)| An object containing request parameters. The `features` object and one of the `text`, `html`, or `url` attributes are required. | [optional] 

### Return type

[**AnalysisResults**](AnalysisResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="analyzeget"></a>
# **AnalyzeGet**
> AnalysisResults AnalyzeGet (List<string> features, string text, string html, string url, bool? returnAnalyzedText, bool? clean, string xpath, bool? fallbackToRaw, string language, int? conceptsLimit, bool? emotionDocument, List<string> emotionTargets, int? entitiesLimit, string entitiesModel, bool? entitiesEmotion, bool? entitiesSentiment, int? keywordsLimit, bool? keywordsEmotion, bool? keywordsSentiment, string relationsModel, int? semanticRolesLimit, bool? semanticRolesEntities, bool? semanticRolesKeywords, bool? sentimentDocument, List<string> sentimentTargets)

Analyze text, HTML, or a public webpage.

Analyzes text, HTML, or a public webpage with one or more text analysis features.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.Model;

namespace Example
{
    public class AnalyzeGetExample
    {
        public void main()
        {
            
            var apiInstance = new AnalyzeAPI();
            var features = new List<string>(); // List<string> | Comma separated list of analysis features
            var text = text_example;  // string | Text to analyze (optional) 
            var html = html_example;  // string | HTML to analyze (optional) 
            var url = url_example;  // string | Public webpage to analyze (optional) 
            var returnAnalyzedText = true;  // bool? | Set this to true to show the analyzed text in the response (optional)  (default to false)
            var clean = true;  // bool? | Set to false to disable text cleaning (optional)  (default to true)
            var xpath = xpath_example;  // string | Xpath query for targeting nodes in HTML (optional) 
            var fallbackToRaw = true;  // bool? | Whether to use raw HTML content if text cleaning fails (optional)  (default to true)
            var language = language_example;  // string | ISO 639-1 code indicating the language to use in the analysis (optional) 
            var conceptsLimit = 56;  // int? | Maximum number of concepts to return (optional)  (default to 8)
            var emotionDocument = true;  // bool? | Set this to false to hide document-level emotion results (optional)  (default to true)
            var emotionTargets = new List<string>(); // List<string> | Target strings, separated by commas. Emotion results will be returned for each target string found in the document (optional) 
            var entitiesLimit = 56;  // int? | Maximum number of entities to return (optional)  (default to 50)
            var entitiesModel = entitiesModel_example;  // string | Enter a custom model ID to override the standard entity detection model (optional) 
            var entitiesEmotion = true;  // bool? | Set this to true to return emotion information for detected entities (optional)  (default to false)
            var entitiesSentiment = true;  // bool? | Set this to true to return sentiment information for detected entities (optional)  (default to false)
            var keywordsLimit = 56;  // int? | Maximum number of keywords to return (optional)  (default to 50)
            var keywordsEmotion = true;  // bool? | Set this to true to return emotion information for detected keywords (optional)  (default to false)
            var keywordsSentiment = true;  // bool? | Set this to true to return sentiment information for detected keywords (optional)  (default to false)
            var relationsModel = relationsModel_example;  // string | Enter a custom model ID to override the default `en-news` relations model (optional)  (default to en-news)
            var semanticRolesLimit = 56;  // int? | Maximum number of semantic_roles results to return (optional)  (default to 50)
            var semanticRolesEntities = true;  // bool? | Set this to true to return entity information for subjects and objects (optional)  (default to false)
            var semanticRolesKeywords = true;  // bool? | Set this to true to return keyword information for subjects and objects (optional)  (default to false)
            var sentimentDocument = true;  // bool? | Set this to false to disable document level sentiment analysis (optional)  (default to true)
            var sentimentTargets = new List<string>(); // List<string> | Sentiment information will return for each target string that is found in the text (optional) 

            try
            {
                // Analyze text, HTML, or a public webpage.
                AnalysisResults result = apiInstance.AnalyzeGet(features, text, html, url, returnAnalyzedText, clean, xpath, fallbackToRaw, language, conceptsLimit, emotionDocument, emotionTargets, entitiesLimit, entitiesModel, entitiesEmotion, entitiesSentiment, keywordsLimit, keywordsEmotion, keywordsSentiment, relationsModel, semanticRolesLimit, semanticRolesEntities, semanticRolesKeywords, sentimentDocument, sentimentTargets);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyzeAPI.AnalyzeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **features** | [**List<string>**](string.md)| Comma separated list of analysis features | 
 **text** | **string**| Text to analyze | [optional] 
 **html** | **string**| HTML to analyze | [optional] 
 **url** | **string**| Public webpage to analyze | [optional] 
 **returnAnalyzedText** | **bool?**| Set this to true to show the analyzed text in the response | [optional] [default to false]
 **clean** | **bool?**| Set to false to disable text cleaning | [optional] [default to true]
 **xpath** | **string**| Xpath query for targeting nodes in HTML | [optional] 
 **fallbackToRaw** | **bool?**| Whether to use raw HTML content if text cleaning fails | [optional] [default to true]
 **language** | **string**| ISO 639-1 code indicating the language to use in the analysis | [optional] 
 **conceptsLimit** | **int?**| Maximum number of concepts to return | [optional] [default to 8]
 **emotionDocument** | **bool?**| Set this to false to hide document-level emotion results | [optional] [default to true]
 **emotionTargets** | [**List<string>**](string.md)| Target strings, separated by commas. Emotion results will be returned for each target string found in the document | [optional] 
 **entitiesLimit** | **int?**| Maximum number of entities to return | [optional] [default to 50]
 **entitiesModel** | **string**| Enter a custom model ID to override the standard entity detection model | [optional] 
 **entitiesEmotion** | **bool?**| Set this to true to return emotion information for detected entities | [optional] [default to false]
 **entitiesSentiment** | **bool?**| Set this to true to return sentiment information for detected entities | [optional] [default to false]
 **keywordsLimit** | **int?**| Maximum number of keywords to return | [optional] [default to 50]
 **keywordsEmotion** | **bool?**| Set this to true to return emotion information for detected keywords | [optional] [default to false]
 **keywordsSentiment** | **bool?**| Set this to true to return sentiment information for detected keywords | [optional] [default to false]
 **relationsModel** | **string**| Enter a custom model ID to override the default `en-news` relations model | [optional] [default to en-news]
 **semanticRolesLimit** | **int?**| Maximum number of semantic_roles results to return | [optional] [default to 50]
 **semanticRolesEntities** | **bool?**| Set this to true to return entity information for subjects and objects | [optional] [default to false]
 **semanticRolesKeywords** | **bool?**| Set this to true to return keyword information for subjects and objects | [optional] [default to false]
 **sentimentDocument** | **bool?**| Set this to false to disable document level sentiment analysis | [optional] [default to true]
 **sentimentTargets** | [**List<string>**](string.md)| Sentiment information will return for each target string that is found in the text | [optional] 

### Return type

[**AnalysisResults**](AnalysisResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

