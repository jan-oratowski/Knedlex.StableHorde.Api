# StableHorde.Api.Api.V2Api

All URIs are relative to */api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteAsyncStatus**](V2Api.md#deleteasyncstatus) | **DELETE** /v2/generate/status/{id} | Cancel an unfinished request |
| [**DeleteWorkerSingle**](V2Api.md#deleteworkersingle) | **DELETE** /v2/workers/{worker_id} | Delete the worker entry |
| [**GetAsyncCheck**](V2Api.md#getasynccheck) | **GET** /v2/generate/check/{id} | Retrieve the status of an Asynchronous generation request without images |
| [**GetAsyncStatus**](V2Api.md#getasyncstatus) | **GET** /v2/generate/status/{id} | Retrieve the full status of an Asynchronous generation request |
| [**GetFindUser**](V2Api.md#getfinduser) | **GET** /v2/find_user | Lookup user details based on their API key |
| [**GetHordeLoad**](V2Api.md#gethordeload) | **GET** /v2/status/performance | Details about the current performance of this Horde |
| [**GetHordeModes**](V2Api.md#gethordemodes) | **GET** /v2/status/modes | Horde Maintenance Mode Status |
| [**GetHordeNews**](V2Api.md#gethordenews) | **GET** /v2/status/news | Read the latest happenings on the horde |
| [**GetModels**](V2Api.md#getmodels) | **GET** /v2/status/models | Returns a list of models active currently in this horde |
| [**GetUserSingle**](V2Api.md#getusersingle) | **GET** /v2/users/{user_id} | Details and statistics about a specific user |
| [**GetUsers**](V2Api.md#getusers) | **GET** /v2/users | A List with the details and statistic of all registered users |
| [**GetWorkerSingle**](V2Api.md#getworkersingle) | **GET** /v2/workers/{worker_id} | Details of a registered worker |
| [**GetWorkers**](V2Api.md#getworkers) | **GET** /v2/workers | A List with the details of all registered and active workers |
| [**PostAsyncGenerate**](V2Api.md#postasyncgenerate) | **POST** /v2/generate/async | Initiate an Asynchronous request to generate images |
| [**PostJobPop**](V2Api.md#postjobpop) | **POST** /v2/generate/pop | Check if there are generation requests queued for fulfillment |
| [**PostJobSubmit**](V2Api.md#postjobsubmit) | **POST** /v2/generate/submit | Submit a generated image |
| [**PostSyncGenerate**](V2Api.md#postsyncgenerate) | **POST** /v2/generate/sync | Initiate a Synchronous request to generate images |
| [**PostTransferKudos**](V2Api.md#posttransferkudos) | **POST** /v2/kudos/transfer | Transfer Kudos to another registed user |
| [**PutHordeModes**](V2Api.md#puthordemodes) | **PUT** /v2/status/modes | Change Horde Modes |
| [**PutUserSingle**](V2Api.md#putusersingle) | **PUT** /v2/users/{user_id} | Endpoint for horde admins to perform operations on users |
| [**PutWorkerSingle**](V2Api.md#putworkersingle) | **PUT** /v2/workers/{worker_id} | Put the worker into maintenance or pause mode |

<a name="deleteasyncstatus"></a>
# **DeleteAsyncStatus**
> RequestStatusStable DeleteAsyncStatus (string id, string xFields = null)

Cancel an unfinished request

This request will include all already generated images in base64 encoded .webp files.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class DeleteAsyncStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var id = "id_example";  // string | 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Cancel an unfinished request
                RequestStatusStable result = apiInstance.DeleteAsyncStatus(id, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteAsyncStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAsyncStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel an unfinished request
    ApiResponse<RequestStatusStable> response = apiInstance.DeleteAsyncStatusWithHttpInfo(id, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.DeleteAsyncStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**RequestStatusStable**](RequestStatusStable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Async Request Full Status |  -  |
| **404** | Request Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteworkersingle"></a>
# **DeleteWorkerSingle**
> DeletedWorker DeleteWorkerSingle (string workerId, string apikey = null, string xFields = null)

Delete the worker entry

This will delete the worker and their statistics. Will not affect the kudos generated by that worker for their owner. Only the worker's owner and an admin can use this endpoint. This action is unrecoverable!

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class DeleteWorkerSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var workerId = "workerId_example";  // string | 
            var apikey = "apikey_example";  // string | The Moderator or Owner API key (optional) 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Delete the worker entry
                DeletedWorker result = apiInstance.DeleteWorkerSingle(workerId, apikey, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteWorkerSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWorkerSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete the worker entry
    ApiResponse<DeletedWorker> response = apiInstance.DeleteWorkerSingleWithHttpInfo(workerId, apikey, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.DeleteWorkerSingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workerId** | **string** |  |  |
| **apikey** | **string** | The Moderator or Owner API key | [optional]  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**DeletedWorker**](DeletedWorker.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Delete Worker |  -  |
| **401** | Invalid API Key |  -  |
| **403** | Access Denied |  -  |
| **404** | Worker Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getasynccheck"></a>
# **GetAsyncCheck**
> RequestStatusCheck GetAsyncCheck (string id, string xFields = null)

Retrieve the status of an Asynchronous generation request without images

Use this request to check the status of a currently running asynchronous request without consuming bandwidth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class GetAsyncCheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var id = "id_example";  // string | 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Retrieve the status of an Asynchronous generation request without images
                RequestStatusCheck result = apiInstance.GetAsyncCheck(id, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetAsyncCheck: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAsyncCheckWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the status of an Asynchronous generation request without images
    ApiResponse<RequestStatusCheck> response = apiInstance.GetAsyncCheckWithHttpInfo(id, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetAsyncCheckWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**RequestStatusCheck**](RequestStatusCheck.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Async Request Status Check |  -  |
| **404** | Request Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getasyncstatus"></a>
# **GetAsyncStatus**
> RequestStatusStable GetAsyncStatus (string id, string xFields = null)

Retrieve the full status of an Asynchronous generation request

This request will include all already generated images in base64 encoded .webp files. As such, you are requested to not retrieve this endpoint often. Instead use the /check/ endpoint first This endpoint is limited to 1 request per minute

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class GetAsyncStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var id = "id_example";  // string | 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Retrieve the full status of an Asynchronous generation request
                RequestStatusStable result = apiInstance.GetAsyncStatus(id, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetAsyncStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAsyncStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the full status of an Asynchronous generation request
    ApiResponse<RequestStatusStable> response = apiInstance.GetAsyncStatusWithHttpInfo(id, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetAsyncStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**RequestStatusStable**](RequestStatusStable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Async Request Full Status |  -  |
| **404** | Request Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfinduser"></a>
# **GetFindUser**
> UserDetailsStable GetFindUser (string apikey = null, string xFields = null)

Lookup user details based on their API key

This can be used to verify a user exists

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class GetFindUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | User API key we're looking for (optional) 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Lookup user details based on their API key
                UserDetailsStable result = apiInstance.GetFindUser(apikey, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetFindUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFindUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lookup user details based on their API key
    ApiResponse<UserDetailsStable> response = apiInstance.GetFindUserWithHttpInfo(apikey, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetFindUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | User API key we&#39;re looking for | [optional]  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**UserDetailsStable**](UserDetailsStable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Worker Details |  -  |
| **404** | User Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethordeload"></a>
# **GetHordeLoad**
> HordePerformanceStable GetHordeLoad (string xFields = null)

Details about the current performance of this Horde

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class GetHordeLoadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Details about the current performance of this Horde
                HordePerformanceStable result = apiInstance.GetHordeLoad(xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetHordeLoad: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHordeLoadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Details about the current performance of this Horde
    ApiResponse<HordePerformanceStable> response = apiInstance.GetHordeLoadWithHttpInfo(xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetHordeLoadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**HordePerformanceStable**](HordePerformanceStable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Horde Maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethordemodes"></a>
# **GetHordeModes**
> HordeModes GetHordeModes (string apikey = null, string xFields = null)

Horde Maintenance Mode Status

Use this endpoint to quicky determine if this horde is in maintenance, invite_only or raid mode.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class GetHordeModesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The Admin or Owner API key (optional) 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Horde Maintenance Mode Status
                HordeModes result = apiInstance.GetHordeModes(apikey, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetHordeModes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHordeModesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Horde Maintenance Mode Status
    ApiResponse<HordeModes> response = apiInstance.GetHordeModesWithHttpInfo(apikey, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetHordeModesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | The Admin or Owner API key | [optional]  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**HordeModes**](HordeModes.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Horde Maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethordenews"></a>
# **GetHordeNews**
> List&lt;Newspiece&gt; GetHordeNews (string xFields = null)

Read the latest happenings on the horde

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class GetHordeNewsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Read the latest happenings on the horde
                List<Newspiece> result = apiInstance.GetHordeNews(xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetHordeNews: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHordeNewsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read the latest happenings on the horde
    ApiResponse<List<Newspiece>> response = apiInstance.GetHordeNewsWithHttpInfo(xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetHordeNewsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**List&lt;Newspiece&gt;**](Newspiece.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Horde News |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmodels"></a>
# **GetModels**
> List&lt;ActiveModel&gt; GetModels (string xFields = null)

Returns a list of models active currently in this horde

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class GetModelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Returns a list of models active currently in this horde
                List<ActiveModel> result = apiInstance.GetModels(xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetModels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetModelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns a list of models active currently in this horde
    ApiResponse<List<ActiveModel>> response = apiInstance.GetModelsWithHttpInfo(xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetModelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**List&lt;ActiveModel&gt;**](ActiveModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List All Active Models |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersingle"></a>
# **GetUserSingle**
> UserDetailsStable GetUserSingle (string userId, string apikey = null, string xFields = null)

Details and statistics about a specific user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class GetUserSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var userId = "userId_example";  // string | 
            var apikey = "apikey_example";  // string | The Admin, Mod or Owner API key (optional) 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Details and statistics about a specific user
                UserDetailsStable result = apiInstance.GetUserSingle(userId, apikey, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetUserSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Details and statistics about a specific user
    ApiResponse<UserDetailsStable> response = apiInstance.GetUserSingleWithHttpInfo(userId, apikey, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetUserSingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |
| **apikey** | **string** | The Admin, Mod or Owner API key | [optional]  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**UserDetailsStable**](UserDetailsStable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User Details |  -  |
| **404** | User Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusers"></a>
# **GetUsers**
> UserDetailsStable GetUsers (string xFields = null)

A List with the details and statistic of all registered users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class GetUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // A List with the details and statistic of all registered users
                UserDetailsStable result = apiInstance.GetUsers(xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // A List with the details and statistic of all registered users
    ApiResponse<UserDetailsStable> response = apiInstance.GetUsersWithHttpInfo(xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**UserDetailsStable**](UserDetailsStable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Users List |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkersingle"></a>
# **GetWorkerSingle**
> WorkerDetailsStable GetWorkerSingle (string workerId, string apikey = null, string xFields = null)

Details of a registered worker

Can retrieve the details of a worker even if inactive (A worker is considered inactive if it has not checked in for 5 minutes)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class GetWorkerSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var workerId = "workerId_example";  // string | 
            var apikey = "apikey_example";  // string | The Moderator or Owner API key (optional) 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Details of a registered worker
                WorkerDetailsStable result = apiInstance.GetWorkerSingle(workerId, apikey, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetWorkerSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkerSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Details of a registered worker
    ApiResponse<WorkerDetailsStable> response = apiInstance.GetWorkerSingleWithHttpInfo(workerId, apikey, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetWorkerSingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workerId** | **string** |  |  |
| **apikey** | **string** | The Moderator or Owner API key | [optional]  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**WorkerDetailsStable**](WorkerDetailsStable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Worker Details |  -  |
| **401** | Invalid API Key |  -  |
| **403** | Access Denied |  -  |
| **404** | Worker Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkers"></a>
# **GetWorkers**
> List&lt;WorkerDetailsStable&gt; GetWorkers (string xFields = null)

A List with the details of all registered and active workers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class GetWorkersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // A List with the details of all registered and active workers
                List<WorkerDetailsStable> result = apiInstance.GetWorkers(xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetWorkers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // A List with the details of all registered and active workers
    ApiResponse<List<WorkerDetailsStable>> response = apiInstance.GetWorkersWithHttpInfo(xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetWorkersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**List&lt;WorkerDetailsStable&gt;**](WorkerDetailsStable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Workers List |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postasyncgenerate"></a>
# **PostAsyncGenerate**
> RequestAsync PostAsyncGenerate (string apikey, GenerationInput payload, string xFields = null)

Initiate an Asynchronous request to generate images

This endpoint will immediately return with the UUID of the request for generation. This endpoint will always be accepted, even if there are no workers available currently to fulfill this request.  Perhaps some will appear in the next 10 minutes. Asynchronous requests live for 10 minutes before being considered stale and being deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class PostAsyncGenerateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The API Key corresponding to a registered user
            var payload = new GenerationInput(); // GenerationInput | 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Initiate an Asynchronous request to generate images
                RequestAsync result = apiInstance.PostAsyncGenerate(apikey, payload, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostAsyncGenerate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostAsyncGenerateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initiate an Asynchronous request to generate images
    ApiResponse<RequestAsync> response = apiInstance.PostAsyncGenerateWithHttpInfo(apikey, payload, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostAsyncGenerateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | The API Key corresponding to a registered user |  |
| **payload** | [**GenerationInput**](GenerationInput.md) |  |  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**RequestAsync**](RequestAsync.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Generation Queued |  -  |
| **400** | Validation Error |  -  |
| **401** | Invalid API Key |  -  |
| **429** | Too Many Prompts |  -  |
| **503** | Maintenance Mode |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postjobpop"></a>
# **PostJobPop**
> GenerationPayload PostJobPop (string apikey, PopInputStable payload, string xFields = null)

Check if there are generation requests queued for fulfillment

This endpoint is used by registered workers only

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class PostJobPopExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The API Key corresponding to a registered user
            var payload = new PopInputStable(); // PopInputStable | 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Check if there are generation requests queued for fulfillment
                GenerationPayload result = apiInstance.PostJobPop(apikey, payload, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostJobPop: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostJobPopWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check if there are generation requests queued for fulfillment
    ApiResponse<GenerationPayload> response = apiInstance.PostJobPopWithHttpInfo(apikey, payload, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostJobPopWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | The API Key corresponding to a registered user |  |
| **payload** | [**PopInputStable**](PopInputStable.md) |  |  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**GenerationPayload**](GenerationPayload.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Generation Popped |  -  |
| **400** | Validation Error |  -  |
| **401** | Invalid API Key |  -  |
| **403** | Access Denied |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postjobsubmit"></a>
# **PostJobSubmit**
> GenerationSubmitted PostJobSubmit (string apikey, PostJobSubmitRequest payload, string xFields = null)

Submit a generated image

This endpoint is used by registered workers only

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class PostJobSubmitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The worker's owner API key
            var payload = new PostJobSubmitRequest(); // PostJobSubmitRequest | 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Submit a generated image
                GenerationSubmitted result = apiInstance.PostJobSubmit(apikey, payload, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostJobSubmit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostJobSubmitWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit a generated image
    ApiResponse<GenerationSubmitted> response = apiInstance.PostJobSubmitWithHttpInfo(apikey, payload, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostJobSubmitWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | The worker&#39;s owner API key |  |
| **payload** | [**PostJobSubmitRequest**](PostJobSubmitRequest.md) |  |  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**GenerationSubmitted**](GenerationSubmitted.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Generation Submitted |  -  |
| **400** | Generation Already Submitted |  -  |
| **401** | Invalid API Key |  -  |
| **403** | Access Denied |  -  |
| **404** | Request Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsyncgenerate"></a>
# **PostSyncGenerate**
> RequestStatusStable PostSyncGenerate (string apikey, GenerationInput payload, string xFields = null)

Initiate a Synchronous request to generate images

This connection will only terminate when the images have been generated, or an error occured. If you connection is interrupted, you will not have the request UUID, so you cannot retrieve the images asynchronously.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class PostSyncGenerateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The API Key corresponding to a registered user
            var payload = new GenerationInput(); // GenerationInput | 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Initiate a Synchronous request to generate images
                RequestStatusStable result = apiInstance.PostSyncGenerate(apikey, payload, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostSyncGenerate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostSyncGenerateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initiate a Synchronous request to generate images
    ApiResponse<RequestStatusStable> response = apiInstance.PostSyncGenerateWithHttpInfo(apikey, payload, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostSyncGenerateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | The API Key corresponding to a registered user |  |
| **payload** | [**GenerationInput**](GenerationInput.md) |  |  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**RequestStatusStable**](RequestStatusStable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Images Generated |  -  |
| **400** | Validation Error |  -  |
| **401** | Invalid API Key |  -  |
| **429** | Too Many Prompts |  -  |
| **503** | Maintenance Mode |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransferkudos"></a>
# **PostTransferKudos**
> KudosTransferred PostTransferKudos (string apikey, PostTransferKudosRequest payload, string xFields = null)

Transfer Kudos to another registed user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class PostTransferKudosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The sending user's API key
            var payload = new PostTransferKudosRequest(); // PostTransferKudosRequest | 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Transfer Kudos to another registed user
                KudosTransferred result = apiInstance.PostTransferKudos(apikey, payload, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostTransferKudos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostTransferKudosWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Transfer Kudos to another registed user
    ApiResponse<KudosTransferred> response = apiInstance.PostTransferKudosWithHttpInfo(apikey, payload, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostTransferKudosWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | The sending user&#39;s API key |  |
| **payload** | [**PostTransferKudosRequest**](PostTransferKudosRequest.md) |  |  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**KudosTransferred**](KudosTransferred.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Generation Submitted |  -  |
| **400** | Validation Error |  -  |
| **401** | Invalid API Key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="puthordemodes"></a>
# **PutHordeModes**
> HordeModes PutHordeModes (string apikey, PutHordeModesRequest payload, string xFields = null)

Change Horde Modes

Endpoint for admins to (un)set the horde into maintenance, invite_only or raid modes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class PutHordeModesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The Admin API key
            var payload = new PutHordeModesRequest(); // PutHordeModesRequest | 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Change Horde Modes
                HordeModes result = apiInstance.PutHordeModes(apikey, payload, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PutHordeModes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutHordeModesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change Horde Modes
    ApiResponse<HordeModes> response = apiInstance.PutHordeModesWithHttpInfo(apikey, payload, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PutHordeModesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | The Admin API key |  |
| **payload** | [**PutHordeModesRequest**](PutHordeModesRequest.md) |  |  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**HordeModes**](HordeModes.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Maintenance Mode Set |  -  |
| **401** | Invalid API Key |  -  |
| **403** | Access Denied |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putusersingle"></a>
# **PutUserSingle**
> ModifyUser PutUserSingle (string userId, string apikey, PutUserSingleRequest payload, string xFields = null)

Endpoint for horde admins to perform operations on users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class PutUserSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var userId = "userId_example";  // string | 
            var apikey = "apikey_example";  // string | The Admin API key
            var payload = new PutUserSingleRequest(); // PutUserSingleRequest | 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Endpoint for horde admins to perform operations on users
                ModifyUser result = apiInstance.PutUserSingle(userId, apikey, payload, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PutUserSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutUserSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Endpoint for horde admins to perform operations on users
    ApiResponse<ModifyUser> response = apiInstance.PutUserSingleWithHttpInfo(userId, apikey, payload, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PutUserSingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |
| **apikey** | **string** | The Admin API key |  |
| **payload** | [**PutUserSingleRequest**](PutUserSingleRequest.md) |  |  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**ModifyUser**](ModifyUser.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Modify User |  -  |
| **400** | Validation Error |  -  |
| **401** | Invalid API Key |  -  |
| **403** | Access Denied |  -  |
| **404** | Worker Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putworkersingle"></a>
# **PutWorkerSingle**
> ModifyWorker PutWorkerSingle (string workerId, string apikey, PutWorkerSingleRequest payload, string xFields = null)

Put the worker into maintenance or pause mode

Maintenance can be set by the owner of the serve or an admin.  When in maintenance, the worker will receive a 503 request when trying to retrieve new requests. Use this to avoid disconnecting your worker in the middle of a generation Paused can be set only by the admins of this Horde. When in paused mode, the worker will not be given any requests to generate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using StableHorde.Api.Api;
using StableHorde.Api.Client;
using StableHorde.Api.Model;

namespace Example
{
    public class PutWorkerSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var workerId = "workerId_example";  // string | 
            var apikey = "apikey_example";  // string | The Moderator or Owner API key
            var payload = new PutWorkerSingleRequest(); // PutWorkerSingleRequest | 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Put the worker into maintenance or pause mode
                ModifyWorker result = apiInstance.PutWorkerSingle(workerId, apikey, payload, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PutWorkerSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutWorkerSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Put the worker into maintenance or pause mode
    ApiResponse<ModifyWorker> response = apiInstance.PutWorkerSingleWithHttpInfo(workerId, apikey, payload, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PutWorkerSingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workerId** | **string** |  |  |
| **apikey** | **string** | The Moderator or Owner API key |  |
| **payload** | [**PutWorkerSingleRequest**](PutWorkerSingleRequest.md) |  |  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**ModifyWorker**](ModifyWorker.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Modify Worker |  -  |
| **400** | Validation Error |  -  |
| **401** | Invalid API Key |  -  |
| **403** | Access Denied |  -  |
| **404** | Worker Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

