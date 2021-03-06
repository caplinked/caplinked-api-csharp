# Caplinked - the C# library for the CapLinked API v1.0

## Overview

C# (C sharp /.NET) SDK for the [Caplinked API](https://developer.caplinked.com/).

Core information security endpoints for managing your virtual data room capabilities around files/folders, users/groups and permissions, uploads/downloads, dynamic watermarking, DRM (digital rights management) and more.

Vist [Caplinked](https://www.caplinked.com/data-protection-api/) for more information.

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            apiInstance.Configuration.SetApiPublicKey("0c1da72601ca7c39df77a317d93c1caefccdd216");
            apiInstance.Configuration.SetApiSecretKey("cad02b1a2593862c5f151a5b8496f6e60c8581c82697ad706d8930bbd5684ba3");
            apiInstance.Configuration.SetApiUserToken("1b62543ca4f8311e9bd0e628705d76fb6aca1bd9");

	    try
	    {
	        // Get info of user resource token
                Console.WriteLine("Fetching user info");
		User result = apiInstance.GetUsersMe();
		Console.WriteLine(result.FirstName);
	    }
	    catch (Exception e)
	    {
		Console.WriteLine("Exception when calling UsersApi.GetUsersMe: " + e.Message);
	    }
	}
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://sandbox.caplinked.com/api/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ActivitiesApi* | [**GetActivitiesWorkspaceWorkspaceId**](docs/ActivitiesApi.md#getactivitiesworkspaceworkspaceid) | **GET** /activities/workspace/{workspace_id} | Get workspace activities
*DownloadsApi* | [**DeleteDownloadsId**](docs/DownloadsApi.md#deletedownloadsid) | **DELETE** /downloads/{id} | Delete download
*DownloadsApi* | [**GetDownloadsFileFileId**](docs/DownloadsApi.md#getdownloadsfilefileid) | **GET** /downloads/file/{file_id} | Get single file
*DownloadsApi* | [**GetDownloadsId**](docs/DownloadsApi.md#getdownloadsid) | **GET** /downloads/{id} | Get zip
*DownloadsApi* | [**GetDownloadsStatusWorkspaceId**](docs/DownloadsApi.md#getdownloadsstatusworkspaceid) | **GET** /downloads/status/{workspace_id} | Get status of downloads for current user
*DownloadsApi* | [**PostDownloads**](docs/DownloadsApi.md#postdownloads) | **POST** /downloads | Create zip file
*FilesApi* | [**DeleteFilesId**](docs/FilesApi.md#deletefilesid) | **DELETE** /files/{id} | Delete file
*FilesApi* | [**GetFilesId**](docs/FilesApi.md#getfilesid) | **GET** /files/{id} | Get file information
*FilesApi* | [**PostFilesIdCopy**](docs/FilesApi.md#postfilesidcopy) | **POST** /files/{id}/copy | Copy file
*FilesApi* | [**PostFilesIdMove**](docs/FilesApi.md#postfilesidmove) | **POST** /files/{id}/move | Move file
*FilesApi* | [**PutFilesId**](docs/FilesApi.md#putfilesid) | **PUT** /files/{id} | Update file information
*FilesApi* | [**PutFilesUpload**](docs/FilesApi.md#putfilesupload) | **PUT** /files/upload | Upload file
*FoldersApi* | [**DeleteFoldersId**](docs/FoldersApi.md#deletefoldersid) | **DELETE** /folders/{id} | Delete folder
*FoldersApi* | [**GetFoldersId**](docs/FoldersApi.md#getfoldersid) | **GET** /folders/{id} | Get folder information
*FoldersApi* | [**PostFolders**](docs/FoldersApi.md#postfolders) | **POST** /folders | Create new folder
*FoldersApi* | [**PostFoldersIdCopy**](docs/FoldersApi.md#postfoldersidcopy) | **POST** /folders/{id}/copy | Copy folder
*FoldersApi* | [**PostFoldersIdMove**](docs/FoldersApi.md#postfoldersidmove) | **POST** /folders/{id}/move | Move folder
*FoldersApi* | [**PutFoldersId**](docs/FoldersApi.md#putfoldersid) | **PUT** /folders/{id} | Update folder information
*GroupsApi* | [**DeleteGroupsId**](docs/GroupsApi.md#deletegroupsid) | **DELETE** /groups/{id} | Delete group
*GroupsApi* | [**DeleteGroupsIdMemberships**](docs/GroupsApi.md#deletegroupsidmemberships) | **DELETE** /groups/{id}/memberships | Remove a user from a group
*GroupsApi* | [**GetGroups**](docs/GroupsApi.md#getgroups) | **GET** /groups | List all groups in workspace
*GroupsApi* | [**GetGroupsId**](docs/GroupsApi.md#getgroupsid) | **GET** /groups/{id} | Get group information
*GroupsApi* | [**GetGroupsIdMemberships**](docs/GroupsApi.md#getgroupsidmemberships) | **GET** /groups/{id}/memberships | List all memberships for a group
*GroupsApi* | [**PostGroups**](docs/GroupsApi.md#postgroups) | **POST** /groups | Create group
*GroupsApi* | [**PostGroupsIdMemberships**](docs/GroupsApi.md#postgroupsidmemberships) | **POST** /groups/{id}/memberships | Add user to group (adds to parent workspace if they are not already a member)
*GroupsApi* | [**PutGroupsId**](docs/GroupsApi.md#putgroupsid) | **PUT** /groups/{id} | Update group
*GroupsApi* | [**PutGroupsIdDisableDrmExpiration**](docs/GroupsApi.md#putgroupsiddisabledrmexpiration) | **PUT** /groups/{id}/disable_drm_expiration | Disable DRM expiration for group
*GroupsApi* | [**PutGroupsIdDisableExpireAccess**](docs/GroupsApi.md#putgroupsiddisableexpireaccess) | **PUT** /groups/{id}/disable_expire_access | Disable access expiration for a group
*GroupsApi* | [**PutGroupsIdDrm**](docs/GroupsApi.md#putgroupsiddrm) | **PUT** /groups/{id}/drm | Update DRM for group
*GroupsApi* | [**PutGroupsIdEnableExpireAccess**](docs/GroupsApi.md#putgroupsidenableexpireaccess) | **PUT** /groups/{id}/enable_expire_access | Enable access expiration for a group
*GroupsApi* | [**PutGroupsIdWatermarking**](docs/GroupsApi.md#putgroupsidwatermarking) | **PUT** /groups/{id}/watermarking | Watermarking for group
*OrganizationApi* | [**DeleteOrganizationMemberships**](docs/OrganizationApi.md#deleteorganizationmemberships) | **DELETE** /organization/memberships | Remove organization admin membership
*OrganizationApi* | [**GetOrganization**](docs/OrganizationApi.md#getorganization) | **GET** /organization | Get organization information
*OrganizationApi* | [**GetOrganizationMemberships**](docs/OrganizationApi.md#getorganizationmemberships) | **GET** /organization/memberships | Show all organization members
*OrganizationApi* | [**PostOrganizationMemberships**](docs/OrganizationApi.md#postorganizationmemberships) | **POST** /organization/memberships | Add organization admin membership
*OrganizationApi* | [**PutOrganization**](docs/OrganizationApi.md#putorganization) | **PUT** /organization | Update organization information
*OrganizationApi* | [**PutOrganizationSupportInformation**](docs/OrganizationApi.md#putorganizationsupportinformation) | **PUT** /organization/support_information | Update support information of organization
*PermissionsApi* | [**GetPermissionsFoldersId**](docs/PermissionsApi.md#getpermissionsfoldersid) | **GET** /permissions/folders/{id} | List subfolder permissions
*PermissionsApi* | [**PutPermissionsFoldersId**](docs/PermissionsApi.md#putpermissionsfoldersid) | **PUT** /permissions/folders/{id} | Update folder permissions
*TeamsApi* | [**DeleteTeamsIdMemberships**](docs/TeamsApi.md#deleteteamsidmemberships) | **DELETE** /teams/{id}/memberships | Remove team member
*TeamsApi* | [**GetTeams**](docs/TeamsApi.md#getteams) | **GET** /teams | List all teams in organization
*TeamsApi* | [**GetTeamsId**](docs/TeamsApi.md#getteamsid) | **GET** /teams/{id} | Get team information
*TeamsApi* | [**GetTeamsIdMemberships**](docs/TeamsApi.md#getteamsidmemberships) | **GET** /teams/{id}/memberships | Get list of team members
*TeamsApi* | [**GetTeamsIdWatermarkSettings**](docs/TeamsApi.md#getteamsidwatermarksettings) | **GET** /teams/{id}/watermark_settings | List custom watermarks for a team
*TeamsApi* | [**PostTeams**](docs/TeamsApi.md#postteams) | **POST** /teams | Create team
*TeamsApi* | [**PostTeamsIdMemberships**](docs/TeamsApi.md#postteamsidmemberships) | **POST** /teams/{id}/memberships | Add team member
*TeamsApi* | [**PutTeamsId**](docs/TeamsApi.md#putteamsid) | **PUT** /teams/{id} | Update team
*UsersApi* | [**DeleteUsers**](docs/UsersApi.md#deleteusers) | **DELETE** /users | Delete user
*UsersApi* | [**GetUsersMe**](docs/UsersApi.md#getusersme) | **GET** /users/me | Get user information
*UsersApi* | [**PostUsers**](docs/UsersApi.md#postusers) | **POST** /users | Create user
*UsersApi* | [**PutUsersMe**](docs/UsersApi.md#putusersme) | **PUT** /users/me | Update a user
*WatermarkApi* | [**DeleteWatermarkId**](docs/WatermarkApi.md#deletewatermarkid) | **DELETE** /watermark/{id} | Delete custom watermark
*WatermarkApi* | [**GetWatermarkId**](docs/WatermarkApi.md#getwatermarkid) | **GET** /watermark/{id} | Get custom watermark setting
*WatermarkApi* | [**PostWatermark**](docs/WatermarkApi.md#postwatermark) | **POST** /watermark | Add custom watermark
*WatermarkApi* | [**PutWatermarkId**](docs/WatermarkApi.md#putwatermarkid) | **PUT** /watermark/{id} | Update custom watermark
*WorkspacesApi* | [**GetWorkspaces**](docs/WorkspacesApi.md#getworkspaces) | **GET** /workspaces | List all workspaces for a team
*WorkspacesApi* | [**GetWorkspacesId**](docs/WorkspacesApi.md#getworkspacesid) | **GET** /workspaces/{id} | Get workspace information
*WorkspacesApi* | [**PostWorkspaces**](docs/WorkspacesApi.md#postworkspaces) | **POST** /workspaces | Create workspace
*WorkspacesApi* | [**PutWorkspacesId**](docs/WorkspacesApi.md#putworkspacesid) | **PUT** /workspaces/{id} | Update workspace


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Activity](docs/Activity.md)
 - [Model.CustomWatermarkSetting](docs/CustomWatermarkSetting.md)
 - [Model.Delete](docs/Delete.md)
 - [Model.ExpiringUrl](docs/ExpiringUrl.md)
 - [Model.FileCopyMove](docs/FileCopyMove.md)
 - [Model.FileDelete](docs/FileDelete.md)
 - [Model.FileInfoCompact](docs/FileInfoCompact.md)
 - [Model.FileInfoMapped](docs/FileInfoMapped.md)
 - [Model.FileViewerImage](docs/FileViewerImage.md)
 - [Model.FolderContent](docs/FolderContent.md)
 - [Model.FolderCopyMove](docs/FolderCopyMove.md)
 - [Model.FolderDelete](docs/FolderDelete.md)
 - [Model.FolderList](docs/FolderList.md)
 - [Model.FolderMeta](docs/FolderMeta.md)
 - [Model.FolderUpdate](docs/FolderUpdate.md)
 - [Model.GroupInfo](docs/GroupInfo.md)
 - [Model.GroupInfoDeleted](docs/GroupInfoDeleted.md)
 - [Model.Membership](docs/Membership.md)
 - [Model.Meta](docs/Meta.md)
 - [Model.Organization](docs/Organization.md)
 - [Model.OrganizationMembership](docs/OrganizationMembership.md)
 - [Model.StatusMessage](docs/StatusMessage.md)
 - [Model.SupportInformation](docs/SupportInformation.md)
 - [Model.Team](docs/Team.md)
 - [Model.User](docs/User.md)
 - [Model.Workspace](docs/Workspace.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

See example on [Getting Started](#getting-started)
