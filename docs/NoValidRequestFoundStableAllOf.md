# StableHorde.Api.Model.NoValidRequestFoundStableAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxPixels** | **int** | How many waiting requests were skipped because they demanded a higher size than this worker provides. | [optional] 
**UnsafeIp** | **int** | How many waiting requests were skipped because they came from an unsafe IP. | [optional] 
**Img2img** | **int** | How many waiting requests were skipped because they requested img2img. | [optional] 
**Painting** | **int** | How many waiting requests were skipped because they requested inpainting/outpainting. | [optional] 
**PostProcessing** | **int** | How many waiting requests were skipped because they requested post-processing. | [optional] 
**Lora** | **int** | How many waiting requests were skipped because they requested loras. | [optional] 
**Controlnet** | **int** | How many waiting requests were skipped because they requested a controlnet. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

