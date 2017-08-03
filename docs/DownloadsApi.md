# Caplinked.Api.DownloadsApi

All URIs are relative to *https://sandbox.caplinked.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteDownloadsId**](DownloadsApi.md#deletedownloadsid) | **DELETE** /downloads/{id} | Delete download
[**GetDownloadsFileFileId**](DownloadsApi.md#getdownloadsfilefileid) | **GET** /downloads/file/{file_id} | Get single file
[**GetDownloadsId**](DownloadsApi.md#getdownloadsid) | **GET** /downloads/{id} | Get zip
[**GetDownloadsStatusWorkspaceId**](DownloadsApi.md#getdownloadsstatusworkspaceid) | **GET** /downloads/status/{workspace_id} | Get status of downloads for current user
[**PostDownloads**](DownloadsApi.md#postdownloads) | **POST** /downloads | Create zip file


<a name="deletedownloadsid"></a>
# **DeleteDownloadsId**
> Delete DeleteDownloadsId (int? id, int? workspaceId)

Delete download

Delete download

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class DeleteDownloadsIdExample
    {
        public void main()
        {
            var apiInstance = new DownloadsApi();
            var id = 56;  // int? | ID of download to delete
            var workspaceId = 56;  // int? | ID of Workspace

            try
            {
                // Delete download
                Delete result = apiInstance.DeleteDownloadsId(id, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadsApi.DeleteDownloadsId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of download to delete | 
 **workspaceId** | **int?**| ID of Workspace | 

### Return type

[**Delete**](Delete.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdownloadsfilefileid"></a>
# **GetDownloadsFileFileId**
> ExpiringUrl GetDownloadsFileFileId (int? fileId, int? workspaceId)

Get single file

Download single file without DRM applied

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetDownloadsFileFileIdExample
    {
        public void main()
        {
            var apiInstance = new DownloadsApi();
            var fileId = 56;  // int? | ID of file to download
            var workspaceId = 56;  // int? | ID of Workspace

            try
            {
                // Get single file
                ExpiringUrl result = apiInstance.GetDownloadsFileFileId(fileId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadsApi.GetDownloadsFileFileId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileId** | **int?**| ID of file to download | 
 **workspaceId** | **int?**| ID of Workspace | 

### Return type

[**ExpiringUrl**](ExpiringUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdownloadsid"></a>
# **GetDownloadsId**
> ExpiringUrl GetDownloadsId (int? id, int? workspaceId)

Get zip

Get a zip file of a previously created download object

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetDownloadsIdExample
    {
        public void main()
        {
            var apiInstance = new DownloadsApi();
            var id = 56;  // int? | ID of download
            var workspaceId = 56;  // int? | ID of Workspace

            try
            {
                // Get zip
                ExpiringUrl result = apiInstance.GetDownloadsId(id, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadsApi.GetDownloadsId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of download | 
 **workspaceId** | **int?**| ID of Workspace | 

### Return type

[**ExpiringUrl**](ExpiringUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdownloadsstatusworkspaceid"></a>
# **GetDownloadsStatusWorkspaceId**
> Meta GetDownloadsStatusWorkspaceId (int? workspaceId)

Get status of downloads for current user

Get status of downloads created by current user within a specified workspace

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetDownloadsStatusWorkspaceIdExample
    {
        public void main()
        {
            var apiInstance = new DownloadsApi();
            var workspaceId = 56;  // int? | ID of Workspace

            try
            {
                // Get status of downloads for current user
                Meta result = apiInstance.GetDownloadsStatusWorkspaceId(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadsApi.GetDownloadsStatusWorkspaceId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| ID of Workspace | 

### Return type

[**Meta**](Meta.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdownloads"></a>
# **PostDownloads**
> Meta PostDownloads (int? workspaceId, List<int?> downloadFolderIds = null, List<int?> downloadFileIds = null)

Create zip file

Create download object containing folders and/or files

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PostDownloadsExample
    {
        public void main()
        {
            var apiInstance = new DownloadsApi();
            var workspaceId = 56;  // int? | ID of Workspace
            var downloadFolderIds = new List<int?>(); // List<int?> | IDs of folders to include in download (optional) 
            var downloadFileIds = new List<int?>(); // List<int?> | IDs of files to include in download (optional) 

            try
            {
                // Create zip file
                Meta result = apiInstance.PostDownloads(workspaceId, downloadFolderIds, downloadFileIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadsApi.PostDownloads: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| ID of Workspace | 
 **downloadFolderIds** | [**List&lt;int?&gt;**](int?.md)| IDs of folders to include in download | [optional] 
 **downloadFileIds** | [**List&lt;int?&gt;**](int?.md)| IDs of files to include in download | [optional] 

### Return type

[**Meta**](Meta.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

