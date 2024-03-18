# Knedlex.StableHorde.Api.Model.SharedKeyDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The SharedKey ID. | [optional] 
**Username** | **string** | The owning user&#39;s unique Username. It is a combination of their chosen alias plus their ID. | [optional] 
**Name** | **string** | The Shared Key Name. | [optional] 
**Kudos** | **int** | The Kudos limit assigned to this key. | [optional] 
**Expiry** | **DateTime** | The date at which this API key will expire. | [optional] 
**Utilized** | **int** | How much kudos has been utilized via this shared key until now. | [optional] 
**MaxImagePixels** | **int** | The maximum amount of image pixels this key can generate per job. -1 means unlimited. | [optional] 
**MaxImageSteps** | **int** | The maximum amount of image steps this key can use per job. -1 means unlimited. | [optional] 
**MaxTextTokens** | **int** | The maximum amount of text tokens this key can generate per job. -1 means unlimited. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

