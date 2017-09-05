# .IBM.WatsonDeveloperCloud.Conversation.v1.Model.CreateWorkspace
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the workspace. | [optional] 
**Description** | **string** | The description of the workspace. | [optional] 
**Language** | **string** | The language of the workspace. | [optional] 
**Intents** | [**array<CreateIntent>**](CreateIntent.md) | An array of objects defining the intents for the workspace. | [optional] 
**Entities** | [**array<CreateEntity>**](CreateEntity.md) | An array of objects defining the entities for the workspace. | [optional] 
**DialogNodes** | [**array<CreateDialogNode>**](CreateDialogNode.md) | An array of objects defining the nodes in the workspace dialog. | [optional] 
**Counterexamples** | [**array<CreateCounterexample>**](CreateCounterexample.md) | An array of objects defining input examples that have been marked as irrelevant input. | [optional] 
**Metadata** | **object** | Any metadata related to the workspace. | [optional] 
**LearningOptOut** | [**bool?**](boolean.md) | Whether training data from the workspace can be used by IBM for general service improvements. `true` indicates that workspace training data is not to be used. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

