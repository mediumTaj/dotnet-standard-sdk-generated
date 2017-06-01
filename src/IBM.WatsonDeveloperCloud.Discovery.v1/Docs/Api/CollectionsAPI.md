# .IBM.WatsonDeveloperCloud.Discovery.v1.CollectionsAPI

All URIs are relative to *https://localhost/discovery/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCollection**](CollectionsAPI.md#createcollection) | **POST** /v1/environments/{environmentId}/collections | Create a collection.
[**DeleteCollection**](CollectionsAPI.md#deletecollection) | **DELETE** /v1/environments/{environmentId}/collections/{collectionId} | Delete a collection.
[**GetCollection**](CollectionsAPI.md#getcollection) | **GET** /v1/environments/{environmentId}/collections/{collectionId} | Get collection details.
[**ListCollectionFields**](CollectionsAPI.md#listcollectionfields) | **GET** /v1/environments/{environmentId}/collections/{collectionId}/fields | List unique fields.
[**ListCollections**](CollectionsAPI.md#listcollections) | **GET** /v1/environments/{environmentId}/collections | List collections.
[**UpdateCollection**](CollectionsAPI.md#updatecollection) | **PUT** /v1/environments/{environmentId}/collections/{collectionId} | Update a collection.


<a name="createcollection"></a>
# **CreateCollection**
> Collection CreateCollection (string environmentId, CreateCollectionRequest body)

Create a collection.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class CreateCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var body = new CreateCollectionRequest(); // CreateCollectionRequest | Input a JSON object that allows you to add a collection. (optional) 

            try
            {
                // Create a collection.
                Collection result = apiInstance.CreateCollection(environmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsAPI.CreateCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environmentId** | **string**| the ID of your environment | 
 **body** | [**CreateCollectionRequest**](CreateCollectionRequest.md)| Input a JSON object that allows you to add a collection. | [optional] 

### Return type

**Collection**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecollection"></a>
# **DeleteCollection**
> DeleteCollectionResponse DeleteCollection (string environmentId, string collectionId)

Delete a collection.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class DeleteCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var collectionId = collectionId_example;  // string | the ID of your collection

            try
            {
                // Delete a collection.
                DeleteCollectionResponse result = apiInstance.DeleteCollection(environmentId, collectionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsAPI.DeleteCollection: " + e.Message );
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

### Return type

[**DeleteCollectionResponse**](DeleteCollectionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcollection"></a>
# **GetCollection**
> Collection GetCollection (string environmentId, string collectionId)

Get collection details.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class GetCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var collectionId = collectionId_example;  // string | the ID of your collection

            try
            {
                // Get collection details.
                Collection result = apiInstance.GetCollection(environmentId, collectionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsAPI.GetCollection: " + e.Message );
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

### Return type

**Collection**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcollectionfields"></a>
# **ListCollectionFields**
> ListCollectionFieldsResponse ListCollectionFields (string environmentId, string collectionId)

List unique fields.

Gets a list of the the unique fields (and their types) stored in the index.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class ListCollectionFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var collectionId = collectionId_example;  // string | the ID of your collection

            try
            {
                // List unique fields.
                ListCollectionFieldsResponse result = apiInstance.ListCollectionFields(environmentId, collectionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsAPI.ListCollectionFields: " + e.Message );
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

### Return type

[**ListCollectionFieldsResponse**](ListCollectionFieldsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcollections"></a>
# **ListCollections**
> ListCollectionsResponse ListCollections (string environmentId, string name)

List collections.

Lists existing collections for the service instance.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class ListCollectionsExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var name = name_example;  // string | Find collections with the given name. (optional) 

            try
            {
                // List collections.
                ListCollectionsResponse result = apiInstance.ListCollections(environmentId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsAPI.ListCollections: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environmentId** | **string**| the ID of your environment | 
 **name** | **string**| Find collections with the given name. | [optional] 

### Return type

[**ListCollectionsResponse**](ListCollectionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecollection"></a>
# **UpdateCollection**
> Collection UpdateCollection (string environmentId, string collectionId, UpdateCollectionRequest body)

Update a collection.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class UpdateCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var collectionId = collectionId_example;  // string | the ID of your collection
            var body = new UpdateCollectionRequest(); // UpdateCollectionRequest | Input a JSON object that allows you to update a collection. (optional) 

            try
            {
                // Update a collection.
                Collection result = apiInstance.UpdateCollection(environmentId, collectionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsAPI.UpdateCollection: " + e.Message );
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
 **body** | [**UpdateCollectionRequest**](UpdateCollectionRequest.md)| Input a JSON object that allows you to update a collection. | [optional] 

### Return type

**Collection**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

