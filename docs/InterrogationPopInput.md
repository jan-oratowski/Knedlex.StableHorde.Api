# StableHorde.Api.Model.InterrogationPopInput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The Name of the Worker. | [optional] 
**PriorityUsernames** | **List&lt;string&gt;** |  | [optional] 
**Forms** | **List&lt;string&gt;** |  | [optional] 
**Amount** | **int** | The amount of forms to pop at the same time. | [optional] 
**BridgeAgent** | **string** | The worker name, version and website. | [optional] [default to "unknown"]
**Threads** | **int** | How many threads this worker is running. This is used to accurately the current power available in the horde. | [optional] 
**MaxTiles** | **int** | The maximum amount of 512x512 tiles this worker can post-process. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

