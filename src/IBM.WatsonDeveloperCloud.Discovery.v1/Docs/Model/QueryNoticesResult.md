# .IBM.WatsonDeveloperCloud.Discovery.v1.Model.QueryNoticesResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the document. | [optional] 
**Score** | **double?** | The confidence score of the result's analysis. Scores range from 0 to 1, with a higher score indicating greater confidence. | [optional] 
**Metadata** | **object** | Metadata of the document. | [optional] 
**NoticeId** | **string** | Identifies the notice. Many notices may have the same ID. This field exists so that user applications can programmatically identify a notice and take automatic corrective action. | [optional] 
**Created** | [**DateTime**](DateTime.md) | The creation date of the collection in the format yyyy-MM-dd'T'HH:mm:ss.SSS'Z'. | [optional] 
**DocumentId** | **string** | Unique identifier of the ingested document. | [optional] 
**Severity** | **string** | Severity level of the notice. | [optional] 
**Step** | **string** | Ingestion step in which the notice occurred. | [optional] 
**Description** | **string** | The description of the notice. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

