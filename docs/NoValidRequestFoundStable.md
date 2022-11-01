# StableHorde.Api.Model.NoValidRequestFoundStable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkerId** | **int** | How many waiting requests were skipped because they demanded a specific worker | [optional] 
**Performance** | **int** | How many waiting requests were skipped because they demanded a specific worker | [optional] 
**Nsfw** | **int** | How many waiting requests were skipped because they demanded a nsfw generation which this worker does not provide. | [optional] 
**Blacklist** | **int** | How many waiting requests were skipped because they demanded a generation with a word that this worker does not accept. | [optional] 
**Untrusted** | **int** | How many waiting requests were skipped because they demanded a trusted worker which this worker is not. | [optional] 
**Models** | **int** | How many waiting requests were skipped because they demanded a different model than what this worker provides. | [optional] 
**MaxPixels** | **int** | How many waiting requests were skipped because they demanded a higher size than this worker provides | [optional] 
**UnsafeIp** | **int** | How many waiting requests were skipped because they came from an unsafe IP | [optional] 
**Img2img** | **int** | How many waiting requests were skipped because they requested img2img | [optional] 
**Painting** | **int** | How many waiting requests were skipped because they requested inpainting/outpainting | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

