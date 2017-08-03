# Caplinked.Api.ActivitiesApi

All URIs are relative to *https://sandbox.caplinked.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetActivitiesWorkspaceWorkspaceId**](ActivitiesApi.md#getactivitiesworkspaceworkspaceid) | **GET** /activities/workspace/{workspace_id} | Get workspace activities


<a name="getactivitiesworkspaceworkspaceid"></a>
# **GetActivitiesWorkspaceWorkspaceId**
> Activity GetActivitiesWorkspaceWorkspaceId (int? workspaceId, int? page = null, int? perPage = null, int? userId = null)

Get workspace activities

Get workspace activities

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetActivitiesWorkspaceWorkspaceIdExample
    {
        public void main()
        {
            var apiInstance = new ActivitiesApi();
            var workspaceId = 56;  // int? | ID of the workspace
            var page = 56;  // int? | Page number of results (optional)  (default to 1)
            var perPage = 56;  // int? | Per page number of results. Options: 25, 50, 75, 100 (optional)  (default to 100)
            var userId = 56;  // int? | ID of the user  (optional) 

            try
            {
                // Get workspace activities
                Activity result = apiInstance.GetActivitiesWorkspaceWorkspaceId(workspaceId, page, perPage, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.GetActivitiesWorkspaceWorkspaceId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| ID of the workspace | 
 **page** | **int?**| Page number of results | [optional] [default to 1]
 **perPage** | **int?**| Per page number of results. Options: 25, 50, 75, 100 | [optional] [default to 100]
 **userId** | **int?**| ID of the user  | [optional] 

### Return type

[**Activity**](Activity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

