# .IBM.WatsonDeveloperCloud.Conversation.v1.Model.UpdateDialogNode
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DialogNode** | **string** | The dialog node ID. | 
**Description** | **string** | The description of the dialog node. | [optional] 
**Conditions** | **string** | The condition that will trigger the dialog node. | [optional] 
**Parent** | **string** | The ID of the parent dialog node (if any). | [optional] 
**PreviousSibling** | **string** | The previous dialog node. | [optional] 
**Output** | **object** | The output of the dialog node. | [optional] 
**Context** | **object** | The context for the dialog node. | [optional] 
**Metadata** | **object** | The metadata for the dialog node. | [optional] 
**NextStep** | [**DialogNodeNextStep**](DialogNodeNextStep.md) | The next step to execute following this dialog node. | [optional] 
**Title** | **string** | The alias used to identify the dialog node. | [optional] 
**NodeType** | **string** | How the node is processed. | [optional] 
**EventName** | **string** | How an `event_handler` node is processed. | [optional] 
**Variable** | **string** | The location in the dialog context where output is stored. | [optional] 
**Actions** | [**array<DialogNodeAction>**](DialogNodeAction.md) | The actions for the dialog node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

