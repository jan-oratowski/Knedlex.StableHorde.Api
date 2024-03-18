# Knedlex.StableHorde.Api.Model.GenerationPayloadStable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Payload** | [**ModelPayloadStable**](ModelPayloadStable.md) |  | [optional] 
**Id** | **string** | The UUID for this image generation. | [optional] 
**Ids** | **List&lt;string&gt;** |  | [optional] 
**Skipped** | [**NoValidRequestFoundStable**](NoValidRequestFoundStable.md) |  | [optional] 
**Model** | **string** | Which of the available models to use for this request. | [optional] 
**SourceImage** | **string** | The Base64-encoded webp to use for img2img. | [optional] 
**SourceProcessing** | **string** | If source_image is provided, specifies how to process it. | [optional] [default to SourceProcessingEnum.Img2img]
**SourceMask** | **string** | If img_processing is set to &#39;inpainting&#39; or &#39;outpainting&#39;, this parameter can be optionally provided as the mask of the areas to inpaint. If this arg is not passed, the inpainting/outpainting mask has to be embedded as alpha channel. | [optional] 
**R2Upload** | **string** | The r2 upload link to use to upload this image. | [optional] 
**R2Uploads** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

