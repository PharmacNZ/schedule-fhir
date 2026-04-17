# ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-2 - Pharmac Schedules FHIR API v1.0.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-2**

## Example ChargeItemDefinition: ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-2

| |
| :--- |
| Active as of 2026-04-17 |



## Resource Content

```json
{
  "resourceType" : "ChargeItemDefinition",
  "id" : "ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-2",
  "meta" : {
    "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"]
  },
  "extension" : [{
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date",
    "valueDate" : "2026-02-01"
  },
  {
    "extension" : [{
      "url" : "type",
      "valueCode" : "community"
    },
    {
      "extension" : [{
        "url" : "type",
        "valueCode" : "CaseSequence"
      },
      {
        "url" : "value",
        "valueInteger" : 1
      }],
      "url" : "rule"
    },
    {
      "extension" : [{
        "url" : "type",
        "valueCode" : "FundingMechanism"
      },
      {
        "url" : "attribute",
        "valueCode" : "RuralPSO"
      }],
      "url" : "rule"
    }],
    "url" : "http://schedule.pharmac.govt.nz/fhir/StructureDefinition/funding-rule"
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-schema",
    "valueBase64Binary" : "ewogICIkc2NoZW1hIjogImh0dHA6Ly9qc29uLXNjaGVtYS5vcmcvZHJhZnQtMDcvc2NoZW1hIyIsCiAgInRpdGxlIjogIkNsZXhhbmUgMTAwbWcgMW1sIFN5cmluZ2UgQ2FzZSAyIiwKICAidHlwZSI6ICJvYmplY3QiLAogICJwcm9wZXJ0aWVzIjogewogICAgImVuZG9yc2VtZW50IjogewogICAgICAidGl0bGUiOiAiUFJJTUUgU2VydmljZSBFbmRvcnNlbWVudCIsCiAgICAgICJ0eXBlIjogImJvb2xlYW4iLAogICAgICAiZGVzY3JpcHRpb24iOiAiRm9yIHVzZSB3aXRoaW4gYSBQcmltYXJ5IFJlc3BvbnNlIGluIE1lZGljYWwgRW1lcmdlbmNpZXMgKFBSSU1FKSBzZXJ2aWNlIgogICAgfSwKICAgICJwcm92aWRlciI6IHsKICAgICAgInRpdGxlIjogIkF1dGhvcmlzZWQgUHJvdmlkZXJzIiwKICAgICAgInR5cGUiOiAiYm9vbGVhbiIsCiAgICAgICJkZXNjcmlwdGlvbiI6ICJQcm92aWRlciBUeXBlIGlzIEF1dGhvcmlzZWQgUHJvdmlkZXJzIgogICAgfQogIH0sCiAgInJlcXVpcmVkIjogWwogICAgImVuZG9yc2VtZW50IiwKICAgICJwcm92aWRlciIKICBdCn0K"
  }],
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-2",
  "version" : "1.0.0",
  "status" : "active",
  "date" : "2026-04-17T06:29:04+00:00",
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
  "description" : "Rules for Clexane 100 mg in 1 ml syringe. Community rural PSO case 2.",
  "instance" : [{
    "reference" : "Medication/Medication-Clexane-100mg-1ml-Syringe"
  }],
  "propertyGroup" : [{
    "applicability" : [{
      "description" : "Case 2 - community RuralPSO"
    }],
    "priceComponent" : [{
      "type" : "discount",
      "code" : {
        "text" : "PHARMAC Subsidy"
      },
      "amount" : {
        "value" : 70.91,
        "currency" : "NZD"
      }
    }]
  }]
}

```
