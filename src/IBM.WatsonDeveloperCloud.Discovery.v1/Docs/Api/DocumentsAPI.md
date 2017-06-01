# .IBM.WatsonDeveloperCloud.Discovery.v1.DocumentsAPI

All URIs are relative to *https://localhost/discovery/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDocument**](DocumentsAPI.md#adddocument) | **POST** /v1/environments/{environmentId}/collections/{collectionId}/documents | Add a document.
[**DeleteDocument**](DocumentsAPI.md#deletedocument) | **DELETE** /v1/environments/{environmentId}/collections/{collectionId}/documents/{documentId} | Delete a document.
[**GetDocument**](DocumentsAPI.md#getdocument) | **GET** /v1/environments/{environmentId}/collections/{collectionId}/documents/{documentId} | Get document details.
[**UpdateDocument**](DocumentsAPI.md#updatedocument) | **POST** /v1/environments/{environmentId}/collections/{collectionId}/documents/{documentId} | Update a document.


<a name="adddocument"></a>
# **AddDocument**
> DocumentAccepted AddDocument (string environmentId, string collectionId, string configurationId, System.IO.Stream file, string metadata, string configuration)

Add a document.

Add a document to a collection with optional metadata and optional configuration.   Set the `Content-Type` header on the request to indicate the media type of the document. If the `Content-Type` header is missing or is one of the generic media types (for example,  `application/octet-stream`), then the service attempts to automatically detect the document's media type.       * The configuration to use to process the document can be provided by using the `configuration_id` query parameter.       * The `version` query parameter is still required.    * Returns immediately after the system has accepted the document for processing.    * The user must provide document content, metadata, or both. If the request is missing both document content and metadata, it is  rejected.       * The user can set the `Content-Type` parameter on the `file` part to indicate the media type of the document. If the `Content-Type` parameter is missing or is one of the generic media types (for example, `application/octet-stream`), then the service attempts to automatically detect the document's media type.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class AddDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new DocumentsAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var collectionId = collectionId_example;  // string | the ID of your collection
            var configurationId = configurationId_example;  // string | The ID of the configuration to use to process the document. If the `configuration` form part is also provided (both are present at the same time), then request will be rejected. (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | The content of the document to ingest.The maximum supported file size is 50 megabytes. Files larger than 50 megabytes is rejected. (optional) 
            var metadata = metadata_example;  // string | If you're using the Data Crawler to upload your documents, you can test a document against the type of metadata that the Data Crawler might send. The maximum supported metadata file size is 1 MB. Metadata parts larger than 1 MB are rejected. Example:  ``` {   \"Creator\": \"Johnny Appleseed\",   \"Subject\": \"Apples\" } ``` (optional) 
            var configuration = configuration_example;  // string | The configuration to use to process the document. If this part is provided, then the provided configuration is used to process the document. If the `configuration_id` is also provided (both are present at the same time), then request is rejected. The maximum supported configuration size is 1 MB. Configuration parts larger than 1 MB are rejected. See the `GET /configurations/{configuration_id}` operation for an example configuration. (optional) 

            try
            {
                // Add a document.
                DocumentAccepted result = apiInstance.AddDocument(environmentId, collectionId, configurationId, file, metadata, configuration);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsAPI.AddDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environmentId** | **string**| the ID of your environment | 
 **collectionId** | **string**| the ID of your collection | 
 **configurationId** | **string**| The ID of the configuration to use to process the document. If the `configuration` form part is also provided (both are present at the same time), then request will be rejected. | [optional] 
 **file** | **System.IO.Stream**| The content of the document to ingest.The maximum supported file size is 50 megabytes. Files larger than 50 megabytes is rejected. | [optional] 
 **metadata** | **string**| If you're using the Data Crawler to upload your documents, you can test a document against the type of metadata that the Data Crawler might send. The maximum supported metadata file size is 1 MB. Metadata parts larger than 1 MB are rejected. Example:  ``` {   "Creator": "Johnny Appleseed",   "Subject": "Apples" } ``` | [optional] 
 **configuration** | **string**| The configuration to use to process the document. If this part is provided, then the provided configuration is used to process the document. If the `configuration_id` is also provided (both are present at the same time), then request is rejected. The maximum supported configuration size is 1 MB. Configuration parts larger than 1 MB are rejected. See the `GET /configurations/{configuration_id}` operation for an example configuration. | [optional] 

### Return type

[**DocumentAccepted**](DocumentAccepted.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedocument"></a>
# **DeleteDocument**
> DeleteDocumentResponse DeleteDocument (string environmentId, string collectionId, string documentId)

Delete a document.

If the given document id is invalid, or if the document is not found, then the a success response is returned (HTTP status code `200`) with the status set to 'deleted'.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class DeleteDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new DocumentsAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var collectionId = collectionId_example;  // string | the ID of your collection
            var documentId = documentId_example;  // string | the ID of your document

            try
            {
                // Delete a document.
                DeleteDocumentResponse result = apiInstance.DeleteDocument(environmentId, collectionId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsAPI.DeleteDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environmentId** | **string**| the ID of your environment | 
 **collectionId** | **string**| the ID of your collection | 
 **documentId** | **string**| the ID of your document | 

### Return type

[**DeleteDocumentResponse**](DeleteDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocument"></a>
# **GetDocument**
> DocumentStatus GetDocument (string environmentId, string collectionId, string documentId)

Get document details.

Fetch status details about a submitted document. **Note:** this operation does not return the document itself. Instead, it returns only the document's processing status and any notices (warnings or errors) that were generated when the document was ingested. Use the query API to retrieve the actual document content.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class GetDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new DocumentsAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var collectionId = collectionId_example;  // string | the ID of your collection
            var documentId = documentId_example;  // string | the ID of your document

            try
            {
                // Get document details.
                DocumentStatus result = apiInstance.GetDocument(environmentId, collectionId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsAPI.GetDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environmentId** | **string**| the ID of your environment | 
 **collectionId** | **string**| the ID of your collection | 
 **documentId** | **string**| the ID of your document | 

### Return type

[**DocumentStatus**](DocumentStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedocument"></a>
# **UpdateDocument**
> DocumentAccepted UpdateDocument (string environmentId, string collectionId, string documentId, string configurationId, System.IO.Stream file, string metadata, string configuration)

Update a document.

Replace an existing document. Starts ingesting a document with optional metadata and optional configurations.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class UpdateDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new DocumentsAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var collectionId = collectionId_example;  // string | the ID of your collection
            var documentId = documentId_example;  // string | the ID of your document
            var configurationId = configurationId_example;  // string | The ID of the configuration to use to process the document. If the `configuration` form part is also provided (both are present at the same time), then request will be rejected. (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | The content of the document to ingest.The maximum supported file size is 50 megabytes. Files larger than 50 megabytes is rejected. (optional) 
            var metadata = metadata_example;  // string | If you're using the Data Crawler to upload your documents, you can test a document against the type of metadata that the Data Crawler might send. The maximum supported metadata file size is 1 MB. Metadata parts larger than 1 MB are rejected. Example:  ``` {   \"Creator\": \"Johnny Appleseed\",   \"Subject\": \"Apples\" } ``` (optional) 
            var configuration = configuration_example;  // string | The configuration to use to process the document. If this part is provided, then the provided configuration is used to process the document. If the `configuration_id` is also provided (both are present at the same time), then request is rejected. The maximum supported configuration size is 1 MB. Configuration parts larger than 1 MB are rejected. See the `GET /configurations/{configuration_id}` operation for an example configuration. (optional) 

            try
            {
                // Update a document.
                DocumentAccepted result = apiInstance.UpdateDocument(environmentId, collectionId, documentId, configurationId, file, metadata, configuration);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsAPI.UpdateDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environmentId** | **string**| the ID of your environment | 
 **collectionId** | **string**| the ID of your collection | 
 **documentId** | **string**| the ID of your document | 
 **configurationId** | **string**| The ID of the configuration to use to process the document. If the `configuration` form part is also provided (both are present at the same time), then request will be rejected. | [optional] 
 **file** | **System.IO.Stream**| The content of the document to ingest.The maximum supported file size is 50 megabytes. Files larger than 50 megabytes is rejected. | [optional] 
 **metadata** | **string**| If you're using the Data Crawler to upload your documents, you can test a document against the type of metadata that the Data Crawler might send. The maximum supported metadata file size is 1 MB. Metadata parts larger than 1 MB are rejected. Example:  ``` {   "Creator": "Johnny Appleseed",   "Subject": "Apples" } ``` | [optional] 
 **configuration** | **string**| The configuration to use to process the document. If this part is provided, then the provided configuration is used to process the document. If the `configuration_id` is also provided (both are present at the same time), then request is rejected. The maximum supported configuration size is 1 MB. Configuration parts larger than 1 MB are rejected. See the `GET /configurations/{configuration_id}` operation for an example configuration. | [optional] 

### Return type

[**DocumentAccepted**](DocumentAccepted.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

