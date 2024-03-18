# StableHorde.Api.Model.PopInputStableAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxPixels** | **int** | The maximum amount of pixels this worker can generate. | [optional] 
**Blacklist** | **List&lt;string&gt;** |  | [optional] 
**AllowImg2img** | **bool** | If True, this worker will pick up img2img requests. | [optional] [default to true]
**AllowPainting** | **bool** | If True, this worker will pick up inpainting/outpainting requests. | [optional] [default to true]
**AllowUnsafeIpaddr** | **bool** | If True, this worker will pick up img2img requests coming from clients with an unsafe IP. | [optional] [default to true]
**AllowPostProcessing** | **bool** | If True, this worker will pick up requests requesting post-processing. | [optional] [default to true]
**AllowControlnet** | **bool** | If True, this worker will pick up requests requesting ControlNet. | [optional] [default to true]
**AllowLora** | **bool** | If True, this worker will pick up requests requesting LoRas. | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

