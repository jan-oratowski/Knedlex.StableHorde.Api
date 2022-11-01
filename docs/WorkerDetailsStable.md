# StableHorde.Api.Model.WorkerDetailsStable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The Name given to this worker. | [optional] 
**Id** | **string** | The UUID of this worker. | [optional] 
**RequestsFulfilled** | **int** | How many images this worker has generated. | [optional] 
**KudosRewards** | **decimal** | How many Kudos this worker has been rewarded in total. | [optional] 
**KudosDetails** | [**WorkerKudosDetails**](WorkerKudosDetails.md) |  | [optional] 
**Performance** | **string** | The average performance of this worker in human readable form. | [optional] 
**Uptime** | **int** | The amount of seconds this worker has been online for this Horde. | [optional] 
**MaintenanceMode** | **bool** | When True, this worker will not pick up any new requests | [optional] 
**Paused** | **bool** | (Privileged) When True, this worker not be given any new requests. | [optional] 
**Info** | **string** | Extra information or comments about this worker provided by its owner. | [optional] 
**Nsfw** | **bool** | Whether this worker can generate NSFW requests or not. | [optional] [default to false]
**Owner** | **string** | Privileged or public if the owner has allowed it. The alias of the owner of this worker. | [optional] 
**Trusted** | **bool** | The worker is trusted to return valid generations. | [optional] 
**Suspicious** | **int** | (Privileged) How much suspicion this worker has accumulated | [optional] 
**Models** | **List&lt;string&gt;** |  | [optional] 
**MaxPixels** | **int** | The maximum pixels in resolution this worker can generate | [optional] 
**MegapixelstepsGenerated** | **decimal** | How many megapixelsteps this worker has generated until now | [optional] 
**Img2img** | **bool** | If True, this worker supports and allows img2img requests. | [optional] [default to true]
**Painting** | **bool** | If True, this worker supports and allows inpainting requests. | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

