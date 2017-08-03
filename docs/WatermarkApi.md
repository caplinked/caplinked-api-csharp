# Caplinked.Api.WatermarkApi

All URIs are relative to *https://sandbox.caplinked.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteWatermarkId**](WatermarkApi.md#deletewatermarkid) | **DELETE** /watermark/{id} | Delete custom watermark
[**GetWatermarkId**](WatermarkApi.md#getwatermarkid) | **GET** /watermark/{id} | Get custom watermark setting
[**PostWatermark**](WatermarkApi.md#postwatermark) | **POST** /watermark | Add custom watermark
[**PutWatermarkId**](WatermarkApi.md#putwatermarkid) | **PUT** /watermark/{id} | Update custom watermark


<a name="deletewatermarkid"></a>
# **DeleteWatermarkId**
> StatusMessage DeleteWatermarkId (int? id)

Delete custom watermark

Delete custom watermark

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class DeleteWatermarkIdExample
    {
        public void main()
        {
            var apiInstance = new WatermarkApi();
            var id = 56;  // int? | ID of the watermark setting to delete

            try
            {
                // Delete custom watermark
                StatusMessage result = apiInstance.DeleteWatermarkId(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WatermarkApi.DeleteWatermarkId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of the watermark setting to delete | 

### Return type

[**StatusMessage**](StatusMessage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwatermarkid"></a>
# **GetWatermarkId**
> CustomWatermarkSetting GetWatermarkId (int? id)

Get custom watermark setting

Get custom watermark setting

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class GetWatermarkIdExample
    {
        public void main()
        {
            var apiInstance = new WatermarkApi();
            var id = 56;  // int? | ID of the watermark setting

            try
            {
                // Get custom watermark setting
                CustomWatermarkSetting result = apiInstance.GetWatermarkId(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WatermarkApi.GetWatermarkId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of the watermark setting | 

### Return type

[**CustomWatermarkSetting**](CustomWatermarkSetting.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postwatermark"></a>
# **PostWatermark**
> CustomWatermarkSetting PostWatermark (int? teamId, string customText, string color = null, float? opacity = null, int? fontSize = null, int? rotation = null, string hposition = null, string vposition = null, bool? displayUserName = null, bool? displayUserEmail = null, bool? displayIpAddress = null, bool? displayTime = null, bool? displayWorkspaceName = null)

Add custom watermark

Add custom watermark

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PostWatermarkExample
    {
        public void main()
        {
            var apiInstance = new WatermarkApi();
            var teamId = 56;  // int? | ID of the team
            var customText = customText_example;  // string | Custom watermark text
            var color = color_example;  // string | Hexadecimal color value (i.e. #eee, #e1e1e1) (optional)  (default to #333333)
            var opacity = 3.4;  // float? | Opacity 0 to 1.0 (optional)  (default to 0.5)
            var fontSize = 56;  // int? | Font size in pixels (optional)  (default to 18)
            var rotation = 56;  // int? | Rotation degrees (-90 to 90) (optional)  (default to 0)
            var hposition = hposition_example;  // string | Horizontal position (left, center, right) (optional)  (default to center)
            var vposition = vposition_example;  // string | Vertical position (top, center, bottom) (optional)  (default to center)
            var displayUserName = true;  // bool? | Display user name (optional)  (default to true)
            var displayUserEmail = true;  // bool? | Display user email address (optional)  (default to true)
            var displayIpAddress = true;  // bool? | Display user IP address (optional)  (default to true)
            var displayTime = true;  // bool? | Display time (optional)  (default to true)
            var displayWorkspaceName = true;  // bool? | Display workspace name (optional) 

            try
            {
                // Add custom watermark
                CustomWatermarkSetting result = apiInstance.PostWatermark(teamId, customText, color, opacity, fontSize, rotation, hposition, vposition, displayUserName, displayUserEmail, displayIpAddress, displayTime, displayWorkspaceName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WatermarkApi.PostWatermark: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **int?**| ID of the team | 
 **customText** | **string**| Custom watermark text | 
 **color** | **string**| Hexadecimal color value (i.e. #eee, #e1e1e1) | [optional] [default to #333333]
 **opacity** | **float?**| Opacity 0 to 1.0 | [optional] [default to 0.5]
 **fontSize** | **int?**| Font size in pixels | [optional] [default to 18]
 **rotation** | **int?**| Rotation degrees (-90 to 90) | [optional] [default to 0]
 **hposition** | **string**| Horizontal position (left, center, right) | [optional] [default to center]
 **vposition** | **string**| Vertical position (top, center, bottom) | [optional] [default to center]
 **displayUserName** | **bool?**| Display user name | [optional] [default to true]
 **displayUserEmail** | **bool?**| Display user email address | [optional] [default to true]
 **displayIpAddress** | **bool?**| Display user IP address | [optional] [default to true]
 **displayTime** | **bool?**| Display time | [optional] [default to true]
 **displayWorkspaceName** | **bool?**| Display workspace name | [optional] 

### Return type

[**CustomWatermarkSetting**](CustomWatermarkSetting.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putwatermarkid"></a>
# **PutWatermarkId**
> CustomWatermarkSetting PutWatermarkId (int? id, string customText = null, string color = null, float? opacity = null, int? fontSize = null, int? rotation = null, string hposition = null, string vposition = null, bool? displayUserName = null, bool? displayUserEmail = null, bool? displayIpAddress = null, bool? displayTime = null, bool? displayWorkspaceName = null)

Update custom watermark

Update custom watermark

### Example
```csharp
using System;
using System.Diagnostics;
using Caplinked.Api;
using Caplinked.Client;
using Caplinked.Model;

namespace Example
{
    public class PutWatermarkIdExample
    {
        public void main()
        {
            var apiInstance = new WatermarkApi();
            var id = 56;  // int? | ID of the watermark setting to update
            var customText = customText_example;  // string | Custom watermark text (optional) 
            var color = color_example;  // string | Hexadecimal color value (i.e. #eee, #e1e1e1) (optional) 
            var opacity = 3.4;  // float? | Opacity 0 to 1.0 (optional) 
            var fontSize = 56;  // int? | Font size in pixels (optional) 
            var rotation = 56;  // int? | Rotation degrees (-90 to 90) (optional) 
            var hposition = hposition_example;  // string | Horizontal position (left, center, right) (optional) 
            var vposition = vposition_example;  // string | Vertical position (top, center, bottom) (optional) 
            var displayUserName = true;  // bool? | Display user name (optional) 
            var displayUserEmail = true;  // bool? | Display user email address (optional) 
            var displayIpAddress = true;  // bool? | Display user IP address (optional) 
            var displayTime = true;  // bool? | Display time (optional) 
            var displayWorkspaceName = true;  // bool? | Display workspace name (optional) 

            try
            {
                // Update custom watermark
                CustomWatermarkSetting result = apiInstance.PutWatermarkId(id, customText, color, opacity, fontSize, rotation, hposition, vposition, displayUserName, displayUserEmail, displayIpAddress, displayTime, displayWorkspaceName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WatermarkApi.PutWatermarkId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID of the watermark setting to update | 
 **customText** | **string**| Custom watermark text | [optional] 
 **color** | **string**| Hexadecimal color value (i.e. #eee, #e1e1e1) | [optional] 
 **opacity** | **float?**| Opacity 0 to 1.0 | [optional] 
 **fontSize** | **int?**| Font size in pixels | [optional] 
 **rotation** | **int?**| Rotation degrees (-90 to 90) | [optional] 
 **hposition** | **string**| Horizontal position (left, center, right) | [optional] 
 **vposition** | **string**| Vertical position (top, center, bottom) | [optional] 
 **displayUserName** | **bool?**| Display user name | [optional] 
 **displayUserEmail** | **bool?**| Display user email address | [optional] 
 **displayIpAddress** | **bool?**| Display user IP address | [optional] 
 **displayTime** | **bool?**| Display time | [optional] 
 **displayWorkspaceName** | **bool?**| Display workspace name | [optional] 

### Return type

[**CustomWatermarkSetting**](CustomWatermarkSetting.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

