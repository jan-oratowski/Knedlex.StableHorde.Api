# StableHorde.Api.Model.ModelPayloadLorasStable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The exact name or CivitAI Model Page ID of the LoRa. If is_version is true, this should be the CivitAI version ID. | 
**Model** | **decimal** | The strength of the LoRa to apply to the SD model. | [optional] 
**Clip** | **decimal** | The strength of the LoRa to apply to the clip model. | [optional] 
**InjectTrigger** | **string** | If set, will try to discover a trigger for this LoRa which matches or is similar to this string and inject it into the prompt. If &#39;any&#39; is specified it will be pick the first trigger. | [optional] 
**IsVersion** | **bool** | If true, will consider the LoRa ID as a CivitAI version ID and search accordingly. Ensure the name is an integer. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

