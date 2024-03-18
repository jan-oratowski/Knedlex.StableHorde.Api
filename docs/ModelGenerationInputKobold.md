# StableHorde.Api.Model.ModelGenerationInputKobold

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**N** | **int** |  | [optional] 
**Frmtadsnsp** | **bool** | Input formatting option. When enabled, adds a leading space to your input if there is no trailing whitespace at the end of the previous action. | [optional] 
**Frmtrmblln** | **bool** | Output formatting option. When enabled, replaces all occurrences of two or more consecutive newlines in the output with one newline. | [optional] 
**Frmtrmspch** | **bool** | Output formatting option. When enabled, removes #/@%}{+&#x3D;~|\\^&lt;&gt; from the output. | [optional] 
**Frmttriminc** | **bool** | Output formatting option. When enabled, removes some characters from the end of the output such that the output doesn&#39;t end in the middle of a sentence. If the output is less than one sentence long, does nothing. | [optional] 
**MaxContextLength** | **int** | Maximum number of tokens to send to the model. | [optional] 
**MaxLength** | **int** | Number of tokens to generate. | [optional] 
**RepPen** | **decimal** | Base repetition penalty value. | [optional] 
**RepPenRange** | **int** | Repetition penalty range. | [optional] 
**RepPenSlope** | **decimal** | Repetition penalty slope. | [optional] 
**Singleline** | **bool** | Output formatting option. When enabled, removes everything after the first line of the output, including the newline. | [optional] 
**Temperature** | **decimal** | Temperature value. | [optional] 
**Tfs** | **decimal** | Tail free sampling value. | [optional] 
**TopA** | **decimal** | Top-a sampling value. | [optional] 
**TopK** | **int** | Top-k sampling value. | [optional] 
**TopP** | **decimal** | Top-p sampling value. | [optional] 
**Typical** | **decimal** | Typical sampling value. | [optional] 
**SamplerOrder** | **List&lt;int&gt;** |  | [optional] 
**UseDefaultBadwordsids** | **bool** | When True, uses the default KoboldAI bad word IDs. | [optional] 
**StopSequence** | **List&lt;string&gt;** |  | [optional] 
**MinP** | **decimal** | Min-p sampling value. | [optional] 
**SmoothingFactor** | **decimal** | Quadratic sampling value. | [optional] 
**DynatempRange** | **decimal** | Dynamic temperature range value. | [optional] 
**DynatempExponent** | **decimal** | Dynamic temperature exponent value. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

