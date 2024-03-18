# Knedlex.StableHorde.Api.Model.ModelPayloadStable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SamplerName** | **string** |  | [optional] [default to SamplerNameEnum.KEulerA]
**CfgScale** | **decimal** |  | [optional] 
**DenoisingStrength** | **decimal** |  | [optional] 
**Seed** | **string** | The seed to use to generate this request. You can pass text as well as numbers. | [optional] 
**Height** | **int** | The height of the image to generate. | [optional] 
**Width** | **int** | The width of the image to generate. | [optional] 
**SeedVariation** | **int** | If passed with multiple n, the provided seed will be incremented every time by this value. | [optional] 
**PostProcessing** | **List&lt;ModelPayloadStable.PostProcessingEnum&gt;** |  | [optional] 
**Karras** | **bool** | Set to True to enable karras noise scheduling tweaks. | [optional] [default to false]
**Tiling** | **bool** | Set to True to create images that stitch together seamlessly. | [optional] [default to false]
**HiresFix** | **bool** | Set to True to process the image at base resolution before upscaling and re-processing. | [optional] [default to false]
**ClipSkip** | **int** | The number of CLIP language processor layers to skip. | [optional] 
**ControlType** | **string** |  | [optional] 
**ImageIsControl** | **bool** | Set to True if the image submitted is a pre-generated control map for ControlNet use. | [optional] [default to false]
**ReturnControlMap** | **bool** | Set to True if you want the ControlNet map returned instead of a generated image. | [optional] [default to false]
**FacefixerStrength** | **decimal** |  | [optional] 
**Loras** | [**List&lt;ModelPayloadLorasStable&gt;**](ModelPayloadLorasStable.md) |  | [optional] 
**Tis** | [**List&lt;ModelPayloadTextualInversionsStable&gt;**](ModelPayloadTextualInversionsStable.md) |  | [optional] 
**Special** | [**ModelSpecialPayloadStable**](ModelSpecialPayloadStable.md) |  | [optional] 
**Prompt** | **string** | The prompt which will be sent to Stable Diffusion to generate an image. | [optional] 
**DdimSteps** | **int** |  | [optional] 
**NIter** | **int** | The amount of images to generate. | [optional] 
**UseNsfwCensor** | **bool** | When true will apply NSFW censoring model on the generation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

