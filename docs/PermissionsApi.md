# Caplinked.Api.PermissionsApi

All URIs are relative to *https://sandbox.caplinked.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPermissionsFoldersId**](PermissionsApi.md#getpermissionsfoldersid) | **GET** /permissions/folders/{id} | List subfolder permissions
[**PutPermissionsFoldersId**](PermissionsApi.md#putpermissionsfoldersid) | **PUT** /permissions/folders/{id} | Update folder permissions


<a name="getpermissionsfoldersid"></a>
# **GetPermissionsFoldersId**
> FolderList GetPermissionsFoldersId (int? id, int? workspaceId, int? groupId)

List subfolder permissions

List subfolder permissions for a group. Will return an array of subfolders under the specified folder, along with their permissions information. For is_mixed_view, is_mixed_download, and is_mixed_upload: if attribute is set to true, it indicates that at least one (but not all) child folder with view, download, or upload attributes set to true, respectively. \"All Folders\" is the parent of all other folders within the workspace; its permissions will be returned if a folder is not specified.

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetPermissionsFoldersIdExample
    {
        public void main()
        {
            var apiInstance = new PermissionsApi();
            var id = 56;  // int? | ID of folder (0 for root)
            var workspaceId = 56;  // int? | ID of workspace
            var groupId = 56;  // int? | ID of group

            try
            {
                // List subfolder permissions
                FolderList result = apiInstance.GetPermissionsFoldersId(id, workspaceId, groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionsApi.GetPermissionsFoldersId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of folder (0 for root) | 
 **workspaceId** | **int?**| ID of workspace | 
 **groupId** | **int?**| ID of group | 

### Return type

[**FolderList**](FolderList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpermissionsfoldersid"></a>
# **PutPermissionsFoldersId**
> FolderUpdate PutPermissionsFoldersId (int? id, int? workspaceId, int? groupId, string verb, string folderAction)

Update folder permissions

Update folder permissions for a group. View = TRUE, this means that group members can return the folder/file and its viewer image. Download = TRUE, this means tha that group members can create download containing the folder. Upload = TRUE, this mean that group members can create an upload object with the folder as a parent.

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PutPermissionsFoldersIdExample
    {
        public void main()
        {
            var apiInstance = new PermissionsApi();
            var id = 56;  // int? | ID of folder (0 for root)
            var workspaceId = 56;  // int? | ID of workspace
            var groupId = 56;  // int? | ID of group
            var verb = verb_example;  // string | Grant or revoke permission for folder
            var folderAction = folderAction_example;  // string | Permission type for folder

            try
            {
                // Update folder permissions
                FolderUpdate result = apiInstance.PutPermissionsFoldersId(id, workspaceId, groupId, verb, folderAction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PermissionsApi.PutPermissionsFoldersId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of folder (0 for root) | 
 **workspaceId** | **int?**| ID of workspace | 
 **groupId** | **int?**| ID of group | 
 **verb** | **string**| Grant or revoke permission for folder | 
 **folderAction** | **string**| Permission type for folder | 

### Return type

[**FolderUpdate**](FolderUpdate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

