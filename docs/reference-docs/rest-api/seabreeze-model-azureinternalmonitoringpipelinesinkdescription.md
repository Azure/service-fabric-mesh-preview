# AzureInternalMonitoringPipelineSinkDescription

Diagnostics settings for Geneva.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`name`](#name) | string | No |
| [`kind`](#kind) | string (enum) | No |
| [`description`](#description) | string | No |
| [`accountName`](#accountname) | string | No |
| [`namespace`](#namespace) | string | No |
| [`maConfigUrl`](#maconfigurl) | string | No |
| [`fluentdConfigUrl`](#fluentdconfigurl) | Object | No |
| [`autoKeyConfigUrl`](#autokeyconfigurl) | string | No |

____
### `name`
__Type__: string <br/>
__Required__: No<br/>
<br/>
Name of the sink. This value is referenced by DiagnosticsReferenceDescription

____
### `kind`
__Type__: string (enum) <br/>
__Required__: No<br/>
<br/>


The kind of DiagnosticsSink.

Possible values are: 

  - `Invalid` - Indicates an invalid sink kind. All Service Fabric enumerations have the invalid type.
  - `AzureInternalMonitoringPipeline` - Diagnostics settings for Geneva.



____
### `description`
__Type__: string <br/>
__Required__: No<br/>
<br/>
A description of the sink.

____
### `accountName`
__Type__: string <br/>
__Required__: No<br/>
<br/>
Azure Internal monitoring pipeline account.

____
### `namespace`
__Type__: string <br/>
__Required__: No<br/>
<br/>
Azure Internal monitoring pipeline account namespace.

____
### `maConfigUrl`
__Type__: string <br/>
__Required__: No<br/>
<br/>
Azure Internal monitoring agent configuration.

____
### `fluentdConfigUrl`
__Type__: Object <br/>
__Required__: No<br/>
<br/>
Azure Internal monitoring agent fluentd configuration.

____
### `autoKeyConfigUrl`
__Type__: string <br/>
__Required__: No<br/>
<br/>
Azure Internal monitoring pipeline autokey associated with the certificate.
