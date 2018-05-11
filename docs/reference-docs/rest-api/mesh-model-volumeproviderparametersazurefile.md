# VolumeProviderParametersAzureFile

This type describes a volume provided by an Azure Files file share.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`accountName`](#accountname) | string | Yes |
| [`accountKey`](#accountkey) | string | Yes |
| [`shareName`](#sharename) | string | Yes |

____
### `accountName`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
Name of the Azure storage account for the File Share.

____
### `accountKey`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
Access key of the Azure storage account for the File Share.

____
### `shareName`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
Name of the Azure Files file share that provides storage for the volume.
