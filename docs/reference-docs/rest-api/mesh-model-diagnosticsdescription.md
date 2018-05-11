# DiagnosticsDescription

Describes the diagnostics options available

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`sinks`](#sinks) | array of [DiagnosticsSinkProperties](mesh-model-diagnosticssinkproperties.md) | No |
| [`enabled`](#enabled) | boolean | No |
| [`defaultSinkRefs`](#defaultsinkrefs) | Object | No |

____
### `sinks`
__Type__: array of [DiagnosticsSinkProperties](mesh-model-diagnosticssinkproperties.md) <br/>
__Required__: No<br/>
<br/>
List of supported sinks that can be referenced.

____
### `enabled`
__Type__: boolean <br/>
__Required__: No<br/>
<br/>
Status of whether or not sinks are enabled.

____
### `defaultSinkRefs`
__Type__: Object <br/>
__Required__: No<br/>
<br/>
The sinks to be used if diagnostics is enabled. Sink choices can be overridden at the service and code package level.
