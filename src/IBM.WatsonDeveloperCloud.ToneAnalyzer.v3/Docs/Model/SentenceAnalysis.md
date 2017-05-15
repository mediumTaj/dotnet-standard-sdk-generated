# .IBM.WatsonDeveloperCloud.ToneAnalyzer.v3.Model.SentenceAnalysis
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SentenceId** | **int?** | A unique number identifying this sentence within this document. Reserved for future use (when sentences need to be referred from different places). | 
**InputFrom** | **int?** | Index of the character in the document where this sentence starts. | 
**InputTo** | **int?** | Index of the character in the document after the end of this sentence (input_to minus input_from is the length of this sentence in characters). | 
**Text** | **string** | The text in this sentence - as just taken from the input text from input_from to input_to. | 
**ToneCategories** | [**List<ToneCategory>**](ToneCategory.md) | Tone analysis results for this sentence; divided in three Tone categories: Social Tone, Emotion Tone and Writing Tone. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

