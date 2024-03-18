# Knedlex.StableHorde.Api.Model.GenerationInputStable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Prompt** | **string** | The prompt which will be sent to Stable Diffusion to generate an image. | 
**VarParams** | [**ModelGenerationInputStable**](ModelGenerationInputStable.md) |  | [optional] 
**Nsfw** | **bool** | Set to true if this request is NSFW. This will skip workers which censor images. | [optional] [default to false]
**TrustedWorkers** | **bool** | When true, only trusted workers will serve this request. When False, Evaluating workers will also be used which can increase speed but adds more risk! | [optional] [default to false]
**SlowWorkers** | **bool** | When True, allows slower workers to pick up this request. Disabling this incurs an extra kudos cost. | [optional] [default to true]
**CensorNsfw** | **bool** | If the request is SFW, and the worker accidentally generates NSFW, it will send back a censored image. | [optional] [default to false]
**Workers** | **List&lt;string&gt;** |  | [optional] 
**WorkerBlacklist** | **bool** | If true, the worker list will be treated as a blacklist instead of a whitelist. | [optional] [default to false]
**Models** | **List&lt;string&gt;** |  | [optional] 
**SourceImage** | **string** | The Base64-encoded webp to use for img2img. | [optional] 
**SourceProcessing** | **string** | If source_image is provided, specifies how to process it. | [optional] [default to SourceProcessingEnum.Img2img]
**SourceMask** | **string** | If source_processing is set to &#39;inpainting&#39; or &#39;outpainting&#39;, this parameter can be optionally provided as the  Base64-encoded webp mask of the areas to inpaint. If this arg is not passed, the inpainting/outpainting mask has to be embedded as alpha channel. | [optional] 
**R2** | **bool** | If True, the image will be sent via cloudflare r2 download link. | [optional] [default to true]
**Shared** | **bool** | If True, The image will be shared with LAION for improving their dataset. This will also reduce your kudos consumption by 2. For anonymous users, this is always True. | [optional] [default to false]
**ReplacementFilter** | **bool** | If enabled, suspicious prompts are sanitized through a string replacement filter instead. | [optional] [default to true]
**DryRun** | **bool** | When true, the endpoint will simply return the cost of the request in kudos and exit. | [optional] [default to false]
**ProxiedAccount** | **string** | If using a service account as a proxy, provide this value to identify the actual account from which this request is coming from. | [optional] 
**DisableBatching** | **bool** | When true, This request will not use batching. This will allow you to retrieve accurate seeds. Feature is restricted to Trusted users and Patreons. | [optional] [default to false]
**Webhook** | **string** | Provide a URL where the AI Horde will send a POST call after each delivered generation. The request will include the details of the job as well as the request ID. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

