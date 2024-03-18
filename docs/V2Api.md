# Knedlex.StableHorde.Api.Api.V2Api

All URIs are relative to */api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteFilterSingle**](V2Api.md#deletefiltersingle) | **DELETE** /v2/filters/{filter_id} | Moderator Only: Delete a regex filter |
| [**DeleteImageAsyncStatus**](V2Api.md#deleteimageasyncstatus) | **DELETE** /v2/generate/status/{id} | Cancel an unfinished request |
| [**DeleteInterrogationStatus**](V2Api.md#deleteinterrogationstatus) | **DELETE** /v2/interrogate/status/{id} | Cancel an unfinished interrogation request |
| [**DeleteOperationsBlockWorkerIp**](V2Api.md#deleteoperationsblockworkerip) | **DELETE** /v2/operations/block_worker_ipaddr/{worker_id} | Remove a worker&#39;s IP block |
| [**DeleteOperationsIp**](V2Api.md#deleteoperationsip) | **DELETE** /v2/operations/ipaddr | Remove an IP from timeout |
| [**DeleteSharedKeySingle**](V2Api.md#deletesharedkeysingle) | **DELETE** /v2/sharedkeys/{sharedkey_id} | Delete an existing SharedKey for this user |
| [**DeleteTeamSingle**](V2Api.md#deleteteamsingle) | **DELETE** /v2/teams/{team_id} | Delete the team entry |
| [**DeleteTextAsyncStatus**](V2Api.md#deletetextasyncstatus) | **DELETE** /v2/generate/text/status/{id} | Cancel an unfinished request |
| [**DeleteWorkerSingle**](V2Api.md#deleteworkersingle) | **DELETE** /v2/workers/{worker_id} | Delete the worker entry |
| [**GetFilterRegex**](V2Api.md#getfilterregex) | **GET** /v2/filters/regex | Moderator Only: A List all filters, or filtered by the query |
| [**GetFilterSingle**](V2Api.md#getfiltersingle) | **GET** /v2/filters/{filter_id} | Moderator Only: Display a single filter |
| [**GetFilters**](V2Api.md#getfilters) | **GET** /v2/filters | Moderator Only: A List all filters, or filtered by the query |
| [**GetFindUser**](V2Api.md#getfinduser) | **GET** /v2/find_user | Lookup user details based on their API key |
| [**GetHeartbeat**](V2Api.md#getheartbeat) | **GET** /v2/status/heartbeat | If this loads, this node is available |
| [**GetHordeLoad**](V2Api.md#gethordeload) | **GET** /v2/status/performance | Details about the current performance of this Horde |
| [**GetHordeModes**](V2Api.md#gethordemodes) | **GET** /v2/status/modes | Horde Maintenance Mode Status |
| [**GetHordeNews**](V2Api.md#gethordenews) | **GET** /v2/status/news | Read the latest happenings on the horde |
| [**GetImageAsyncCheck**](V2Api.md#getimageasynccheck) | **GET** /v2/generate/check/{id} | Retrieve the status of an Asynchronous generation request without images |
| [**GetImageAsyncStatus**](V2Api.md#getimageasyncstatus) | **GET** /v2/generate/status/{id} | Retrieve the full status of an Asynchronous generation request |
| [**GetImageHordeStatsModels**](V2Api.md#getimagehordestatsmodels) | **GET** /v2/stats/img/models | Details how many images were generated per model for the past day, month and total |
| [**GetImageHordeStatsTotals**](V2Api.md#getimagehordestatstotals) | **GET** /v2/stats/img/totals | Details how many images have been generated in the past minux,hour,day,month and total |
| [**GetInterrogationStatus**](V2Api.md#getinterrogationstatus) | **GET** /v2/interrogate/status/{id} | Retrieve the full status of an interrogation request |
| [**GetModelSingle**](V2Api.md#getmodelsingle) | **GET** /v2/status/models/{model_name} | Returns all the statistics of a specific model in this horde |
| [**GetModels**](V2Api.md#getmodels) | **GET** /v2/status/models | Returns a list of models active currently in this horde |
| [**GetOperationsIp**](V2Api.md#getoperationsip) | **GET** /v2/operations/ipaddr | Return all existing IP Block timeouts |
| [**GetOperationsIpSingle**](V2Api.md#getoperationsipsingle) | **GET** /v2/operations/ipaddr/{ipaddr} | Check if an IP or CIDR is in timeout |
| [**GetSharedKeySingle**](V2Api.md#getsharedkeysingle) | **GET** /v2/sharedkeys/{sharedkey_id} | Get details about an existing Shared Key |
| [**GetTeamSingle**](V2Api.md#getteamsingle) | **GET** /v2/teams/{team_id} | Details of a worker Team |
| [**GetTeams**](V2Api.md#getteams) | **GET** /v2/teams | A List with the details of all teams |
| [**GetTextAsyncStatus**](V2Api.md#gettextasyncstatus) | **GET** /v2/generate/text/status/{id} | Retrieve the full status of an Asynchronous generation request |
| [**GetTextHordeStatsModels**](V2Api.md#gettexthordestatsmodels) | **GET** /v2/stats/text/models | Details how many texts were generated per model for the past day, month and total |
| [**GetTextHordeStatsTotals**](V2Api.md#gettexthordestatstotals) | **GET** /v2/stats/text/totals | Details how many texts have been generated in the past minux,hour,day,month and total |
| [**GetUserSingle**](V2Api.md#getusersingle) | **GET** /v2/users/{user_id} | Details and statistics about a specific user |
| [**GetUsers**](V2Api.md#getusers) | **GET** /v2/users | A List with the details and statistic of all registered users |
| [**GetWorkerSingle**](V2Api.md#getworkersingle) | **GET** /v2/workers/{worker_id} | Details of a registered worker |
| [**GetWorkers**](V2Api.md#getworkers) | **GET** /v2/workers | A List with the details of all registered and active workers |
| [**PatchFilterSingle**](V2Api.md#patchfiltersingle) | **PATCH** /v2/filters/{filter_id} | Moderator Only: Modify an existing regex filter |
| [**PatchSharedKeySingle**](V2Api.md#patchsharedkeysingle) | **PATCH** /v2/sharedkeys/{sharedkey_id} | Modify an existing Shared Key |
| [**PatchTeamSingle**](V2Api.md#patchteamsingle) | **PATCH** /v2/teams/{team_id} | Update a Team&#39;s information |
| [**PostAesthetics**](V2Api.md#postaesthetics) | **POST** /v2/generate/rate/{id} | Submit aesthetic ratings for generated images to be used by LAION and Stability |
| [**PostAwardKudos**](V2Api.md#postawardkudos) | **POST** /v2/kudos/award | Awards Kudos to registed user |
| [**PostFilters**](V2Api.md#postfilters) | **POST** /v2/filters | Moderator Only: Check The suspicion of the provided prompt |
| [**PostImageAsyncGenerate**](V2Api.md#postimageasyncgenerate) | **POST** /v2/generate/async | Initiate an Asynchronous request to generate images |
| [**PostImageJobPop**](V2Api.md#postimagejobpop) | **POST** /v2/generate/pop | Check if there are generation requests queued for fulfillment |
| [**PostImageJobSubmit**](V2Api.md#postimagejobsubmit) | **POST** /v2/generate/submit | Submit a generated image |
| [**PostInterrogate**](V2Api.md#postinterrogate) | **POST** /v2/interrogate/async | Initiate an Asynchronous request to interrogate an image |
| [**PostInterrogatePop**](V2Api.md#postinterrogatepop) | **POST** /v2/interrogate/pop | Check if there are interrogation requests queued for fulfillment |
| [**PostInterrogateSubmit**](V2Api.md#postinterrogatesubmit) | **POST** /v2/interrogate/submit | Submit the results of an interrogated image |
| [**PostOperationsIp**](V2Api.md#postoperationsip) | **POST** /v2/operations/ipaddr | Add an IP or CIDR to timeout |
| [**PostTeams**](V2Api.md#postteams) | **POST** /v2/teams | Create a new team |
| [**PostTextAsyncGenerate**](V2Api.md#posttextasyncgenerate) | **POST** /v2/generate/text/async | Initiate an Asynchronous request to generate text |
| [**PostTextJobPop**](V2Api.md#posttextjobpop) | **POST** /v2/generate/text/pop | Check if there are generation requests queued for fulfillment |
| [**PostTextJobSubmit**](V2Api.md#posttextjobsubmit) | **POST** /v2/generate/text/submit | Submit generated text |
| [**PostTransferKudos**](V2Api.md#posttransferkudos) | **POST** /v2/kudos/transfer | Transfer Kudos to another registed user |
| [**PutFilters**](V2Api.md#putfilters) | **PUT** /v2/filters | Moderator Only: Add a new regex filter |
| [**PutHordeModes**](V2Api.md#puthordemodes) | **PUT** /v2/status/modes | Change Horde Modes |
| [**PutOperationsBlockWorkerIp**](V2Api.md#putoperationsblockworkerip) | **PUT** /v2/operations/block_worker_ipaddr/{worker_id} | Block worker&#39;s from a specific IP for 24 hours |
| [**PutSharedKey**](V2Api.md#putsharedkey) | **PUT** /v2/sharedkeys | Create a new SharedKey for this user |
| [**PutUserSingle**](V2Api.md#putusersingle) | **PUT** /v2/users/{user_id} | Endpoint for horde admins to perform operations on users |
| [**PutWorkerSingle**](V2Api.md#putworkersingle) | **PUT** /v2/workers/{worker_id} |  |

<a id="deletefiltersingle"></a>
# **DeleteFilterSingle**
> SimpleResponse DeleteFilterSingle (string filterId, string apikey, string clientAgent = null, string xFields = null)

Moderator Only: Delete a regex filter

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class DeleteFilterSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var filterId = "filterId_example";  // string | 
            var apikey = "apikey_example";  // string | A mod API key.
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Moderator Only: Delete a regex filter
                SimpleResponse result = apiInstance.DeleteFilterSingle(filterId, apikey, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteFilterSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFilterSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Moderator Only: Delete a regex filter
    ApiResponse<SimpleResponse> response = apiInstance.DeleteFilterSingleWithHttpInfo(filterId, apikey, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.DeleteFilterSingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterId** | **string** |  |  |
| **apikey** | **string** | A mod API key. |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**SimpleResponse**](SimpleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Filter Deleted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteimageasyncstatus"></a>
# **DeleteImageAsyncStatus**
> RequestStatusStable DeleteImageAsyncStatus (string id, string clientAgent = null, string xFields = null)

Cancel an unfinished request

This request will include all already generated images in base64 encoded .webp files.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class DeleteImageAsyncStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var id = "id_example";  // string | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Cancel an unfinished request
                RequestStatusStable result = apiInstance.DeleteImageAsyncStatus(id, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteImageAsyncStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteImageAsyncStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel an unfinished request
    ApiResponse<RequestStatusStable> response = apiInstance.DeleteImageAsyncStatusWithHttpInfo(id, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.DeleteImageAsyncStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **clientAgent** | **string** | The client name and version | [optional] [default to &quot;unknown:0:unknown&quot;] |
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
| **404** | Request Not found |  -  |
| **200** | Async Request Full Status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteinterrogationstatus"></a>
# **DeleteInterrogationStatus**
> InterrogationStatus DeleteInterrogationStatus (string id, string clientAgent = null, string xFields = null)

Cancel an unfinished interrogation request

This request will return all already interrogated image results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class DeleteInterrogationStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var id = "id_example";  // string | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Cancel an unfinished interrogation request
                InterrogationStatus result = apiInstance.DeleteInterrogationStatus(id, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteInterrogationStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInterrogationStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel an unfinished interrogation request
    ApiResponse<InterrogationStatus> response = apiInstance.DeleteInterrogationStatusWithHttpInfo(id, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.DeleteInterrogationStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **clientAgent** | **string** | The client name and version | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**InterrogationStatus**](InterrogationStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Request Not found |  -  |
| **200** | Interrogation Request Status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteoperationsblockworkerip"></a>
# **DeleteOperationsBlockWorkerIp**
> SimpleResponse DeleteOperationsBlockWorkerIp (string workerId, string apikey, string clientAgent = null, string xFields = null)

Remove a worker's IP block

Only usable by horde moderators

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class DeleteOperationsBlockWorkerIpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var workerId = "workerId_example";  // string | 
            var apikey = "apikey_example";  // string | A mod API key.
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Remove a worker's IP block
                SimpleResponse result = apiInstance.DeleteOperationsBlockWorkerIp(workerId, apikey, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteOperationsBlockWorkerIp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteOperationsBlockWorkerIpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a worker's IP block
    ApiResponse<SimpleResponse> response = apiInstance.DeleteOperationsBlockWorkerIpWithHttpInfo(workerId, apikey, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.DeleteOperationsBlockWorkerIpWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workerId** | **string** |  |  |
| **apikey** | **string** | A mod API key. |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**SimpleResponse**](SimpleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Operation Completed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteoperationsip"></a>
# **DeleteOperationsIp**
> SimpleResponse DeleteOperationsIp (string apikey, DeleteTimeoutIPInput payload, string clientAgent = null, string xFields = null)

Remove an IP from timeout

Only usable by horde moderators

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class DeleteOperationsIpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | A mod API key.
            var payload = new DeleteTimeoutIPInput(); // DeleteTimeoutIPInput | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Remove an IP from timeout
                SimpleResponse result = apiInstance.DeleteOperationsIp(apikey, payload, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteOperationsIp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteOperationsIpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove an IP from timeout
    ApiResponse<SimpleResponse> response = apiInstance.DeleteOperationsIpWithHttpInfo(apikey, payload, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.DeleteOperationsIpWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | A mod API key. |  |
| **payload** | [**DeleteTimeoutIPInput**](DeleteTimeoutIPInput.md) |  |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**SimpleResponse**](SimpleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Operation Completed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletesharedkeysingle"></a>
# **DeleteSharedKeySingle**
> SimpleResponse DeleteSharedKeySingle (string sharedkeyId, string apikey, string clientAgent = null, string xFields = null)

Delete an existing SharedKey for this user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class DeleteSharedKeySingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var sharedkeyId = "sharedkeyId_example";  // string | 
            var apikey = "apikey_example";  // string | User API key.
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Delete an existing SharedKey for this user
                SimpleResponse result = apiInstance.DeleteSharedKeySingle(sharedkeyId, apikey, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteSharedKeySingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSharedKeySingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing SharedKey for this user
    ApiResponse<SimpleResponse> response = apiInstance.DeleteSharedKeySingleWithHttpInfo(sharedkeyId, apikey, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.DeleteSharedKeySingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sharedkeyId** | **string** |  |  |
| **apikey** | **string** | User API key. |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**SimpleResponse**](SimpleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Shared Key Not Found |  -  |
| **200** | Shared Key Deleted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteteamsingle"></a>
# **DeleteTeamSingle**
> DeletedTeam DeleteTeamSingle (string teamId, string clientAgent = null, string apikey = null, string xFields = null)

Delete the team entry

Only the team's creator or a horde moderator can use this endpoint. This action is unrecoverable!

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class DeleteTeamSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var teamId = "teamId_example";  // string | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var apikey = "apikey_example";  // string | The Moderator or Owner API key. (optional) 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Delete the team entry
                DeletedTeam result = apiInstance.DeleteTeamSingle(teamId, clientAgent, apikey, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteTeamSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTeamSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete the team entry
    ApiResponse<DeletedTeam> response = apiInstance.DeleteTeamSingleWithHttpInfo(teamId, clientAgent, apikey, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.DeleteTeamSingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **teamId** | **string** |  |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **apikey** | **string** | The Moderator or Owner API key. | [optional]  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**DeletedTeam**](DeletedTeam.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Team Not Found |  -  |
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **200** | Delete Team |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetextasyncstatus"></a>
# **DeleteTextAsyncStatus**
> RequestStatusKobold DeleteTextAsyncStatus (string id, string clientAgent = null, string xFields = null)

Cancel an unfinished request

This request will include all already generated texts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class DeleteTextAsyncStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var id = "id_example";  // string | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Cancel an unfinished request
                RequestStatusKobold result = apiInstance.DeleteTextAsyncStatus(id, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.DeleteTextAsyncStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTextAsyncStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel an unfinished request
    ApiResponse<RequestStatusKobold> response = apiInstance.DeleteTextAsyncStatusWithHttpInfo(id, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.DeleteTextAsyncStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **clientAgent** | **string** | The client name and version | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**RequestStatusKobold**](RequestStatusKobold.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Request Not found |  -  |
| **200** | Async Request Full Status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteworkersingle"></a>
# **DeleteWorkerSingle**
> DeletedWorker DeleteWorkerSingle (string workerId, string apikey = null, string clientAgent = null, string xFields = null)

Delete the worker entry

This will delete the worker and their statistics. Will not affect the kudos generated by that worker for their owner. Only the worker's owner and an admin can use this endpoint. This action is unrecoverable!

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

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
            var apikey = "apikey_example";  // string | The Moderator or Owner API key. (optional) 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Delete the worker entry
                DeletedWorker result = apiInstance.DeleteWorkerSingle(workerId, apikey, clientAgent, xFields);
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
    ApiResponse<DeletedWorker> response = apiInstance.DeleteWorkerSingleWithHttpInfo(workerId, apikey, clientAgent, xFields);
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
| **apikey** | **string** | The Moderator or Owner API key. | [optional]  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
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
| **404** | Worker Not Found |  -  |
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **200** | Delete Worker |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfilterregex"></a>
# **GetFilterRegex**
> List&lt;FilterRegex&gt; GetFilterRegex (string apikey, string clientAgent = null, int? filterType = null, string xFields = null)

Moderator Only: A List all filters, or filtered by the query

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetFilterRegexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | A mod API key.
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var filterType = 56;  // int? | The filter type. (optional) 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Moderator Only: A List all filters, or filtered by the query
                List<FilterRegex> result = apiInstance.GetFilterRegex(apikey, clientAgent, filterType, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetFilterRegex: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFilterRegexWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Moderator Only: A List all filters, or filtered by the query
    ApiResponse<List<FilterRegex>> response = apiInstance.GetFilterRegexWithHttpInfo(apikey, clientAgent, filterType, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetFilterRegexWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | A mod API key. |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **filterType** | **int?** | The filter type. | [optional]  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**List&lt;FilterRegex&gt;**](FilterRegex.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Filters Regex |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfiltersingle"></a>
# **GetFilterSingle**
> List&lt;FilterDetails&gt; GetFilterSingle (string filterId, string apikey, string clientAgent = null, string xFields = null)

Moderator Only: Display a single filter

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetFilterSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var filterId = "filterId_example";  // string | 
            var apikey = "apikey_example";  // string | A mod API key.
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Moderator Only: Display a single filter
                List<FilterDetails> result = apiInstance.GetFilterSingle(filterId, apikey, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetFilterSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFilterSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Moderator Only: Display a single filter
    ApiResponse<List<FilterDetails>> response = apiInstance.GetFilterSingleWithHttpInfo(filterId, apikey, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetFilterSingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterId** | **string** |  |  |
| **apikey** | **string** | A mod API key. |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**List&lt;FilterDetails&gt;**](FilterDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Filters List |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfilters"></a>
# **GetFilters**
> List&lt;FilterDetails&gt; GetFilters (string apikey, string clientAgent = null, int? filterType = null, string contains = null, string xFields = null)

Moderator Only: A List all filters, or filtered by the query

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetFiltersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | A mod API key.
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var filterType = 56;  // int? | The filter type. (optional) 
            var contains = "contains_example";  // string | Only return filter containing this word. (optional) 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Moderator Only: A List all filters, or filtered by the query
                List<FilterDetails> result = apiInstance.GetFilters(apikey, clientAgent, filterType, contains, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetFilters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFiltersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Moderator Only: A List all filters, or filtered by the query
    ApiResponse<List<FilterDetails>> response = apiInstance.GetFiltersWithHttpInfo(apikey, clientAgent, filterType, contains, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetFiltersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | A mod API key. |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **filterType** | **int?** | The filter type. | [optional]  |
| **contains** | **string** | Only return filter containing this word. | [optional]  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**List&lt;FilterDetails&gt;**](FilterDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Filters List |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfinduser"></a>
# **GetFindUser**
> UserDetails GetFindUser (string apikey = null, string clientAgent = null, string xFields = null)

Lookup user details based on their API key

This can be used to verify a user exists

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetFindUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | User API key we're looking for. (optional) 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Lookup user details based on their API key
                UserDetails result = apiInstance.GetFindUser(apikey, clientAgent, xFields);
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
    ApiResponse<UserDetails> response = apiInstance.GetFindUserWithHttpInfo(apikey, clientAgent, xFields);
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
| **apikey** | **string** | User API key we&#39;re looking for. | [optional]  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**UserDetails**](UserDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | User Not Found |  -  |
| **400** | Validation Error |  -  |
| **200** | Worker Details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getheartbeat"></a>
# **GetHeartbeat**
> void GetHeartbeat (string clientAgent = null)

If this loads, this node is available

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetHeartbeatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")

            try
            {
                // If this loads, this node is available
                apiInstance.GetHeartbeat(clientAgent);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetHeartbeat: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHeartbeatWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // If this loads, this node is available
    apiInstance.GetHeartbeatWithHttpInfo(clientAgent);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetHeartbeatWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gethordeload"></a>
# **GetHordeLoad**
> HordePerformance GetHordeLoad (string clientAgent = null, string xFields = null)

Details about the current performance of this Horde

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetHordeLoadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Details about the current performance of this Horde
                HordePerformance result = apiInstance.GetHordeLoad(clientAgent, xFields);
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
    ApiResponse<HordePerformance> response = apiInstance.GetHordeLoadWithHttpInfo(clientAgent, xFields);
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
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**HordePerformance**](HordePerformance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | AI Horde Performance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gethordemodes"></a>
# **GetHordeModes**
> HordeModes GetHordeModes (string apikey = null, string xFields = null)

Horde Maintenance Mode Status

Use this endpoint to quicky determine if this horde is in maintenance, invite_only or raid mode.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetHordeModesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The Admin or Owner API key. (optional) 
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
| **apikey** | **string** | The Admin or Owner API key. | [optional]  |
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
| **200** | AI Horde Maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gethordenews"></a>
# **GetHordeNews**
> List&lt;Newspiece&gt; GetHordeNews (string clientAgent = null, string xFields = null)

Read the latest happenings on the horde

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetHordeNewsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Read the latest happenings on the horde
                List<Newspiece> result = apiInstance.GetHordeNews(clientAgent, xFields);
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
    ApiResponse<List<Newspiece>> response = apiInstance.GetHordeNewsWithHttpInfo(clientAgent, xFields);
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
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
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
| **200** | AI Horde News |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getimageasynccheck"></a>
# **GetImageAsyncCheck**
> RequestStatusCheck GetImageAsyncCheck (string id, string clientAgent = null, string xFields = null)

Retrieve the status of an Asynchronous generation request without images

Use this request to check the status of a currently running asynchronous request without consuming bandwidth.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetImageAsyncCheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var id = "id_example";  // string | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Retrieve the status of an Asynchronous generation request without images
                RequestStatusCheck result = apiInstance.GetImageAsyncCheck(id, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetImageAsyncCheck: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetImageAsyncCheckWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the status of an Asynchronous generation request without images
    ApiResponse<RequestStatusCheck> response = apiInstance.GetImageAsyncCheckWithHttpInfo(id, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetImageAsyncCheckWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **clientAgent** | **string** | The client name and version | [optional] [default to &quot;unknown:0:unknown&quot;] |
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
| **404** | Request Not found |  -  |
| **200** | Async Request Status Check |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getimageasyncstatus"></a>
# **GetImageAsyncStatus**
> RequestStatusStable GetImageAsyncStatus (string id, string clientAgent = null, string xFields = null)

Retrieve the full status of an Asynchronous generation request

This request will include all already generated images in download URL or base64 encoded .webp files. As such, you are requested to not retrieve this endpoint often. Instead use the /check/ endpoint first This endpoint is limited to 10 request per minute

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetImageAsyncStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var id = "id_example";  // string | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Retrieve the full status of an Asynchronous generation request
                RequestStatusStable result = apiInstance.GetImageAsyncStatus(id, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetImageAsyncStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetImageAsyncStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the full status of an Asynchronous generation request
    ApiResponse<RequestStatusStable> response = apiInstance.GetImageAsyncStatusWithHttpInfo(id, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetImageAsyncStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **clientAgent** | **string** | The client name and version | [optional] [default to &quot;unknown:0:unknown&quot;] |
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
| **404** | Request Not found |  -  |
| **200** | Async Request Full Status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getimagehordestatsmodels"></a>
# **GetImageHordeStatsModels**
> ImgModelStats GetImageHordeStatsModels (string clientAgent = null, string xFields = null)

Details how many images were generated per model for the past day, month and total

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetImageHordeStatsModelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Details how many images were generated per model for the past day, month and total
                ImgModelStats result = apiInstance.GetImageHordeStatsModels(clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetImageHordeStatsModels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetImageHordeStatsModelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Details how many images were generated per model for the past day, month and total
    ApiResponse<ImgModelStats> response = apiInstance.GetImageHordeStatsModelsWithHttpInfo(clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetImageHordeStatsModelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientAgent** | **string** | The client name and version | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**ImgModelStats**](ImgModelStats.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | AI Horde generated images statistics per model |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getimagehordestatstotals"></a>
# **GetImageHordeStatsTotals**
> StatsImgTotals GetImageHordeStatsTotals (string clientAgent = null, string xFields = null)

Details how many images have been generated in the past minux,hour,day,month and total

Also shows the amount of pixelsteps for the same timeframe.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetImageHordeStatsTotalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Details how many images have been generated in the past minux,hour,day,month and total
                StatsImgTotals result = apiInstance.GetImageHordeStatsTotals(clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetImageHordeStatsTotals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetImageHordeStatsTotalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Details how many images have been generated in the past minux,hour,day,month and total
    ApiResponse<StatsImgTotals> response = apiInstance.GetImageHordeStatsTotalsWithHttpInfo(clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetImageHordeStatsTotalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientAgent** | **string** | The client name and version | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**StatsImgTotals**](StatsImgTotals.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | AI Horde generated images statistics |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinterrogationstatus"></a>
# **GetInterrogationStatus**
> InterrogationStatus GetInterrogationStatus (string id, string clientAgent = null, string xFields = null)

Retrieve the full status of an interrogation request

This request will include all already generated images. As such, you are requested to not retrieve this endpoint often. Instead use the /check/ endpoint first

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetInterrogationStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var id = "id_example";  // string | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Retrieve the full status of an interrogation request
                InterrogationStatus result = apiInstance.GetInterrogationStatus(id, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetInterrogationStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInterrogationStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the full status of an interrogation request
    ApiResponse<InterrogationStatus> response = apiInstance.GetInterrogationStatusWithHttpInfo(id, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetInterrogationStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **clientAgent** | **string** | The client name and version | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**InterrogationStatus**](InterrogationStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Request Not found |  -  |
| **200** | Interrogation Request Status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmodelsingle"></a>
# **GetModelSingle**
> ActiveModel GetModelSingle (string modelName, string clientAgent = null, string xFields = null)

Returns all the statistics of a specific model in this horde

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetModelSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var modelName = "modelName_example";  // string | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Returns all the statistics of a specific model in this horde
                ActiveModel result = apiInstance.GetModelSingle(modelName, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetModelSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetModelSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all the statistics of a specific model in this horde
    ApiResponse<ActiveModel> response = apiInstance.GetModelSingleWithHttpInfo(modelName, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetModelSingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **modelName** | **string** |  |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**ActiveModel**](ActiveModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Lists specific model stats |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmodels"></a>
# **GetModels**
> List&lt;ActiveModel&gt; GetModels (string clientAgent = null, string type = null, int? minCount = null, int? maxCount = null, string xFields = null)

Returns a list of models active currently in this horde

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetModelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var type = "\"image\"";  // string | Filter the models by type (image or text). (optional)  (default to "image")
            var minCount = 56;  // int? | Filter only models that have at least this amount of threads serving. (optional) 
            var maxCount = 56;  // int? | Filter the models that have at most this amount of threads serving. (optional) 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Returns a list of models active currently in this horde
                List<ActiveModel> result = apiInstance.GetModels(clientAgent, type, minCount, maxCount, xFields);
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
    ApiResponse<List<ActiveModel>> response = apiInstance.GetModelsWithHttpInfo(clientAgent, type, minCount, maxCount, xFields);
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
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **type** | **string** | Filter the models by type (image or text). | [optional] [default to &quot;image&quot;] |
| **minCount** | **int?** | Filter only models that have at least this amount of threads serving. | [optional]  |
| **maxCount** | **int?** | Filter the models that have at most this amount of threads serving. | [optional]  |
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

<a id="getoperationsip"></a>
# **GetOperationsIp**
> List&lt;IPTimeout&gt; GetOperationsIp (string apikey, string clientAgent = null, string xFields = null)

Return all existing IP Block timeouts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetOperationsIpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | A mod API key.
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Return all existing IP Block timeouts
                List<IPTimeout> result = apiInstance.GetOperationsIp(apikey, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetOperationsIp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOperationsIpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return all existing IP Block timeouts
    ApiResponse<List<IPTimeout>> response = apiInstance.GetOperationsIpWithHttpInfo(apikey, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetOperationsIpWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | A mod API key. |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**List&lt;IPTimeout&gt;**](IPTimeout.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | An IP timeout entry |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getoperationsipsingle"></a>
# **GetOperationsIpSingle**
> List&lt;IPTimeout&gt; GetOperationsIpSingle (string ipaddr, string apikey, string clientAgent = null, string xFields = null)

Check if an IP or CIDR is in timeout

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetOperationsIpSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var ipaddr = "ipaddr_example";  // string | 
            var apikey = "apikey_example";  // string | A mod API key.
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Check if an IP or CIDR is in timeout
                List<IPTimeout> result = apiInstance.GetOperationsIpSingle(ipaddr, apikey, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetOperationsIpSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOperationsIpSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check if an IP or CIDR is in timeout
    ApiResponse<List<IPTimeout>> response = apiInstance.GetOperationsIpSingleWithHttpInfo(ipaddr, apikey, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetOperationsIpSingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ipaddr** | **string** |  |  |
| **apikey** | **string** | A mod API key. |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**List&lt;IPTimeout&gt;**](IPTimeout.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | IP timeout entries that match IP |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsharedkeysingle"></a>
# **GetSharedKeySingle**
> SharedKeyDetails GetSharedKeySingle (string sharedkeyId, string clientAgent = null, string xFields = null)

Get details about an existing Shared Key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetSharedKeySingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var sharedkeyId = "sharedkeyId_example";  // string | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Get details about an existing Shared Key
                SharedKeyDetails result = apiInstance.GetSharedKeySingle(sharedkeyId, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetSharedKeySingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSharedKeySingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details about an existing Shared Key
    ApiResponse<SharedKeyDetails> response = apiInstance.GetSharedKeySingleWithHttpInfo(sharedkeyId, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetSharedKeySingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sharedkeyId** | **string** |  |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**SharedKeyDetails**](SharedKeyDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Shared Key Not Found |  -  |
| **401** | Invalid API Key |  -  |
| **200** | Shared Key Details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getteamsingle"></a>
# **GetTeamSingle**
> TeamDetails GetTeamSingle (string teamId, string apikey = null, string clientAgent = null, string xFields = null)

Details of a worker Team

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetTeamSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var teamId = "teamId_example";  // string | 
            var apikey = "apikey_example";  // string | The Moderator or Owner API key. (optional) 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Details of a worker Team
                TeamDetails result = apiInstance.GetTeamSingle(teamId, apikey, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetTeamSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTeamSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Details of a worker Team
    ApiResponse<TeamDetails> response = apiInstance.GetTeamSingleWithHttpInfo(teamId, apikey, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetTeamSingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **teamId** | **string** |  |  |
| **apikey** | **string** | The Moderator or Owner API key. | [optional]  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**TeamDetails**](TeamDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Team Not Found |  -  |
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **200** | Team Details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getteams"></a>
# **GetTeams**
> List&lt;TeamDetails&gt; GetTeams (string clientAgent = null, string xFields = null)

A List with the details of all teams

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetTeamsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // A List with the details of all teams
                List<TeamDetails> result = apiInstance.GetTeams(clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetTeams: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTeamsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // A List with the details of all teams
    ApiResponse<List<TeamDetails>> response = apiInstance.GetTeamsWithHttpInfo(clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetTeamsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**List&lt;TeamDetails&gt;**](TeamDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Teams List |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettextasyncstatus"></a>
# **GetTextAsyncStatus**
> RequestStatusKobold GetTextAsyncStatus (string id, string clientAgent = null, string xFields = null)

Retrieve the full status of an Asynchronous generation request

This request will include all already generated texts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetTextAsyncStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var id = "id_example";  // string | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Retrieve the full status of an Asynchronous generation request
                RequestStatusKobold result = apiInstance.GetTextAsyncStatus(id, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetTextAsyncStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTextAsyncStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the full status of an Asynchronous generation request
    ApiResponse<RequestStatusKobold> response = apiInstance.GetTextAsyncStatusWithHttpInfo(id, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetTextAsyncStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **clientAgent** | **string** | The client name and version | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**RequestStatusKobold**](RequestStatusKobold.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Request Not found |  -  |
| **200** | Async Request Full Status |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettexthordestatsmodels"></a>
# **GetTextHordeStatsModels**
> TxtModelStats GetTextHordeStatsModels (string clientAgent = null, string xFields = null)

Details how many texts were generated per model for the past day, month and total

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetTextHordeStatsModelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Details how many texts were generated per model for the past day, month and total
                TxtModelStats result = apiInstance.GetTextHordeStatsModels(clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetTextHordeStatsModels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTextHordeStatsModelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Details how many texts were generated per model for the past day, month and total
    ApiResponse<TxtModelStats> response = apiInstance.GetTextHordeStatsModelsWithHttpInfo(clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetTextHordeStatsModelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientAgent** | **string** | The client name and version | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**TxtModelStats**](TxtModelStats.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | AI Horde generated text statistics per model |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettexthordestatstotals"></a>
# **GetTextHordeStatsTotals**
> StatsTxtTotals GetTextHordeStatsTotals (string clientAgent = null, string xFields = null)

Details how many texts have been generated in the past minux,hour,day,month and total

Also shows the amount of pixelsteps for the same timeframe.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetTextHordeStatsTotalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Details how many texts have been generated in the past minux,hour,day,month and total
                StatsTxtTotals result = apiInstance.GetTextHordeStatsTotals(clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.GetTextHordeStatsTotals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTextHordeStatsTotalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Details how many texts have been generated in the past minux,hour,day,month and total
    ApiResponse<StatsTxtTotals> response = apiInstance.GetTextHordeStatsTotalsWithHttpInfo(clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.GetTextHordeStatsTotalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientAgent** | **string** | The client name and version | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**StatsTxtTotals**](StatsTxtTotals.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | AI Horde generated text statistics |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getusersingle"></a>
# **GetUserSingle**
> UserDetails GetUserSingle (string userId, string apikey = null, string clientAgent = null, string xFields = null)

Details and statistics about a specific user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

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
            var apikey = "apikey_example";  // string | The Admin, Mod or Owner API key. (optional) 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Details and statistics about a specific user
                UserDetails result = apiInstance.GetUserSingle(userId, apikey, clientAgent, xFields);
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
    ApiResponse<UserDetails> response = apiInstance.GetUserSingleWithHttpInfo(userId, apikey, clientAgent, xFields);
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
| **apikey** | **string** | The Admin, Mod or Owner API key. | [optional]  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**UserDetails**](UserDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | User Not Found |  -  |
| **401** | Invalid API Key |  -  |
| **200** | User Details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getusers"></a>
# **GetUsers**
> UserDetails GetUsers (string clientAgent = null, int? page = null, string sort = null, string xFields = null)

A List with the details and statistic of all registered users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var page = 1;  // int? | Which page of results to return. Each page has 25 users. (optional)  (default to 1)
            var sort = "\"kudos\"";  // string | How to sort the returned list. (optional)  (default to "kudos")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // A List with the details and statistic of all registered users
                UserDetails result = apiInstance.GetUsers(clientAgent, page, sort, xFields);
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
    ApiResponse<UserDetails> response = apiInstance.GetUsersWithHttpInfo(clientAgent, page, sort, xFields);
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
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **page** | **int?** | Which page of results to return. Each page has 25 users. | [optional] [default to 1] |
| **sort** | **string** | How to sort the returned list. | [optional] [default to &quot;kudos&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**UserDetails**](UserDetails.md)

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

<a id="getworkersingle"></a>
# **GetWorkerSingle**
> WorkerDetails GetWorkerSingle (string workerId, string apikey = null, string clientAgent = null, string xFields = null)

Details of a registered worker

Can retrieve the details of a worker even if inactive (A worker is considered inactive if it has not checked in for 5 minutes)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

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
            var apikey = "apikey_example";  // string | The Moderator or Owner API key. (optional) 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Details of a registered worker
                WorkerDetails result = apiInstance.GetWorkerSingle(workerId, apikey, clientAgent, xFields);
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
    ApiResponse<WorkerDetails> response = apiInstance.GetWorkerSingleWithHttpInfo(workerId, apikey, clientAgent, xFields);
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
| **apikey** | **string** | The Moderator or Owner API key. | [optional]  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**WorkerDetails**](WorkerDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Worker Not Found |  -  |
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **200** | Worker Details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworkers"></a>
# **GetWorkers**
> List&lt;WorkerDetails&gt; GetWorkers (string apikey = null, string clientAgent = null, string type = null, string xFields = null)

A List with the details of all registered and active workers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class GetWorkersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | A Moderator API key. (optional) 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var type = "type_example";  // string | Filter the workers by type (image, text or interrogation). (optional) 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // A List with the details of all registered and active workers
                List<WorkerDetails> result = apiInstance.GetWorkers(apikey, clientAgent, type, xFields);
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
    ApiResponse<List<WorkerDetails>> response = apiInstance.GetWorkersWithHttpInfo(apikey, clientAgent, type, xFields);
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
| **apikey** | **string** | A Moderator API key. | [optional]  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **type** | **string** | Filter the workers by type (image, text or interrogation). | [optional]  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**List&lt;WorkerDetails&gt;**](WorkerDetails.md)

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

<a id="patchfiltersingle"></a>
# **PatchFilterSingle**
> FilterDetails PatchFilterSingle (string filterId, string apikey, PatchExistingFilter payload, string clientAgent = null, string xFields = null)

Moderator Only: Modify an existing regex filter

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PatchFilterSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var filterId = "filterId_example";  // string | 
            var apikey = "apikey_example";  // string | A mod API key.
            var payload = new PatchExistingFilter(); // PatchExistingFilter | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Moderator Only: Modify an existing regex filter
                FilterDetails result = apiInstance.PatchFilterSingle(filterId, apikey, payload, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PatchFilterSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchFilterSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Moderator Only: Modify an existing regex filter
    ApiResponse<FilterDetails> response = apiInstance.PatchFilterSingleWithHttpInfo(filterId, apikey, payload, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PatchFilterSingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterId** | **string** |  |  |
| **apikey** | **string** | A mod API key. |  |
| **payload** | [**PatchExistingFilter**](PatchExistingFilter.md) |  |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**FilterDetails**](FilterDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Patched Filter details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="patchsharedkeysingle"></a>
# **PatchSharedKeySingle**
> SharedKeyDetails PatchSharedKeySingle (string sharedkeyId, string apikey, SharedKeyInput payload, string clientAgent = null, string xFields = null)

Modify an existing Shared Key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PatchSharedKeySingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var sharedkeyId = "sharedkeyId_example";  // string | 
            var apikey = "apikey_example";  // string | User API key.
            var payload = new SharedKeyInput(); // SharedKeyInput | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Modify an existing Shared Key
                SharedKeyDetails result = apiInstance.PatchSharedKeySingle(sharedkeyId, apikey, payload, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PatchSharedKeySingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchSharedKeySingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Modify an existing Shared Key
    ApiResponse<SharedKeyDetails> response = apiInstance.PatchSharedKeySingleWithHttpInfo(sharedkeyId, apikey, payload, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PatchSharedKeySingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sharedkeyId** | **string** |  |  |
| **apikey** | **string** | User API key. |  |
| **payload** | [**SharedKeyInput**](SharedKeyInput.md) |  |  |
| **clientAgent** | **string** | The client name and version | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**SharedKeyDetails**](SharedKeyDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Shared Key Not Found |  -  |
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Shared Key Details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="patchteamsingle"></a>
# **PatchTeamSingle**
> ModifyTeam PatchTeamSingle (string teamId, ModifyTeamInput payload, string apikey = null, string clientAgent = null, string xFields = null)

Update a Team's information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PatchTeamSingleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var teamId = "teamId_example";  // string | 
            var payload = new ModifyTeamInput(); // ModifyTeamInput | 
            var apikey = "apikey_example";  // string | The Moderator or Creator API key. (optional) 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Update a Team's information
                ModifyTeam result = apiInstance.PatchTeamSingle(teamId, payload, apikey, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PatchTeamSingle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchTeamSingleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Team's information
    ApiResponse<ModifyTeam> response = apiInstance.PatchTeamSingleWithHttpInfo(teamId, payload, apikey, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PatchTeamSingleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **teamId** | **string** |  |  |
| **payload** | [**ModifyTeamInput**](ModifyTeamInput.md) |  |  |
| **apikey** | **string** | The Moderator or Creator API key. | [optional]  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**ModifyTeam**](ModifyTeam.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Team Not Found |  -  |
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Modify Team |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postaesthetics"></a>
# **PostAesthetics**
> GenerationSubmitted PostAesthetics (string id, AestheticsPayload payload, string clientAgent = null, string xFields = null)

Submit aesthetic ratings for generated images to be used by LAION and Stability

AI The request has to have been sent as shared: true. You can select the best image in the set, and/or provide a rating for each or some images in the set. If you select best-of image, you will gain 4 kudos. Each rating is 5 kudos. Best-of will be ignored when ratings conflict with it. You can never gain more kudos than you spent for this generation. Your reward at max will be your kudos consumption - 1.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PostAestheticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var id = "id_example";  // string | 
            var payload = new AestheticsPayload(); // AestheticsPayload | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Submit aesthetic ratings for generated images to be used by LAION and Stability
                GenerationSubmitted result = apiInstance.PostAesthetics(id, payload, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostAesthetics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostAestheticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit aesthetic ratings for generated images to be used by LAION and Stability
    ApiResponse<GenerationSubmitted> response = apiInstance.PostAestheticsWithHttpInfo(id, payload, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostAestheticsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **payload** | [**AestheticsPayload**](AestheticsPayload.md) |  |  |
| **clientAgent** | **string** | The client name and version | [optional] [default to &quot;unknown:0:unknown&quot;] |
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
| **404** | Generation Request Not Found |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Aesthetics Already Submitted |  -  |
| **200** | Aesthetics Submitted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postawardkudos"></a>
# **PostAwardKudos**
> KudosAwarded PostAwardKudos (string apikey, PostAwardKudosRequest payload, string xFields = null)

Awards Kudos to registed user

This API can only be used through privileged access.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PostAwardKudosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The sending user's API key.
            var payload = new PostAwardKudosRequest(); // PostAwardKudosRequest | 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Awards Kudos to registed user
                KudosAwarded result = apiInstance.PostAwardKudos(apikey, payload, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostAwardKudos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostAwardKudosWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Awards Kudos to registed user
    ApiResponse<KudosAwarded> response = apiInstance.PostAwardKudosWithHttpInfo(apikey, payload, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostAwardKudosWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | The sending user&#39;s API key. |  |
| **payload** | [**PostAwardKudosRequest**](PostAwardKudosRequest.md) |  |  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**KudosAwarded**](KudosAwarded.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Kudos Awarded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postfilters"></a>
# **PostFilters**
> FilterPromptSuspicion PostFilters (string apikey, PostFiltersRequest payload, string clientAgent = null, string xFields = null)

Moderator Only: Check The suspicion of the provided prompt

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PostFiltersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | A mod API key.
            var payload = new PostFiltersRequest(); // PostFiltersRequest | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Moderator Only: Check The suspicion of the provided prompt
                FilterPromptSuspicion result = apiInstance.PostFilters(apikey, payload, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostFilters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostFiltersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Moderator Only: Check The suspicion of the provided prompt
    ApiResponse<FilterPromptSuspicion> response = apiInstance.PostFiltersWithHttpInfo(apikey, payload, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostFiltersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | A mod API key. |  |
| **payload** | [**PostFiltersRequest**](PostFiltersRequest.md) |  |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**FilterPromptSuspicion**](FilterPromptSuspicion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Returns the suspicion of the provided prompt. A suspicion of 2 or more means it would be blocked. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postimageasyncgenerate"></a>
# **PostImageAsyncGenerate**
> RequestAsync PostImageAsyncGenerate (string apikey, GenerationInputStable payload, string clientAgent = null, string xFields = null)

Initiate an Asynchronous request to generate images

This endpoint will immediately return with the UUID of the request for generation. This endpoint will always be accepted, even if there are no workers available currently to fulfill this request. Perhaps some will appear in the next 10 minutes. Asynchronous requests live for 10 minutes before being considered stale and being deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PostImageAsyncGenerateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The API Key corresponding to a registered user.
            var payload = new GenerationInputStable(); // GenerationInputStable | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Initiate an Asynchronous request to generate images
                RequestAsync result = apiInstance.PostImageAsyncGenerate(apikey, payload, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostImageAsyncGenerate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostImageAsyncGenerateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initiate an Asynchronous request to generate images
    ApiResponse<RequestAsync> response = apiInstance.PostImageAsyncGenerateWithHttpInfo(apikey, payload, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostImageAsyncGenerateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | The API Key corresponding to a registered user. |  |
| **payload** | [**GenerationInputStable**](GenerationInputStable.md) |  |  |
| **clientAgent** | **string** | The client name and version | [optional] [default to &quot;unknown:0:unknown&quot;] |
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
| **429** | Too Many Prompts |  -  |
| **503** | Maintenance Mode |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **202** | Generation Queued |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postimagejobpop"></a>
# **PostImageJobPop**
> GenerationPayloadStable PostImageJobPop (string apikey, PopInputStable payload, string xFields = null)

Check if there are generation requests queued for fulfillment

This endpoint is used by registered workers only

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PostImageJobPopExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The API Key corresponding to a registered user.
            var payload = new PopInputStable(); // PopInputStable | 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Check if there are generation requests queued for fulfillment
                GenerationPayloadStable result = apiInstance.PostImageJobPop(apikey, payload, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostImageJobPop: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostImageJobPopWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check if there are generation requests queued for fulfillment
    ApiResponse<GenerationPayloadStable> response = apiInstance.PostImageJobPopWithHttpInfo(apikey, payload, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostImageJobPopWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | The API Key corresponding to a registered user. |  |
| **payload** | [**PopInputStable**](PopInputStable.md) |  |  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**GenerationPayloadStable**](GenerationPayloadStable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Generation Popped |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postimagejobsubmit"></a>
# **PostImageJobSubmit**
> GenerationSubmitted PostImageJobSubmit (string apikey, SubmitInputStable payload, string xFields = null)

Submit a generated image

This endpoint is used by registered workers only

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PostImageJobSubmitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The worker's owner API key.
            var payload = new SubmitInputStable(); // SubmitInputStable | 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Submit a generated image
                GenerationSubmitted result = apiInstance.PostImageJobSubmit(apikey, payload, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostImageJobSubmit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostImageJobSubmitWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit a generated image
    ApiResponse<GenerationSubmitted> response = apiInstance.PostImageJobSubmitWithHttpInfo(apikey, payload, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostImageJobSubmitWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | The worker&#39;s owner API key. |  |
| **payload** | [**SubmitInputStable**](SubmitInputStable.md) |  |  |
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
| **404** | Request Not Found |  -  |
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Generation Already Submitted |  -  |
| **200** | Generation Submitted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postinterrogate"></a>
# **PostInterrogate**
> RequestInterrogationResponse PostInterrogate (string apikey, ModelInterrogationInputStable payload, string clientAgent = null, string xFields = null)

Initiate an Asynchronous request to interrogate an image

This endpoint will immediately return with the UUID of the request for interrogation. This endpoint will always be accepted, even if there are no workers available currently to fulfill this request. Perhaps some will appear in the next 20 minutes. Asynchronous requests live for 20 minutes before being considered stale and being deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PostInterrogateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | A User API key
            var payload = new ModelInterrogationInputStable(); // ModelInterrogationInputStable | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Initiate an Asynchronous request to interrogate an image
                RequestInterrogationResponse result = apiInstance.PostInterrogate(apikey, payload, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostInterrogate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostInterrogateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initiate an Asynchronous request to interrogate an image
    ApiResponse<RequestInterrogationResponse> response = apiInstance.PostInterrogateWithHttpInfo(apikey, payload, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostInterrogateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | A User API key |  |
| **payload** | [**ModelInterrogationInputStable**](ModelInterrogationInputStable.md) |  |  |
| **clientAgent** | **string** | The client name and version | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**RequestInterrogationResponse**](RequestInterrogationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **429** | Too Many Prompts |  -  |
| **503** | Maintenance Mode |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **202** | Interrogation Queued |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postinterrogatepop"></a>
# **PostInterrogatePop**
> InterrogationPopPayload PostInterrogatePop (string apikey, InterrogationPopInput payload, string xFields = null)

Check if there are interrogation requests queued for fulfillment

This endpoint is used by registered workers only

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PostInterrogatePopExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The API Key corresponding to a registered user
            var payload = new InterrogationPopInput(); // InterrogationPopInput | 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Check if there are interrogation requests queued for fulfillment
                InterrogationPopPayload result = apiInstance.PostInterrogatePop(apikey, payload, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostInterrogatePop: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostInterrogatePopWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check if there are interrogation requests queued for fulfillment
    ApiResponse<InterrogationPopPayload> response = apiInstance.PostInterrogatePopWithHttpInfo(apikey, payload, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostInterrogatePopWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | The API Key corresponding to a registered user |  |
| **payload** | [**InterrogationPopInput**](InterrogationPopInput.md) |  |  |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**InterrogationPopPayload**](InterrogationPopPayload.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Interrogation Popped |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postinterrogatesubmit"></a>
# **PostInterrogateSubmit**
> GenerationSubmitted PostInterrogateSubmit (string apikey, PostInterrogateSubmitRequest payload, string xFields = null)

Submit the results of an interrogated image

This endpoint is used by registered workers only

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PostInterrogateSubmitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The worker's owner API key
            var payload = new PostInterrogateSubmitRequest(); // PostInterrogateSubmitRequest | 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Submit the results of an interrogated image
                GenerationSubmitted result = apiInstance.PostInterrogateSubmit(apikey, payload, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostInterrogateSubmit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostInterrogateSubmitWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit the results of an interrogated image
    ApiResponse<GenerationSubmitted> response = apiInstance.PostInterrogateSubmitWithHttpInfo(apikey, payload, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostInterrogateSubmitWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | The worker&#39;s owner API key |  |
| **payload** | [**PostInterrogateSubmitRequest**](PostInterrogateSubmitRequest.md) |  |  |
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
| **404** | Request Not Found |  -  |
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Generation Already Submitted |  -  |
| **200** | Interrogation Submitted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postoperationsip"></a>
# **PostOperationsIp**
> SimpleResponse PostOperationsIp (string apikey, AddTimeoutIPInput payload, string clientAgent = null, string xFields = null)

Add an IP or CIDR to timeout

Only usable by horde moderators

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PostOperationsIpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | A mod API key.
            var payload = new AddTimeoutIPInput(); // AddTimeoutIPInput | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Add an IP or CIDR to timeout
                SimpleResponse result = apiInstance.PostOperationsIp(apikey, payload, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostOperationsIp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostOperationsIpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add an IP or CIDR to timeout
    ApiResponse<SimpleResponse> response = apiInstance.PostOperationsIpWithHttpInfo(apikey, payload, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostOperationsIpWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | A mod API key. |  |
| **payload** | [**AddTimeoutIPInput**](AddTimeoutIPInput.md) |  |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**SimpleResponse**](SimpleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Operation Completed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postteams"></a>
# **PostTeams**
> ModifyTeam PostTeams (string apikey, CreateTeamInput payload, string clientAgent = null, string xFields = null)

Create a new team

Only trusted users can create new teams.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PostTeamsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | A User API key.
            var payload = new CreateTeamInput(); // CreateTeamInput | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Create a new team
                ModifyTeam result = apiInstance.PostTeams(apikey, payload, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostTeams: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostTeamsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new team
    ApiResponse<ModifyTeam> response = apiInstance.PostTeamsWithHttpInfo(apikey, payload, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostTeamsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | A User API key. |  |
| **payload** | [**CreateTeamInput**](CreateTeamInput.md) |  |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**ModifyTeam**](ModifyTeam.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Create Team |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="posttextasyncgenerate"></a>
# **PostTextAsyncGenerate**
> RequestAsync PostTextAsyncGenerate (string apikey, GenerationInputKobold payload, string clientAgent = null, string xFields = null)

Initiate an Asynchronous request to generate text

This endpoint will immediately return with the UUID of the request for generation. This endpoint will always be accepted, even if there are no workers available currently to fulfill this request. Perhaps some will appear in the next 20 minutes. Asynchronous requests live for 20 minutes before being considered stale and being deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PostTextAsyncGenerateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The API Key corresponding to a registered user.
            var payload = new GenerationInputKobold(); // GenerationInputKobold | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Initiate an Asynchronous request to generate text
                RequestAsync result = apiInstance.PostTextAsyncGenerate(apikey, payload, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostTextAsyncGenerate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostTextAsyncGenerateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initiate an Asynchronous request to generate text
    ApiResponse<RequestAsync> response = apiInstance.PostTextAsyncGenerateWithHttpInfo(apikey, payload, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostTextAsyncGenerateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | The API Key corresponding to a registered user. |  |
| **payload** | [**GenerationInputKobold**](GenerationInputKobold.md) |  |  |
| **clientAgent** | **string** | The client name and version | [optional] [default to &quot;unknown:0:unknown&quot;] |
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
| **429** | Too Many Prompts |  -  |
| **503** | Maintenance Mode |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **202** | Generation Queued |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="posttextjobpop"></a>
# **PostTextJobPop**
> GenerationPayload PostTextJobPop (string apikey, PopInputKobold payload, string xFields = null)

Check if there are generation requests queued for fulfillment

This endpoint is used by registered workers only

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PostTextJobPopExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The API Key corresponding to a registered user.
            var payload = new PopInputKobold(); // PopInputKobold | 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Check if there are generation requests queued for fulfillment
                GenerationPayload result = apiInstance.PostTextJobPop(apikey, payload, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostTextJobPop: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostTextJobPopWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check if there are generation requests queued for fulfillment
    ApiResponse<GenerationPayload> response = apiInstance.PostTextJobPopWithHttpInfo(apikey, payload, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostTextJobPopWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | The API Key corresponding to a registered user. |  |
| **payload** | [**PopInputKobold**](PopInputKobold.md) |  |  |
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
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Generation Popped |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="posttextjobsubmit"></a>
# **PostTextJobSubmit**
> GenerationSubmitted PostTextJobSubmit (string apikey, SubmitInputKobold payload, string xFields = null)

Submit generated text

This endpoint is used by registered workers only

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PostTextJobSubmitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The worker's owner API key.
            var payload = new SubmitInputKobold(); // SubmitInputKobold | 
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Submit generated text
                GenerationSubmitted result = apiInstance.PostTextJobSubmit(apikey, payload, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PostTextJobSubmit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostTextJobSubmitWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit generated text
    ApiResponse<GenerationSubmitted> response = apiInstance.PostTextJobSubmitWithHttpInfo(apikey, payload, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PostTextJobSubmitWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | The worker&#39;s owner API key. |  |
| **payload** | [**SubmitInputKobold**](SubmitInputKobold.md) |  |  |
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
| **404** | Request Not Found |  -  |
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Generation Already Submitted |  -  |
| **200** | Generation Submitted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="posttransferkudos"></a>
# **PostTransferKudos**
> KudosTransferred PostTransferKudos (string apikey, PostAwardKudosRequest payload, string clientAgent = null, string xFields = null)

Transfer Kudos to another registed user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PostTransferKudosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The sending user's API key.
            var payload = new PostAwardKudosRequest(); // PostAwardKudosRequest | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Transfer Kudos to another registed user
                KudosTransferred result = apiInstance.PostTransferKudos(apikey, payload, clientAgent, xFields);
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
    ApiResponse<KudosTransferred> response = apiInstance.PostTransferKudosWithHttpInfo(apikey, payload, clientAgent, xFields);
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
| **apikey** | **string** | The sending user&#39;s API key. |  |
| **payload** | [**PostAwardKudosRequest**](PostAwardKudosRequest.md) |  |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
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
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Kudos Transferred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putfilters"></a>
# **PutFilters**
> FilterDetails PutFilters (string apikey, PutNewFilter payload, string clientAgent = null, string xFields = null)

Moderator Only: Add a new regex filter

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PutFiltersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | A mod API key.
            var payload = new PutNewFilter(); // PutNewFilter | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Moderator Only: Add a new regex filter
                FilterDetails result = apiInstance.PutFilters(apikey, payload, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PutFilters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutFiltersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Moderator Only: Add a new regex filter
    ApiResponse<FilterDetails> response = apiInstance.PutFiltersWithHttpInfo(apikey, payload, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PutFiltersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | A mod API key. |  |
| **payload** | [**PutNewFilter**](PutNewFilter.md) |  |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**FilterDetails**](FilterDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **201** | New Filter details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="puthordemodes"></a>
# **PutHordeModes**
> HordeModes PutHordeModes (string apikey, PutHordeModesRequest payload, string xFields = null)

Change Horde Modes

Endpoint for admins to (un)set the horde into maintenance, invite_only or raid modes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PutHordeModesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | The Admin API key.
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
| **apikey** | **string** | The Admin API key. |  |
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
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **200** | Maintenance Mode Set |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putoperationsblockworkerip"></a>
# **PutOperationsBlockWorkerIp**
> SimpleResponse PutOperationsBlockWorkerIp (string workerId, string apikey, AddWorkerTimeout payload, string clientAgent = null, string xFields = null)

Block worker's from a specific IP for 24 hours

Only usable by horde moderators

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PutOperationsBlockWorkerIpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var workerId = "workerId_example";  // string | 
            var apikey = "apikey_example";  // string | A mod API key.
            var payload = new AddWorkerTimeout(); // AddWorkerTimeout | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Block worker's from a specific IP for 24 hours
                SimpleResponse result = apiInstance.PutOperationsBlockWorkerIp(workerId, apikey, payload, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PutOperationsBlockWorkerIp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutOperationsBlockWorkerIpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Block worker's from a specific IP for 24 hours
    ApiResponse<SimpleResponse> response = apiInstance.PutOperationsBlockWorkerIpWithHttpInfo(workerId, apikey, payload, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PutOperationsBlockWorkerIpWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workerId** | **string** |  |  |
| **apikey** | **string** | A mod API key. |  |
| **payload** | [**AddWorkerTimeout**](AddWorkerTimeout.md) |  |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**SimpleResponse**](SimpleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Operation Completed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putsharedkey"></a>
# **PutSharedKey**
> SharedKeyDetails PutSharedKey (string apikey, SharedKeyInput payload, string clientAgent = null, string xFields = null)

Create a new SharedKey for this user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

namespace Example
{
    public class PutSharedKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new V2Api(config);
            var apikey = "apikey_example";  // string | User API key.
            var payload = new SharedKeyInput(); // SharedKeyInput | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Create a new SharedKey for this user
                SharedKeyDetails result = apiInstance.PutSharedKey(apikey, payload, clientAgent, xFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling V2Api.PutSharedKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutSharedKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new SharedKey for this user
    ApiResponse<SharedKeyDetails> response = apiInstance.PutSharedKeyWithHttpInfo(apikey, payload, clientAgent, xFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling V2Api.PutSharedKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apikey** | **string** | User API key. |  |
| **payload** | [**SharedKeyInput**](SharedKeyInput.md) |  |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
| **xFields** | **string** | An optional fields mask | [optional]  |

### Return type

[**SharedKeyDetails**](SharedKeyDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Shared Key Not Found |  -  |
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | SharedKey Details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putusersingle"></a>
# **PutUserSingle**
> ModifyUser PutUserSingle (string userId, string apikey, ModifyUserInput payload, string clientAgent = null, string xFields = null)

Endpoint for horde admins to perform operations on users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

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
            var apikey = "apikey_example";  // string | The Admin API .
            var payload = new ModifyUserInput(); // ModifyUserInput | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                // Endpoint for horde admins to perform operations on users
                ModifyUser result = apiInstance.PutUserSingle(userId, apikey, payload, clientAgent, xFields);
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
    ApiResponse<ModifyUser> response = apiInstance.PutUserSingleWithHttpInfo(userId, apikey, payload, clientAgent, xFields);
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
| **apikey** | **string** | The Admin API . |  |
| **payload** | [**ModifyUserInput**](ModifyUserInput.md) |  |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
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
| **404** | Worker Not Found |  -  |
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Modify User |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putworkersingle"></a>
# **PutWorkerSingle**
> ModifyWorker PutWorkerSingle (string workerId, string apikey, ModifyWorkerInput payload, string clientAgent = null, string xFields = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.StableHorde.Api.Api;
using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Model;

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
            var apikey = "apikey_example";  // string | The Moderator or Owner API key.
            var payload = new ModifyWorkerInput(); // ModifyWorkerInput | 
            var clientAgent = "\"unknown:0:unknown\"";  // string | The client name and version. (optional)  (default to "unknown:0:unknown")
            var xFields = "xFields_example";  // string | An optional fields mask (optional) 

            try
            {
                ModifyWorker result = apiInstance.PutWorkerSingle(workerId, apikey, payload, clientAgent, xFields);
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
    ApiResponse<ModifyWorker> response = apiInstance.PutWorkerSingleWithHttpInfo(workerId, apikey, payload, clientAgent, xFields);
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
| **apikey** | **string** | The Moderator or Owner API key. |  |
| **payload** | [**ModifyWorkerInput**](ModifyWorkerInput.md) |  |  |
| **clientAgent** | **string** | The client name and version. | [optional] [default to &quot;unknown:0:unknown&quot;] |
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
| **404** | Worker Not Found |  -  |
| **403** | Access Denied |  -  |
| **401** | Invalid API Key |  -  |
| **400** | Validation Error |  -  |
| **200** | Modify Worker |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

