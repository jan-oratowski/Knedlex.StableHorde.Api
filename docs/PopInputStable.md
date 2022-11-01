# StableHorde.Api.Model.PopInputStable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The Name of the Worker | [optional] 
**PriorityUsernames** | **List&lt;string&gt;** |  | [optional] 
**Nsfw** | **bool** | Whether this worker can generate NSFW requests or not. | [optional] [default to false]
**Blacklist** | **List&lt;string&gt;** |  | [optional] 
**Models** | **List&lt;string&gt;** |  | [optional] 
**BridgeVersion** | **int** | The version of the bridge used by this worker | [optional] 
**MaxPixels** | **int** | The maximum amount of pixels this worker can generate | [optional] 
**AllowImg2img** | **bool** | If True, this worker will pick up img2img requests | [optional] [default to true]
**AllowPainting** | **bool** | If True, this worker will pick up inpainting/outpainting requests | [optional] [default to true]
**AllowUnsafeIpaddr** | **bool** | If True, this worker will pick up img2img requests coming from clients with an unsafe IP. | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

