# StableHorde.Api.Model.PopInputStable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The Name of the Worker. | [optional] 
**PriorityUsernames** | **List&lt;string&gt;** |  | [optional] 
**Nsfw** | **bool** | Whether this worker can generate NSFW requests or not. | [optional] [default to false]
**Models** | **List&lt;string&gt;** |  | [optional] 
**BridgeAgent** | **string** | The worker name, version and website. | [optional] [default to "unknown:0:unknown"]
**Threads** | **int** | How many threads this worker is running. This is used to accurately the current power available in the horde. | [optional] 
**RequireUpfrontKudos** | **bool** | If True, this worker will only pick up requests where the owner has the required kudos to consume already available. | [optional] [default to false]
**Amount** | **int** | How many jobvs to pop at the same time | [optional] 
**MaxPixels** | **int** | The maximum amount of pixels this worker can generate. | [optional] 
**Blacklist** | **List&lt;string&gt;** |  | [optional] 
**AllowImg2img** | **bool** | If True, this worker will pick up img2img requests. | [optional] [default to true]
**AllowPainting** | **bool** | If True, this worker will pick up inpainting/outpainting requests. | [optional] [default to true]
**AllowUnsafeIpaddr** | **bool** | If True, this worker will pick up img2img requests coming from clients with an unsafe IP. | [optional] [default to true]
**AllowPostProcessing** | **bool** | If True, this worker will pick up requests requesting post-processing. | [optional] [default to true]
**AllowControlnet** | **bool** | If True, this worker will pick up requests requesting ControlNet. | [optional] [default to true]
**AllowLora** | **bool** | If True, this worker will pick up requests requesting LoRas. | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

