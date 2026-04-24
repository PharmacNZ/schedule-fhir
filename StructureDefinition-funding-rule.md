# Funding Rule - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Funding Rule**

## Extension: Funding Rule 

| | |
| :--- | :--- |
| *Official URL*:http://schedule.pharmac.govt.nz/fhir/StructureDefinition/funding-rule | *Version*:1.0.1 |
| Active as of 2025-01-29 | *Computable Name*:FundingRule |

Funding rules that define medication and device funding conditions, restrictions, and special requirements

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Charge Item Definition](StructureDefinition-pharmac-charge-item-definition.md)
* Examples for this Extension: [Bundle/SearchSet-Bundle-Clexane-Pricing](Bundle-SearchSet-Bundle-Clexane-Pricing.md), [ChargeItemDefinition/ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1](ChargeItemDefinition-ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-2](ChargeItemDefinition-ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-2.md) and [ChargeItemDefinition/ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-3](ChargeItemDefinition-ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-3.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/pharmac.fhir.pharmac-schedules|current/StructureDefinition/funding-rule)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-funding-rule.csv), [Excel](StructureDefinition-funding-rule.xlsx), [Schematron](StructureDefinition-funding-rule.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "funding-rule",
  "url" : "http://schedule.pharmac.govt.nz/fhir/StructureDefinition/funding-rule",
  "version" : "1.0.1",
  "name" : "FundingRule",
  "title" : "Funding Rule",
  "status" : "active",
  "date" : "2025-01-29",
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
  "description" : "Funding rules that define medication and device funding conditions, restrictions, and special requirements",
  "fhirVersion" : "4.0.1",
  "mapping" : [{
    "identity" : "rim",
    "uri" : "http://hl7.org/v3",
    "name" : "RIM Mapping"
  }],
  "kind" : "complex-type",
  "abstract" : false,
  "context" : [{
    "type" : "element",
    "expression" : "ChargeItemDefinition"
  }],
  "type" : "Extension",
  "baseDefinition" : "http://hl7.org/fhir/StructureDefinition/Extension",
  "derivation" : "constraint",
  "differential" : {
    "element" : [{
      "id" : "Extension",
      "path" : "Extension",
      "short" : "Funding Rule",
      "definition" : "Funding rules that define medication and device funding conditions, restrictions, and special requirements"
    },
    {
      "id" : "Extension.extension",
      "path" : "Extension.extension",
      "min" : 1
    },
    {
      "id" : "Extension.extension:type",
      "path" : "Extension.extension",
      "sliceName" : "type",
      "min" : 1,
      "max" : "1",
      "mustSupport" : true
    },
    {
      "id" : "Extension.extension:type.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:type.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "type"
    },
    {
      "id" : "Extension.extension:type.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Funding type",
      "definition" : "The type of funding context (e.g., community, hospital). Typically aligns with PHARMAC schedule funding columns such as community or hospital supply.",
      "type" : [{
        "code" : "code"
      }]
    },
    {
      "id" : "Extension.extension:rule",
      "path" : "Extension.extension",
      "sliceName" : "rule",
      "min" : 0,
      "max" : "*",
      "mustSupport" : true
    },
    {
      "id" : "Extension.extension:rule.extension",
      "path" : "Extension.extension.extension",
      "min" : 1
    },
    {
      "id" : "Extension.extension:rule.extension:type",
      "path" : "Extension.extension.extension",
      "sliceName" : "type",
      "min" : 1,
      "max" : "1",
      "mustSupport" : true
    },
    {
      "id" : "Extension.extension:rule.extension:type.extension",
      "path" : "Extension.extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:rule.extension:type.url",
      "path" : "Extension.extension.extension.url",
      "fixedUri" : "type"
    },
    {
      "id" : "Extension.extension:rule.extension:type.value[x]",
      "path" : "Extension.extension.extension.value[x]",
      "short" : "Rule type",
      "definition" : "The type of funding rule (e.g., DoseSWt, FormReqd, FormMax, MaxCoPayment, SubRxF, Special, CaseSequence). CaseSequence indicates an ordered case within a card, with the numeric value held in the corresponding value element.",
      "type" : [{
        "code" : "code"
      }]
    },
    {
      "id" : "Extension.extension:rule.extension:value",
      "path" : "Extension.extension.extension",
      "sliceName" : "value",
      "definition" : "Numeric value associated with the funding rule. For CaseSequence, this is the case sequence number (e.g., 1, 2).",
      "min" : 0,
      "max" : "1",
      "mustSupport" : true
    },
    {
      "id" : "Extension.extension:rule.extension:value.extension",
      "path" : "Extension.extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:rule.extension:value.url",
      "path" : "Extension.extension.extension.url",
      "fixedUri" : "value"
    },
    {
      "id" : "Extension.extension:rule.extension:value.value[x]",
      "path" : "Extension.extension.extension.value[x]",
      "slicing" : {
        "discriminator" : [{
          "type" : "type",
          "path" : "$this"
        }],
        "ordered" : false,
        "rules" : "open"
      },
      "type" : [{
        "code" : "decimal"
      },
      {
        "code" : "integer"
      }]
    },
    {
      "id" : "Extension.extension:rule.extension:value.value[x]:valueDecimal",
      "path" : "Extension.extension.extension.value[x]",
      "sliceName" : "valueDecimal",
      "short" : "Rule value (decimal)",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "decimal"
      }]
    },
    {
      "id" : "Extension.extension:rule.extension:value.value[x]:valueInteger",
      "path" : "Extension.extension.extension.value[x]",
      "sliceName" : "valueInteger",
      "short" : "Rule value (integer)",
      "min" : 0,
      "max" : "1",
      "type" : [{
        "code" : "integer"
      }]
    },
    {
      "id" : "Extension.extension:rule.extension:attribute",
      "path" : "Extension.extension.extension",
      "sliceName" : "attribute",
      "min" : 0,
      "max" : "1",
      "mustSupport" : true
    },
    {
      "id" : "Extension.extension:rule.extension:attribute.extension",
      "path" : "Extension.extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:rule.extension:attribute.url",
      "path" : "Extension.extension.extension.url",
      "fixedUri" : "attribute"
    },
    {
      "id" : "Extension.extension:rule.extension:attribute.value[x]",
      "path" : "Extension.extension.extension.value[x]",
      "short" : "Rule attribute",
      "definition" : "Attribute associated with the funding rule (e.g., Rx, Subsidy). This may be used to further qualify the rule type where required.",
      "type" : [{
        "code" : "code"
      }]
    },
    {
      "id" : "Extension.extension:rule.extension:href",
      "path" : "Extension.extension.extension",
      "sliceName" : "href",
      "min" : 0,
      "max" : "1",
      "mustSupport" : true
    },
    {
      "id" : "Extension.extension:rule.extension:href.extension",
      "path" : "Extension.extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:rule.extension:href.url",
      "path" : "Extension.extension.extension.url",
      "fixedUri" : "href"
    },
    {
      "id" : "Extension.extension:rule.extension:href.value[x]",
      "path" : "Extension.extension.extension.value[x]",
      "short" : "Rule href/reference",
      "definition" : "Reference code for special funding arrangements (e.g., SA2137)",
      "type" : [{
        "code" : "code"
      }]
    },
    {
      "id" : "Extension.extension:rule.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "rule"
    },
    {
      "id" : "Extension.extension:rule.value[x]",
      "path" : "Extension.extension.value[x]",
      "max" : "0"
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "http://schedule.pharmac.govt.nz/fhir/StructureDefinition/funding-rule"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "max" : "0"
    }]
  }
}

```
