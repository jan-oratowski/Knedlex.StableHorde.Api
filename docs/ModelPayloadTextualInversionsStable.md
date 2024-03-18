# Knedlex.StableHorde.Api.Model.ModelPayloadTextualInversionsStable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The exact name or CivitAI ID of the Textual Inversion. | 
**InjectTi** | **string** | If set, Will automatically add this TI filename to the prompt or negative prompt accordingly using the provided strength. If this is set to None, then the user will have to manually add the embed to the prompt themselves. | [optional] 
**Strength** | **decimal** | The strength with which to apply the TI to the prompt. Only used when inject_ti is not None | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

