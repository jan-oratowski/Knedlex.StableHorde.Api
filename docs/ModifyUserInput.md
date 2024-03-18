# StableHorde.Api.Model.ModifyUserInput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Kudos** | **decimal** | The amount of kudos to modify (can be negative). | [optional] 
**Concurrency** | **int** | The amount of concurrent request this user can have. | [optional] 
**UsageMultiplier** | **decimal** | The amount by which to multiply the users kudos consumption. | [optional] 
**WorkerInvited** | **int** | Set to the amount of workers this user is allowed to join to the horde when in worker invite-only mode. | [optional] 
**Moderator** | **bool** | Set to true to make this user a horde moderator. | [optional] 
**PublicWorkers** | **bool** | Set to true to make this user display their worker IDs. | [optional] 
**MonthlyKudos** | **int** | When specified, will start assigning the user monthly kudos, starting now! | [optional] 
**Username** | **string** | When specified, will change the username. No profanity allowed! | [optional] 
**Trusted** | **bool** | When set to true,the user and their servers will not be affected by suspicion. | [optional] 
**Flagged** | **bool** | When set to true, the user cannot tranfer kudos and all their workers are put into permanent maintenance. | [optional] 
**Customizer** | **bool** | When set to true, the user will be able to serve custom Stable Diffusion models which do not exist in the Official AI Horde Model Reference. | [optional] 
**Vpn** | **bool** | When set to true, the user will be able to onboard workers behind a VPN. This should be used as a temporary solution until the user is trusted. | [optional] 
**Service** | **bool** | When set to true, the user is considered a service account proxying the requests for other users. | [optional] 
**Education** | **bool** | When set to true, the user is considered an education account and some options become more restrictive. | [optional] 
**Special** | **bool** | When set to true, The user can send special payloads. | [optional] 
**Filtered** | **bool** | When set to true, the replacement filter will always be applied against this user | [optional] 
**ResetSuspicion** | **bool** | Set the user&#39;s suspicion back to 0. | [optional] 
**Contact** | **string** | Contact details for the horde admins to reach the user in case of emergency. This is only visible to horde moderators. | [optional] 
**AdminComment** | **string** | Add further information about this user for the other admins. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

