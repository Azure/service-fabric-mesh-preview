# ImageRegistryCredential

Image registry credential.

## Properties
| Name | Type | Required |
| --- | --- | --- |
| [`server`](#server) | string | Yes |
| [`username`](#username) | string | Yes |
| [`password`](#password) | string | No |

____
### `server`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
Docker image registry server, without protocol such as `http` and `https`.

____
### `username`
__Type__: string <br/>
__Required__: Yes<br/>
<br/>
The username for the private registry.

____
### `password`
__Type__: string <br/>
__Required__: No<br/>
<br/>
The password for the private registry.
