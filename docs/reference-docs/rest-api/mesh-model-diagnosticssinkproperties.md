# DiagnosticsSinkProperties

Properties of a DiagnosticsSink.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`name`](#name) | string | No |
| [`kind`](#kind) | string (enum) | No |
| [`description`](#description) | string | No |

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
