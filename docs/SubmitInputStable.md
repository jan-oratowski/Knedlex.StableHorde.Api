# StableHorde.Api.Model.SubmitInputStable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The UUID of this generation. | 
**Generation** | **string** | R2 result was uploaded to R2, else the string of the result. | [optional] 
**State** | **string** | The state of this generation. | [optional] [default to StateEnum.Ok]
**Seed** | **int** | The seed for this generation. | 
**Censored** | **bool** | OBSOLETE (start using meta): If True, this resulting image has been censored. | [optional] [default to false]
**GenMetadata** | [**List&lt;GenerationMetadataStable&gt;**](GenerationMetadataStable.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

