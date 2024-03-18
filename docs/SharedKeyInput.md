# StableHorde.Api.Model.SharedKeyInput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Kudos** | **int** | The Kudos limit assigned to this key. If -1, then anyone with this key can use an unlimited amount of kudos from this account. | [optional] 
**Expiry** | **int** | The amount of days after which this key will expire. If -1, this key will not expire. | [optional] 
**Name** | **string** | A descriptive name for this key. | [optional] 
**MaxImagePixels** | **int** | The maximum amount of image pixels this key can generate per job. -1 means unlimited. | [optional] 
**MaxImageSteps** | **int** | The maximum amount of image steps this key can use per job. -1 means unlimited. | [optional] 
**MaxTextTokens** | **int** | The maximum amount of text tokens this key can generate per job. -1 means unlimited. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

