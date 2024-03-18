# StableHorde.Api.Model.PopInput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The Name of the Worker. | [optional] 
**PriorityUsernames** | **List&lt;string&gt;** |  | [optional] 
**Nsfw** | **bool** | Whether this worker can generate NSFW requests or not. | [optional] [default to false]
**Models** | **List&lt;string&gt;** |  | [optional] 
**BridgeAgent** | **string** | The worker name, version and website. | [optional] [default to "unknown:0:unknown"]
**Threads** | **int** | How many threads this worker is running. This is used to accurately the current power available in the horde. | [optional] 
**RequireUpfrontKudos** | **bool** | If True, this worker will only pick up requests where the owner has the required kudos to consume already available. | [optional] [default to false]
**Amount** | **int** | How many jobvs to pop at the same time | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

