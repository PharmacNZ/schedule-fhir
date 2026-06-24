# Pharmac Medicine & Medical Device Schedule - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* **Pharmac Medicine & Medical Device Schedule**

## Pharmac Medicine & Medical Device Schedule

| | |
| :--- | :--- |
| *Official URL*:https://fhir-ig.digital.health.nz/pharmac-schedules/ImplementationGuide/pharmac.fhir.pharmac-schedules | *Version*:1.1.0 |
| Draft as of 2026-06-24 | *Computable Name*:pharmacschedules |

# Pharmac Schedules FHIR API

The Pharmac Schedules FHIR API provides access to schedule data for funded medicines and devices. This Fast Healthcare Interoperable Resources (FHIR) API publishes Schedule data using standard FHIR resources to support integration and reuse. API Consumers can query the Pharmac Schedules API to retrieve information about funded items and related details.

# Who can use this API

This API is intended for approved consumers integrating Pharmac schedule information into their systems.

# Onboarding and Implementation

Contact the Pharmac team to request access and onboarding details.



## Resource Content

```json
{
  "resourceType" : "ImplementationGuide",
  "id" : "pharmac.fhir.pharmac-schedules",
  "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/ImplementationGuide/pharmac.fhir.pharmac-schedules",
  "version" : "1.1.0",
  "name" : "pharmacschedules",
  "title" : "Pharmac Schedules FHIR API",
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
  "description" : "Pharmac Schedules FHIR Implementation Guide",
  "packageId" : "pharmac.fhir.pharmac-schedules",
  "license" : "CC0-1.0",
  "fhirVersion" : ["4.0.1"],
  "dependsOn" : [{
    "id" : "hl7tx",
    "extension" : [{
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/implementationguide-dependency-comment",
      "valueMarkdown" : "Automatically added as a dependency - all IGs depend on HL7 Terminology"
    }],
    "uri" : "http://terminology.hl7.org/ImplementationGuide/hl7.terminology",
    "packageId" : "hl7.terminology.r4",
    "version" : "7.2.0"
  },
  {
    "id" : "hl7ext",
    "extension" : [{
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/implementationguide-dependency-comment",
      "valueMarkdown" : "Automatically added as a dependency - all IGs depend on the HL7 Extension Pack"
    }],
    "uri" : "http://hl7.org/fhir/extensions/ImplementationGuide/hl7.fhir.uv.extensions",
    "packageId" : "hl7.fhir.uv.extensions.r4",
    "version" : "5.3.0"
  }],
  "definition" : {
    "extension" : [{
      "extension" : [{
        "url" : "code",
        "valueString" : "copyrightyear"
      },
      {
        "url" : "value",
        "valueString" : "2026+"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "releaselabel"
      },
      {
        "url" : "value",
        "valueString" : "draft"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "no-narrative"
      },
      {
        "url" : "value",
        "valueString" : "*/*"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "excludexml"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "excludettl"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "autoload-resources"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "path-liquid"
      },
      {
        "url" : "value",
        "valueString" : "template/liquid"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "path-liquid"
      },
      {
        "url" : "value",
        "valueString" : "input/liquid"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "path-qa"
      },
      {
        "url" : "value",
        "valueString" : "temp/qa"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "path-temp"
      },
      {
        "url" : "value",
        "valueString" : "temp/pages"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "path-output"
      },
      {
        "url" : "value",
        "valueString" : "output"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "path-suppressed-warnings"
      },
      {
        "url" : "value",
        "valueString" : "input/ignoreWarnings.txt"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "path-history"
      },
      {
        "url" : "value",
        "valueString" : "https://fhir-ig.digital.health.nz/pharmac-schedules/history.html"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "template-html"
      },
      {
        "url" : "value",
        "valueString" : "template-page.html"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "template-md"
      },
      {
        "url" : "value",
        "valueString" : "template-page-md.html"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "apply-contact"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "apply-context"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "apply-copyright"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "apply-jurisdiction"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "apply-license"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "apply-publisher"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "apply-version"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "apply-wg"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "active-tables"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "fmm-definition"
      },
      {
        "url" : "value",
        "valueString" : "http://hl7.org/fhir/versions.html#maturity"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "propagate-status"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "excludelogbinaryformat"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueString" : "tabbed-snapshots"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-internal-dependency",
      "valueCode" : "hl7.fhir.uv.tools.r4#1.1.2"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "copyrightyear"
      },
      {
        "url" : "value",
        "valueString" : "2026+"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "releaselabel"
      },
      {
        "url" : "value",
        "valueString" : "draft"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "no-narrative"
      },
      {
        "url" : "value",
        "valueString" : "*/*"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "excludexml"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "excludettl"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "autoload-resources"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "path-liquid"
      },
      {
        "url" : "value",
        "valueString" : "template/liquid"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "path-liquid"
      },
      {
        "url" : "value",
        "valueString" : "input/liquid"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "path-qa"
      },
      {
        "url" : "value",
        "valueString" : "temp/qa"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "path-temp"
      },
      {
        "url" : "value",
        "valueString" : "temp/pages"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "path-output"
      },
      {
        "url" : "value",
        "valueString" : "output"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "path-suppressed-warnings"
      },
      {
        "url" : "value",
        "valueString" : "input/ignoreWarnings.txt"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "path-history"
      },
      {
        "url" : "value",
        "valueString" : "https://fhir-ig.digital.health.nz/pharmac-schedules/history.html"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "template-html"
      },
      {
        "url" : "value",
        "valueString" : "template-page.html"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "template-md"
      },
      {
        "url" : "value",
        "valueString" : "template-page-md.html"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "apply-contact"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "apply-context"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "apply-copyright"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "apply-jurisdiction"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "apply-license"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "apply-publisher"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "apply-version"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "apply-wg"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "active-tables"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "fmm-definition"
      },
      {
        "url" : "value",
        "valueString" : "http://hl7.org/fhir/versions.html#maturity"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "propagate-status"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "excludelogbinaryformat"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    },
    {
      "extension" : [{
        "url" : "code",
        "valueCode" : "tabbed-snapshots"
      },
      {
        "url" : "value",
        "valueString" : "true"
      }],
      "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-parameter"
    }],
    "resource" : [{
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "OperationOutcome"
      }],
      "reference" : {
        "reference" : "OperationOutcome/APIError-Unauthorised"
      },
      "name" : "APIError-Unauthorised",
      "description" : "An example of an OperationOutcome resource representing an unauthorised access error.",
      "exampleBoolean" : true
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/authorization-case-count"
      },
      "name" : "Authorization Case Count",
      "description" : "The number of authorization cases or approval criteria specified in the authorization requirement. This indicates how many different clinical scenarios or conditions have distinct approval pathways.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/authorization-form"
      },
      "name" : "Authorization Form",
      "description" : "The special authorization form code required for this medication (e.g., 'SA2535'). This identifies the specific PHARMAC authorization form that prescribers must complete for patient eligibility.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/authorization-schema"
      },
      "name" : "Authorization Schema",
      "description" : "Base64-encoded JSON Schema that defines the structure and validation rules for a Special Authorization application form. The decoded content is a JSON Schema (application/schema+json).",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/authorization-title"
      },
      "name" : "Authorization Title",
      "description" : "A human-readable title for the authorization requirement (e.g., 'Budesonide - Special Authorization Required'). This provides context for the authorization need.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/brand-switch-fee"
      },
      "name" : "Brand Switch Fee",
      "description" : "Indicates whether a brand switch fee applies for this item.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50003171000117108-Hospital-Case-7"
      },
      "name" : "ChargeItemDefinition-50003171000117108-Hospital-Case-7",
      "description" : "Rules for Remicade 100 mg injection: powder for, 1 x 100 mg vial. hospital Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50014861000117106-Community-Case-1",
      "description" : "Rules for Mifegyne 200 mg tablet: uncoated, 3 tablets, blister pack. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Community-Case-2"
      },
      "name" : "ChargeItemDefinition-50014861000117106-Community-Case-2",
      "description" : "Rules for Mifegyne 200 mg tablet: uncoated, 3 tablets, blister pack. community BSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Community-Case-3"
      },
      "name" : "ChargeItemDefinition-50014861000117106-Community-Case-3",
      "description" : "Rules for Mifegyne 200 mg tablet: uncoated, 3 tablets, blister pack. community Rural PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Community-Case-4"
      },
      "name" : "ChargeItemDefinition-50014861000117106-Community-Case-4",
      "description" : "Rules for Mifegyne 200 mg tablet: uncoated, 3 tablets, blister pack. community PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50014861000117106-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50014861000117106-Hospital-Case-5",
      "description" : "Rules for Mifegyne 200 mg tablet: uncoated, 3 tablets, blister pack. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50021691000117107-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50021691000117107-Community-Case-1",
      "description" : "Rules for Seretide Accuhaler 250/50 inhalation: powder for, 60 actuations, blister pack. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50021691000117107-Community-Case-2"
      },
      "name" : "ChargeItemDefinition-50021691000117107-Community-Case-2",
      "description" : "Rules for Seretide Accuhaler 250/50 inhalation: powder for, 60 actuations, blister pack. community BSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50021691000117107-Community-Case-3"
      },
      "name" : "ChargeItemDefinition-50021691000117107-Community-Case-3",
      "description" : "Rules for Seretide Accuhaler 250/50 inhalation: powder for, 60 actuations, blister pack. community Rural PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50021691000117107-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50021691000117107-Hospital-Case-5",
      "description" : "Rules for Seretide Accuhaler 250/50 inhalation: powder for, 60 actuations, blister pack. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50021721000117104-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50021721000117104-Community-Case-1",
      "description" : "Rules for Rectogesic 0.2% (2 mg/g) ointment, 30 g, tube. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50021721000117104-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50021721000117104-Hospital-Case-5",
      "description" : "Rules for Rectogesic 0.2% (2 mg/g) ointment, 30 g, tube. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50021991000117100-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50021991000117100-Community-Case-1",
      "description" : "Rules for Sulphur Precipitated (Midwest) powder, 100 g, jar. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50021991000117100-Community-Case-2"
      },
      "name" : "ChargeItemDefinition-50021991000117100-Community-Case-2",
      "description" : "Rules for Sulphur Precipitated (Midwest) powder, 100 g, jar. community BSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50021991000117100-Community-Case-3"
      },
      "name" : "ChargeItemDefinition-50021991000117100-Community-Case-3",
      "description" : "Rules for Sulphur Precipitated (Midwest) powder, 100 g, jar. community Rural PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50021991000117100-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50021991000117100-Hospital-Case-5",
      "description" : "Rules for Sulphur Precipitated (Midwest) powder, 100 g, jar. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50038111000117102-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50038111000117102-Community-Case-1",
      "description" : "Rules for EpiPen Auto-Injector 300 microgram/0.3 mL injection: solution, 1 x 0.3 mL prefilled injection device. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50038111000117102-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50038111000117102-Hospital-Case-5",
      "description" : "Rules for EpiPen Auto-Injector 300 microgram/0.3 mL injection: solution, 1 x 0.3 mL prefilled injection device. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50046921000117106-Community-Case-1",
      "description" : "Rules for Deprim oral liquid+E15:Y15: suspension, 100 mL, bottle. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Community-Case-2"
      },
      "name" : "ChargeItemDefinition-50046921000117106-Community-Case-2",
      "description" : "Rules for Deprim oral liquid+E15:Y15: suspension, 100 mL, bottle. community BSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Community-Case-3"
      },
      "name" : "ChargeItemDefinition-50046921000117106-Community-Case-3",
      "description" : "Rules for Deprim oral liquid+E15:Y15: suspension, 100 mL, bottle. community Rural PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Community-Case-4"
      },
      "name" : "ChargeItemDefinition-50046921000117106-Community-Case-4",
      "description" : "Rules for Deprim oral liquid+E15:Y15: suspension, 100 mL, bottle. community PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50046921000117106-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50046921000117106-Hospital-Case-5",
      "description" : "Rules for Deprim oral liquid+E15:Y15: suspension, 100 mL, bottle. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50046931000117109-Community-Case-1",
      "description" : "Rules for Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-2"
      },
      "name" : "ChargeItemDefinition-50046931000117109-Community-Case-2",
      "description" : "Rules for Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules. community BSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-3"
      },
      "name" : "ChargeItemDefinition-50046931000117109-Community-Case-3",
      "description" : "Rules for Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules. community Rural PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Community-Case-4"
      },
      "name" : "ChargeItemDefinition-50046931000117109-Community-Case-4",
      "description" : "Rules for Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules. community PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50046931000117109-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50046931000117109-Hospital-Case-5",
      "description" : "Rules for Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50048881000117104-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50048881000117104-Community-Case-1",
      "description" : "Rules for Hydrocortisone (ABM) powder, 25 g, jar. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50048881000117104-Community-Case-2"
      },
      "name" : "ChargeItemDefinition-50048881000117104-Community-Case-2",
      "description" : "Rules for Hydrocortisone (ABM) powder, 25 g, jar. community BSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50048881000117104-Community-Case-3"
      },
      "name" : "ChargeItemDefinition-50048881000117104-Community-Case-3",
      "description" : "Rules for Hydrocortisone (ABM) powder, 25 g, jar. community Rural PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50048881000117104-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50048881000117104-Hospital-Case-5",
      "description" : "Rules for Hydrocortisone (ABM) powder, 25 g, jar. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50055641000117102-Hospital-Case-7"
      },
      "name" : "ChargeItemDefinition-50055641000117102-Hospital-Case-7",
      "description" : "Rules for Thio-Tepa 15 mg injection: powder for, 1 x 15 mg vial. hospital Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50058961000117103-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50058961000117103-Community-Case-1",
      "description" : "Rules for Solu-Cortef ACT-O-VIAL 100 mg injection: powder for, 1 x 100 mg dual chamber vial. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50058961000117103-Community-Case-3"
      },
      "name" : "ChargeItemDefinition-50058961000117103-Community-Case-3",
      "description" : "Rules for Solu-Cortef ACT-O-VIAL 100 mg injection: powder for, 1 x 100 mg dual chamber vial. community Rural PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50058961000117103-Community-Case-4"
      },
      "name" : "ChargeItemDefinition-50058961000117103-Community-Case-4",
      "description" : "Rules for Solu-Cortef ACT-O-VIAL 100 mg injection: powder for, 1 x 100 mg dual chamber vial. community PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50058961000117103-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50058961000117103-Hospital-Case-5",
      "description" : "Rules for Solu-Cortef ACT-O-VIAL 100 mg injection: powder for, 1 x 100 mg dual chamber vial. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50074861000117103-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50074861000117103-Community-Case-1",
      "description" : "Rules for Laevolac 3.34 g/5 mL oral liquid: solution, 500 mL, bottle. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50074861000117103-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50074861000117103-Hospital-Case-5",
      "description" : "Rules for Laevolac 3.34 g/5 mL oral liquid: solution, 500 mL, bottle. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50083491000117102-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50083491000117102-Community-Case-1",
      "description" : "Rules for Clexane 80 mg/0.8 mL injection: solution, 10 x 0.8 mL syringes. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50083491000117102-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50083491000117102-Hospital-Case-5",
      "description" : "Rules for Clexane 80 mg/0.8 mL injection: solution, 10 x 0.8 mL syringes. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50085781000117107-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50085781000117107-Community-Case-1",
      "description" : "Rules for Fluanxol Depot 40 mg/2 mL injection: modified release, 5 x 2 mL ampoules. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50085781000117107-Community-Case-2"
      },
      "name" : "ChargeItemDefinition-50085781000117107-Community-Case-2",
      "description" : "Rules for Fluanxol Depot 40 mg/2 mL injection: modified release, 5 x 2 mL ampoules. community BSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50085781000117107-Community-Case-3"
      },
      "name" : "ChargeItemDefinition-50085781000117107-Community-Case-3",
      "description" : "Rules for Fluanxol Depot 40 mg/2 mL injection: modified release, 5 x 2 mL ampoules. community Rural PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50085781000117107-Community-Case-4"
      },
      "name" : "ChargeItemDefinition-50085781000117107-Community-Case-4",
      "description" : "Rules for Fluanxol Depot 40 mg/2 mL injection: modified release, 5 x 2 mL ampoules. community PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50085781000117107-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50085781000117107-Hospital-Case-5",
      "description" : "Rules for Fluanxol Depot 40 mg/2 mL injection: modified release, 5 x 2 mL ampoules. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50120021000117104-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50120021000117104-Community-Case-1",
      "description" : "Rules for Fludara Oral 10 mg tablet: film-coated, 20 tablets, blister pack. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50120021000117104-Community-Case-2"
      },
      "name" : "ChargeItemDefinition-50120021000117104-Community-Case-2",
      "description" : "Rules for Fludara Oral 10 mg tablet: film-coated, 20 tablets, blister pack. community BSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50120021000117104-Community-Case-3"
      },
      "name" : "ChargeItemDefinition-50120021000117104-Community-Case-3",
      "description" : "Rules for Fludara Oral 10 mg tablet: film-coated, 20 tablets, blister pack. community Rural PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50120021000117104-Hospital-Case-7"
      },
      "name" : "ChargeItemDefinition-50120021000117104-Hospital-Case-7",
      "description" : "Rules for Fludara Oral 10 mg tablet: film-coated, 20 tablets, blister pack. hospital Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50121491000117102-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50121491000117102-Community-Case-1",
      "description" : "Rules for Estradot 75 microgram/24 hours patch, 8, sachet. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50121491000117102-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50121491000117102-Hospital-Case-5",
      "description" : "Rules for Estradot 75 microgram/24 hours patch, 8, sachet. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50148261000117103-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50148261000117103-Community-Case-1",
      "description" : "Rules for Apo-Azithromycin 250 mg tablet: film-coated, 30 tablets, bottle [Obsolete]. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50148261000117103-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50148261000117103-Hospital-Case-5",
      "description" : "Rules for Apo-Azithromycin 250 mg tablet: film-coated, 30 tablets, bottle [Obsolete]. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50225401000117106-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50225401000117106-Community-Case-1",
      "description" : "Rules for Etoposide (Rex) 100 mg/5 mL injection: concentrated, 1 x 5 mL vial. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50225401000117106-Community-Case-2"
      },
      "name" : "ChargeItemDefinition-50225401000117106-Community-Case-2",
      "description" : "Rules for Etoposide (Rex) 100 mg/5 mL injection: concentrated, 1 x 5 mL vial. community BSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50225401000117106-Community-Case-3"
      },
      "name" : "ChargeItemDefinition-50225401000117106-Community-Case-3",
      "description" : "Rules for Etoposide (Rex) 100 mg/5 mL injection: concentrated, 1 x 5 mL vial. community Rural PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50225401000117106-Hospital-Case-7"
      },
      "name" : "ChargeItemDefinition-50225401000117106-Hospital-Case-7",
      "description" : "Rules for Etoposide (Rex) 100 mg/5 mL injection: concentrated, 1 x 5 mL vial. hospital Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50227471000117107-Community-Case-4"
      },
      "name" : "ChargeItemDefinition-50227471000117107-Community-Case-4",
      "description" : "Rules for Mini-Wright Peak Flow Meter AFS Low Range diagnostic test: peak flow meter, 1 device. community PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50227471000117107-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50227471000117107-Hospital-Case-5",
      "description" : "Rules for Mini-Wright Peak Flow Meter AFS Low Range diagnostic test: peak flow meter, 1 device. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50242281000117106-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50242281000117106-Community-Case-1",
      "description" : "Rules for Agrylin (Shire) 500 microgram capsule: hard, 100 capsules, bottle. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50242281000117106-Community-Case-2"
      },
      "name" : "ChargeItemDefinition-50242281000117106-Community-Case-2",
      "description" : "Rules for Agrylin (Shire) 500 microgram capsule: hard, 100 capsules, bottle. community BSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50242281000117106-Community-Case-3"
      },
      "name" : "ChargeItemDefinition-50242281000117106-Community-Case-3",
      "description" : "Rules for Agrylin (Shire) 500 microgram capsule: hard, 100 capsules, bottle. community Rural PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50242281000117106-Hospital-Case-7"
      },
      "name" : "ChargeItemDefinition-50242281000117106-Hospital-Case-7",
      "description" : "Rules for Agrylin (Shire) 500 microgram capsule: hard, 100 capsules, bottle. hospital Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50248381000117100-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50248381000117100-Community-Case-1",
      "description" : "Rules for Pregabalin Pfizer 75 mg capsule: hard, 56 capsules, blister pack. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50248381000117100-Community-Case-2"
      },
      "name" : "ChargeItemDefinition-50248381000117100-Community-Case-2",
      "description" : "Rules for Pregabalin Pfizer 75 mg capsule: hard, 56 capsules, blister pack. community BSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50248381000117100-Community-Case-3"
      },
      "name" : "ChargeItemDefinition-50248381000117100-Community-Case-3",
      "description" : "Rules for Pregabalin Pfizer 75 mg capsule: hard, 56 capsules, blister pack. community Rural PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50248381000117100-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50248381000117100-Hospital-Case-5",
      "description" : "Rules for Pregabalin Pfizer 75 mg capsule: hard, 56 capsules, blister pack. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50270251000117100-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50270251000117100-Community-Case-1",
      "description" : "Rules for Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50270251000117100-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50270251000117100-Hospital-Case-5",
      "description" : "Rules for Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50277841000117102-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50277841000117102-Community-Case-1",
      "description" : "Rules for MiniMed Sure-T MMT-864A insulin pump infusion set (6 mm x 29 gauge steel needle x 10, 60 cm line x 10), 1 pack, composite pack. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50277841000117102-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50277841000117102-Hospital-Case-5",
      "description" : "Rules for MiniMed Sure-T MMT-864A insulin pump infusion set (6 mm x 29 gauge steel needle x 10, 60 cm line x 10), 1 pack, composite pack. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50283011000117109-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50283011000117109-Community-Case-1",
      "description" : "Rules for Estradiol Transdermal System (Mylan) (Twice weekly) 25 microgram/24 hours patch, 8, sachet. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50283011000117109-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50283011000117109-Hospital-Case-5",
      "description" : "Rules for Estradiol Transdermal System (Mylan) (Twice weekly) 25 microgram/24 hours patch, 8, sachet. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50289761000117107-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50289761000117107-Community-Case-1",
      "description" : "Rules for Heparon Junior (2021 Formulation) oral liquid: powder for, 400 g, can. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50289761000117107-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50289761000117107-Hospital-Case-5",
      "description" : "Rules for Heparon Junior (2021 Formulation) oral liquid: powder for, 400 g, can. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50301271000117101-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50301271000117101-Community-Case-1",
      "description" : "Rules for Oralcon 30 ED tablet: film-coated, 84 tablets [3 x 28 tablets], blister pack. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50301271000117101-Community-Case-2"
      },
      "name" : "ChargeItemDefinition-50301271000117101-Community-Case-2",
      "description" : "Rules for Oralcon 30 ED tablet: film-coated, 84 tablets [3 x 28 tablets], blister pack. community BSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50301271000117101-Community-Case-3"
      },
      "name" : "ChargeItemDefinition-50301271000117101-Community-Case-3",
      "description" : "Rules for Oralcon 30 ED tablet: film-coated, 84 tablets [3 x 28 tablets], blister pack. community Rural PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50301271000117101-Community-Case-4"
      },
      "name" : "ChargeItemDefinition-50301271000117101-Community-Case-4",
      "description" : "Rules for Oralcon 30 ED tablet: film-coated, 84 tablets [3 x 28 tablets], blister pack. community PSO.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50301271000117101-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50301271000117101-Hospital-Case-5",
      "description" : "Rules for Oralcon 30 ED tablet: film-coated, 84 tablets [3 x 28 tablets], blister pack. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50308221000117108-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50308221000117108-Community-Case-1",
      "description" : "Rules for Vegzelma 100 mg/4 mL injection: concentrated, 1 x 4 mL vial. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50320741000117103-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50320741000117103-Community-Case-1",
      "description" : "Rules for Vitamin B6 25 (Evara) 25 mg tablet: uncoated, 90 tablets, bottle. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50320741000117103-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50320741000117103-Hospital-Case-5",
      "description" : "Rules for Vitamin B6 25 (Evara) 25 mg tablet: uncoated, 90 tablets, bottle. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50324571000117108-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50324571000117108-Community-Case-1",
      "description" : "Rules for Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50324571000117108-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50324571000117108-Hospital-Case-5",
      "description" : "Rules for Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50350151000117104-Community-Case-1"
      },
      "name" : "ChargeItemDefinition-50350151000117104-Community-Case-1",
      "description" : "Rules for Teevir tablet: film-coated, 30 tablets, bottle. community Prescription.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-50350151000117104-Hospital-Case-5"
      },
      "name" : "ChargeItemDefinition-50350151000117104-Hospital-Case-5",
      "description" : "Rules for Teevir tablet: film-coated, 30 tablets, bottle. hospital n/a.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-SA1098-Authorization"
      },
      "name" : "ChargeItemDefinition-SA1098-Authorization",
      "description" : "Special Authority SA1098. Detailed eligibility criteria available via authorization form.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-SA1329-Authorization"
      },
      "name" : "ChargeItemDefinition-SA1329-Authorization",
      "description" : "Special Authority SA1329. Detailed eligibility criteria available via authorization form.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-SA1683-Authorization"
      },
      "name" : "ChargeItemDefinition-SA1683-Authorization",
      "description" : "Special Authority SA1683. Detailed eligibility criteria available via authorization form.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-SA2139-Authorization"
      },
      "name" : "ChargeItemDefinition-SA2139-Authorization",
      "description" : "Special Authority SA2139. Detailed eligibility criteria available via authorization form.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-SA2185-Authorization"
      },
      "name" : "ChargeItemDefinition-SA2185-Authorization",
      "description" : "Special Authority SA2185. Detailed eligibility criteria available via authorization form.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-SA2453-Authorization"
      },
      "name" : "ChargeItemDefinition-SA2453-Authorization",
      "description" : "Special Authority SA2453. Detailed eligibility criteria available via authorization form.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-SA2536-Authorization"
      },
      "name" : "ChargeItemDefinition-SA2536-Authorization",
      "description" : "Special Authority SA2536. Detailed eligibility criteria available via authorization form.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-SA2561-Authorization"
      },
      "name" : "ChargeItemDefinition-SA2561-Authorization",
      "description" : "Special Authority SA2561. Detailed eligibility criteria available via authorization form.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-SA2620-Authorization"
      },
      "name" : "ChargeItemDefinition-SA2620-Authorization",
      "description" : "Special Authority SA2620. Detailed eligibility criteria available via authorization form.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ChargeItemDefinition"
      }],
      "reference" : {
        "reference" : "ChargeItemDefinition/ChargeItemDefinition-SA2628-Authorization"
      },
      "name" : "ChargeItemDefinition-SA2628-Authorization",
      "description" : "Special Authority SA2628. Detailed eligibility criteria available via authorization form.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "SearchParameter"
      }],
      "reference" : {
        "reference" : "SearchParameter/ChargeItemDefinitionCodeSearchParam"
      },
      "name" : "ChargeItemDefinitionCodeSearchParam",
      "description" : "Allow ChargeItemDefinition search by code (usually special authority code)",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "SearchParameter"
      }],
      "reference" : {
        "reference" : "SearchParameter/ChargeItemDefinitionDeviceReferenceSearchParam"
      },
      "name" : "ChargeItemDefinitionDeviceReferenceSearchParam",
      "description" : "Reference from ChargeItemDefinition to DeviceDefinition via IG extension. Enables searching for pricing and authorization rules by associated device.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "SearchParameter"
      }],
      "reference" : {
        "reference" : "SearchParameter/ChargeItemDefinitionInstanceSearchParam"
      },
      "name" : "ChargeItemDefinitionInstanceSearchParam",
      "description" : "Allow _revinclude from Medication to ChargeItemDefinition",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "SearchParameter"
      }],
      "reference" : {
        "reference" : "SearchParameter/ChargeItemDefinitionSACodeSearchParam"
      },
      "name" : "ChargeItemDefinitionSACodeSearchParam",
      "description" : "Allow ChargeItemDefinition search by code eg special authority code",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/contract-type"
      },
      "name" : "Contract Type",
      "description" : "Type of PHARMAC contract that applies to this item (for example, sole-supply, preferred).",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/cost-brand-source"
      },
      "name" : "Cost Brand Source",
      "description" : "Indicates whether pricing for this item is sourced from a cost brand.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/dv-limit-percent"
      },
      "name" : "Daily Volume Limit Percent",
      "description" : "Percentage daily volume limit that applies to this item.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/device-definition-reference"
      },
      "name" : "Device Definition Reference",
      "description" : "Reference to a DeviceDefinition that this pricing applies to. Used because ChargeItemDefinition.instance can only reference Device, Medication, or Substance instances, not DeviceDefinition. For Medication, use ChargeItemDefinition.instance directly.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/funding-rule"
      },
      "name" : "Funding Rule",
      "description" : "Funding rules that define medication and device funding conditions, restrictions, and special requirements",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/funding-subsidy-amount"
      },
      "name" : "Funding Subsidy Amount",
      "description" : "Structured subsidy details for funding rule cases, including subsidy type, status, optional amount, and display label.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/in-combination"
      },
      "name" : "In-Combination",
      "description" : "Indicates whether this item is only subsidised when used in combination with other medicines or treatments.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/medication-atc"
      },
      "name" : "Medication ATC",
      "description" : "ATC code and display for the medication.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/medication-description"
      },
      "name" : "Medication Description",
      "description" : "Structured description fields for medication terms.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ValueSet"
      }],
      "reference" : {
        "reference" : "ValueSet/medication-form-codes"
      },
      "name" : "Medication Form Codes",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/medication-legal-class"
      },
      "name" : "Medication Legal Class",
      "description" : "Structured legal class code for a medication.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/medication-legal-classification"
      },
      "name" : "Medication Legal Classification",
      "description" : "Legal classification for a medication.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/medication-nzmt-type"
      },
      "name" : "Medication NZMT Type",
      "description" : "NZMT concept type for the medication code (for example CTPP).",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/medication-pack"
      },
      "name" : "Medication Pack",
      "description" : "Pack details including NZMT medicine code, quantity, and size.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/medication-price"
      },
      "name" : "Medication Price",
      "description" : "Medication-level schedule date and display price information.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50003171000117108"
      },
      "name" : "Medication-50003171000117108",
      "description" : "Medication representation of Remicade 100 mg injection: powder for, 1 x 100 mg vial.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50014861000117106"
      },
      "name" : "Medication-50014861000117106",
      "description" : "Medication representation of Mifegyne 200 mg tablet: uncoated, 3 tablets, blister pack.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50021691000117107"
      },
      "name" : "Medication-50021691000117107",
      "description" : "Medication representation of Seretide Accuhaler 250/50 inhalation: powder for, 60 actuations, blister pack.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50021721000117104"
      },
      "name" : "Medication-50021721000117104",
      "description" : "Medication representation of Rectogesic 0.2% (2 mg/g) ointment, 30 g, tube.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50021991000117100"
      },
      "name" : "Medication-50021991000117100",
      "description" : "Medication representation of Sulphur Precipitated (Midwest) powder, 100 g, jar.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50038111000117102"
      },
      "name" : "Medication-50038111000117102",
      "description" : "Medication representation of EpiPen Auto-Injector 300 microgram/0.3 mL injection: solution, 1 x 0.3 mL prefilled injection device.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50046921000117106"
      },
      "name" : "Medication-50046921000117106",
      "description" : "Medication representation of Deprim oral liquid+E15:Y15: suspension, 100 mL, bottle.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50046931000117109"
      },
      "name" : "Medication-50046931000117109",
      "description" : "Medication representation of Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50048881000117104"
      },
      "name" : "Medication-50048881000117104",
      "description" : "Medication representation of Hydrocortisone (ABM) powder, 25 g, jar.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50055641000117102"
      },
      "name" : "Medication-50055641000117102",
      "description" : "Medication representation of Thio-Tepa 15 mg injection: powder for, 1 x 15 mg vial.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50058961000117103"
      },
      "name" : "Medication-50058961000117103",
      "description" : "Medication representation of Solu-Cortef ACT-O-VIAL 100 mg injection: powder for, 1 x 100 mg dual chamber vial.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50074861000117103"
      },
      "name" : "Medication-50074861000117103",
      "description" : "Medication representation of Laevolac 3.34 g/5 mL oral liquid: solution, 500 mL, bottle.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50083491000117102"
      },
      "name" : "Medication-50083491000117102",
      "description" : "Medication representation of Clexane 80 mg/0.8 mL injection: solution, 10 x 0.8 mL syringes.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50085781000117107"
      },
      "name" : "Medication-50085781000117107",
      "description" : "Medication representation of Fluanxol Depot 40 mg/2 mL injection: modified release, 5 x 2 mL ampoules.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50120021000117104"
      },
      "name" : "Medication-50120021000117104",
      "description" : "Medication representation of Fludara Oral 10 mg tablet: film-coated, 20 tablets, blister pack.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50121491000117102"
      },
      "name" : "Medication-50121491000117102",
      "description" : "Medication representation of Estradot 75 microgram/24 hours patch, 8, sachet.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50148261000117103"
      },
      "name" : "Medication-50148261000117103",
      "description" : "Medication representation of Apo-Azithromycin 250 mg tablet: film-coated, 30 tablets, bottle [Obsolete].",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50225401000117106"
      },
      "name" : "Medication-50225401000117106",
      "description" : "Medication representation of Etoposide (Rex) 100 mg/5 mL injection: concentrated, 1 x 5 mL vial.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50227471000117107"
      },
      "name" : "Medication-50227471000117107",
      "description" : "Medication representation of Mini-Wright Peak Flow Meter AFS Low Range diagnostic test: peak flow meter, 1 device.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50242281000117106"
      },
      "name" : "Medication-50242281000117106",
      "description" : "Medication representation of Agrylin (Shire) 500 microgram capsule: hard, 100 capsules, bottle.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50248381000117100"
      },
      "name" : "Medication-50248381000117100",
      "description" : "Medication representation of Pregabalin Pfizer 75 mg capsule: hard, 56 capsules, blister pack.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50270251000117100"
      },
      "name" : "Medication-50270251000117100",
      "description" : "Medication representation of Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50277841000117102"
      },
      "name" : "Medication-50277841000117102",
      "description" : "Medication representation of MiniMed Sure-T MMT-864A insulin pump infusion set (6 mm x 29 gauge steel needle x 10, 60 cm line x 10), 1 pack, composite pack.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50283011000117109"
      },
      "name" : "Medication-50283011000117109",
      "description" : "Medication representation of Estradiol Transdermal System (Mylan) (Twice weekly) 25 microgram/24 hours patch, 8, sachet.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50289761000117107"
      },
      "name" : "Medication-50289761000117107",
      "description" : "Medication representation of Heparon Junior (2021 Formulation) oral liquid: powder for, 400 g, can.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50301271000117101"
      },
      "name" : "Medication-50301271000117101",
      "description" : "Medication representation of Oralcon 30 ED tablet: film-coated, 84 tablets [3 x 28 tablets], blister pack.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50308221000117108"
      },
      "name" : "Medication-50308221000117108",
      "description" : "Medication representation of Vegzelma 100 mg/4 mL injection: concentrated, 1 x 4 mL vial.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50320741000117103"
      },
      "name" : "Medication-50320741000117103",
      "description" : "Medication representation of Vitamin B6 25 (Evara) 25 mg tablet: uncoated, 90 tablets, bottle.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50324571000117108"
      },
      "name" : "Medication-50324571000117108",
      "description" : "Medication representation of Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Medication"
      }],
      "reference" : {
        "reference" : "Medication/50350151000117104"
      },
      "name" : "Medication-50350151000117104",
      "description" : "Medication representation of Teevir tablet: film-coated, 30 tablets, bottle.",
      "exampleCanonical" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "SearchParameter"
      }],
      "reference" : {
        "reference" : "SearchParameter/MedicationCategorySearchParam"
      },
      "name" : "MedicationCategorySearchParam",
      "description" : "Search for medications by ATC category",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "SearchParameter"
      }],
      "reference" : {
        "reference" : "SearchParameter/MedicationNameSearchParam"
      },
      "name" : "MedicationNameSearchParam",
      "description" : "Search for medications by the text representation of the medication code (e.g., 'Gaviscon Infant', 'Acidex oral liquid'). Enables discovery by the full medication name or formulation description.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:resource"
      }],
      "reference" : {
        "reference" : "StructureDefinition/pharmac-charge-item-definition"
      },
      "name" : "PHARMAC Charge Item Definition",
      "description" : "Profile for ChargeItemDefinition resources representing pricing, subsidy, and rules for devices and medications in the PHARMAC schedule. This profile allows FHIR consumers to use the _include search parameter to retrieve pricing information alongside device or medication resources.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:resource"
      }],
      "reference" : {
        "reference" : "StructureDefinition/pharmac-charge-item-definition-funding-rules"
      },
      "name" : "PHARMAC Charge Item Definition - Funding Rules",
      "description" : "Profile for ChargeItemDefinition resources representing funding mechanisms and reimbursement rules in the PHARMAC schedule. This profile captures funding conditions, provider requirements, endorsement criteria, case sequences, and funding mechanism types (Prescription, BSO, Rural PSO, etc.).",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:resource"
      }],
      "reference" : {
        "reference" : "StructureDefinition/pharmac-charge-item-definition-special-authority"
      },
      "name" : "PHARMAC Charge Item Definition - Special Authority",
      "description" : "Profile for ChargeItemDefinition resources representing Special Authorization (SA) requirements and clinical eligibility criteria in the PHARMAC schedule. This profile captures SA codes, authorization case counts, clinical eligibility, and references to medications requiring special authorization.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/pharmac-is-primary-coding"
      },
      "name" : "Pharmac Is Primary Coding",
      "description" : "Marks the primary pharmac subsidy coding within Medication.code.coding.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:resource"
      }],
      "reference" : {
        "reference" : "StructureDefinition/pharmac-medication"
      },
      "name" : "PHARMAC Medication",
      "description" : "Profile for Medication resources representing pharmaceutical products in the PHARMAC schedule. This profile defines the structure for medications including product names, coding, form, ingredients, and medication-level extensions such as ATC, pack, price, and legal class.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ValueSet"
      }],
      "reference" : {
        "reference" : "ValueSet/pharmac-medication-code"
      },
      "name" : "PHARMAC Medication Code ValueSet",
      "description" : "ValueSet containing medication codes from NZMT CTPP, PackID, and SNOMED CT code systems used for PHARMAC pharmaceutical schedule medications.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "CapabilityStatement"
      }],
      "reference" : {
        "reference" : "CapabilityStatement/PharmacSchedulesCapabilityStatement"
      },
      "name" : "Pharmac Schedules Capability Statement",
      "description" : "Pharmac Schedules Capability Statement. This FHIR resource declares the capabilities of the Pharmac Schedules FHIR API, including supported interactions, resources, and security mechanisms.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/pricing-copayment-max"
      },
      "name" : "Pricing Co-Payment Max",
      "description" : "Indicates whether Co-Payment Max applies to this pricing record.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/pricing-effective-date"
      },
      "name" : "Pricing Effective Date",
      "description" : "The date from which this pricing becomes effective.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/pricing-expiry-date"
      },
      "name" : "Pricing Expiry Date",
      "description" : "The date on which this pricing expires or ceases to be valid.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/pricing-not-combined"
      },
      "name" : "Pricing Not Combined",
      "description" : "Indicates whether Not Combined applies to this pricing record.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/pricing-section-29"
      },
      "name" : "Pricing Section 29",
      "description" : "Indicates whether Section 29 applies to this pricing record.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/schedule-funding-attributes"
      },
      "name" : "Schedule Funding Attributes",
      "description" : "Grouped funding attributes for schedule records, including contract and dispensing flags, co-payment markers, and related indicators.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Bundle"
      }],
      "reference" : {
        "reference" : "Bundle/SearchSet-Bundle-Adrenaline-Note-And-Limit"
      },
      "name" : "SearchSet-Bundle-Adrenaline-Note-And-Limit",
      "description" : "Example search result demonstrating _revinclude to retrieve Adrenaline with separate community and hospital Funding Rules records. The current source demonstrates provider requirements and a PSO limit; it does not contain a note condition.",
      "exampleBoolean" : true
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Bundle"
      }],
      "reference" : {
        "reference" : "Bundle/SearchSet-Bundle-All-Funding-Rules"
      },
      "name" : "SearchSet-Bundle-All-Funding-Rules",
      "description" : "Example search result demonstrating a search for all funding ChargeItemDefinition records. GET [base]/ChargeItemDefinition?_profile=pharmac-charge-item-definition-funding-rules&_count=1000&_total=accurate",
      "exampleBoolean" : true
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Bundle"
      }],
      "reference" : {
        "reference" : "Bundle/SearchSet-Bundle-All-Medications"
      },
      "name" : "SearchSet-Bundle-All-Medications",
      "description" : "Example search result demonstrating a bulk medication search with GET [base]/Medication?_count=1000&_total=accurate",
      "exampleBoolean" : true
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Bundle"
      }],
      "reference" : {
        "reference" : "Bundle/SearchSet-Bundle-All-Special-Authorities"
      },
      "name" : "SearchSet-Bundle-All-Special-Authorities",
      "description" : "Example search result demonstrating a search for all special authorization definitions. GET [base]/ChargeItemDefinition?_profile=pharmac-charge-item-definition-special-authority&_count=1000&_total=accurate",
      "exampleBoolean" : true
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Bundle"
      }],
      "reference" : {
        "reference" : "Bundle/SearchSet-Bundle-Estradiol-Limit"
      },
      "name" : "SearchSet-Bundle-Estradiol-Limit",
      "description" : "Example search result demonstrating _revinclude to retrieve Estradiol Transdermal System with a community limit and provider requirement plus a hospital funding record.",
      "exampleBoolean" : true
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Bundle"
      }],
      "reference" : {
        "reference" : "Bundle/SearchSet-Bundle-Etoposide-Authority-Endorsement"
      },
      "name" : "SearchSet-Bundle-Etoposide-Authority-Endorsement",
      "description" : "Example search result demonstrating _revinclude to retrieve Etoposide with separate Prescription, BSO, Rural PSO, and hospital Funding Rules records. The community pathways demonstrate provider and specialist endorsement conditions. No Special Authority resource applies to Etoposide.",
      "exampleBoolean" : true
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Bundle"
      }],
      "reference" : {
        "reference" : "Bundle/SearchSet-Bundle-Famotidine-Endorsement-And-Note"
      },
      "name" : "SearchSet-Bundle-Famotidine-Endorsement-And-Note",
      "description" : "Example search result demonstrating _revinclude to retrieve Famotidine with an endorsement, provider requirement, and Schedule memoranda note on the community funding pathway.",
      "exampleBoolean" : true
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Bundle"
      }],
      "reference" : {
        "reference" : "Bundle/SearchSet-Bundle-Fluanxol-Multiple-Community-And-Hospital"
      },
      "name" : "SearchSet-Bundle-Fluanxol-Multiple-Community-And-Hospital",
      "description" : "Example search result demonstrating _revinclude to retrieve Fluanxol Depot with separate community and hospital Funding Rules records. The example covers Prescription, BSO, Rural PSO, PSO, provider, and limit patterns.",
      "exampleBoolean" : true
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "Bundle"
      }],
      "reference" : {
        "reference" : "Bundle/SearchSet-Bundle-Nitisinone-Hospital-Restriction"
      },
      "name" : "SearchSet-Bundle-Nitisinone-Hospital-Restriction",
      "description" : "Example search result demonstrating _revinclude to retrieve Nitisinone with a community Special Authority requirement and a separate hospital restriction.",
      "exampleBoolean" : true
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "ValueSet"
      }],
      "reference" : {
        "reference" : "ValueSet/snomed-ct-device-types"
      },
      "name" : "SNOMED CT Device Types",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/statim"
      },
      "name" : "Statim (Urgent Dispensing)",
      "description" : "Indicates whether stat (urgent) dispensing rules apply for this item.",
      "exampleBoolean" : false
    },
    {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/resource-information",
        "valueString" : "StructureDefinition:extension"
      }],
      "reference" : {
        "reference" : "StructureDefinition/wastage-claimable"
      },
      "name" : "Wastage Claimable",
      "description" : "Indicates whether wastage for this item may be claimed.",
      "exampleBoolean" : false
    }],
    "page" : {
      "extension" : [{
        "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-page-name",
        "valueUrl" : "toc.html"
      }],
      "nameUrl" : "toc.html",
      "title" : "Table of Contents",
      "generation" : "html",
      "page" : [{
        "extension" : [{
          "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-page-name",
          "valueUrl" : "index.html"
        }],
        "nameUrl" : "index.html",
        "title" : "Pharmac Medicine & Medical Device Schedule",
        "generation" : "markdown"
      },
      {
        "extension" : [{
          "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-page-name",
          "valueUrl" : "use-cases.html"
        }],
        "nameUrl" : "use-cases.html",
        "title" : "Use Cases",
        "generation" : "markdown"
      },
      {
        "extension" : [{
          "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-page-name",
          "valueUrl" : "fhir-ig-to-xml.html"
        }],
        "nameUrl" : "fhir-ig-to-xml.html",
        "title" : "XML to FHIR Mapping",
        "generation" : "markdown"
      },
      {
        "extension" : [{
          "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-page-name",
          "valueUrl" : "sa-json-schema-guide.html"
        }],
        "nameUrl" : "sa-json-schema-guide.html",
        "title" : "JSON Schema for Special Authorities",
        "generation" : "markdown"
      },
      {
        "extension" : [{
          "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-page-name",
          "valueUrl" : "fr-json-schema-guide.html"
        }],
        "nameUrl" : "fr-json-schema-guide.html",
        "title" : "JSON Schema for Funding Rules",
        "generation" : "markdown"
      },
      {
        "extension" : [{
          "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-page-name",
          "valueUrl" : "examples.html"
        }],
        "nameUrl" : "examples.html",
        "title" : "Examples",
        "generation" : "markdown"
      },
      {
        "extension" : [{
          "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-page-name",
          "valueUrl" : "api.html"
        }],
        "nameUrl" : "api.html",
        "title" : "API",
        "generation" : "markdown"
      },
      {
        "extension" : [{
          "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-page-name",
          "valueUrl" : "relationships.html"
        }],
        "nameUrl" : "relationships.html",
        "title" : "Resource Relationships",
        "generation" : "markdown"
      },
      {
        "extension" : [{
          "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-page-name",
          "valueUrl" : "datamodel.html"
        }],
        "nameUrl" : "datamodel.html",
        "title" : "Data Models",
        "generation" : "markdown"
      },
      {
        "extension" : [{
          "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-page-name",
          "valueUrl" : "terminology.html"
        }],
        "nameUrl" : "terminology.html",
        "title" : "Terminology",
        "generation" : "markdown"
      },
      {
        "extension" : [{
          "url" : "http://hl7.org/fhir/tools/StructureDefinition/ig-page-name",
          "valueUrl" : "version-history.html"
        }],
        "nameUrl" : "version-history.html",
        "title" : "Version History",
        "generation" : "markdown"
      }]
    },
    "parameter" : [{
      "code" : "path-resource",
      "value" : "input/capabilities"
    },
    {
      "code" : "path-resource",
      "value" : "input/examples"
    },
    {
      "code" : "path-resource",
      "value" : "input/extensions"
    },
    {
      "code" : "path-resource",
      "value" : "input/models"
    },
    {
      "code" : "path-resource",
      "value" : "input/operations"
    },
    {
      "code" : "path-resource",
      "value" : "input/profiles"
    },
    {
      "code" : "path-resource",
      "value" : "input/resources"
    },
    {
      "code" : "path-resource",
      "value" : "input/vocabulary"
    },
    {
      "code" : "path-resource",
      "value" : "input/maps"
    },
    {
      "code" : "path-resource",
      "value" : "input/testing"
    },
    {
      "code" : "path-resource",
      "value" : "input/history"
    },
    {
      "code" : "path-resource",
      "value" : "fsh-generated/resources"
    },
    {
      "code" : "path-pages",
      "value" : "template/config"
    },
    {
      "code" : "path-pages",
      "value" : "input/images"
    },
    {
      "code" : "path-tx-cache",
      "value" : "input-cache/txcache"
    }]
  }
}

```
