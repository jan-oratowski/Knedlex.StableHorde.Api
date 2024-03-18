# StableHorde.Api.Model.ModelInterrogationInputStable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Forms** | [**List&lt;ModelInterrogationFormStable&gt;**](ModelInterrogationFormStable.md) |  | [optional] 
**SourceImage** | **string** | The public URL of the image to interrogate. | [optional] 
**SlowWorkers** | **bool** | When True, allows slower workers to pick up this request. Disabling this incurs an extra kudos cost. | [optional] [default to true]
**Webhook** | **string** | Provide a URL where the AI Horde will send a POST call after each delivered generation. The request will include the details of the job as well as the request ID. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

