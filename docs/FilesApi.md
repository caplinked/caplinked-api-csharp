# Caplinked.Api.FilesApi

All URIs are relative to *https://sandbox.caplinked.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteFilesId**](FilesApi.md#deletefilesid) | **DELETE** /files/{id} | Delete file
[**GetFilesId**](FilesApi.md#getfilesid) | **GET** /files/{id} | Get file information
[**PostFilesIdCopy**](FilesApi.md#postfilesidcopy) | **POST** /files/{id}/copy | Copy file
[**PostFilesIdMove**](FilesApi.md#postfilesidmove) | **POST** /files/{id}/move | Move file
[**PutFilesId**](FilesApi.md#putfilesid) | **PUT** /files/{id} | Update file information
[**PutFilesUpload**](FilesApi.md#putfilesupload) | **PUT** /files/upload | Upload file


<a name="deletefilesid"></a>
# **DeleteFilesId**
> FileDelete DeleteFilesId (int? id, int? workspaceId)

Delete file

Delete file

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class DeleteFilesIdExample
    {
        public void main()
        {
            var apiInstance = new FilesApi();
            var id = 56;  // int? | ID of file to delete
            var workspaceId = 56;  // int? | ID of workspace

            try
            {
                // Delete file
                FileDelete result = apiInstance.DeleteFilesId(id, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.DeleteFilesId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of file to delete | 
 **workspaceId** | **int?**| ID of workspace | 

### Return type

[**FileDelete**](FileDelete.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfilesid"></a>
# **GetFilesId**
> FileInfoMapped GetFilesId (int? id, int? workspaceId, int? pageNumber = null)

Get file information

Get file information

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetFilesIdExample
    {
        public void main()
        {
            var apiInstance = new FilesApi();
            var id = 56;  // int? | ID of file
            var workspaceId = 56;  // int? | ID of workspace
            var pageNumber = 56;  // int? | Page number of file (for viewer tokens) (optional)  (default to 1)

            try
            {
                // Get file information
                FileInfoMapped result = apiInstance.GetFilesId(id, workspaceId, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.GetFilesId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of file | 
 **workspaceId** | **int?**| ID of workspace | 
 **pageNumber** | **int?**| Page number of file (for viewer tokens) | [optional] [default to 1]

### Return type

[**FileInfoMapped**](FileInfoMapped.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfilesidcopy"></a>
# **PostFilesIdCopy**
> FileCopyMove PostFilesIdCopy (int? id, int? workspaceId, int? destinationFolderId)

Copy file

Copy file into another folder (existing file will not be modified)

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PostFilesIdCopyExample
    {
        public void main()
        {
            var apiInstance = new FilesApi();
            var id = 56;  // int? | ID of file to copy
            var workspaceId = 56;  // int? | ID of workspace
            var destinationFolderId = 56;  // int? | ID of destination parent folder

            try
            {
                // Copy file
                FileCopyMove result = apiInstance.PostFilesIdCopy(id, workspaceId, destinationFolderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.PostFilesIdCopy: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of file to copy | 
 **workspaceId** | **int?**| ID of workspace | 
 **destinationFolderId** | **int?**| ID of destination parent folder | 

### Return type

[**FileCopyMove**](FileCopyMove.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfilesidmove"></a>
# **PostFilesIdMove**
> FileCopyMove PostFilesIdMove (int? id, int? workspaceId, int? destinationFolderId)

Move file

Move file into another folder

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PostFilesIdMoveExample
    {
        public void main()
        {
            var apiInstance = new FilesApi();
            var id = 56;  // int? | ID of file to move
            var workspaceId = 56;  // int? | ID of workspace
            var destinationFolderId = 56;  // int? | ID of destination parent folder

            try
            {
                // Move file
                FileCopyMove result = apiInstance.PostFilesIdMove(id, workspaceId, destinationFolderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.PostFilesIdMove: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of file to move | 
 **workspaceId** | **int?**| ID of workspace | 
 **destinationFolderId** | **int?**| ID of destination parent folder | 

### Return type

[**FileCopyMove**](FileCopyMove.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfilesid"></a>
# **PutFilesId**
> FileInfoMapped PutFilesId (int? id, int? workspaceId, string fileTitle = null, int? fileIndex = null)

Update file information

Update file information

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PutFilesIdExample
    {
        public void main()
        {
            var apiInstance = new FilesApi();
            var id = 56;  // int? | ID of file
            var workspaceId = 56;  // int? | ID of workspace
            var fileTitle = fileTitle_example;  // string | Title of file (optional) 
            var fileIndex = 56;  // int? | Index number of file within current folder scope (integer) (optional) 

            try
            {
                // Update file information
                FileInfoMapped result = apiInstance.PutFilesId(id, workspaceId, fileTitle, fileIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.PutFilesId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of file | 
 **workspaceId** | **int?**| ID of workspace | 
 **fileTitle** | **string**| Title of file | [optional] 
 **fileIndex** | **int?**| Index number of file within current folder scope (integer) | [optional] 

### Return type

[**FileInfoMapped**](FileInfoMapped.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfilesupload"></a>
# **PutFilesUpload**
> FileInfoCompact PutFilesUpload (int? workspaceId, int? folderId, string fileName)

Upload file

Create or update a file with the same file name. Request body should be the file body itself as binary data.

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PutFilesUploadExample
    {
        public void main()
        {
            var apiInstance = new FilesApi();
            var workspaceId = 56;  // int? | Workspace ID
            var folderId = 56;  // int? | Folder ID
            var fileName = fileName_example;  // string | File name

            try
            {
                // Upload file
                FileInfoCompact result = apiInstance.PutFilesUpload(workspaceId, folderId, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilesApi.PutFilesUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| Workspace ID | 
 **folderId** | **int?**| Folder ID | 
 **fileName** | **string**| File name | 

### Return type

[**FileInfoCompact**](FileInfoCompact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

