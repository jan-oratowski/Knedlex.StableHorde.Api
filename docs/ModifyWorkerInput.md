# StableHorde.Api.Model.ModifyWorkerInput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Maintenance** | **bool** | Set to true to put this worker into maintenance. | [optional] 
**MaintenanceMsg** | **string** | if maintenance is True, you can optionally provide a message to be used instead of the default maintenance message, so that the owner is informed. | [optional] 
**Paused** | **bool** | (Mods only) Set to true to pause this worker. | [optional] 
**Info** | **string** | You can optionally provide a server note which will be seen in the server details. No profanity allowed! | [optional] 
**Name** | **string** | When this is set, it will change the worker&#39;s name. No profanity allowed! | [optional] 
**Team** | **string** | The team towards which this worker contributes kudos.  It an empty string (&#39;&#39;) is passed, it will leave the worker without a team. No profanity allowed! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

