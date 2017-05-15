# .IBM.WatsonDeveloperCloud.ToneAnalyzer.v3.ToneAPI

All URIs are relative to *https://localhost/tone-analyzer/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Tone**](ToneAPI.md#tone) | **POST** /v3/tone | Analyze general tone.
[**ToneChat**](ToneAPI.md#tonechat) | **POST** /v3/tone_chat | Analyze customer engagement tone.


<a name="tone"></a>
# **Tone**
> ToneAnalysis Tone (ToneInput text, string tones, bool? sentences)

Analyze general tone.

Analyze the tone of a piece of text. The message is analyzed for several tones - social, emotional, and language. For each tone, various traits are derived. For example, conscientiousness, agreeableness, and openness.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.ToneAnalyzer.v3;
using .Client;
using .IBM.WatsonDeveloperCloud.ToneAnalyzer.v3.Model;

namespace Example
{
    public class ToneExample
    {
        public void main()
        {
            
            var apiInstance = new ToneAPI();
            var text = new ToneInput(); // ToneInput | The content to be analyzed. The Tone Analyzer service supports up to 128 KB of text, or about 1000 sentences. Sentences with less than three words cannot be analyzed.
            var tones = tones_example;  // string | Filter the results by a specific tone. Valid values are `emotion`, `language`, and `social`. (optional) 
            var sentences = true;  // bool? | Filter your response to remove the sentence level analysis. Valid values are `true` and `false`. This parameter defaults to `true` when it's not set, which means that a sentence level analysis is automatically provided. Change `sentences` to `false` to filter out the sentence level analysis. (optional) 

            try
            {
                // Analyze general tone.
                ToneAnalysis result = apiInstance.Tone(text, tones, sentences);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToneAPI.Tone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | [**ToneInput**](ToneInput.md)| The content to be analyzed. The Tone Analyzer service supports up to 128 KB of text, or about 1000 sentences. Sentences with less than three words cannot be analyzed. | 
 **tones** | **string**| Filter the results by a specific tone. Valid values are `emotion`, `language`, and `social`. | [optional] 
 **sentences** | **bool?**| Filter your response to remove the sentence level analysis. Valid values are `true` and `false`. This parameter defaults to `true` when it's not set, which means that a sentence level analysis is automatically provided. Change `sentences` to `false` to filter out the sentence level analysis. | [optional] 

### Return type

[**ToneAnalysis**](ToneAnalysis.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/plain, text/html
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tonechat"></a>
# **ToneChat**
> UtteranceAnalyses ToneChat (ToneChatInput utterances)

Analyze customer engagement tone.

Use the Tone Analyzer for Customer Engagement Endpoint to monitor customer service and customer support conversations.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.ToneAnalyzer.v3;
using .Client;
using .IBM.WatsonDeveloperCloud.ToneAnalyzer.v3.Model;

namespace Example
{
    public class ToneChatExample
    {
        public void main()
        {
            
            var apiInstance = new ToneAPI();
            var utterances = new ToneChatInput(); // ToneChatInput | The content to be analyzed.

            try
            {
                // Analyze customer engagement tone.
                UtteranceAnalyses result = apiInstance.ToneChat(utterances);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToneAPI.ToneChat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **utterances** | [**ToneChatInput**](ToneChatInput.md)| The content to be analyzed. | 

### Return type

[**UtteranceAnalyses**](UtteranceAnalyses.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

