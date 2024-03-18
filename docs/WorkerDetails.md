# Knedlex.StableHorde.Api.Model.WorkerDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The Type of worker this is. | [optional] 
**Name** | **string** | The Name given to this worker. | [optional] 
**Id** | **string** | The UUID of this worker. | [optional] 
**Online** | **bool** | True if the worker has checked-in the past 5 minutes. | [optional] 
**RequestsFulfilled** | **int** | How many images this worker has generated. | [optional] 
**KudosRewards** | **decimal** | How many Kudos this worker has been rewarded in total. | [optional] 
**KudosDetails** | [**WorkerKudosDetails**](WorkerKudosDetails.md) |  | [optional] 
**Performance** | **string** | The average performance of this worker in human readable form. | [optional] 
**Threads** | **int** | How many threads this worker is running. | [optional] 
**Uptime** | **int** | The amount of seconds this worker has been online for this AI Horde. | [optional] 
**MaintenanceMode** | **bool** | When True, this worker will not pick up any new requests. | [optional] 
**Paused** | **bool** | (Privileged) When True, this worker not be given any new requests. | [optional] 
**Info** | **string** | Extra information or comments about this worker provided by its owner. | [optional] 
**Nsfw** | **bool** | Whether this worker can generate NSFW requests or not. | [optional] [default to false]
**Owner** | **string** | Privileged or public if the owner has allowed it. The alias of the owner of this worker. | [optional] 
**Ipaddr** | **string** | Privileged. The last known IP this worker has connected from. | [optional] 
**Trusted** | **bool** | The worker is trusted to return valid generations. | [optional] 
**Flagged** | **bool** | The worker&#39;s owner has been flagged for suspicious activity. This worker will not be given any jobs to process. | [optional] 
**Suspicious** | **int** | (Privileged) How much suspicion this worker has accumulated. | [optional] 
**UncompletedJobs** | **int** | How many jobs this worker has left uncompleted after it started them. | [optional] 
**Models** | **List&lt;string&gt;** |  | [optional] 
**Forms** | **List&lt;string&gt;** |  | [optional] 
**Team** | [**TeamDetailsLite**](TeamDetailsLite.md) |  | [optional] 
**Contact** | **string** | (Privileged) Contact details for the horde admins to reach the owner of this worker in emergencies. | [optional] 
**BridgeAgent** | **string** | The bridge agent name, version and website. | [default to "unknown:0:unknown"]
**MaxPixels** | **int** | The maximum pixels in resolution this worker can generate. | [optional] 
**MegapixelstepsGenerated** | **decimal** | How many megapixelsteps this worker has generated until now. | [optional] 
**Img2img** | **bool** | If True, this worker supports and allows img2img requests. | [optional] 
**Painting** | **bool** | If True, this worker supports and allows inpainting requests. | [optional] 
**PostProcessing** | **bool** | If True, this worker supports and allows post-processing requests. | [optional] 
**Lora** | **bool** | If True, this worker supports and allows lora requests. | [optional] 
**MaxLength** | **int** | The maximum tokens this worker can generate. | [optional] 
**MaxContextLength** | **int** | The maximum tokens this worker can read. | [optional] 
**TokensGenerated** | **decimal** | How many tokens this worker has generated until now. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

