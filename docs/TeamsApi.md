# Caplinked.Api.TeamsApi

All URIs are relative to *https://sandbox.caplinked.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteTeamsIdMemberships**](TeamsApi.md#deleteteamsidmemberships) | **DELETE** /teams/{id}/memberships | Remove team member
[**GetTeams**](TeamsApi.md#getteams) | **GET** /teams | List all teams in organization
[**GetTeamsId**](TeamsApi.md#getteamsid) | **GET** /teams/{id} | Get team information
[**GetTeamsIdMemberships**](TeamsApi.md#getteamsidmemberships) | **GET** /teams/{id}/memberships | Get list of team members
[**GetTeamsIdWatermarkSettings**](TeamsApi.md#getteamsidwatermarksettings) | **GET** /teams/{id}/watermark_settings | List custom watermarks for a team
[**PostTeams**](TeamsApi.md#postteams) | **POST** /teams | Create team
[**PostTeamsIdMemberships**](TeamsApi.md#postteamsidmemberships) | **POST** /teams/{id}/memberships | Add team member
[**PutTeamsId**](TeamsApi.md#putteamsid) | **PUT** /teams/{id} | Update team


<a name="deleteteamsidmemberships"></a>
# **DeleteTeamsIdMemberships**
> void DeleteTeamsIdMemberships (int? id, int? userId)

Remove team member

Remove team member

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class DeleteTeamsIdMembershipsExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var id = 56;  // int? | ID of team from which user will be removed
            var userId = 56;  // int? | ID of user to remove

            try
            {
                // Remove team member
                apiInstance.DeleteTeamsIdMemberships(id, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.DeleteTeamsIdMemberships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of team from which user will be removed | 
 **userId** | **int?**| ID of user to remove | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteams"></a>
# **GetTeams**
> Team GetTeams ()

List all teams in organization

List all teams in organization

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetTeamsExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();

            try
            {
                // List all teams in organization
                Team result = apiInstance.GetTeams();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetTeams: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Team**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteamsid"></a>
# **GetTeamsId**
> Team GetTeamsId (int? id)

Get team information

Get team information

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetTeamsIdExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var id = 56;  // int? | ID of the Team

            try
            {
                // Get team information
                Team result = apiInstance.GetTeamsId(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetTeamsId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of the Team | 

### Return type

[**Team**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteamsidmemberships"></a>
# **GetTeamsIdMemberships**
> List<Membership> GetTeamsIdMemberships (int? id)

Get list of team members

Get list of team members

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetTeamsIdMembershipsExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var id = 56;  // int? | ID of team for which users will be listed

            try
            {
                // Get list of team members
                List&lt;Membership&gt; result = apiInstance.GetTeamsIdMemberships(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetTeamsIdMemberships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of team for which users will be listed | 

### Return type

[**List<Membership>**](Membership.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteamsidwatermarksettings"></a>
# **GetTeamsIdWatermarkSettings**
> CustomWatermarkSetting GetTeamsIdWatermarkSettings (int? id)

List custom watermarks for a team

List custom watermarks for a team

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetTeamsIdWatermarkSettingsExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var id = 56;  // int? | ID of team

            try
            {
                // List custom watermarks for a team
                CustomWatermarkSetting result = apiInstance.GetTeamsIdWatermarkSettings(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetTeamsIdWatermarkSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of team | 

### Return type

[**CustomWatermarkSetting**](CustomWatermarkSetting.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postteams"></a>
# **PostTeams**
> Team PostTeams (string teamName, int? teamAllowedWorkspaces = null, int? teamAllowedAdmins = null, bool? teamDrmEnabled = null, bool? teamWatermarking = null, bool? teamSuppressEmails = null)

Create team

Create team. Current user will become team owner.

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PostTeamsExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var teamName = teamName_example;  // string | Name of the team
            var teamAllowedWorkspaces = 56;  // int? | Maximum workspaces for team (optional)  (default to 1)
            var teamAllowedAdmins = 56;  // int? | Maximum number of admins for team (optional)  (default to 10)
            var teamDrmEnabled = true;  // bool? | Toggle DRM (feature availability in workspaces) (optional) 
            var teamWatermarking = true;  // bool? | Toggle watermarking (feature availability in workspaces) (optional) 
            var teamSuppressEmails = true;  // bool? | Toggle email invites (optional)  (default to true)

            try
            {
                // Create team
                Team result = apiInstance.PostTeams(teamName, teamAllowedWorkspaces, teamAllowedAdmins, teamDrmEnabled, teamWatermarking, teamSuppressEmails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.PostTeams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamName** | **string**| Name of the team | 
 **teamAllowedWorkspaces** | **int?**| Maximum workspaces for team | [optional] [default to 1]
 **teamAllowedAdmins** | **int?**| Maximum number of admins for team | [optional] [default to 10]
 **teamDrmEnabled** | **bool?**| Toggle DRM (feature availability in workspaces) | [optional] 
 **teamWatermarking** | **bool?**| Toggle watermarking (feature availability in workspaces) | [optional] 
 **teamSuppressEmails** | **bool?**| Toggle email invites | [optional] [default to true]

### Return type

[**Team**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postteamsidmemberships"></a>
# **PostTeamsIdMemberships**
> Membership PostTeamsIdMemberships (int? id, int? userId)

Add team member

Add team member

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PostTeamsIdMembershipsExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var id = 56;  // int? | ID of team to which user will be added
            var userId = 56;  // int? | ID of user to add

            try
            {
                // Add team member
                Membership result = apiInstance.PostTeamsIdMemberships(id, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.PostTeamsIdMemberships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of team to which user will be added | 
 **userId** | **int?**| ID of user to add | 

### Return type

[**Membership**](Membership.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putteamsid"></a>
# **PutTeamsId**
> Team PutTeamsId (int? id, string teamName = null, int? teamTeamOwnerId = null, int? teamAllowedWorkspaces = null, int? teamAllowedAdmins = null, bool? teamDrmEnabled = null, bool? teamWatermarking = null, bool? teamSuppressEmails = null)

Update team

Update team. Includes option to designate a new Team Owner.

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PutTeamsIdExample
    {
        public void main()
        {
            var apiInstance = new TeamsApi();
            var id = 56;  // int? | ID of team to update
            var teamName = teamName_example;  // string | Name of the team (optional) 
            var teamTeamOwnerId = 56;  // int? | User ID of the team owner (optional) 
            var teamAllowedWorkspaces = 56;  // int? | Maximum workspaces for team (optional) 
            var teamAllowedAdmins = 56;  // int? | Maximum number of admins for team (optional) 
            var teamDrmEnabled = true;  // bool? | Toggle DRM (feature availability in workspaces) (optional) 
            var teamWatermarking = true;  // bool? | Toggle watermarking (feature availability in workspaces) (optional) 
            var teamSuppressEmails = true;  // bool? | Toggle email invites (optional) 

            try
            {
                // Update team
                Team result = apiInstance.PutTeamsId(id, teamName, teamTeamOwnerId, teamAllowedWorkspaces, teamAllowedAdmins, teamDrmEnabled, teamWatermarking, teamSuppressEmails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.PutTeamsId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of team to update | 
 **teamName** | **string**| Name of the team | [optional] 
 **teamTeamOwnerId** | **int?**| User ID of the team owner | [optional] 
 **teamAllowedWorkspaces** | **int?**| Maximum workspaces for team | [optional] 
 **teamAllowedAdmins** | **int?**| Maximum number of admins for team | [optional] 
 **teamDrmEnabled** | **bool?**| Toggle DRM (feature availability in workspaces) | [optional] 
 **teamWatermarking** | **bool?**| Toggle watermarking (feature availability in workspaces) | [optional] 
 **teamSuppressEmails** | **bool?**| Toggle email invites | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

