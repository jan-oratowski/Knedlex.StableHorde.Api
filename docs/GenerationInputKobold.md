# Knedlex.StableHorde.Api.Model.GenerationInputKobold

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Prompt** | **string** | The prompt which will be sent to KoboldAI to generate text. | [optional] 
**VarParams** | [**ModelGenerationInputKobold**](ModelGenerationInputKobold.md) |  | [optional] 
**Softprompt** | **string** | Specify which softpompt needs to be used to service this request. | [optional] 
**TrustedWorkers** | **bool** | When true, only trusted workers will serve this request. When False, Evaluating workers will also be used which can increase speed but adds more risk! | [optional] [default to false]
**SlowWorkers** | **bool** | When True, allows slower workers to pick up this request. Disabling this incurs an extra kudos cost. | [optional] [default to true]
**Workers** | **List&lt;string&gt;** |  | [optional] 
**WorkerBlacklist** | **bool** | If true, the worker list will be treated as a blacklist instead of a whitelist. | [optional] [default to false]
**Models** | **List&lt;string&gt;** |  | [optional] 
**DryRun** | **bool** | When true, the endpoint will simply return the cost of the request in kudos and exit. | [optional] [default to false]
**ProxiedAccount** | **string** | If using a service account as a proxy, provide this value to identify the actual account from which this request is coming from. | [optional] 
**DisableBatching** | **bool** | When true, This request will not use batching. This will allow you to retrieve accurate seeds. Feature is restricted to Trusted users and Patreons. | [optional] [default to false]
**Webhook** | **string** | Provide a URL where the AI Horde will send a POST call after each delivered generation. The request will include the details of the job as well as the request ID. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

