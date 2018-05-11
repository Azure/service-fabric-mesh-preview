# HealthState enum

type: string

The health state of a resource such as Application, Service, or Network.

Possible values are: 

  - `Invalid` - Indicates an invalid health state. All Service Fabric enumerations have the invalid type. The value is zero.
  - `Ok` - Indicates the health state is okay. The value is 1.
  - `Warning` - Indicates the health state is at a warning level. The value is 2.
  - `Error` - Indicates the health state is at an error level. Error health state should be investigated, as they can impact the correct functionality of the cluster. The value is 3.
  - `Unknown` - Indicates an unknown health status. The value is 65535.

