# .IBM.WatsonDeveloperCloud.Discovery.v1.ConfigurationsAPI

All URIs are relative to *https://localhost/discovery/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateConfiguration**](ConfigurationsAPI.md#createconfiguration) | **POST** /v1/environments/{environmentId}/configurations | Add configuration.
[**DeleteConfiguration**](ConfigurationsAPI.md#deleteconfiguration) | **DELETE** /v1/environments/{environmentId}/configurations/{configurationId} | Delete a configuration.
[**GetConfiguration**](ConfigurationsAPI.md#getconfiguration) | **GET** /v1/environments/{environmentId}/configurations/{configurationId} | Get configuration details.
[**ListConfigurations**](ConfigurationsAPI.md#listconfigurations) | **GET** /v1/environments/{environmentId}/configurations | List configurations.
[**UpdateConfiguration**](ConfigurationsAPI.md#updateconfiguration) | **PUT** /v1/environments/{environmentId}/configurations/{configurationId} | Update a configuration.


<a name="createconfiguration"></a>
# **CreateConfiguration**
> Configuration CreateConfiguration (string environmentId, Configuration configuration)

Add configuration.

Creates a new configuration.  If the input configuration contains the `configuration_id`, `created`, or `updated` properties, then they are ignored and overridden by the system, and an error is not returned so that the overridden fields do not need to be removed when copying a configuration.  The configuration can contain unrecognized JSON fields. Any such fields are ignored and do not generate an error. This makes it easier to use newer configuration files with older versions of the API and the service. It also makes it possible for the tooling to add additional metadata and information to the configuration.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class CreateConfigurationExample
    {
        public void main()
        {
            
            var apiInstance = new ConfigurationsAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var configuration = new Configuration(); // Configuration | Input a JSON object that enables you to customize how your content is ingested and what enrichments are added to your data.   `name` is required and must be unique within the current `environment`. All other properties are optional.  If the input configuration contains the `configuration_id`, `created`, or `updated` properties, then they will be ignored and overridden by the system (an error is not returned so that the overridden fields do not need to be removed when copying a configuration).   The configuration can contain unrecognized JSON fields. Any such fields will be ignored and will not generate an error. This makes it easier to use newer configuration files with older versions of the API and the service. It also makes it possible for the tooling to add additional metadata and information to the configuration.

            try
            {
                // Add configuration.
                Configuration result = apiInstance.CreateConfiguration(environmentId, configuration);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationsAPI.CreateConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environmentId** | **string**| the ID of your environment | 
 **configuration** | [**Configuration**](Configuration.md)| Input a JSON object that enables you to customize how your content is ingested and what enrichments are added to your data.   `name` is required and must be unique within the current `environment`. All other properties are optional.  If the input configuration contains the `configuration_id`, `created`, or `updated` properties, then they will be ignored and overridden by the system (an error is not returned so that the overridden fields do not need to be removed when copying a configuration).   The configuration can contain unrecognized JSON fields. Any such fields will be ignored and will not generate an error. This makes it easier to use newer configuration files with older versions of the API and the service. It also makes it possible for the tooling to add additional metadata and information to the configuration. | 

### Return type

[**Configuration**](Configuration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteconfiguration"></a>
# **DeleteConfiguration**
> DeleteConfigurationResponse DeleteConfiguration (string environmentId, string configurationId)

Delete a configuration.

The deletion is performed unconditionally. A configuration deletion request succeeds even if the configuration is referenced by a collection or document ingestion. However, documents that have already been submitted for processing continue to use the deleted configuration. Documents are always processed with a snapshot of the configuration as it existed at the time the document was submitted.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class DeleteConfigurationExample
    {
        public void main()
        {
            
            var apiInstance = new ConfigurationsAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var configurationId = configurationId_example;  // string | the ID of your configuration

            try
            {
                // Delete a configuration.
                DeleteConfigurationResponse result = apiInstance.DeleteConfiguration(environmentId, configurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationsAPI.DeleteConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environmentId** | **string**| the ID of your environment | 
 **configurationId** | **string**| the ID of your configuration | 

### Return type

[**DeleteConfigurationResponse**](DeleteConfigurationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfiguration"></a>
# **GetConfiguration**
> Configuration GetConfiguration (string environmentId, string configurationId)

Get configuration details.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class GetConfigurationExample
    {
        public void main()
        {
            
            var apiInstance = new ConfigurationsAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var configurationId = configurationId_example;  // string | the ID of your configuration

            try
            {
                // Get configuration details.
                Configuration result = apiInstance.GetConfiguration(environmentId, configurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationsAPI.GetConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environmentId** | **string**| the ID of your environment | 
 **configurationId** | **string**| the ID of your configuration | 

### Return type

[**Configuration**](Configuration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listconfigurations"></a>
# **ListConfigurations**
> ListConfigurationsResponse ListConfigurations (string environmentId, string name)

List configurations.

Lists existing configurations for the service instance.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class ListConfigurationsExample
    {
        public void main()
        {
            
            var apiInstance = new ConfigurationsAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var name = name_example;  // string | Find configurations with the given name. (optional) 

            try
            {
                // List configurations.
                ListConfigurationsResponse result = apiInstance.ListConfigurations(environmentId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationsAPI.ListConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environmentId** | **string**| the ID of your environment | 
 **name** | **string**| Find configurations with the given name. | [optional] 

### Return type

[**ListConfigurationsResponse**](ListConfigurationsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateconfiguration"></a>
# **UpdateConfiguration**
> Configuration UpdateConfiguration (string environmentId, string configurationId, Configuration configuration)

Update a configuration.

Replaces an existing configuration.   * Completely replaces the original configuration.   * The `configuration_id`, `updated`, and `created` fields are accepted in the request, but they are ignored, and an error is not generated. It is also acceptable for users to submit an updated configuration with none of the three properties.   * Documents are processed with a snapshot of the configuration as it was at the time the document was submitted to be ingested. This means that already submitted documents will not see any updates made to the configuration.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class UpdateConfigurationExample
    {
        public void main()
        {
            
            var apiInstance = new ConfigurationsAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var configurationId = configurationId_example;  // string | the ID of your configuration
            var configuration = new Configuration(); // Configuration | Input a JSON object that enables you to update and customize how your data is ingested and what enrichments are added to your data.  The `name` parameter is required and must be unique within the current `environment`. All other properties are optional, but if they are omitted  the default values replace the current value of each omitted property.  If the input configuration contains the `configuration_id`, `created`, or `updated` properties, they are ignored and overridden by the system, and an error is not returned so that the overridden fields do not need to be removed when updating a configuration.   The configuration can contain unrecognized JSON fields. Any such fields are ignored and do not generate an error. This makes it easier to use newer configuration files with older versions of the API and the service. It also makes it possible for the tooling to add additional metadata and information to the configuration.

            try
            {
                // Update a configuration.
                Configuration result = apiInstance.UpdateConfiguration(environmentId, configurationId, configuration);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationsAPI.UpdateConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environmentId** | **string**| the ID of your environment | 
 **configurationId** | **string**| the ID of your configuration | 
 **configuration** | [**Configuration**](Configuration.md)| Input a JSON object that enables you to update and customize how your data is ingested and what enrichments are added to your data.  The `name` parameter is required and must be unique within the current `environment`. All other properties are optional, but if they are omitted  the default values replace the current value of each omitted property.  If the input configuration contains the `configuration_id`, `created`, or `updated` properties, they are ignored and overridden by the system, and an error is not returned so that the overridden fields do not need to be removed when updating a configuration.   The configuration can contain unrecognized JSON fields. Any such fields are ignored and do not generate an error. This makes it easier to use newer configuration files with older versions of the API and the service. It also makes it possible for the tooling to add additional metadata and information to the configuration. | 

### Return type

[**Configuration**](Configuration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

