# Pharmac Schedules Capability Statement - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Pharmac Schedules Capability Statement**

## CapabilityStatement: Pharmac Schedules Capability Statement 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/CapabilityStatement/PharmacSchedulesCapabilityStatement | *Version*:1.0.1 |
| Draft as of 1970-01-01 | *Computable Name*:PharmacSchedulesCapabilityStatement |

 
Pharmac Schedules Capability Statement. This FHIR resource declares the capabilities of the Pharmac Schedules FHIR API, including supported interactions, resources, and security mechanisms. 

 [Raw OpenAPI-Swagger Definition file](PharmacSchedulesCapabilityStatement.openapi.json) | [Download](PharmacSchedulesCapabilityStatement.openapi.json) 



## Resource Content

```json
{
  "resourceType" : "CapabilityStatement",
  "id" : "PharmacSchedulesCapabilityStatement",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/CapabilityStatement/PharmacSchedulesCapabilityStatement",
  "version" : "1.0.1",
  "name" : "PharmacSchedulesCapabilityStatement",
  "title" : "Pharmac Schedules Capability Statement",
  "status" : "draft",
  "experimental" : false,
  "date" : "2026",
  "publisher" : "Pharmac",
  "contact" : [{
    "name" : "Pharmac",
    "telecom" : [{
      "system" : "url",
      "value" : "https://www.pharmac.govt.nz/about/contact"
    }]
  },
  {
    "name" : "Pharmac",
    "telecom" : [{
      "system" : "email",
      "value" : "enquiry@pharmac.govt.nz",
      "use" : "work"
    }]
  }],
  "description" : "Pharmac Schedules Capability Statement. This FHIR resource declares the capabilities of the Pharmac Schedules FHIR API, including supported interactions, resources, and security mechanisms.",
  "kind" : "instance",
  "software" : {
    "name" : "Pharmac Schedules API",
    "version" : "0.0.1"
  },
  "implementation" : {
    "description" : "Pharmac Schedules API",
    "url" : "https://example.com/fhir/ImplementationGuide/pharmac-schedules"
  },
  "fhirVersion" : "4.0.1",
  "format" : ["application/fhir+json"],
  "rest" : [{
    "mode" : "server",
    "security" : {
      "extension" : [{
        "extension" : [{
          "url" : "token",
          "valueUri" : "https://example.com/openid-connect/token"
        },
        {
          "url" : "authorize",
          "valueUri" : "https://example.com/openid-connect/token/openid-connect/authorize"
        }],
        "url" : "http://fhir-registry.smarthealthit.org/StructureDefinition/oauth-uris"
      },
      {
        "url" : "http://fhir-registry.smarthealthit.org/StructureDefinition/capabilities",
        "valueCode" : "client-confidential-symmetric"
      }],
      "cors" : true,
      "service" : [{
        "coding" : [{
          "code" : "SMART-on-FHIR"
        }]
      }],
      "description" : "OAuth 2.0 - Client Credential flow."
    },
    "resource" : [{
      "type" : "Medication",
      "profile" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication",
      "interaction" : [{
        "code" : "search-type",
        "documentation" : "Search for Medication resources by code, name, or identifier"
      },
      {
        "code" : "read",
        "documentation" : "Read a single Medication resource by ID"
      }],
      "searchParam" : [{
        "name" : "code",
        "type" : "token"
      },
      {
        "name" : "name",
        "type" : "string"
      }]
    },
    {
      "type" : "ChargeItemDefinition",
      "profile" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition",
      "interaction" : [{
        "code" : "search-type",
        "documentation" : "Search for ChargeItemDefinition resources (pricing information)"
      },
      {
        "code" : "read",
        "documentation" : "Read a single ChargeItemDefinition resource by ID"
      }],
      "searchParam" : [{
        "name" : "cid-code",
        "type" : "token"
      }]
    }]
  }]
}

```
