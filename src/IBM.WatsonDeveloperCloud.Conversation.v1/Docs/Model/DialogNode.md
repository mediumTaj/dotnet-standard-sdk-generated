# .IBM.WatsonDeveloperCloud.Conversation.v1.Model.DialogNode
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DialogNodeId** | **string** | The dialog node ID. | 
**Description** | **string** | The description of the dialog node. | 
**Conditions** | **string** | The condition that triggers the dialog node. | 
**Parent** | **string** | The ID of the parent dialog node. | 
**PreviousSibling** | **string** | The ID of the previous sibling dialog node. | 
**Output** | **object** | The output of the dialog node. | 
**Context** | **object** | The context (if defined) for the dialog node. | 
**Metadata** | **object** | The metadata (if any) for the dialog node. | 
**NextStep** | [**DialogNodeNextStep**](DialogNodeNextStep.md) | The next step to execute following this dialog node. | 
**Created** | [**DateTime**](DateTime.md) | The timestamp for creation of the dialog node. | 
**Updated** | [**DateTime**](DateTime.md) | The timestamp for the most recent update to the dialog node. | [optional] 
**Actions** | [**array<DialogNodeAction>**](DialogNodeAction.md) | The actions for the dialog node. | [optional] 
**Title** | **string** | The alias used to identify the dialog node. | 
**NodeType** | **string** | How the dialog node is processed. | [optional] 
**EventName** | **string** | How an `event_handler` node is processed. | [optional] 
**Variable** | **string** | The location in the dialog context where output is stored. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

