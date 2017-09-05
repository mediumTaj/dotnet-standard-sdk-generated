# .IBM.WatsonDeveloperCloud.Conversation.v1.Model.WorkspaceExport
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the workspace. | 
**Description** | **string** | The description of the workspace. | 
**Language** | **string** | The language of the workspace. | 
**Metadata** | **object** | Any metadata that is required by the workspace. | 
**Created** | [**DateTime**](DateTime.md) | The timestamp for creation of the workspace. | 
**Updated** | [**DateTime**](DateTime.md) | The timestamp for the last update to the workspace. | 
**WorkspaceId** | **string** | The workspace ID. | 
**Status** | **string** | The current status of the workspace. | 
**LearningOptOut** | [**bool?**](boolean.md) | Whether training data from the workspace can be used by IBM for general service improvements. `true` indicates that workspace training data is not to be used. | [default to false]
**Intents** | [**array<IntentExport>**](IntentExport.md) | An array of intents. | [optional] 
**Entities** | [**array<EntityExport>**](EntityExport.md) | An array of entities. | [optional] 
**Counterexamples** | [**array<Counterexample>**](Counterexample.md) | An array of counterexamples. | [optional] 
**DialogNodes** | [**array<DialogNode>**](DialogNode.md) | An array of objects describing the dialog nodes in the workspace. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

