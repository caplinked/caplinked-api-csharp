# Caplinked.Api.UsersApi

All URIs are relative to *https://sandbox.caplinked.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteUsers**](UsersApi.md#deleteusers) | **DELETE** /users | Delete user
[**GetUsersMe**](UsersApi.md#getusersme) | **GET** /users/me | Get user information
[**PostUsers**](UsersApi.md#postusers) | **POST** /users | Create user
[**PutUsersMe**](UsersApi.md#putusersme) | **PUT** /users/me | Update a user


<a name="deleteusers"></a>
# **DeleteUsers**
> StatusMessage DeleteUsers (int? userId)

Delete user

Delete user

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class DeleteUsersExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = 56;  // int? | ID of the user you want to delete

            try
            {
                // Delete user
                StatusMessage result = apiInstance.DeleteUsers(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| ID of the user you want to delete | 

### Return type

[**StatusMessage**](StatusMessage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersme"></a>
# **GetUsersMe**
> User GetUsersMe ()

Get user information

Get user information

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetUsersMeExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();

            try
            {
                // Get user information
                User result = apiInstance.GetUsersMe();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsersMe: " + e.Message );
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

<a name="postusers"></a>
# **PostUsers**
> User PostUsers (string userEmail, string userFirstName, string userLastName, string userTimeZone = null)

Create user

Create user

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PostUsersExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userEmail = userEmail_example;  // string | Email of new user
            var userFirstName = userFirstName_example;  // string | First of new user
            var userLastName = userLastName_example;  // string | Last name of new user
            var userTimeZone = userTimeZone_example;  // string | Time zone of new user (optional) 

            try
            {
                // Create user
                User result = apiInstance.PostUsers(userEmail, userFirstName, userLastName, userTimeZone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userEmail** | **string**| Email of new user | 
 **userFirstName** | **string**| First of new user | 
 **userLastName** | **string**| Last name of new user | 
 **userTimeZone** | **string**| Time zone of new user | [optional] 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putusersme"></a>
# **PutUsersMe**
> User PutUsersMe (string userEmail = null, string userFirstName = null, string userLastName = null, string userTimeZone = null)

Update a user

Update a user

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PutUsersMeExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userEmail = userEmail_example;  // string | Email of user to update (optional) 
            var userFirstName = userFirstName_example;  // string | First name of user to update (optional) 
            var userLastName = userLastName_example;  // string | Last name of user to update (optional) 
            var userTimeZone = userTimeZone_example;  // string | Time zone of user to update (optional) 

            try
            {
                // Update a user
                User result = apiInstance.PutUsersMe(userEmail, userFirstName, userLastName, userTimeZone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUsersMe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userEmail** | **string**| Email of user to update | [optional] 
 **userFirstName** | **string**| First name of user to update | [optional] 
 **userLastName** | **string**| Last name of user to update | [optional] 
 **userTimeZone** | **string**| Time zone of user to update | [optional] 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

