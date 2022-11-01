# StableHorde.Api.Model.GenerationInput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Prompt** | **string** | The prompt which will be sent to Stable Diffusion to generate an image | 
**Params** | [**ModelGenerationInputStable**](ModelGenerationInputStable.md) |  | [optional] 
**Nsfw** | **bool** | Set to true if this request is NSFW. This will skip workers which censor images. | [optional] [default to false]
**TrustedWorkers** | **bool** | When true, only trusted workers will serve this request. When False, Evaluating workers will also be used which can increase speed but adds more risk! | [optional] [default to true]
**CensorNsfw** | **bool** | If the request is SFW, and the worker accidentaly generates NSFW, it will send back a censored image. | [optional] [default to false]
**Workers** | **List&lt;string&gt;** |  | [optional] 
**Models** | **List&lt;string&gt;** |  | [optional] 
**SourceImage** | **string** | The Base64-encoded webp to use for img2img | [optional] 
**SourceProcessing** | **string** | If source_image is provided, specifies how to process it. | [optional] [default to SourceProcessingEnum.Img2img]
**SourceMask** | **string** | If source_processing is set to &#39;inpainting&#39; or &#39;outpainting&#39;, this parameter can be optionally provided as the  Base64-encoded webp mask of the areas to inpaint. If this arg is not passed, the inpainting/outpainting mask has to be embedded as alpha channel | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

