# .IBM.WatsonDeveloperCloud.Discovery.v1.EnvironmentsAPI

All URIs are relative to *https://localhost/discovery/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateEnvironment**](EnvironmentsAPI.md#createenvironment) | **POST** /v1/environments | Add an environment.
[**DeleteEnvironment**](EnvironmentsAPI.md#deleteenvironment) | **DELETE** /v1/environments/{environmentId} | Delete environment.
[**GetEnvironment**](EnvironmentsAPI.md#getenvironment) | **GET** /v1/environments/{environmentId} | Get environment info.
[**ListEnvironments**](EnvironmentsAPI.md#listenvironments) | **GET** /v1/environments | List environments.
[**UpdateEnvironment**](EnvironmentsAPI.md#updateenvironment) | **PUT** /v1/environments/{environmentId} | Update an environment.


<a name="createenvironment"></a>
# **CreateEnvironment**
> ModelEnvironment CreateEnvironment (CreateEnvironmentRequest body)

Add an environment.

Creates a new environment.  You can create only one environment per service instance. An attempt to create another environment will result in an error.  The size of the new environment can be controlled by specifying the `size` parameter. Use the table below to map size values to the size of the environment which is created:  | Size | Disk (GB)  | RAM (GB) | Included Standard Enrichments | Notes | | ---:  | -----------: | -----------: | --------------------------------------------: | -------- | | 0  | 2              | 1              | n/a (effectively unlimited)   | Free Plan only, no HA (single node in elastic.co)| | 1     | 48             | 2              | 4,000    | | | 2     | 192            | 8              | 16,000   | | | 3     | 384            | 16             | 32,000   | |  **Note:** you cannot set the size property when using the free plan.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class CreateEnvironmentExample
    {
        public void main()
        {
            
            var apiInstance = new EnvironmentsAPI();
            var body = new CreateEnvironmentRequest(); // CreateEnvironmentRequest | A JSON object where you define an environment name, description, and size.

            try
            {
                // Add an environment.
                ModelEnvironment result = apiInstance.CreateEnvironment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentsAPI.CreateEnvironment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateEnvironmentRequest**](CreateEnvironmentRequest.md)| A JSON object where you define an environment name, description, and size. | 

### Return type

[**ModelEnvironment**](ModelEnvironment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteenvironment"></a>
# **DeleteEnvironment**
> DeleteEnvironmentResponse DeleteEnvironment (string environmentId)

Delete environment.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class DeleteEnvironmentExample
    {
        public void main()
        {
            
            var apiInstance = new EnvironmentsAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment

            try
            {
                // Delete environment.
                DeleteEnvironmentResponse result = apiInstance.DeleteEnvironment(environmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentsAPI.DeleteEnvironment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environmentId** | **string**| the ID of your environment | 

### Return type

[**DeleteEnvironmentResponse**](DeleteEnvironmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getenvironment"></a>
# **GetEnvironment**
> ModelEnvironment GetEnvironment (string environmentId)

Get environment info.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class GetEnvironmentExample
    {
        public void main()
        {
            
            var apiInstance = new EnvironmentsAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment

            try
            {
                // Get environment info.
                ModelEnvironment result = apiInstance.GetEnvironment(environmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentsAPI.GetEnvironment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environmentId** | **string**| the ID of your environment | 

### Return type

[**ModelEnvironment**](ModelEnvironment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listenvironments"></a>
# **ListEnvironments**
> ListEnvironmentsResponse ListEnvironments (string name)

List environments.

List existing environments for the service instance.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class ListEnvironmentsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvironmentsAPI();
            var name = name_example;  // string | Show only the environment with the given name. (optional) 

            try
            {
                // List environments.
                ListEnvironmentsResponse result = apiInstance.ListEnvironments(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentsAPI.ListEnvironments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Show only the environment with the given name. | [optional] 

### Return type

[**ListEnvironmentsResponse**](ListEnvironmentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateenvironment"></a>
# **UpdateEnvironment**
> ModelEnvironment UpdateEnvironment (string environmentId, UpdateEnvironmentRequest body)

Update an environment.

Updates an environment. The environment's `name` and  `description` parameters can be changed. You can increase the value of the `size` parameter. If you need to decrease an environment's size, contact IBM Support.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class UpdateEnvironmentExample
    {
        public void main()
        {
            
            var apiInstance = new EnvironmentsAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var body = new UpdateEnvironmentRequest(); // UpdateEnvironmentRequest | 

            try
            {
                // Update an environment.
                ModelEnvironment result = apiInstance.UpdateEnvironment(environmentId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvironmentsAPI.UpdateEnvironment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environmentId** | **string**| the ID of your environment | 
 **body** | [**UpdateEnvironmentRequest**](UpdateEnvironmentRequest.md)|  | 

### Return type

[**ModelEnvironment**](ModelEnvironment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

