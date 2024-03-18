# StableHorde.Api.Model.HordePerformance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QueuedRequests** | **int** | The amount of waiting and processing image requests currently in this horde. | [optional] 
**QueuedTextRequests** | **int** | The amount of waiting and processing text requests currently in this horde. | [optional] 
**WorkerCount** | **int** | How many workers are actively processing prompt generations in this horde in the past 5 minutes. | [optional] 
**TextWorkerCount** | **int** | How many workers are actively processing prompt generations in this horde in the past 5 minutes. | [optional] 
**ThreadCount** | **int** | How many worker threads are actively processing prompt generations in this {horde_noun} in the past 5 minutes. | [optional] 
**TextThreadCount** | **int** | How many worker threads are actively processing prompt generations in this {horde_noun} in the past 5 minutes. | [optional] 
**QueuedMegapixelsteps** | **decimal** | The amount of megapixelsteps in waiting and processing requests currently in this horde. | [optional] 
**PastMinuteMegapixelsteps** | **decimal** | How many megapixelsteps this horde generated in the last minute. | [optional] 
**QueuedForms** | **decimal** | The amount of image interrogations waiting and processing currently in this horde. | [optional] 
**InterrogatorCount** | **int** | How many workers are actively processing image interrogations in this {horde_noun} in the past 5 minutes. | [optional] 
**InterrogatorThreadCount** | **int** | How many worker threads are actively processing image interrogation in this {horde_noun} in the past 5 minutes. | [optional] 
**QueuedTokens** | **decimal** | The amount of tokens in waiting and processing requests currently in this horde. | [optional] 
**PastMinuteTokens** | **decimal** | How many tokens this horde generated in the last minute. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

