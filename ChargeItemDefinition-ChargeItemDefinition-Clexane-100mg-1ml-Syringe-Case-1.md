# ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1 - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1**

## Example ChargeItemDefinition: ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1

| |
| :--- |
| Active as of 2026-04-24 |



## Resource Content

```json
{
  "resourceType" : "ChargeItemDefinition",
  "id" : "ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1",
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
        "valueCode" : "Prescription"
      }],
      "url" : "rule"
    },
    {
      "extension" : [{
        "url" : "type",
        "valueCode" : "SubsidyType"
      },
      {
        "url" : "attribute",
        "valueCode" : "Full"
      }],
      "url" : "rule"
    }],
    "url" : "http://schedule.pharmac.govt.nz/fhir/StructureDefinition/funding-rule"
  },
  {
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-schema",
    "valueBase64Binary" : "ewogICIkc2NoZW1hIjogImh0dHA6Ly9qc29uLXNjaGVtYS5vcmcvZHJhZnQtMDcvc2NoZW1hIyIsCiAgInRpdGxlIjogIkNsZXhhbmUgMTAwbWcgMW1sIFN5cmluZ2UgQ2FzZSAxIiwKICAidHlwZSI6ICJvYmplY3QiLAogICJwcm9wZXJ0aWVzIjogewogICAgImF1dGhvcml0eSI6IHsKICAgICAgInRpdGxlIjogIlNBOTk5OSIsCiAgICAgICIkdXJsIjogImh0dHBzOi8vZmhpci1pZy5kaWdpdGFsLmhlYWx0aC5uei9waGFybWFjLXNjaGVkdWxlcy9DaGFyZ2VJdGVtRGVmaW5pdGlvbi9DaGFyZ2VJdGVtRGVmaW5pdGlvbi1TQTk5OTktQXV0aG9yaXphdGlvbiIsCiAgICAgICJ0eXBlIjogImJvb2xlYW4iLAogICAgICAiZGVzY3JpcHRpb24iOiAiSGFzIFNBOTk5OSIKICAgIH0sCiAgICAicHJvdmlkZXIiOiB7CiAgICAgICJ0aXRsZSI6ICJBdXRob3Jpc2VkIFByb3ZpZGVycyIsCiAgICAgICJ0eXBlIjogImJvb2xlYW4iLAogICAgICAiZGVzY3JpcHRpb24iOiAiUHJvdmlkZXIgVHlwZSBpcyBBdXRob3Jpc2VkIFByb3ZpZGVycyIKICAgIH0KICB9LAogICJyZXF1aXJlZCI6IFsKICAgICJhdXRob3JpdHkiLAogICAgInByb3ZpZGVyIgogIF0KfQo="
  }],
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ChargeItemDefinition/ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-Sequence-1",
  "version" : "1.0.1",
  "status" : "active",
  "date" : "2026-04-24T01:18:12+00:00",
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
  "description" : "Rules for Clexane 100 mg in 1 ml syringe. Community pharmacy prescription case sequence 1.",
  "instance" : [{
    "reference" : "Medication/Medication-Clexane-100mg-1ml-Syringe"
  }],
  "propertyGroup" : [{
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
