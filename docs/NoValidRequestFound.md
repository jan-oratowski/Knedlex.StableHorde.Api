# StableHorde.Api.Model.NoValidRequestFound

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkerId** | **int** | How many waiting requests were skipped because they demanded a specific worker. | [optional] 
**Performance** | **int** | How many waiting requests were skipped because they required higher performance. | [optional] 
**Nsfw** | **int** | How many waiting requests were skipped because they demanded a nsfw generation which this worker does not provide. | [optional] 
**Blacklist** | **int** | How many waiting requests were skipped because they demanded a generation with a word that this worker does not accept. | [optional] 
**Untrusted** | **int** | How many waiting requests were skipped because they demanded a trusted worker which this worker is not. | [optional] 
**Models** | **int** | How many waiting requests were skipped because they demanded a different model than what this worker provides. | [optional] 
**BridgeVersion** | **int** | How many waiting requests were skipped because they require a higher version of the bridge than this worker is running (upgrade if you see this in your skipped list). | [optional] 
**Kudos** | **int** | How many waiting requests were skipped because the user didn&#39;t have enough kudos when this worker requires upfront kudos. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

