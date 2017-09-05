# .IBM.WatsonDeveloperCloud.Conversation.v1.DialogNodesAPI

All URIs are relative to *https://localhost/conversation/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDialogNode**](DialogNodesAPI.md#createdialognode) | **POST** /v1/workspaces/{workspaceId}/dialog_nodes | Create dialog node.
[**DeleteDialogNode**](DialogNodesAPI.md#deletedialognode) | **DELETE** /v1/workspaces/{workspaceId}/dialogNodes/{dialogNode} | Delete dialog node.
[**GetDialogNode**](DialogNodesAPI.md#getdialognode) | **GET** /v1/workspaces/{workspaceId}/dialogNodes/{dialogNode} | Get dialog node.
[**ListDialogNodes**](DialogNodesAPI.md#listdialognodes) | **GET** /v1/workspaces/{workspaceId}/dialog_nodes | List dialog nodes.
[**UpdateDialogNode**](DialogNodesAPI.md#updatedialognode) | **POST** /v1/workspaces/{workspaceId}/dialogNodes/{dialogNode} | Update dialog node.


<a name="createdialognode"></a>
# **CreateDialogNode**
> DialogNode CreateDialogNode (string workspaceId, CreateDialogNode properties)

Create dialog node.

Create a dialog node.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Conversation.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Conversation.v1.Model;

namespace Example
{
    public class CreateDialogNodeExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DialogNodesAPI();
            var workspaceId = workspaceId_example;  // string | The workspace ID.
            var properties = new CreateDialogNode(); // CreateDialogNode | A CreateDialogNode object defining the content of the new dialog node.

            try
            {
                // Create dialog node.
                DialogNode result = apiInstance.CreateDialogNode(workspaceId, properties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DialogNodesAPI.CreateDialogNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **string**| The workspace ID. | 
 **properties** | [**CreateDialogNode**](CreateDialogNode.md)| A CreateDialogNode object defining the content of the new dialog node. | 

### Return type

[**DialogNode**](DialogNode.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedialognode"></a>
# **DeleteDialogNode**
> object DeleteDialogNode (string workspaceId, string dialogNode)

Delete dialog node.

Delete a dialog node from the workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Conversation.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Conversation.v1.Model;

namespace Example
{
    public class DeleteDialogNodeExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DialogNodesAPI();
            var workspaceId = workspaceId_example;  // string | The workspace ID.
            var dialogNode = dialogNode_example;  // string | The dialog node ID (for example, `get_order`).

            try
            {
                // Delete dialog node.
                object result = apiInstance.DeleteDialogNode(workspaceId, dialogNode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DialogNodesAPI.DeleteDialogNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **string**| The workspace ID. | 
 **dialogNode** | **string**| The dialog node ID (for example, `get_order`). | 

### Return type

**object**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdialognode"></a>
# **GetDialogNode**
> DialogNode GetDialogNode (string workspaceId, string dialogNode)

Get dialog node.

Get information about a dialog node.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Conversation.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Conversation.v1.Model;

namespace Example
{
    public class GetDialogNodeExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DialogNodesAPI();
            var workspaceId = workspaceId_example;  // string | The workspace ID.
            var dialogNode = dialogNode_example;  // string | The dialog node ID (for example, `get_order`).

            try
            {
                // Get dialog node.
                DialogNode result = apiInstance.GetDialogNode(workspaceId, dialogNode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DialogNodesAPI.GetDialogNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **string**| The workspace ID. | 
 **dialogNode** | **string**| The dialog node ID (for example, `get_order`). | 

### Return type

[**DialogNode**](DialogNode.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdialognodes"></a>
# **ListDialogNodes**
> DialogNodeCollection ListDialogNodes (string workspaceId, int? pageLimit, bool? includeCount, string sort, string cursor)

List dialog nodes.

List the dialog nodes in the workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Conversation.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Conversation.v1.Model;

namespace Example
{
    public class ListDialogNodesExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DialogNodesAPI();
            var workspaceId = workspaceId_example;  // string | The workspace ID.
            var pageLimit = 56;  // int? | The number of records to return in each page of results. The default page limit is 100. (optional) 
            var includeCount = true;  // bool? | Whether to include information about the number of records returned. (optional)  (default to false)
            var sort = sort_example;  // string | Sorts the response according to the value of the specified property, in ascending or descending order. (optional) 
            var cursor = cursor_example;  // string | A token identifying the last value from the previous page of results. (optional) 

            try
            {
                // List dialog nodes.
                DialogNodeCollection result = apiInstance.ListDialogNodes(workspaceId, pageLimit, includeCount, sort, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DialogNodesAPI.ListDialogNodes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **string**| The workspace ID. | 
 **pageLimit** | **int?**| The number of records to return in each page of results. The default page limit is 100. | [optional] 
 **includeCount** | **bool?**| Whether to include information about the number of records returned. | [optional] [default to false]
 **sort** | **string**| Sorts the response according to the value of the specified property, in ascending or descending order. | [optional] 
 **cursor** | **string**| A token identifying the last value from the previous page of results. | [optional] 

### Return type

[**DialogNodeCollection**](DialogNodeCollection.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedialognode"></a>
# **UpdateDialogNode**
> DialogNode UpdateDialogNode (string workspaceId, string dialogNode, UpdateDialogNode properties)

Update dialog node.

Update information for a dialog node.

### Example
```csharp
using System;
using System.Diagnostics;
using .IBM.WatsonDeveloperCloud.Conversation.v1;
using .Client;
using .IBM.WatsonDeveloperCloud.Conversation.v1.Model;

namespace Example
{
    public class UpdateDialogNodeExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DialogNodesAPI();
            var workspaceId = workspaceId_example;  // string | The workspace ID.
            var dialogNode = dialogNode_example;  // string | The dialog node ID (for example, `get_order`).
            var properties = new UpdateDialogNode(); // UpdateDialogNode | An UpdateDialogNode object defining the new contents of the dialog node.

            try
            {
                // Update dialog node.
                DialogNode result = apiInstance.UpdateDialogNode(workspaceId, dialogNode, properties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DialogNodesAPI.UpdateDialogNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **string**| The workspace ID. | 
 **dialogNode** | **string**| The dialog node ID (for example, `get_order`). | 
 **properties** | [**UpdateDialogNode**](UpdateDialogNode.md)| An UpdateDialogNode object defining the new contents of the dialog node. | 

### Return type

[**DialogNode**](DialogNode.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

