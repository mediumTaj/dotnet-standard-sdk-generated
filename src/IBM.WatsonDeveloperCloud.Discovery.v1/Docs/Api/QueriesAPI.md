# .IBM.WatsonDeveloperCloud.Discovery.v1.QueriesAPI

All URIs are relative to *https://localhost/discovery/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Query**](QueriesAPI.md#query) | **GET** /v1/environments/{environmentId}/collections/{collectionId}/query | Query documents.
[**QueryNotices**](QueriesAPI.md#querynotices) | **GET** /v1/environments/{environmentId}/collections/{collectionId}/notices | 


<a name="query"></a>
# **Query**
> QueryResponse Query (string environmentId, string collectionId, string filter, string query, string naturalLanguageQuery, bool? passages, string aggregation, int? count, List<string> _return, int? offset, string sort, bool? highlight)

Query documents.

See the [Discovery service documentation](https://www.ibm.com/watson/developercloud/doc/discovery/using.html) for more details.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class QueryExample
    {
        public void main()
        {
            
            var apiInstance = new QueriesAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var collectionId = collectionId_example;  // string | the ID of your collection
            var filter = filter_example;  // string | A cacheable query that limits the documents returned to exclude any documents that don't mention the query content. Filter searches are better for metadata type searches and when you are trying to get a sense of concepts in the data set. (optional) 
            var query = query_example;  // string | A query search returns all documents in your data set with full enrichments and full text, but with the most relevant documents listed first. Use a query search when you want to find the most relevant search results. You cannot use `natural_language_query` and `query` at the same time. (optional) 
            var naturalLanguageQuery = naturalLanguageQuery_example;  // string | A natural language query that returns relevant documents by utilizing training data and natural language understanding. You cannot use `natural_language_query` and `query` at the same time. (optional) 
            var passages = true;  // bool? | A passages query that returns the most relevant passages from the document. (optional) 
            var aggregation = aggregation_example;  // string | An aggregation search uses combinations of filters and query search to return an exact answer. Aggregations are useful for building applications, because you can use them to build lists, tables, and time series. For a full list of possible aggregrations, see the Query reference. (optional) 
            var count = 56;  // int? | Number of documents to return (optional)  (default to 10)
            var _return = new List<string>(); // List<string> | A comma separated list of the portion of the document hierarchy to return. (optional) 
            var offset = 56;  // int? | The number of query results to skip at the beginning. For example, if the total number of results that are returned is 10, and the offset is 8, it returns the last two results. (optional) 
            var sort = sort_example;  // string | A comma separated list of fields in the document to sort on. You can optionally specify a sort direction by prefixing the field with `-` for descending or `+` for ascending. Ascending is the default sort direction if no prefix is specified. (optional) 
            var highlight = true;  // bool? | When true a highlight field is returned for each result which contains the fields that match the query with `<em></em>` tags around the matching query terms. Defaults to false. (optional) 

            try
            {
                // Query documents.
                QueryResponse result = apiInstance.Query(environmentId, collectionId, filter, query, naturalLanguageQuery, passages, aggregation, count, _return, offset, sort, highlight);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueriesAPI.Query: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environmentId** | **string**| the ID of your environment | 
 **collectionId** | **string**| the ID of your collection | 
 **filter** | **string**| A cacheable query that limits the documents returned to exclude any documents that don't mention the query content. Filter searches are better for metadata type searches and when you are trying to get a sense of concepts in the data set. | [optional] 
 **query** | **string**| A query search returns all documents in your data set with full enrichments and full text, but with the most relevant documents listed first. Use a query search when you want to find the most relevant search results. You cannot use `natural_language_query` and `query` at the same time. | [optional] 
 **naturalLanguageQuery** | **string**| A natural language query that returns relevant documents by utilizing training data and natural language understanding. You cannot use `natural_language_query` and `query` at the same time. | [optional] 
 **passages** | **bool?**| A passages query that returns the most relevant passages from the document. | [optional] 
 **aggregation** | **string**| An aggregation search uses combinations of filters and query search to return an exact answer. Aggregations are useful for building applications, because you can use them to build lists, tables, and time series. For a full list of possible aggregrations, see the Query reference. | [optional] 
 **count** | **int?**| Number of documents to return | [optional] [default to 10]
 **_return** | [**List<string>**](string.md)| A comma separated list of the portion of the document hierarchy to return. | [optional] 
 **offset** | **int?**| The number of query results to skip at the beginning. For example, if the total number of results that are returned is 10, and the offset is 8, it returns the last two results. | [optional] 
 **sort** | **string**| A comma separated list of fields in the document to sort on. You can optionally specify a sort direction by prefixing the field with `-` for descending or `+` for ascending. Ascending is the default sort direction if no prefix is specified. | [optional] 
 **highlight** | **bool?**| When true a highlight field is returned for each result which contains the fields that match the query with `<em></em>` tags around the matching query terms. Defaults to false. | [optional] 

### Return type

[**QueryResponse**](QueryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="querynotices"></a>
# **QueryNotices**
> QueryNoticesResponse QueryNotices (string environmentId, string collectionId, string filter, string query, string naturalLanguageQuery, bool? passages, string aggregation, int? count, List<string> _return, int? offset, string sort, bool? highlight)



Queries for notices (errors or warnings) that may have been generated by the system. Currently, notices are only generated when ingesting documents. See the [Discovery service documentation](https://www.ibm.com/watson/developercloud/doc/discovery/using.html) for more details on the query language.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Discovery.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Discovery.v1.Model;

namespace Example
{
    public class QueryNoticesExample
    {
        public void main()
        {
            
            var apiInstance = new QueriesAPI();
            var environmentId = environmentId_example;  // string | the ID of your environment
            var collectionId = collectionId_example;  // string | the ID of your collection
            var filter = filter_example;  // string | A cacheable query that limits the documents returned to exclude any documents that don't mention the query content. Filter searches are better for metadata type searches and when you are trying to get a sense of concepts in the data set. (optional) 
            var query = query_example;  // string | A query search returns all documents in your data set with full enrichments and full text, but with the most relevant documents listed first. Use a query search when you want to find the most relevant search results. You cannot use `natural_language_query` and `query` at the same time. (optional) 
            var naturalLanguageQuery = naturalLanguageQuery_example;  // string | A natural language query that returns relevant documents by utilizing training data and natural language understanding. You cannot use `natural_language_query` and `query` at the same time. (optional) 
            var passages = true;  // bool? | A passages query that returns the most relevant passages from the document. (optional) 
            var aggregation = aggregation_example;  // string | An aggregation search uses combinations of filters and query search to return an exact answer. Aggregations are useful for building applications, because you can use them to build lists, tables, and time series. For a full list of possible aggregrations, see the Query reference. (optional) 
            var count = 56;  // int? | Number of documents to return (optional)  (default to 10)
            var _return = new List<string>(); // List<string> | A comma separated list of the portion of the document hierarchy to return. (optional) 
            var offset = 56;  // int? | The number of query results to skip at the beginning. For example, if the total number of results that are returned is 10, and the offset is 8, it returns the last two results. (optional) 
            var sort = sort_example;  // string | A comma separated list of fields in the document to sort on. You can optionally specify a sort direction by prefixing the field with `-` for descending or `+` for ascending. Ascending is the default sort direction if no prefix is specified. (optional) 
            var highlight = true;  // bool? | When true a highlight field is returned for each result which contains the fields that match the query with `<em></em>` tags around the matching query terms. Defaults to false. (optional) 

            try
            {
                QueryNoticesResponse result = apiInstance.QueryNotices(environmentId, collectionId, filter, query, naturalLanguageQuery, passages, aggregation, count, _return, offset, sort, highlight);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QueriesAPI.QueryNotices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **environmentId** | **string**| the ID of your environment | 
 **collectionId** | **string**| the ID of your collection | 
 **filter** | **string**| A cacheable query that limits the documents returned to exclude any documents that don't mention the query content. Filter searches are better for metadata type searches and when you are trying to get a sense of concepts in the data set. | [optional] 
 **query** | **string**| A query search returns all documents in your data set with full enrichments and full text, but with the most relevant documents listed first. Use a query search when you want to find the most relevant search results. You cannot use `natural_language_query` and `query` at the same time. | [optional] 
 **naturalLanguageQuery** | **string**| A natural language query that returns relevant documents by utilizing training data and natural language understanding. You cannot use `natural_language_query` and `query` at the same time. | [optional] 
 **passages** | **bool?**| A passages query that returns the most relevant passages from the document. | [optional] 
 **aggregation** | **string**| An aggregation search uses combinations of filters and query search to return an exact answer. Aggregations are useful for building applications, because you can use them to build lists, tables, and time series. For a full list of possible aggregrations, see the Query reference. | [optional] 
 **count** | **int?**| Number of documents to return | [optional] [default to 10]
 **_return** | [**List<string>**](string.md)| A comma separated list of the portion of the document hierarchy to return. | [optional] 
 **offset** | **int?**| The number of query results to skip at the beginning. For example, if the total number of results that are returned is 10, and the offset is 8, it returns the last two results. | [optional] 
 **sort** | **string**| A comma separated list of fields in the document to sort on. You can optionally specify a sort direction by prefixing the field with `-` for descending or `+` for ascending. Ascending is the default sort direction if no prefix is specified. | [optional] 
 **highlight** | **bool?**| When true a highlight field is returned for each result which contains the fields that match the query with `<em></em>` tags around the matching query terms. Defaults to false. | [optional] 

### Return type

[**QueryNoticesResponse**](QueryNoticesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

