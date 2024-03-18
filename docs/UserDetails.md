# Knedlex.StableHorde.Api.Model.UserDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Username** | **string** | The user&#39;s unique Username. It is a combination of their chosen alias plus their ID. | [optional] 
**Id** | **int** | The user unique ID. It is always an integer. | [optional] 
**Kudos** | **decimal** | The amount of Kudos this user has. The amount of Kudos determines the priority when requesting image generations. | [optional] 
**EvaluatingKudos** | **decimal** | (Privileged) The amount of Evaluating Kudos this untrusted user has from generations and uptime. When this number reaches a prespecified threshold, they automatically become trusted. | [optional] 
**Concurrency** | **int** | How many concurrent generations this user may request. | [optional] 
**WorkerInvited** | **int** | Whether this user has been invited to join a worker to the AI Horde and how many of them. When 0, this user cannot add (new) workers to the horde. | [optional] 
**Moderator** | **bool** | This user is a AI Horde moderator. | [optional] 
**KudosDetails** | [**UserKudosDetails**](UserKudosDetails.md) |  | [optional] 
**WorkerCount** | **int** | How many workers this user has created (active or inactive). | [optional] 
**WorkerIds** | **List&lt;string&gt;** |  | [optional] 
**SharedkeyIds** | **List&lt;string&gt;** |  | [optional] 
**MonthlyKudos** | [**MonthlyKudos**](MonthlyKudos.md) |  | [optional] 
**Trusted** | **bool** | This user is a trusted member of the AI Horde. | [optional] 
**Flagged** | **bool** | (Privileged) This user has been flagged for suspicious activity. | [optional] 
**Vpn** | **bool** | (Privileged) This user has been given the VPN role. | [optional] 
**Service** | **bool** | This is a service account used by a horde proxy. | [optional] 
**Education** | **bool** | This is an education account used schools and universities. | [optional] 
**Special** | **bool** | (Privileged) This user has been given the Special role. | [optional] 
**Suspicious** | **int** | (Privileged) How much suspicion this user has accumulated. | [optional] 
**Pseudonymous** | **bool** | If true, this user has not registered using an oauth service. | [optional] 
**Contact** | **string** | (Privileged) Contact details for the horde admins to reach the user in case of emergency. | [optional] 
**AdminComment** | **string** | (Privileged) Information about this users by the admins | [optional] 
**AccountAge** | **int** | How many seconds since this account was created. | [optional] 
**Usage** | [**UsageDetails**](UsageDetails.md) |  | [optional] 
**Contributions** | [**ContributionsDetails**](ContributionsDetails.md) |  | [optional] 
**Records** | [**UserRecords**](UserRecords.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

