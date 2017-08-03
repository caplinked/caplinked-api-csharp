# Caplinked.Api.OrganizationApi

All URIs are relative to *https://sandbox.caplinked.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteOrganizationMemberships**](OrganizationApi.md#deleteorganizationmemberships) | **DELETE** /organization/memberships | Remove organization admin membership
[**GetOrganization**](OrganizationApi.md#getorganization) | **GET** /organization | Get organization information
[**GetOrganizationMemberships**](OrganizationApi.md#getorganizationmemberships) | **GET** /organization/memberships | Show all organization members
[**PostOrganizationMemberships**](OrganizationApi.md#postorganizationmemberships) | **POST** /organization/memberships | Add organization admin membership
[**PutOrganization**](OrganizationApi.md#putorganization) | **PUT** /organization | Update organization information
[**PutOrganizationSupportInformation**](OrganizationApi.md#putorganizationsupportinformation) | **PUT** /organization/support_information | Update support information of organization


<a name="deleteorganizationmemberships"></a>
# **DeleteOrganizationMemberships**
> void DeleteOrganizationMemberships (int? userId)

Remove organization admin membership

Remove organization admin membership

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class DeleteOrganizationMembershipsExample
    {
        public void main()
        {
            var apiInstance = new OrganizationApi();
            var userId = 56;  // int? | ID of user to be removed as an organization admin

            try
            {
                // Remove organization admin membership
                apiInstance.DeleteOrganizationMemberships(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.DeleteOrganizationMemberships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| ID of user to be removed as an organization admin | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganization"></a>
# **GetOrganization**
> Organization GetOrganization ()

Get organization information

Get organization information

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetOrganizationExample
    {
        public void main()
        {
            var apiInstance = new OrganizationApi();

            try
            {
                // Get organization information
                Organization result = apiInstance.GetOrganization();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Organization**](Organization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationmemberships"></a>
# **GetOrganizationMemberships**
> User GetOrganizationMemberships ()

Show all organization members

Show all organization members

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetOrganizationMembershipsExample
    {
        public void main()
        {
            var apiInstance = new OrganizationApi();

            try
            {
                // Show all organization members
                User result = apiInstance.GetOrganizationMemberships();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganizationMemberships: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postorganizationmemberships"></a>
# **PostOrganizationMemberships**
> OrganizationMembership PostOrganizationMemberships (int? userId)

Add organization admin membership

Add organization admin membership

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PostOrganizationMembershipsExample
    {
        public void main()
        {
            var apiInstance = new OrganizationApi();
            var userId = 56;  // int? | ID of user to be added as an organization admin

            try
            {
                // Add organization admin membership
                OrganizationMembership result = apiInstance.PostOrganizationMemberships(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.PostOrganizationMemberships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| ID of user to be added as an organization admin | 

### Return type

[**OrganizationMembership**](OrganizationMembership.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putorganization"></a>
# **PutOrganization**
> Organization PutOrganization (string name = null, string description = null, string location = null, string billingEmail = null, string url = null)

Update organization information

Update organization information

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PutOrganizationExample
    {
        public void main()
        {
            var apiInstance = new OrganizationApi();
            var name = name_example;  // string | Name of the organization to update (optional) 
            var description = description_example;  // string | Description of the organization to update (optional) 
            var location = location_example;  // string | Location of the organization to update (optional) 
            var billingEmail = billingEmail_example;  // string | Billing email address of the organization to update (optional) 
            var url = url_example;  // string | Website of the organization to update (optional) 

            try
            {
                // Update organization information
                Organization result = apiInstance.PutOrganization(name, description, location, billingEmail, url);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.PutOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the organization to update | [optional] 
 **description** | **string**| Description of the organization to update | [optional] 
 **location** | **string**| Location of the organization to update | [optional] 
 **billingEmail** | **string**| Billing email address of the organization to update | [optional] 
 **url** | **string**| Website of the organization to update | [optional] 

### Return type

[**Organization**](Organization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putorganizationsupportinformation"></a>
# **PutOrganizationSupportInformation**
> SupportInformation PutOrganizationSupportInformation (string phoneNumber = null, string email = null, string website = null)

Update support information of organization

Update support information of organization

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PutOrganizationSupportInformationExample
    {
        public void main()
        {
            var apiInstance = new OrganizationApi();
            var phoneNumber = phoneNumber_example;  // string | Support phone number of the organization to update (optional) 
            var email = email_example;  // string | Support email of the organization to update (optional) 
            var website = website_example;  // string | Support website of the organization to update (optional) 

            try
            {
                // Update support information of organization
                SupportInformation result = apiInstance.PutOrganizationSupportInformation(phoneNumber, email, website);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.PutOrganizationSupportInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phoneNumber** | **string**| Support phone number of the organization to update | [optional] 
 **email** | **string**| Support email of the organization to update | [optional] 
 **website** | **string**| Support website of the organization to update | [optional] 

### Return type

[**SupportInformation**](SupportInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

