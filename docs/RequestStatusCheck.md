# StableHorde.Api.Model.RequestStatusCheck

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Finished** | **int** | The amount of finished images in this request | [optional] 
**Processing** | **int** | The amount of still processing images in this request | [optional] 
**Waiting** | **int** | The amount of images waiting to be picked up by a worker | [optional] 
**Done** | **bool** | True when all images in this request are done. Else False. | [optional] 
**Faulted** | **bool** | True when this request caused an internal server error and cannot be completed. | [optional] [default to false]
**WaitTime** | **int** | The expected amount to wait (in seconds) to generate all images in this request | [optional] 
**QueuePosition** | **int** | The position in the requests queue. This position is determined by relative Kudos amounts. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

