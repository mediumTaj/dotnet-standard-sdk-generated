# .IBM.WatsonDeveloperCloud.Discovery.v1.Model.Configuration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigurationId** | **string** | The unique identifier of the configuration. | [optional] 
**Name** | **string** | The name of the configuration. | [default to ""]
**Created** | [**DateTime**](DateTime.md) | The creation date of the configuration in the format yyyy-MM-dd'T'HH:mm:ss.SSS'Z'. | [optional] 
**Updated** | [**DateTime**](DateTime.md) | The timestamp of when the configuration was last updated in the format yyyy-MM-dd'T'HH:mm:ss.SSS'Z'. | [optional] 
**Description** | **string** | The description of the configuration, if available. | [optional] 
**Conversions** | [**Conversions**](Conversions.md) | The document conversion settings for the configuration. | [optional] 
**Enrichments** | [**List<Enrichment>**](Enrichment.md) | An array of document enrichment settings for the configuration. | [optional] 
**Normalizations** | [**List<NormalizationOperation>**](NormalizationOperation.md) | Defines operations that can be used to transform the final output JSON into a normalized form. Operations are executed in the order that they appear in the array. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

