# .IBM.WatsonDeveloperCloud.Discovery.v1.Model.ModelEnvironment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnvironmentId** | **string** | Unique identifier for this environment. | [optional] 
**Name** | **string** | Name that identifies this environment. | [optional] [default to ""]
**Description** | **string** | Description of the environment. | [optional] [default to ""]
**Created** | [**DateTime**](DateTime.md) | Creation date of the environment, in the format yyyy-MM-dd'T'HH:mm:ss.SSS'Z'. | [optional] 
**Updated** | [**DateTime**](DateTime.md) | Date of most recent environment update, in the format yyyy-MM-dd'T'HH:mm:ss.SSS'Z'. | [optional] 
**Status** | **string** | Status of the environment. | [optional] 
**_ReadOnly** | **bool?** | If true, then the environment contains read-only collections which are maintained by IBM. | [optional] 
**Size** | **int?** | Size of the environment. | [optional] [default to 1]
**IndexCapacity** | [**IndexCapacity**](IndexCapacity.md) | Object containing information about disk and memory usage. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

