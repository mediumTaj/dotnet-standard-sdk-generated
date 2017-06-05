# .IBM.WatsonDeveloperCloud.Discovery.v1.Model.Enrichment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Describes what the enrichment step does. | [optional] [default to ""]
**DestinationField** | **string** | Field where enrichments will be stored. This field must already exist or be at most 1 level deeper than an existing field. For example, if `text` is a top-level field with no sub-fields, `text.foo` is a valid destination but `text.foo.bar` is not. | 
**SourceField** | **string** | Field to be enriched. | 
**Overwrite** | **bool?** | Indicates that the enrichments will overwrite the destination_field field if it already exists. | [optional] [default to false]
**EnrichmentName** | **string** | Name of the enrichment service to call. Currently the only valid value is `alchemy_language`. | 
**IgnoreDownstreamErrors** | **bool?** | If true, then most errors generated during the enrichment process will be treated as warnings and will not cause the document to fail processing. | [optional] [default to false]
**Options** | [**EnrichmentOptions**](EnrichmentOptions.md) | A list of options specific to the enrichment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

