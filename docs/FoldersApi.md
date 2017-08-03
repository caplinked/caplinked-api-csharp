# Caplinked.Api.FoldersApi

All URIs are relative to *https://sandbox.caplinked.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteFoldersId**](FoldersApi.md#deletefoldersid) | **DELETE** /folders/{id} | Delete folder
[**GetFoldersId**](FoldersApi.md#getfoldersid) | **GET** /folders/{id} | Get folder information
[**PostFolders**](FoldersApi.md#postfolders) | **POST** /folders | Create new folder
[**PostFoldersIdCopy**](FoldersApi.md#postfoldersidcopy) | **POST** /folders/{id}/copy | Copy folder
[**PostFoldersIdMove**](FoldersApi.md#postfoldersidmove) | **POST** /folders/{id}/move | Move folder
[**PutFoldersId**](FoldersApi.md#putfoldersid) | **PUT** /folders/{id} | Update folder information


<a name="deletefoldersid"></a>
# **DeleteFoldersId**
> FolderDelete DeleteFoldersId (int? id, string workspaceId)

Delete folder

Delete folder

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class DeleteFoldersIdExample
    {
        public void main()
        {
            var apiInstance = new FoldersApi();
            var id = 56;  // int? | ID of folder to delete
            var workspaceId = workspaceId_example;  // string | ID of workspace

            try
            {
                // Delete folder
                FolderDelete result = apiInstance.DeleteFoldersId(id, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.DeleteFoldersId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of folder to delete | 
 **workspaceId** | **string**| ID of workspace | 

### Return type

[**FolderDelete**](FolderDelete.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfoldersid"></a>
# **GetFoldersId**
> FolderContent GetFoldersId (int? id, string workspaceId)

Get folder information

Get folder information

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetFoldersIdExample
    {
        public void main()
        {
            var apiInstance = new FoldersApi();
            var id = 56;  // int? | ID of folder
            var workspaceId = workspaceId_example;  // string | ID of workspace

            try
            {
                // Get folder information
                FolderContent result = apiInstance.GetFoldersId(id, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFoldersId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of folder | 
 **workspaceId** | **string**| ID of workspace | 

### Return type

[**FolderContent**](FolderContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfolders"></a>
# **PostFolders**
> FolderMeta PostFolders (string workspaceId, string name, int? parentId = null)

Create new folder

Create new folder

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PostFoldersExample
    {
        public void main()
        {
            var apiInstance = new FoldersApi();
            var workspaceId = workspaceId_example;  // string | ID of workspace
            var name = name_example;  // string | Name of new folder
            var parentId = 56;  // int? | ID of parent folder (defaults to root folder [id=0]) (optional)  (default to 0)

            try
            {
                // Create new folder
                FolderMeta result = apiInstance.PostFolders(workspaceId, name, parentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.PostFolders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **string**| ID of workspace | 
 **name** | **string**| Name of new folder | 
 **parentId** | **int?**| ID of parent folder (defaults to root folder [id&#x3D;0]) | [optional] [default to 0]

### Return type

[**FolderMeta**](FolderMeta.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfoldersidcopy"></a>
# **PostFoldersIdCopy**
> FolderCopyMove PostFoldersIdCopy (int? id, string workspaceId, int? destinationFolderId)

Copy folder

Copy folder into another folder (existing folder will not be modified). The copied folder will inherit group folder permissions from its new parent folder.

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PostFoldersIdCopyExample
    {
        public void main()
        {
            var apiInstance = new FoldersApi();
            var id = 56;  // int? | ID of folder to copy
            var workspaceId = workspaceId_example;  // string | ID of workspace
            var destinationFolderId = 56;  // int? | ID of destination parent folder

            try
            {
                // Copy folder
                FolderCopyMove result = apiInstance.PostFoldersIdCopy(id, workspaceId, destinationFolderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.PostFoldersIdCopy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of folder to copy | 
 **workspaceId** | **string**| ID of workspace | 
 **destinationFolderId** | **int?**| ID of destination parent folder | 

### Return type

[**FolderCopyMove**](FolderCopyMove.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfoldersidmove"></a>
# **PostFoldersIdMove**
> FolderCopyMove PostFoldersIdMove (int? id, string workspaceId, int? destinationFolderId)

Move folder

Move folder into another folder

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PostFoldersIdMoveExample
    {
        public void main()
        {
            var apiInstance = new FoldersApi();
            var id = 56;  // int? | ID of folder to move
            var workspaceId = workspaceId_example;  // string | ID of workspace
            var destinationFolderId = 56;  // int? | ID of destination parent folder

            try
            {
                // Move folder
                FolderCopyMove result = apiInstance.PostFoldersIdMove(id, workspaceId, destinationFolderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.PostFoldersIdMove: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of folder to move | 
 **workspaceId** | **string**| ID of workspace | 
 **destinationFolderId** | **int?**| ID of destination parent folder | 

### Return type

[**FolderCopyMove**](FolderCopyMove.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfoldersid"></a>
# **PutFoldersId**
> FolderMeta PutFoldersId (int? id, string workspaceId, string folderName = null, int? folderIndex = null)

Update folder information

Update folder information

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PutFoldersIdExample
    {
        public void main()
        {
            var apiInstance = new FoldersApi();
            var id = 56;  // int? | Update folder name and index
            var workspaceId = workspaceId_example;  // string | ID of workspace
            var folderName = folderName_example;  // string | Name of folder (optional) 
            var folderIndex = 56;  // int? | Index number of folder within current folder scope (integer) (optional) 

            try
            {
                // Update folder information
                FolderMeta result = apiInstance.PutFoldersId(id, workspaceId, folderName, folderIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.PutFoldersId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Update folder name and index | 
 **workspaceId** | **string**| ID of workspace | 
 **folderName** | **string**| Name of folder | [optional] 
 **folderIndex** | **int?**| Index number of folder within current folder scope (integer) | [optional] 

### Return type

[**FolderMeta**](FolderMeta.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

