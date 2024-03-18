# StableHorde.Api.Model.GenerationKobold

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkerId** | **string** | The UUID of the worker which generated this image. | [optional] 
**WorkerName** | **string** | The name of the worker which generated this image. | [optional] 
**Model** | **string** | The model which generated this image. | [optional] 
**State** | **string** | OBSOLETE (Use the gen_metadata field). The state of this generation. | [default to StateEnum.Ok]
**Text** | **string** | The generated text. | [optional] 
**Seed** | **int** | The seed which generated this text. | [optional] 
**GenMetadata** | [**List&lt;GenerationMetadataKobold&gt;**](GenerationMetadataKobold.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

