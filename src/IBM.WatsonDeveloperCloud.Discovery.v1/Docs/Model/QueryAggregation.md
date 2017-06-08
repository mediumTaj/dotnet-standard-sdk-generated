# .IBM.WatsonDeveloperCloud.Discovery.v1.Model.QueryAggregation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of aggregation command used. e.g. term, filter, max, min, etc. | [optional] 
**Field** | **string** | The field where the aggregation is located in the document. | [optional] 
**Results** | [**List<AggregationResult>**](AggregationResult.md) |  | [optional] 
**Match** | **string** | The match the aggregated results queried for. | [optional] 
**MatchingResults** | [**long?**](Long.md) | Number of matching results. | [optional] 
**Aggregations** | [**List<QueryAggregation>**](QueryAggregation.md) | Aggregations returned by the Discovery service. | [optional] 
**Interval** | [**long?**](Long.md) | Interval specified by using aggregation type 'timeslice'. | [optional] 
**Value** | **double?** | Value of the aggregation. (For 'max' and 'min' type). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

