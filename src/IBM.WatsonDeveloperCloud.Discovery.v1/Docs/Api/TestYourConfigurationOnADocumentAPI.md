# .IBM.WatsonDeveloperCloud.Discovery.v1.TestYourConfigurationOnADocumentAPI

All URIs are relative to *https://localhost/discovery/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TestConfigurationInEnvironment**](TestYourConfigurationOnADocumentAPI.md#testconfigurationinenvironment) | **POST** /v1/environments/{environmentId}/preview | Test configuration.


<a name="testconfigurationinenvironment"></a>
# **TestConfigurationInEnvironment**
> TestDocument TestConfigurationInEnvironment (string environmentId, string configuration, string step, string configurationId, System.IO.Stream file, string metadata)

Test configuration.

Runs a sample document through the default or your configuration and returns diagnostic information designed to help you understand how the document was processed. The document is not added to the index.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class TestConfigurationInEnvironmentExample
    {
        public void main()
        {
            
            var apiInstance = new TestYourConfigurationOnADocumentAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var configuration = configuration_example;  // string | The configuration to use to process the document. If this part is provided, then the provided configuration is used to process the document. If the `configuration_id` is also provided (both are present at the same time), then request is rejected. The maximum supported configuration size is 1 MB. Configuration parts larger than 1 MB are rejected. See the `GET /configurations/{configuration_id}` operation for an example configuration. (optional) 
            var step = step_example;  // string | Specify to only run the input document through the given step instead of running the input document through the entire ingestion workflow. Valid values are `convert`, `enrich`, and `normalize`. (optional) 
            var configurationId = configurationId_example;  // string | The ID of the configuration to use to process the document. If the `configuration` form part is also provided (both are present at the same time), then request will be rejected. (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | The content of the document to ingest.The maximum supported file size is 50 megabytes. Files larger than 50 megabytes is rejected. (optional) 
            var metadata = metadata_example;  // string | If you're using the Data Crawler to upload your documents, you can test a document against the type of metadata that the Data Crawler might send. The maximum supported metadata file size is 1 MB. Metadata parts larger than 1 MB are rejected. Example:  ``` {   \"Creator\": \"Johnny Appleseed\",   \"Subject\": \"Apples\" } ``` (optional) 

            try
            {
                // Test configuration.
                TestDocument result = apiInstance.TestConfigurationInEnvironment(environmentId, configuration, step, configurationId, file, metadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestYourConfigurationOnADocumentAPI.TestConfigurationInEnvironment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environmentId** | **string**| the ID of your environment | 
 **configuration** | **string**| The configuration to use to process the document. If this part is provided, then the provided configuration is used to process the document. If the `configuration_id` is also provided (both are present at the same time), then request is rejected. The maximum supported configuration size is 1 MB. Configuration parts larger than 1 MB are rejected. See the `GET /configurations/{configuration_id}` operation for an example configuration. | [optional] 
 **step** | **string**| Specify to only run the input document through the given step instead of running the input document through the entire ingestion workflow. Valid values are `convert`, `enrich`, and `normalize`. | [optional] 
 **configurationId** | **string**| The ID of the configuration to use to process the document. If the `configuration` form part is also provided (both are present at the same time), then request will be rejected. | [optional] 
 **file** | **System.IO.Stream**| The content of the document to ingest.The maximum supported file size is 50 megabytes. Files larger than 50 megabytes is rejected. | [optional] 
 **metadata** | **string**| If you're using the Data Crawler to upload your documents, you can test a document against the type of metadata that the Data Crawler might send. The maximum supported metadata file size is 1 MB. Metadata parts larger than 1 MB are rejected. Example:  ``` {   "Creator": "Johnny Appleseed",   "Subject": "Apples" } ``` | [optional] 

### Return type

[**TestDocument**](TestDocument.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

