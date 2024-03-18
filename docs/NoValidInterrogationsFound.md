# StableHorde.Api.Model.NoValidInterrogationsFound

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkerId** | **int** | How many waiting requests were skipped because they demanded a specific worker. | [optional] 
**Untrusted** | **int** | How many waiting requests were skipped because they demanded a trusted worker which this worker is not. | [optional] 
**BridgeVersion** | **int** | How many waiting requests were skipped because they require a higher version of the bridge than this worker is running (upgrade if you see this in your skipped list). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

