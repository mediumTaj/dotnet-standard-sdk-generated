# .IBM.WatsonDeveloperCloud.Discovery.v1.Model.LanguageEnrichmentOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Extract** | **string** | A comma sepeated list of analyses that should be applied when using the `alchemy_language` enrichment. See the the service documentation for details on each extract option.  Possible values include:    * entity   * keyword   * taxonomy   * concept   * relation   * doc-sentiment   * doc-emotion   * typed-rels. | [optional] [default to "entity,keyword,concept,taxonomy"]
**Sentiment** | **bool?** |  | [optional] [default to false]
**Quotations** | **bool?** |  | [optional] [default to false]
**ShowSourceText** | **bool?** |  | [optional] [default to false]
**HierarchicalTypedRelations** | **bool?** |  | [optional] [default to false]
**Model** | **string** | Required when using the `typed-rel` extract option. Should be set to the ID of a previously published custom Watson Knowledge Studio model. | [optional] 
**Language** | **string** | If provided, then do not attempt to detect the language of the input document. Instead, assume the language is the one specified in this field.  You can set this property to work around `unsupported-text-language` errors.  Supported languages include English, German, French, Italian, Portuguese, Russian, Spanish and Swedish. Supported language codes are the ISO-639-1, ISO-639-2, ISO-639-3, and the plain english name of the language (e.g. "russian"). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

