# Funding Subsidy Amount - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Funding Subsidy Amount**

## Extension: Funding Subsidy Amount 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/funding-subsidy-amount | *Version*:1.1.0 |
| Draft as of 2026-06-24 | *Computable Name*:FundingSubsidyAmount |

Structured subsidy details for funding rule cases, including subsidy type, status, optional amount, and display label.

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Charge Item Definition](StructureDefinition-pharmac-charge-item-definition.md)
* Examples for this Extension: [Bundle/SearchSet-Bundle-Adrenaline-Note-And-Limit](Bundle-SearchSet-Bundle-Adrenaline-Note-And-Limit.md), [Bundle/SearchSet-Bundle-All-Funding-Rules](Bundle-SearchSet-Bundle-All-Funding-Rules.md), [Bundle/SearchSet-Bundle-Estradiol-Limit](Bundle-SearchSet-Bundle-Estradiol-Limit.md), [Bundle/SearchSet-Bundle-Etoposide-Authority-Endorsement](Bundle-SearchSet-Bundle-Etoposide-Authority-Endorsement.md)... Show 46 more, [Bundle/SearchSet-Bundle-Famotidine-Endorsement-And-Note](Bundle-SearchSet-Bundle-Famotidine-Endorsement-And-Note.md), [Bundle/SearchSet-Bundle-Fluanxol-Multiple-Community-And-Hospital](Bundle-SearchSet-Bundle-Fluanxol-Multiple-Community-And-Hospital.md), [Bundle/SearchSet-Bundle-Nitisinone-Hospital-Restriction](Bundle-SearchSet-Bundle-Nitisinone-Hospital-Restriction.md), [ChargeItemDefinition/ChargeItemDefinition-50003171000117108-Hospital-Case-7](ChargeItemDefinition-ChargeItemDefinition-50003171000117108-Hospital-Case-7.md), [ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Community-Case-4.md), [ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50021691000117107-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50021691000117107-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50021691000117107-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50021691000117107-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50021691000117107-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50021691000117107-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50021691000117107-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50021691000117107-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50021721000117104-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50021721000117104-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50021721000117104-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50021721000117104-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50021991000117100-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50021991000117100-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50021991000117100-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50021991000117100-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50021991000117100-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50021991000117100-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50021991000117100-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50021991000117100-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50038111000117102-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50038111000117102-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50038111000117102-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50038111000117102-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Community-Case-4.md), [ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Community-Case-4.md), [ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50048881000117104-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50048881000117104-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50048881000117104-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50048881000117104-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50048881000117104-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50048881000117104-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50048881000117104-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50048881000117104-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50055641000117102-Hospital-Case-7](ChargeItemDefinition-ChargeItemDefinition-50055641000117102-Hospital-Case-7.md), [ChargeItemDefinition/ChargeItemDefinition-50058961000117103-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50058961000117103-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50058961000117103-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50058961000117103-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50058961000117103-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50058961000117103-Community-Case-4.md), [ChargeItemDefinition/ChargeItemDefinition-50058961000117103-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50058961000117103-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50074861000117103-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50074861000117103-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50074861000117103-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50074861000117103-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50083491000117102-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50083491000117102-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50083491000117102-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50083491000117102-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50085781000117107-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50085781000117107-Community-Case-1.md) and [ChargeItemDefinition/ChargeItemDefinition-50085781000117107-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50085781000117107-Community-Case-2.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/resource/pharmac.fhir.pharmac-schedules|current/StructureDefinition/StructureDefinition-funding-subsidy-amount.json)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-funding-subsidy-amount.csv), [Excel](StructureDefinition-funding-subsidy-amount.xlsx), [Schematron](StructureDefinition-funding-subsidy-amount.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "funding-subsidy-amount",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/funding-subsidy-amount",
  "version" : "1.1.0",
  "name" : "FundingSubsidyAmount",
  "title" : "Funding Subsidy Amount",
  "status" : "draft",
  "date" : "2026-06-24T20:43:54+00:00",
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
  "description" : "Structured subsidy details for funding rule cases, including subsidy type, status, optional amount, and display label.",
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
      "short" : "Funding Subsidy Amount",
      "definition" : "Structured subsidy details for funding rule cases, including subsidy type, status, optional amount, and display label."
    },
    {
      "id" : "Extension.extension:subsidyType",
      "path" : "Extension.extension",
      "sliceName" : "subsidyType",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:subsidyType.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:subsidyType.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "subsidyType"
    },
    {
      "id" : "Extension.extension:subsidyType.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Subsidy type code",
      "type" : [{
        "code" : "code"
      }]
    },
    {
      "id" : "Extension.extension:subsidyStatus",
      "path" : "Extension.extension",
      "sliceName" : "subsidyStatus",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:subsidyStatus.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:subsidyStatus.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "subsidyStatus"
    },
    {
      "id" : "Extension.extension:subsidyStatus.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Subsidy status code",
      "type" : [{
        "code" : "code"
      }]
    },
    {
      "id" : "Extension.extension:amount",
      "path" : "Extension.extension",
      "sliceName" : "amount",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:amount.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:amount.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "amount"
    },
    {
      "id" : "Extension.extension:amount.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Subsidy amount",
      "type" : [{
        "code" : "Money"
      }]
    },
    {
      "id" : "Extension.extension:display",
      "path" : "Extension.extension",
      "sliceName" : "display",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:display.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:display.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "display"
    },
    {
      "id" : "Extension.extension:display.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Subsidy label",
      "type" : [{
        "code" : "string"
      }]
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/funding-subsidy-amount"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "max" : "0"
    }]
  }
}

```
