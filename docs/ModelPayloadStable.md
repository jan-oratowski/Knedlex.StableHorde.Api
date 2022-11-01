# StableHorde.Api.Model.ModelPayloadStable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SamplerName** | **string** |  | [optional] [default to SamplerNameEnum.KEuler]
**Toggles** | **List&lt;int&gt;** | Obsolete Toggles used in the SD Webui. To be removed. Do not modify unless you know what you&#39;re doing. | [optional] 
**CfgScale** | **decimal** |  | [optional] 
**DenoisingStrength** | **decimal** |  | [optional] 
**Seed** | **string** | The seed to use to generete this request | [optional] 
**Height** | **int** | The height of the image to generate | [optional] 
**Width** | **int** | The width of the image to generate | [optional] 
**SeedVariation** | **int** | If passed with multiple n, the provided seed will be incremented every time by this value | [optional] 
**UseGfpgan** | **bool** | Set to true to process the generated image with GFPGAN (face correction) | [optional] 
**UseRealEsrgan** | **bool** | Set to true to process the generated image with RealESRGAN | [optional] 
**UseLdsr** | **bool** | Set to true to process the generated image with LDSR | [optional] 
**UseUpscaling** | **bool** | Set to true to upscale the image | [optional] 
**Prompt** | **string** | The prompt which will be sent to Stable Diffusion to generate an image | [optional] 
**DdimSteps** | **int** |  | [optional] 
**NIter** | **int** | The amount of images to generate | [optional] 
**UseNsfwCensor** | **bool** | When true will apply NSFW censoring model on the generation | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

