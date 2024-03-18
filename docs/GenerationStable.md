# Knedlex.StableHorde.Api.Model.GenerationStable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkerId** | **string** | The UUID of the worker which generated this image. | [optional] 
**WorkerName** | **string** | The name of the worker which generated this image. | [optional] 
**Model** | **string** | The model which generated this image. | [optional] 
**State** | **string** | OBSOLETE (Use the gen_metadata field). The state of this generation. | [default to StateEnum.Ok]
**Img** | **string** | The generated image as a Base64-encoded .webp file. | [optional] 
**Seed** | **string** | The seed which generated this image. | [optional] 
**Id** | **string** | The ID for this image. | [optional] 
**Censored** | **bool** | When true this image has been censored by the worker&#39;s safety filter. | [optional] 
**GenMetadata** | [**List&lt;GenerationMetadataStable&gt;**](GenerationMetadataStable.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

