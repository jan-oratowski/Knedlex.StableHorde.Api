# StableHorde.Api.Model.RequestStatusCheck

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Finished** | **int** | The amount of finished jobs in this request. | [optional] 
**Processing** | **int** | The amount of still processing jobs in this request. | [optional] 
**Restarted** | **int** | The amount of jobs that timed out and had to be restarted or were reported as failed by a worker. | [optional] 
**Waiting** | **int** | The amount of jobs waiting to be picked up by a worker. | [optional] 
**Done** | **bool** | True when all jobs in this request are done. Else False. | [optional] 
**Faulted** | **bool** | True when this request caused an internal server error and could not be completed. | [optional] [default to false]
**WaitTime** | **int** | The expected amount to wait (in seconds) to generate all jobs in this request. | [optional] 
**QueuePosition** | **int** | The position in the requests queue. This position is determined by relative Kudos amounts. | [optional] 
**Kudos** | **decimal** | The amount of total Kudos this request has consumed until now. | [optional] 
**IsPossible** | **bool** | If False, this request will not be able to be completed with the pool of workers currently available. | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

