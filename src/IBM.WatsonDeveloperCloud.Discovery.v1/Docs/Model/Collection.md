# .IBM.WatsonDeveloperCloud.Discovery.v1.Model.Collection
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CollectionId** | **string** | The unique identifier of the collection. | [optional] 
**Name** | **string** | The name of the collection. | [optional] 
**Description** | **string** | The description of the collection. | [optional] 
**Created** | [**DateTime**](DateTime.md) | The creation date of the collection in the format yyyy-MM-dd'T'HH:mmcon:ss.SSS'Z'. | [optional] 
**Updated** | [**DateTime**](DateTime.md) | The timestamp of when the collection was last updated in the format yyyy-MM-dd'T'HH:mm:ss.SSS'Z'. | [optional] 
**Status** | **string** | The status of the collection. | [optional] 
**ConfigurationId** | **string** | The unique identifier of the collection's configuration. | [optional] 
**Language** | **string** | The language of the documents stored in the collection. The only currently accepted value is en_us (U.S. English). | [optional] 
**DocumentCounts** | [**DocumentCounts**](DocumentCounts.md) | The object providing information about the documents in the collection. Present only when retrieving details of a colleciton. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

