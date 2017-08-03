# Caplinked.Api.WorkspacesApi

All URIs are relative to *https://sandbox.caplinked.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWorkspaces**](WorkspacesApi.md#getworkspaces) | **GET** /workspaces | List all workspaces for a team
[**GetWorkspacesId**](WorkspacesApi.md#getworkspacesid) | **GET** /workspaces/{id} | Get workspace information
[**PostWorkspaces**](WorkspacesApi.md#postworkspaces) | **POST** /workspaces | Create workspace
[**PutWorkspacesId**](WorkspacesApi.md#putworkspacesid) | **PUT** /workspaces/{id} | Update workspace


<a name="getworkspaces"></a>
# **GetWorkspaces**
> Workspace GetWorkspaces (int? teamId)

List all workspaces for a team

List all workspaces for a team

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetWorkspacesExample
    {
        public void main()
        {
            var apiInstance = new WorkspacesApi();
            var teamId = 56;  // int? | ID of team from which to list workspaces

            try
            {
                // List all workspaces for a team
                Workspace result = apiInstance.GetWorkspaces(teamId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.GetWorkspaces: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| ID of team from which to list workspaces | 

### Return type

[**Workspace**](Workspace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacesid"></a>
# **GetWorkspacesId**
> Workspace GetWorkspacesId (int? id)

Get workspace information

Get workspace information

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetWorkspacesIdExample
    {
        public void main()
        {
            var apiInstance = new WorkspacesApi();
            var id = 56;  // int? | ID of workspace

            try
            {
                // Get workspace information
                Workspace result = apiInstance.GetWorkspacesId(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.GetWorkspacesId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of workspace | 

### Return type

[**Workspace**](Workspace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postworkspaces"></a>
# **PostWorkspaces**
> Workspace PostWorkspaces (int? teamId, string workspaceName)

Create workspace

Create workspace. Workspace creator will be added to Workspace Admins group.

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PostWorkspacesExample
    {
        public void main()
        {
            var apiInstance = new WorkspacesApi();
            var teamId = 56;  // int? | ID of parent team for this workspace
            var workspaceName = workspaceName_example;  // string | Name of workspace to create

            try
            {
                // Create workspace
                Workspace result = apiInstance.PostWorkspaces(teamId, workspaceName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.PostWorkspaces: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| ID of parent team for this workspace | 
 **workspaceName** | **string**| Name of workspace to create | 

### Return type

[**Workspace**](Workspace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putworkspacesid"></a>
# **PutWorkspacesId**
> Workspace PutWorkspacesId (int? id, string workspaceName = null)

Update workspace

Update workspace

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PutWorkspacesIdExample
    {
        public void main()
        {
            var apiInstance = new WorkspacesApi();
            var id = 56;  // int? | ID of workspace to update
            var workspaceName = workspaceName_example;  // string | Name of workspace to update (optional) 

            try
            {
                // Update workspace
                Workspace result = apiInstance.PutWorkspacesId(id, workspaceName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.PutWorkspacesId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of workspace to update | 
 **workspaceName** | **string**| Name of workspace to update | [optional] 

### Return type

[**Workspace**](Workspace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

