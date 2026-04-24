# APIError-Unauthorised - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **APIError-Unauthorised**

## Example OperationOutcome: APIError-Unauthorised



## Resource Content

```json
{
  "resourceType" : "OperationOutcome",
  "id" : "APIError-Unauthorised",
  "issue" : [{
    "severity" : "error",
    "code" : "suppressed",
    "details" : {
      "coding" : [{
        "code" : "UNAUTHORISED"
      }]
    },
    "diagnostics" : "Unauthorised."
  }]
}

```
