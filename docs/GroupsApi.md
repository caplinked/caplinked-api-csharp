# Caplinked.Api.GroupsApi

All URIs are relative to *https://sandbox.caplinked.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteGroupsId**](GroupsApi.md#deletegroupsid) | **DELETE** /groups/{id} | Delete group
[**DeleteGroupsIdMemberships**](GroupsApi.md#deletegroupsidmemberships) | **DELETE** /groups/{id}/memberships | Remove a user from a group
[**GetGroups**](GroupsApi.md#getgroups) | **GET** /groups | List all groups in workspace
[**GetGroupsId**](GroupsApi.md#getgroupsid) | **GET** /groups/{id} | Get group information
[**GetGroupsIdMemberships**](GroupsApi.md#getgroupsidmemberships) | **GET** /groups/{id}/memberships | List all memberships for a group
[**PostGroups**](GroupsApi.md#postgroups) | **POST** /groups | Create group
[**PostGroupsIdMemberships**](GroupsApi.md#postgroupsidmemberships) | **POST** /groups/{id}/memberships | Add user to group (adds to parent workspace if they are not already a member)
[**PutGroupsId**](GroupsApi.md#putgroupsid) | **PUT** /groups/{id} | Update group
[**PutGroupsIdDisableDrmExpiration**](GroupsApi.md#putgroupsiddisabledrmexpiration) | **PUT** /groups/{id}/disable_drm_expiration | Disable DRM expiration for group
[**PutGroupsIdDisableExpireAccess**](GroupsApi.md#putgroupsiddisableexpireaccess) | **PUT** /groups/{id}/disable_expire_access | Disable access expiration for a group
[**PutGroupsIdDrm**](GroupsApi.md#putgroupsiddrm) | **PUT** /groups/{id}/drm | Update DRM for group
[**PutGroupsIdEnableExpireAccess**](GroupsApi.md#putgroupsidenableexpireaccess) | **PUT** /groups/{id}/enable_expire_access | Enable access expiration for a group
[**PutGroupsIdWatermarking**](GroupsApi.md#putgroupsidwatermarking) | **PUT** /groups/{id}/watermarking | Watermarking for group


<a name="deletegroupsid"></a>
# **DeleteGroupsId**
> GroupInfoDeleted DeleteGroupsId (int? id, int? workspaceId)

Delete group

Delete group

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class DeleteGroupsIdExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var id = 56;  // int? | ID of group to update
            var workspaceId = 56;  // int? | Workspace ID for the group

            try
            {
                // Delete group
                GroupInfoDeleted result = apiInstance.DeleteGroupsId(id, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroupsId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of group to update | 
 **workspaceId** | **int?**| Workspace ID for the group | 

### Return type

[**GroupInfoDeleted**](GroupInfoDeleted.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroupsidmemberships"></a>
# **DeleteGroupsIdMemberships**
> void DeleteGroupsIdMemberships (int? id, int? workspaceId, int? userId)

Remove a user from a group

Remove a user from a group. Members of the Workspace Admin group may only be removed by other Workspace Admins. If Workspace Admin is Team Member, they may only be removed by another Team Member.

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class DeleteGroupsIdMembershipsExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var id = 56;  // int? | ID of the group you wish the user to be removed from
            var workspaceId = 56;  // int? | Workspace ID for the group
            var userId = 56;  // int? | ID of the user to be removed from this group

            try
            {
                // Remove a user from a group
                apiInstance.DeleteGroupsIdMemberships(id, workspaceId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroupsIdMemberships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of the group you wish the user to be removed from | 
 **workspaceId** | **int?**| Workspace ID for the group | 
 **userId** | **int?**| ID of the user to be removed from this group | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroups"></a>
# **GetGroups**
> GroupInfo GetGroups (int? workspaceId)

List all groups in workspace

List all groups in workspace

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetGroupsExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var workspaceId = 56;  // int? | ID of workspace from which to list groups

            try
            {
                // List all groups in workspace
                GroupInfo result = apiInstance.GetGroups(workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceId** | **int?**| ID of workspace from which to list groups | 

### Return type

[**GroupInfo**](GroupInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupsid"></a>
# **GetGroupsId**
> GroupInfo GetGroupsId (int? id, int? workspaceId)

Get group information

Get group information

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetGroupsIdExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var id = 56;  // int? | ID of group
            var workspaceId = 56;  // int? | Workspace ID for the group

            try
            {
                // Get group information
                GroupInfo result = apiInstance.GetGroupsId(id, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupsId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of group | 
 **workspaceId** | **int?**| Workspace ID for the group | 

### Return type

[**GroupInfo**](GroupInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupsidmemberships"></a>
# **GetGroupsIdMemberships**
> User GetGroupsIdMemberships (int? id, int? workspaceId)

List all memberships for a group

List all memberships for a group. Note that Workspace Admins are in two groups: Workspace Admins and Team Admins. The latter contains workspace admins that are also Team Members of the workspace parent team.

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetGroupsIdMembershipsExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var id = 56;  // int? | ID of the group you want to list the members of
            var workspaceId = 56;  // int? | Workspace ID for the group

            try
            {
                // List all memberships for a group
                User result = apiInstance.GetGroupsIdMemberships(id, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroupsIdMemberships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of the group you want to list the members of | 
 **workspaceId** | **int?**| Workspace ID for the group | 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgroups"></a>
# **PostGroups**
> GroupInfo PostGroups (string groupName, int? groupWorkspaceId, bool? groupFileManagingAbilities = null)

Create group

Create group

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PostGroupsExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var groupName = groupName_example;  // string | Name of group
            var groupWorkspaceId = 56;  // int? | Workspace ID for the group
            var groupFileManagingAbilities = true;  // bool? | Enable file managing abililies for uploading users (optional) 

            try
            {
                // Create group
                GroupInfo result = apiInstance.PostGroups(groupName, groupWorkspaceId, groupFileManagingAbilities);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupName** | **string**| Name of group | 
 **groupWorkspaceId** | **int?**| Workspace ID for the group | 
 **groupFileManagingAbilities** | **bool?**| Enable file managing abililies for uploading users | [optional] 

### Return type

[**GroupInfo**](GroupInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgroupsidmemberships"></a>
# **PostGroupsIdMemberships**
> void PostGroupsIdMemberships (int? id, int? workspaceId, int? userId, bool? sendEmail = null)

Add user to group (adds to parent workspace if they are not already a member)

Add user to group (adds to parent workspace if they are not already a member)

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PostGroupsIdMembershipsExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var id = 56;  // int? | ID of the group you wish the user to be added to
            var workspaceId = 56;  // int? | Workspace ID for the group
            var userId = 56;  // int? | ID of the user to be added to this group
            var sendEmail = true;  // bool? | Send workspace invitation email to this user.  Defaults to true, use false if you do not want the email to be sent (optional) 

            try
            {
                // Add user to group (adds to parent workspace if they are not already a member)
                apiInstance.PostGroupsIdMemberships(id, workspaceId, userId, sendEmail);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PostGroupsIdMemberships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of the group you wish the user to be added to | 
 **workspaceId** | **int?**| Workspace ID for the group | 
 **userId** | **int?**| ID of the user to be added to this group | 
 **sendEmail** | **bool?**| Send workspace invitation email to this user.  Defaults to true, use false if you do not want the email to be sent | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putgroupsid"></a>
# **PutGroupsId**
> GroupInfo PutGroupsId (int? id, int? workspaceId, string groupName = null, bool? groupFileManagingAbilities = null)

Update group

Update group

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PutGroupsIdExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var id = 56;  // int? | ID of group
            var workspaceId = 56;  // int? | Workspace ID for the group
            var groupName = groupName_example;  // string | Name of group (optional) 
            var groupFileManagingAbilities = true;  // bool? | Ability to delete, rename, and reindex files for uploading users (optional) 

            try
            {
                // Update group
                GroupInfo result = apiInstance.PutGroupsId(id, workspaceId, groupName, groupFileManagingAbilities);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PutGroupsId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of group | 
 **workspaceId** | **int?**| Workspace ID for the group | 
 **groupName** | **string**| Name of group | [optional] 
 **groupFileManagingAbilities** | **bool?**| Ability to delete, rename, and reindex files for uploading users | [optional] 

### Return type

[**GroupInfo**](GroupInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putgroupsiddisabledrmexpiration"></a>
# **PutGroupsIdDisableDrmExpiration**
> GroupInfo PutGroupsIdDisableDrmExpiration (int? id, int? workspaceId)

Disable DRM expiration for group

Disable DRM expiration for group

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PutGroupsIdDisableDrmExpirationExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var id = 56;  // int? | ID of group to update
            var workspaceId = 56;  // int? | Workspace ID for the group

            try
            {
                // Disable DRM expiration for group
                GroupInfo result = apiInstance.PutGroupsIdDisableDrmExpiration(id, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PutGroupsIdDisableDrmExpiration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of group to update | 
 **workspaceId** | **int?**| Workspace ID for the group | 

### Return type

[**GroupInfo**](GroupInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putgroupsiddisableexpireaccess"></a>
# **PutGroupsIdDisableExpireAccess**
> GroupInfo PutGroupsIdDisableExpireAccess (int? id, int? workspaceId)

Disable access expiration for a group

Disable access expiration for a group

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PutGroupsIdDisableExpireAccessExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var id = 56;  // int? | ID of group to update
            var workspaceId = 56;  // int? | Workspace ID for the group

            try
            {
                // Disable access expiration for a group
                GroupInfo result = apiInstance.PutGroupsIdDisableExpireAccess(id, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PutGroupsIdDisableExpireAccess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of group to update | 
 **workspaceId** | **int?**| Workspace ID for the group | 

### Return type

[**GroupInfo**](GroupInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putgroupsiddrm"></a>
# **PutGroupsIdDrm**
> GroupInfo PutGroupsIdDrm (int? id, int? workspaceId, string groupDrmEnabled, DateTime? groupDrmExpiresAfter = null)

Update DRM for group

Update DRM for group

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PutGroupsIdDrmExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var id = 56;  // int? | ID of group to update
            var workspaceId = 56;  // int? | Workspace ID for the group
            var groupDrmEnabled = groupDrmEnabled_example;  // string | Enable DRM for group
            var groupDrmExpiresAfter = 2013-10-20;  // DateTime? | Expire DRM after this date. Format: yyyy-mm-dd (optional) 

            try
            {
                // Update DRM for group
                GroupInfo result = apiInstance.PutGroupsIdDrm(id, workspaceId, groupDrmEnabled, groupDrmExpiresAfter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PutGroupsIdDrm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of group to update | 
 **workspaceId** | **int?**| Workspace ID for the group | 
 **groupDrmEnabled** | **string**| Enable DRM for group | 
 **groupDrmExpiresAfter** | **DateTime?**| Expire DRM after this date. Format: yyyy-mm-dd | [optional] 

### Return type

[**GroupInfo**](GroupInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putgroupsidenableexpireaccess"></a>
# **PutGroupsIdEnableExpireAccess**
> GroupInfo PutGroupsIdEnableExpireAccess (int? id, int? workspaceId, DateTime? groupExpireWorkspaceAccessAt)

Enable access expiration for a group

Enable access expiration for a group

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PutGroupsIdEnableExpireAccessExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var id = 56;  // int? | ID of group to update
            var workspaceId = 56;  // int? | Workspace ID for the group
            var groupExpireWorkspaceAccessAt = 2013-10-20;  // DateTime? | Expire access on the following date. Format: yyyy-mm-dd

            try
            {
                // Enable access expiration for a group
                GroupInfo result = apiInstance.PutGroupsIdEnableExpireAccess(id, workspaceId, groupExpireWorkspaceAccessAt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PutGroupsIdEnableExpireAccess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of group to update | 
 **workspaceId** | **int?**| Workspace ID for the group | 
 **groupExpireWorkspaceAccessAt** | **DateTime?**| Expire access on the following date. Format: yyyy-mm-dd | 

### Return type

[**GroupInfo**](GroupInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putgroupsidwatermarking"></a>
# **PutGroupsIdWatermarking**
> GroupInfo PutGroupsIdWatermarking (int? id, int? workspaceId, bool? groupWatermarking)

Watermarking for group

Watermarking for group

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PutGroupsIdWatermarkingExample
    {
        public void main()
        {
            var apiInstance = new GroupsApi();
            var id = 56;  // int? | ID of group to update
            var workspaceId = 56;  // int? | Workspace ID for the group
            var groupWatermarking = true;  // bool? | Enable watermarking for group

            try
            {
                // Watermarking for group
                GroupInfo result = apiInstance.PutGroupsIdWatermarking(id, workspaceId, groupWatermarking);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.PutGroupsIdWatermarking: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of group to update | 
 **workspaceId** | **int?**| Workspace ID for the group | 
 **groupWatermarking** | **bool?**| Enable watermarking for group | 

### Return type

[**GroupInfo**](GroupInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

