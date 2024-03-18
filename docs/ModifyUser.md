# Knedlex.StableHorde.Api.Model.ModifyUser

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NewKudos** | **decimal** | The new total Kudos this user has after this request. | [optional] 
**Concurrency** | **int** | The request concurrency this user has after this request. | [optional] 
**UsageMultiplier** | **decimal** | Multiplies the amount of kudos lost when generating images. | [optional] 
**WorkerInvited** | **int** | Whether this user has been invited to join a worker to the horde and how many of them. When 0, this user cannot add (new) workers to the horde. | [optional] 
**Moderator** | **bool** | The user&#39;s new moderator status. | [optional] 
**PublicWorkers** | **bool** | The user&#39;s new public_workers status. | [optional] 
**Username** | **string** | The user&#39;s new username. | [optional] 
**MonthlyKudos** | **int** | The user&#39;s new monthly kudos total. | [optional] 
**Trusted** | **bool** | The user&#39;s new trusted status. | [optional] 
**Flagged** | **bool** | The user&#39;s new flagged status. | [optional] 
**Customizer** | **bool** | The user&#39;s new customizer status. | [optional] 
**Vpn** | **bool** | The user&#39;s new vpn status. | [optional] 
**Service** | **bool** | The user&#39;s new service status. | [optional] 
**Education** | **bool** | The user&#39;s new education status. | [optional] 
**Special** | **bool** | The user&#39;s new special status. | [optional] 
**NewSuspicion** | **int** | The user&#39;s new suspiciousness rating. | [optional] 
**Contact** | **string** | The new contact details. | [optional] 
**AdminComment** | **string** | The new admin comment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

