# JSON Schema for Special Authorities - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* **JSON Schema for Special Authorities**

## JSON Schema for Special Authorities

This page explains how PHARMAC uses JSON Schema to define conditional logic for Special Authority (SA) application forms and funding condition logic — the structure, validation rules, and eligibility criteria that determine who can access subsidised medications.

### What is JSON Schema?

**JSON Schema** is a standard language for describing the structure and validation rules of JSON data. Think of it as a "blueprint" or "contract" that says:

* What fields must be present
* What type each field must be (text, number, true/false)
* What values are acceptable (ranges, allowed values, patterns)
* When certain fields become mandatory based on other values

**Real-world analogy:** If a form is a blank piece of paper, JSON Schema is the filled-in version with all the rules printed next to each question: "This field is required", "Enter a number between 1 and 100", "Choose one of these options".

### How PHARMAC Uses JSON Schema for SAs

PHARMAC embeds a **JSON Schema** directly inside each Special Authority ChargeItemDefinition resource. This schema defines:

1. **Application Form Structure**— What questions are asked
1. **Validation Rules**— What answers are acceptable
1. **Authorization Cases**— The different clinical scenarios an applicant can qualify under
1. **Conditional Logic**— Which fields become required based on other answers

#### Example Flow

```
Doctor fills out an online form for SA2139 (Antiretrovirals)
                    ↓
Form renderer uses the embedded JSON Schema to:
  • Show the right fields for the patient's condition (e.g., "Confirmed HIV" vs "PEP")
  • Validate answers match the rules (e.g., CD4 count > 50)
  • Warn if required information is missing
                    ↓
When submitted, the data is validated against the schema
                    ↓
If valid → Application approved for initial step
If invalid → Error message shows what's missing/wrong

```

#### Schema Structure Overview

This breaks downs the key components of a Special Authority and how they map to the JSON Schema structure.
##### Key Components

* Wrapper - The entire schema is an object that defines the overall structure of the application form.
* Properties - a group of `Subforms`.
* SubForms - An JSON Schema object that defines nested forms Special Authority each has the required fields: 
* `$formType` - can be `initial`, `renewal` or `standard`.
* `$period` - the of time type can be `week`, `month`, or `year`.
* `$validFor` - the duration of the Special Authority in the specified period (e.g., `6` with a `$period` of `month` means 6 months).
* `properties` - the fields/questions that must be answered for that specific subform.
 

##### PHARMAC Custom Schema Extensions

PHARMAC extends the standard JSON Schema vocabulary with custom keywords (prefixed with `$`) to capture metadata specific to Special Authority applications:

| | | | |
| :--- | :--- | :--- | :--- |
| `$formType` | string | Indicates the application type:`initial`,`renewal`, or`standard` | `"$formType": "initial"` |
| `$validFor` | string | Duration the Special Authority remains valid (as a number) | `"$validFor": "12"` |
| `$period` | string | Unit of time for the validity period:`week`,`month`, or`year` | `"$period": "month"` |
| `$note` | string | Explanatory text or special instructions for applicants or specific sections | `"$note": "Note: Indications marked with * are unapproved"` |

**Note:** These are PHARMAC-specific extensions and are NOT part of the standard JSON Schema specification. They are preserved during schema validation and can be used by form renderers and processing systems to provide better user experience.

-------

##### Subforms

Subforms are used to define a set of fields that are used in an approval route for a specific clinical scenario. There are three types of subforms:

* Initial - used for the initial application of a Special Authority.
* Renewal - used for the renewal application of a Special Authority.
* Standard - used for both initial and renewal applications of a Special Authority.

In the example below `SA1683 - Partial` there is a `initial` called `SA1683.1` subform that defines the fields required for the initial application of the Special Authority, and a `renewal` called `SA1683.2` subform that defines the fields required for the renewal application of the Special Authority.

###### Initial Example

In the example below, the `SA1683.1` subform defines the fields required for the initial application of the Special Authority for non-cystic fibrosis bronchiectasis in patients under 18 years old. It includes custom metadata fields to indicate that this is an initial application form, valid for 12 months, and includes a note about unapproved indications.

You can see that the it has custom fields such as `$formType`, `$validFor`, `$period`, and `$note` to provide additional context about the form and its requirements. The `properties` section defines the specific fields that applicants must fill out, along with their types, titles, descriptions, and validation rules.

```
"SA1683.2": {
  "$formType": "initial",
  "$validFor": "12",
  "$period": "month",
  "type": "object",
  "title": "Initial application — non-cystic fibrosis bronchiectasis*",
  "description": "Applications only from a respiratory specialist or paediatrician. Approvals valid for 12 months.",
  "$note": "Note: Indications marked with * are unapproved indications.",
  "properties": {
    "noncysticFibrosisBronchiectasis": {
      "type": "boolean",
      "title": "For prophylaxis of exacerbations of non-cystic fibrosis bronchiectasis*"
    },
    "ageRequirement": {
      "type": "integer",
      "title": "Age (must be under 18 years)",
      "description": "Must be under 18 years old.",
      "minimum": 0,
      "maximum": 18
    },
    "exacerbations12Month": {
      "type": "object",
      "properties": {
        "exacerbations12Month": {
          "type": "boolean",
          "title": "Patient has had 3 or more exacerbations of their bronchiectasis, within a 12 month period"
        },
        "hospitalTreatment": {
          "type": "boolean",
          "title": "Patient has had 3 acute admissions to hospital for treatment of infective respiratory exacerbations within a 12 month period"
        }
      },
      "anyOf": [
        {
          "required": [
            "exacerbations12Month"
          ],
          "properties": {
            "exacerbations12Month": {
              "const": true
            }
          }
        },
        {
          "required": [
            "hospitalTreatment"
          ],
          "properties": {
            "hospitalTreatment": {
              "const": true
            }
          }
        }
      ]
    }
  },
  "required": [
    "noncysticFibrosisBronchiectasis",
    "Under18YearsOld",
    "exacerbations12Month"
  ]
}

```

###### Renewal Example

In the example below, the `SA1683.2` subform defines the fields required for the renewal application of the Special Authority for non-cystic fibrosis bronchiectasis. It includes custom metadata fields to indicate that this is a renewal application form, valid for 12 months, and includes a note about unapproved indications.

You can see that the it has custom fields such as `$formType`, `$validFor`, `$period`, and `$note` to provide additional context about the form and its requirements. The `properties` section defines the specific fields that applicants must fill out, along with their types, titles, descriptions, and validation rules. In this case, the renewal application requires confirmation that the patient has completed 12 months of treatment, has not received further treatment for a certain period, and will not exceed a cumulative treatment limit.

```
"SA1683.2": {
  "$formType": "renewal",
  "$validFor": "12",
  "$period": "month",
  "type": "object",
  "title": "Renewal — non-cystic fibrosis bronchiectasis*",
  "description": "Applications only from a respiratory specialist or paediatrician. Approvals valid for 12 months. The patient must not have had more than 1 prior approval.",
  "$note": "Note: Indications marked with * are unapproved indications.",
  "properties": {
    "completed12Months": {
      "type": "boolean",
      "title": "The patient has completed 12 months of azithromycin treatment for non-cystic fibrosis bronchiectasis"
    },
    "noFurtherTreatment": {
      "type": "boolean",
      "title": "Following initial 12 months of treatment, the patient has not received any further azithromycin treatment for non-cystic fibrosis bronchiectasis for a further 12 months, unless considered clinically inappropriate to stop treatment"
    },
    "maxCumulativeTreatment": {
      "type": "boolean",
      "title": "The patient will not receive more than a total of 24 months’ azithromycin cumulative treatment (see note)"
    }

  },
  "required": [
    "completed12Months",
    "noFurtherTreatment",
    "maxCumulativeTreatment"
  ]
}

```

#### Full Example

Below is the full JSON Schema for SA1683, which includes both the initial and renewal application forms, along with the top-level logic that requires applicants to choose one of the two forms when applying.

```
// ============================================================
// SA1683 - Non-Cystic Fibrosis Bronchiectasis
// ============================================================
// This schema defines the Special Authority application form
// for azithromycin prophylaxis in non-cystic fibrosis bronchiectasis.
// It includes both initial and renewal application pathways.
//
// CUSTOM METADATA FIELDS (non-standard JSON Schema extensions):
// - $formType: "initial" or "renewal" - indicates application type
// - $validFor: duration number - how long the approval is valid (in units below)
// - $period: "month", "week", "year" - unit of time for validity period
// - $note: explanatory text for the form or specific fields
// ============================================================
{
  "$schema": "http://json-schema.org/draft-07/schema#",
  "title": "SA1683 - Partial",
  "description": "",
  "type": "object",
  "properties": {
    // INITIAL APPLICATION FORM
    // For first-time applications. Valid for 12 months if approved.
    // Only respiratory specialists or paediatricians can apply.
    "SA1683.1": {
      "$formType": "initial",
      "$validFor": "12",
      "$period": "month",
      "type": "object",
      "title": "Initial application — non-cystic fibrosis bronchiectasis*",
      "description": "Applications only from a respiratory specialist or paediatrician. Approvals valid for 12 months.",
      "$note": "Note: Indications marked with * are unapproved indications.",
      "properties": {
        "noncysticFibrosisBronchiectasis": {
          "type": "boolean",
          "title": "For prophylaxis of exacerbations of non-cystic fibrosis bronchiectasis*"
        },
        "ageRequirement": {
          "type": "integer",
          "title": "Age (must be under 18 years)",
          "description": "Must be under 18 years old.",
          "minimum": 0,
          "maximum": 18
        },
        "exacerbations12Month": {
          "type": "object",
          "properties": {
            "exacerbations12Month": {
              "type": "boolean",
              "title": "Patient has had 3 or more exacerbations of their bronchiectasis, within a 12 month period"
            },
            "hospitalTreatment": {
              "type": "boolean",
              "title": "Patient has had 3 acute admissions to hospital for treatment of infective respiratory exacerbations within a 12 month period"
            }
          },
          // anyOf: At least ONE criterion must be true
          // Either: 3+ exacerbations within 12 months OR 3+ hospital admissions
          // Patient qualifies if either condition is met (OR logic)
          "anyOf": [
            {
              "required": [
                "exacerbations12Month"
              ],
              "properties": {
                "exacerbations12Month": {
                  "const": true
                }
              }
            },
            {
              "required": [
                "hospitalTreatment"
              ],
              "properties": {
                "hospitalTreatment": {
                  "const": true
                }
              }
            }
          ]
        }
      },
      "required": [
        "noncysticFibrosisBronchiectasis",
        "Under18YearsOld",
        "exacerbations12Month"
      ]
    },
    // RENEWAL APPLICATION FORM
    // For applications after 12 months of initial treatment.
    // Valid for 12 months if approved.
    // Can only renew once (max 24 months total treatment).
    "SA1683.2": {
      "$formType": "renewal",
      "$validFor": "12",
      "$period": "month",
      "type": "object",
      "title": "Renewal — non-cystic fibrosis bronchiectasis*",
      "description": "Applications only from a respiratory specialist or paediatrician. Approvals valid for 12 months. The patient must not have had more than 1 prior approval.",
      "$note": "Note: Indications marked with * are unapproved indications.",
      "properties": {
        "completed12Months": {
          "type": "boolean",
          "title": "The patient has completed 12 months of azithromycin treatment for non-cystic fibrosis bronchiectasis"
        },
        "noFurtherTreatment": {
          "type": "boolean",
          "title": "Following initial 12 months of treatment, the patient has not received any further azithromycin treatment for non-cystic fibrosis bronchiectasis for a further 12 months, unless considered clinically inappropriate to stop treatment"
        },
        "maxCumulativeTreatment": {
          "type": "boolean",
          "title": "The patient will not receive more than a total of 24 months’ azithromycin cumulative treatment (see note)"
        }

      },
      "required": [
        "completed12Months",
        "noFurtherTreatment",
        "maxCumulativeTreatment"
      ]
    }
  },
  // Top-level form selection: User submits either an initial application (SA1683.1)
  // or a renewal application (SA1683.2), but not both
  "anyOf": [
    {
      "$ref": "#/properties/SA1683.1"
    },
    {
      "$ref": "#/properties/SA1683.2"
    }
  ]
}


```

### Common JSON Schema Patterns

#### Pattern 1: Required Text Field

```
"freeText": {
  "type": "object",
  "properties": {
    "clinicalNotes": {
      "type": "string",
      "title": "Clinical notes from the treating doctor"
    }
  },
  "required": ["clinicalNotes"]
}

```

**Meaning:** A text field that MUST be filled in.

-------

#### Pattern 2: Number with Range

```
"age": {
  "type": "object",
  "properties": {
    "patientAge": {
      "type": "number",
      "title": "Patient age in years",
      "minimum": 18,
      "maximum": 120
    }
  },
  "required": ["patientAge"]
}

```

**Meaning:** A number field where the value must be between 18 and 120 (inclusive).

-------

#### Pattern 3: Checkboxes (Multiple Options)

```
"sevenOfNine": {
  "type": "object",
  "properties": {
    "symptom1": { "type": "boolean" },
    "symptom2": { "type": "boolean" },
    "symptom3": { "type": "boolean" },
    "symptom4": { "type": "boolean" },
    "symptom5": { "type": "boolean" },
    "symptom6": { "type": "boolean" },
    "symptom7": { "type": "boolean" },
    "symptom8": { "type": "boolean" },
    "symptom9": { "type": "boolean" }
  },
  "minProperties": 7
}

```

**Meaning:** At least 7 out of 9 checkboxes must be ticked (marked `true`).

-------

#### Pattern 4: All Required (AND Logic)

```
"allRequired": {
  "type": "object",
  "properties": {
    "patientName": { "type": "string" },
    "patientAge": { "type": "number" },
    "diagnosis": { "type": "string" }
  },
  "required": ["patientName", "patientAge", "diagnosis"]
}

```

**Meaning:** ALL three fields (`patientName` AND `patientAge` AND `diagnosis`) must be provided.

-------

#### Pattern 5: At Least One Required (OR Logic)

```
"eitherOne": {
  "type": "object",
  "properties": {
    "phoneNumber": { "type": "string" },
    "emailAddress": { "type": "string" }
  },
  "anyOf": [
    { "required": ["phoneNumber"] },
    { "required": ["emailAddress"] }
  ]
}

```

**Meaning:** Either `phoneNumber` OR `emailAddress` (or both) must be provided.

-------

#### Pattern 6: Conditional Requirements

```
"oneAndEither": {
  "type": "object",
  "properties": {
    "alwaysRequired": { "type": "boolean" },
    "conditionalA": { "type": "string" },
    "conditionalB": { "type": "number" }
  },
  "required": ["alwaysRequired"],
  "anyOf": [
    { "required": ["conditionalA"] },
    { "required": ["conditionalB"] }
  ]
}

```

**Meaning:** `alwaysRequired` is mandatory, AND at least one of (`conditionalA` OR `conditionalB`) must also be provided.

-------

#### Pattern 7: Allowed Values Only (Enum)

```
"prescriber": {
  "type": "object",
  "properties": {
    "type": {
      "type": "string",
      "enum": ["GP", "Specialist", "Hospital"]
    }
  },
  "required": ["type"]
}

```

**Meaning:** The `type` field can ONLY be one of: "GP", "Specialist", or "Hospital". Any other value is invalid.

-------

### Examples

#### SA9999 — Example Template (Multiple Validation Patterns)

A demonstration schema showing **all common JSON Schema validation patterns** in one place:

* **Free text field** — Required string input
* **Numeric field with range** — Values between 0 and 100 (exclusive)
* **Age field with minimum** — Age must be 18+
* **Checkboxes (7 of 9)** — At least 7 must be selected
* **AND condition** — All fields required together
* **OR condition** — At least one field required
* **AND + OR combined** — One mandatory, plus at least one of two others
* **Nested AND + OR** — Complex logic with grouped conditions
* **Duration with time periods** — Validity periods with units (weeks, months, years)
* **Percentage ranges** — Different percentage thresholds with flexible boundaries

Perfect for understanding how to structure validation rules. **[View the full annotated schema with detailed comments](sa9999-schema-example.md)** to see real examples and learn how to adapt these patterns for your own SAs.

-------

### For Developers

#### How to Use the Schema

1. **Fetch the SA resource:**

```
GET /ChargeItemDefinition/ChargeItemDefinition-SA2139-Authorization

```


1. **Extract the encoded schema:**

```
extension[authorizationSchema].valueBase64Binary

```


1. **Decode from Base64:**

```
const encoded = resource.extension.find(e => e.url === '...authorizationSchema').valueBase64Binary;
const decoded = atob(encoded);
const schema = JSON.parse(decoded);

```


1. **Validate user input:**

```
const Ajv = require('ajv');
const ajv = new Ajv();
const validate = ajv.compile(schema);
const isValid = validate(userData);
if (!isValid) console.log(validate.errors);

```


1. **Render dynamic forms:**
* Use the schema's `properties` to build form fields
* Apply type constraints (text input vs number input vs checkbox)
* Show validation errors based on `required` and `anyOf` rules

#### Recommended Libraries

* **AJV** (JavaScript) — Fast JSON Schema validator
* **python-jsonschema** (Python) — Standard JSON Schema validation
* **jsonschema** (Java) — Full-featured validator
* **json-schema-validator** (Go) — Pure Go implementation

-------

### Key Concepts Summary

| | | |
| :--- | :--- | :--- |
| `type: "string"` | Text field | Name, address, notes |
| `type: "number"` | Numeric field | Age, CD4 count, weight |
| `type: "boolean"` | True/False checkbox | Symptom present? |
| `type: "object"` | Group of fields | A section of the form |
| `required` | All listed fields MUST be present | `"required": ["name", "age"]` |
| `anyOf` | At least ONE sub-schema must pass | Either field A or field B |
| `enum` | Only these exact values allowed | `"enum": ["Yes", "No"]` |
| `minimum`/`maximum` | Range limits (inclusive) | Age 18–120 |
| `exclusiveMinimum`/`exclusiveMaximum` | Range limits (exclusive) | > 0, < 100 (not including 0 or 100) |
| `minProperties` | Minimum number of fields present | At least 7 of 9 checkboxes |

-------

### Related Pages

* [SA Examples](examples.md) — Browse SA9999
* [Charge Item Definition - Special Authority Profile](StructureDefinition-pharmac-charge-item-definition-special-authority.md) — Technical profile details
* [JSON Schema Specification](https://json-schema.org/) — Official JSON Schema documentation

