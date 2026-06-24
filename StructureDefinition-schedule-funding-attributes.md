# Schedule Funding Attributes - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **Schedule Funding Attributes**

## Extension: Schedule Funding Attributes 

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/schedule-funding-attributes | *Version*:1.1.0 |
| Draft as of 2026-06-24 | *Computable Name*:ScheduleFundingAttributes |

Grouped funding attributes for schedule records, including contract and dispensing flags, co-payment markers, and related indicators.

**Context of Use**

**Usage info**

**Usages:**

* Use this Extension: [PHARMAC Charge Item Definition](StructureDefinition-pharmac-charge-item-definition.md)
* Examples for this Extension: [Bundle/SearchSet-Bundle-Adrenaline-Note-And-Limit](Bundle-SearchSet-Bundle-Adrenaline-Note-And-Limit.md), [Bundle/SearchSet-Bundle-All-Funding-Rules](Bundle-SearchSet-Bundle-All-Funding-Rules.md), [Bundle/SearchSet-Bundle-Estradiol-Limit](Bundle-SearchSet-Bundle-Estradiol-Limit.md), [Bundle/SearchSet-Bundle-Etoposide-Authority-Endorsement](Bundle-SearchSet-Bundle-Etoposide-Authority-Endorsement.md)... Show 46 more, [Bundle/SearchSet-Bundle-Famotidine-Endorsement-And-Note](Bundle-SearchSet-Bundle-Famotidine-Endorsement-And-Note.md), [Bundle/SearchSet-Bundle-Fluanxol-Multiple-Community-And-Hospital](Bundle-SearchSet-Bundle-Fluanxol-Multiple-Community-And-Hospital.md), [Bundle/SearchSet-Bundle-Nitisinone-Hospital-Restriction](Bundle-SearchSet-Bundle-Nitisinone-Hospital-Restriction.md), [ChargeItemDefinition/ChargeItemDefinition-50003171000117108-Hospital-Case-7](ChargeItemDefinition-ChargeItemDefinition-50003171000117108-Hospital-Case-7.md), [ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Community-Case-4.md), [ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50021691000117107-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50021691000117107-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50021691000117107-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50021691000117107-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50021691000117107-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50021691000117107-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50021691000117107-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50021691000117107-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50021721000117104-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50021721000117104-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50021721000117104-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50021721000117104-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50021991000117100-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50021991000117100-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50021991000117100-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50021991000117100-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50021991000117100-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50021991000117100-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50021991000117100-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50021991000117100-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50038111000117102-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50038111000117102-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50038111000117102-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50038111000117102-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Community-Case-4.md), [ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Community-Case-4.md), [ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50048881000117104-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50048881000117104-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50048881000117104-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50048881000117104-Community-Case-2.md), [ChargeItemDefinition/ChargeItemDefinition-50048881000117104-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50048881000117104-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50048881000117104-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50048881000117104-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50055641000117102-Hospital-Case-7](ChargeItemDefinition-ChargeItemDefinition-50055641000117102-Hospital-Case-7.md), [ChargeItemDefinition/ChargeItemDefinition-50058961000117103-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50058961000117103-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50058961000117103-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50058961000117103-Community-Case-3.md), [ChargeItemDefinition/ChargeItemDefinition-50058961000117103-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50058961000117103-Community-Case-4.md), [ChargeItemDefinition/ChargeItemDefinition-50058961000117103-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50058961000117103-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50074861000117103-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50074861000117103-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50074861000117103-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50074861000117103-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50083491000117102-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50083491000117102-Community-Case-1.md), [ChargeItemDefinition/ChargeItemDefinition-50083491000117102-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50083491000117102-Hospital-Case-5.md), [ChargeItemDefinition/ChargeItemDefinition-50085781000117107-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50085781000117107-Community-Case-1.md) and [ChargeItemDefinition/ChargeItemDefinition-50085781000117107-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50085781000117107-Community-Case-2.md)

You can also check for [usages in the FHIR IG Statistics](https://packages2.fhir.org/xig/resource/pharmac.fhir.pharmac-schedules|current/StructureDefinition/StructureDefinition-schedule-funding-attributes.json)

### Formal Views of Extension Content

 [Description of Profiles, Differentials, Snapshots, and how the XML and JSON presentations work](http://build.fhir.org/ig/FHIR/ig-guidance/readingIgs.html#structure-definitions). 

 

Other representations of profile: [CSV](StructureDefinition-schedule-funding-attributes.csv), [Excel](StructureDefinition-schedule-funding-attributes.xlsx), [Schematron](StructureDefinition-schedule-funding-attributes.sch) 

#### Constraints



## Resource Content

```json
{
  "resourceType" : "StructureDefinition",
  "id" : "schedule-funding-attributes",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/schedule-funding-attributes",
  "version" : "1.1.0",
  "name" : "ScheduleFundingAttributes",
  "title" : "Schedule Funding Attributes",
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
  "description" : "Grouped funding attributes for schedule records, including contract and dispensing flags, co-payment markers, and related indicators.",
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
      "short" : "Schedule Funding Attributes",
      "definition" : "Grouped funding attributes for schedule records, including contract and dispensing flags, co-payment markers, and related indicators."
    },
    {
      "id" : "Extension.extension:productMultiple",
      "path" : "Extension.extension",
      "sliceName" : "productMultiple",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:productMultiple.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:productMultiple.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "productMultiple"
    },
    {
      "id" : "Extension.extension:productMultiple.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Product multiple flag",
      "type" : [{
        "code" : "boolean"
      }]
    },
    {
      "id" : "Extension.extension:productMultiplier",
      "path" : "Extension.extension",
      "sliceName" : "productMultiplier",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:productMultiplier.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:productMultiplier.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "productMultiplier"
    },
    {
      "id" : "Extension.extension:productMultiplier.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Product multiplier value",
      "type" : [{
        "code" : "integer"
      }]
    },
    {
      "id" : "Extension.extension:originalPack",
      "path" : "Extension.extension",
      "sliceName" : "originalPack",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:originalPack.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:originalPack.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "originalPack"
    },
    {
      "id" : "Extension.extension:originalPack.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Original pack flag",
      "type" : [{
        "code" : "boolean"
      }]
    },
    {
      "id" : "Extension.extension:safetyListMedicine",
      "path" : "Extension.extension",
      "sliceName" : "safetyListMedicine",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:safetyListMedicine.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:safetyListMedicine.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "safetyListMedicine"
    },
    {
      "id" : "Extension.extension:safetyListMedicine.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Safety list medicine flag",
      "type" : [{
        "code" : "boolean"
      }]
    },
    {
      "id" : "Extension.extension:costBrandSource",
      "path" : "Extension.extension",
      "sliceName" : "costBrandSource",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:costBrandSource.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:costBrandSource.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "costBrandSource"
    },
    {
      "id" : "Extension.extension:costBrandSource.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Cost brand source flag",
      "type" : [{
        "code" : "boolean"
      }]
    },
    {
      "id" : "Extension.extension:wastageClaimable",
      "path" : "Extension.extension",
      "sliceName" : "wastageClaimable",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:wastageClaimable.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:wastageClaimable.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "wastageClaimable"
    },
    {
      "id" : "Extension.extension:wastageClaimable.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Wastage claimable flag",
      "type" : [{
        "code" : "boolean"
      }]
    },
    {
      "id" : "Extension.extension:contractType",
      "path" : "Extension.extension",
      "sliceName" : "contractType",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:contractType.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:contractType.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "contractType"
    },
    {
      "id" : "Extension.extension:contractType.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Contract type",
      "type" : [{
        "code" : "string"
      }]
    },
    {
      "id" : "Extension.extension:dvLimitPercent",
      "path" : "Extension.extension",
      "sliceName" : "dvLimitPercent",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:dvLimitPercent.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:dvLimitPercent.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "dvLimitPercent"
    },
    {
      "id" : "Extension.extension:dvLimitPercent.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "DV limit percentage",
      "type" : [{
        "code" : "decimal"
      }]
    },
    {
      "id" : "Extension.extension:brandSwitchFee",
      "path" : "Extension.extension",
      "sliceName" : "brandSwitchFee",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:brandSwitchFee.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:brandSwitchFee.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "brandSwitchFee"
    },
    {
      "id" : "Extension.extension:brandSwitchFee.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Brand switch fee flag",
      "type" : [{
        "code" : "boolean"
      }]
    },
    {
      "id" : "Extension.extension:statim",
      "path" : "Extension.extension",
      "sliceName" : "statim",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:statim.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:statim.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "statim"
    },
    {
      "id" : "Extension.extension:statim.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Statim applicability",
      "type" : [{
        "code" : "string"
      }]
    },
    {
      "id" : "Extension.extension:inCombination",
      "path" : "Extension.extension",
      "sliceName" : "inCombination",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:inCombination.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:inCombination.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "inCombination"
    },
    {
      "id" : "Extension.extension:inCombination.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "In-combination funding flag",
      "type" : [{
        "code" : "code"
      }]
    },
    {
      "id" : "Extension.extension:section29",
      "path" : "Extension.extension",
      "sliceName" : "section29",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:section29.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:section29.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "section29"
    },
    {
      "id" : "Extension.extension:section29.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Section 29 applicability",
      "type" : [{
        "code" : "boolean"
      }]
    },
    {
      "id" : "Extension.extension:coPaymentMin",
      "path" : "Extension.extension",
      "sliceName" : "coPaymentMin",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:coPaymentMin.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:coPaymentMin.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "coPaymentMin"
    },
    {
      "id" : "Extension.extension:coPaymentMin.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Co-payment minimum applicability",
      "type" : [{
        "code" : "code"
      }]
    },
    {
      "id" : "Extension.extension:coPaymentMax",
      "path" : "Extension.extension",
      "sliceName" : "coPaymentMax",
      "min" : 0,
      "max" : "1"
    },
    {
      "id" : "Extension.extension:coPaymentMax.extension",
      "path" : "Extension.extension.extension",
      "max" : "0"
    },
    {
      "id" : "Extension.extension:coPaymentMax.url",
      "path" : "Extension.extension.url",
      "fixedUri" : "coPaymentMax"
    },
    {
      "id" : "Extension.extension:coPaymentMax.value[x]",
      "path" : "Extension.extension.value[x]",
      "short" : "Co-payment maximum applicability",
      "type" : [{
        "code" : "code"
      }]
    },
    {
      "id" : "Extension.url",
      "path" : "Extension.url",
      "fixedUri" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/schedule-funding-attributes"
    },
    {
      "id" : "Extension.value[x]",
      "path" : "Extension.value[x]",
      "max" : "0"
    }]
  }
}

```
