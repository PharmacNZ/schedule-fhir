# Sa 9999 Schema Example - Pharmac Schedules FHIR API v1.0.0

* [**Table of Contents**](toc.md)
* **Sa 9999 Schema Example**

## Sa 9999 Schema Example

## SA9999 — Example Schema

This page displays the complete **SA9999** schema, a demonstration template showing all common JSON Schema validation patterns used in PHARMAC Special Authority applications.

### Schema Overview

SA9999 includes **10 different form examples** demonstrating all common JSON Schema patterns:

| | | | |
| :--- | :--- | :--- | :--- |
| 1 | **freeText** | Required text input | Clinical notes, patient descriptions |
| 2 | **clinicalMeasurement** | Number (exclusive range) | CD4 count, viral load (0 < value < 100) |
| 3 | **age** | Number (inclusive minimum) | Age must be 18+ |
| 4 | **sevenOfNine** | Minimum checkboxes | At least 7 of 9 symptoms must be present |
| 5 | **conditionAnd** | AND logic | Field1 AND Field2 both mandatory |
| 6 | **conditionOr** | OR logic | Field1 OR Field2 (or both) |
| 7 | **conditionAndOr** | AND + OR logic | Field3 required PLUS (Field1 OR Field2) |
| 8 | **conditionAndSubOr** | Nested groups | (Field1 OR Field2) AND (Field3 OR Field4) |
| 9 | **durationExample** | Time periods | SA validity duration with unit (months, years) |
| 10 | **percentageExample** | Percentage ranges | Different percentage thresholds (0-100%, < 20%, etc) |

-------

### Full Schema (JSON with Detailed Comments)

```
// ============================================================
// SA9999 - COMPREHENSIVE SCHEMA EXAMPLES
// ============================================================
//
// PURPOSE:
// This file demonstrates all common JSON Schema validation patterns
// used in PHARMAC Special Authority application forms. Each top-level
// property (freeText, age, conditionOr, etc.) is a complete example
// showing a different validation technique.
//
// HOW THIS WORKS:
// When a doctor submits a Special Authority application, the form data
// is validated against this schema. The top-level "anyOf" at the end
// means the submitted data must match AT LEAST ONE of these form types.
//
// WHAT YOU'LL LEARN:
// - Pattern 1: Simple required text field
// - Pattern 2: Numeric field with exclusive range (> 0 and < 100)
// - Pattern 3: Numeric field with inclusive minimum (≥ 18)
// - Pattern 4: Multiple checkboxes with minimum count (7 of 9)
// - Pattern 5: AND logic (all fields required together)
// - Pattern 6: OR logic (at least one field required)
// - Pattern 7: Combined AND + OR logic
// - Pattern 8: Nested AND + OR conditions
// - Pattern 9: Duration with time period units
// - Pattern 10: Percentage ranges with different constraints
//
// CUSTOM PHARMAC KEYWORDS:
// - $formType: "initial" | "renewal" | "standard" (application type)
// - $validFor: number (how long the approval lasts)
// - $period: "week" | "month" | "year" (unit for validity)
// - $measure: string (unit of measurement for display: percent, units, etc)
// - $note: string (help text shown to applicants)
//
// STANDARD JSON SCHEMA KEYWORDS:
// - type: Data type (string, number, boolean, object)
// - required: Array of field names that MUST be present
// - anyOf: At least ONE sub-schema must validate (OR logic)
// - properties: Object defining available fields
// - enum: Array of allowed values (whitelist)
// - minimum/maximum: Numeric range (INCLUSIVE bounds)
// - exclusiveMinimum/exclusiveMaximum: Numeric range (EXCLUSIVE bounds)
// - minProperties: Minimum number of fields that must have values
//
// ============================================================

{
  "$schema": "http://json-schema.org/draft-07/schema#",
  "title": "SA9999 - Example Schema",
  "type": "object",
  "properties": {

    // ============================================================
    // PATTERN 1: FREE TEXT FIELD (Simple Required String)
    // ============================================================
    // USE CASE: Clinical notes, provider comments, patient descriptions
    // EXAMPLE: "Patient reports difficulty breathing"
    //
    // WHAT THIS VALIDATES:
    // - Field is required (must be present)
    // - Value must be a string (text)
    // - Any text is accepted (no length limits in this example)
    //
    // HOW FORM RENDERING WORKS:
    // UI renders a text input box, marks it as required (*)
    //
    // REAL-WORLD EXAMPLES:
    // - SA2139 (Antiretrovirals): Clinical justification text
    // - SA1859 (Supplements): Reason for nutritional support
    // ============================================================
    "freeText": {
      "type": "object",
      "title": "Free Text Example",
      "description": "This is an example of a required free text field.",
      "$formType": "renewal",
      "$validFor": "12",
      "$period": "month",
      "properties": {
        "field": {
          "title": "Required Text",
          "type": "string",
          "description": "The value of the free text field."
        }
      },
      "required": [
        "field"
      ]
    },


    // ============================================================
    // PATTERN 2: NUMERIC RANGE (EXCLUSIVE bounds: > 0 and < 100)
    // ============================================================
    // USE CASE: Measurements that must fall STRICTLY within a range
    // EXAMPLE: CD4 count must be > 50 (not including 50 itself)
    //
    // WHAT THIS VALIDATES:
    // - Value must be numeric (45.5 is valid, "45" as text is not)
    // - Value must be STRICTLY GREATER than 0 (0 is rejected)
    // - Value must be STRICTLY LESS than 100 (100 is rejected)
    // - Valid range: 0.001 to 99.999...
    //
    // EXCLUSIVE vs INCLUSIVE:
    // - exclusiveMinimum: value > minimum (does NOT include minimum)
    // - exclusiveMaximum: value < maximum (does NOT include maximum)
    // - minimum: value >= minimum (INCLUDES minimum)
    // - maximum: value <= maximum (INCLUDES maximum)
    //
    // REAL-WORLD EXAMPLES:
    // - SA2139: CD4 count range validation (must be between thresholds)
    // - SA2525: PASI score for psoriasis (0 to 72, not exact boundaries)
    // ============================================================
    "clinicalMeasurement": {
      "type": "object",
      "title": "Clinical Measurement Example",
      "description": "This is an example of a required clinical measurement field.",
      "$formType": "standalone",
      "$validFor": "12",
      "$period": "month",
      "properties": {
        "field": {
          "type": "number",
          "title": "Clinical Measurement",
          "description": "The value of the clinical measurement field needs to be greater than zero and less than 100.",
          "$measure": "units",
          // exclusiveMinimum: Must be STRICTLY greater than 0 (0 is not allowed)
          "exclusiveMinimum": 0,
          // exclusiveMaximum: Must be STRICTLY less than 100 (100 is not allowed)
          "exclusiveMaximum": 100
        }
      },
      "required": [
        "field"
      ]
    },


    // ============================================================
    // PATTERN 3: NUMERIC RANGE (INCLUSIVE minimum: ≥ 18)
    // ============================================================
    // USE CASE: Age restrictions where boundary values ARE allowed
    // EXAMPLE: Must be 18 or older (18 is minimum eligible age)
    //
    // WHAT THIS VALIDATES:
    // - Value must be numeric
    // - Value must be >= 18 (18 itself IS allowed)
    // - No maximum limit in this example
    //
    // WHY INCLUSIVE vs EXCLUSIVE:
    // - Age 18: Use minimum (> includes 18)
    // - Age > 18: Use exclusiveMinimum (> excludes 18)
    //
    // REAL-WORLD EXAMPLES:
    // - SA1683: Patient age must be ≤ 18 years (for paediatric forms)
    // - SA1859: Adult forms require age ≥ 18
    // ============================================================
    "age": {
      "type": "object",
      "title": "Age Example",
      "description": "This is an example of a required age field.",
      "$formType": "standalone",
      "$validFor": "12",
      "$period": "month",
      "properties": {
        "field": {
          "type": "number",
          "title": "Age",
          "description": "The value of the age field needs to be at least 18.",
          // minimum: >= 18 (allows exactly 18)
          "minimum": 18
        }
      },
      "required": [
        "field"
      ]
    },


    // ============================================================
    // PATTERN 4: MULTIPLE CHECKBOXES WITH MINIMUM COUNT
    // ============================================================
    // USE CASE: Symptom checklists where at least N symptoms required
    // EXAMPLE: "Check at least 7 of these 9 symptoms"
    //
    // WHAT THIS VALIDATES:
    // - Each field is boolean (true = checked, false = unchecked)
    // - Use minProperties: At least 7 fields must have values
    // - Only include/submit the "true" fields to count towards minimum
    //
    // HOW FORM RENDERING WORKS:
    // UI renders 9 checkboxes, shows error if < 7 are checked
    //
    // REAL-WORLD EXAMPLES:
    // - SA1859: ACR/EULAR criteria for rheumatoid arthritis (7 of 9)
    // - SA2525: DLQI/PASI scoring for dermatology (multiple criteria)
    // ============================================================
    "sevenOfNine": {
      "type": "object",
      "title": "Multi select example",
      "description": "This is an example of a required field that needs at least 7 of the 9 boolean fields to be true.",
      "$formType": "standalone",
      "$validFor": "12",
      "$period": "month",
      "properties": {
        "fieldOne": {
          "type": "boolean",
          "title": "Field One",
          "description": "The value of the field must be true or false."
        },
        "fieldTwo": {
          "type": "boolean",
          "title": "Field Two",
          "description": "The value of the field must be true or false."
        },
        "fieldThree": {
          "type": "boolean",
          "title": "Field Three",
          "description": "The value of the field must be true or false."
        },
        "fieldFour": {
          "type": "boolean",
          "title": "Field Four",
          "description": "The value of the field must be true or false."
        },
        "fieldFive": {
          "type": "boolean",
          "title": "Field Five",
          "description": "The value of the field must be true or false."
        },
        "fieldSix": {
          "type": "boolean",
          "title": "Field Six",
          "description": "The value of the field must be true or false."
        },
        "fieldSeven": {
          "type": "boolean",
          "title": "Field Seven",
          "description": "The value of the field must be true or false."
        },
        "fieldEight": {
          "type": "boolean",
          "title": "Field Eight",
          "description": "The value of the field must be true or false."
        },
        "fieldNine": {
          "type": "boolean",
          "title": "Field Nine",
          "description": "The value of the field must be true or false."
        }
      },
      // minProperties: At least 7 of these fields must be present with values
      "minProperties": 7
    },


    // ============================================================
    // PATTERN 5: AND CONDITION (All fields required together)
    // ============================================================
    // USE CASE: Multiple criteria that all must be true simultaneously
    // EXAMPLE: "Patient confirms HIV AND CD4 < 50 AND on treatment"
    //
    // WHAT THIS VALIDATES:
    // - BOTH fieldOne AND fieldTwo must be present
    // - fieldOne must equal exactly "Yes" (enum constraint)
    // - fieldTwo must be > 10 (numeric constraint)
    // - If either field is missing → validation fails
    //
    // LOGIC: AND
    // Both conditions must be TRUE for form to be valid
    //
    // REAL-WORLD EXAMPLES:
    // - SA2139: Confirmed HIV status AND recent CD4 count
    // - SA1859: Patient age >= 18 AND BMI < 18.5
    // ============================================================
    "conditionAnd": {
      "type": "object",
      "title" : "AndExample",
      "description": "This is an example of a required field that needs to meet multiple conditions.",
      "$formType": "standalone",
      "$validFor": "12",
      "$period": "month",
      "properties": {
        "fieldOne": {
          "type": "string",
          "title": "Field One",
          "description": "The value of the field must be 'Yes'.",
          // enum: Only "Yes" is allowed (whitelist of valid values)
          "enum": [
            "Yes"
          ]
        },
        "fieldTwo": {
          "type": "number",
          "title": "Field Two",
          "description": "The value of the field must be greater than 10.",
          // exclusiveMinimum: Must be > 10 (not including 10)
          "exclusiveMinimum": 10
        }
      },
      // required: BOTH fields must be present for validation to pass
      "required": [
        "fieldOne",
        "fieldTwo"
      ]
    },


    // ============================================================
    // PATTERN 6: OR CONDITION (At least one field required)
    // ============================================================
    // USE CASE: Multiple pathways where any ONE criterion can qualify
    // EXAMPLE: "Either recent CD4 test OR recent viral load test required"
    //
    // WHAT THIS VALIDATES:
    // - fieldOne OR fieldTwo (or both) must be present
    // - At least ONE of the sub-schemas in "anyOf" must validate
    // - If both are missing → validation fails
    // - If both are present and valid → validation passes
    //
    // LOGIC: OR (Logical Disjunction)
    // At least one condition must be TRUE for form to be valid
    //
    // REAL-WORLD EXAMPLES:
    // - SA1683: Patient had 3+ exacerbations OR 3+ hospital admissions
    // - SA2139: Confirmed HIV OR presumed HIV (different evidence paths)
    // ============================================================
    "conditionOr": {
      "type": "object",
      "title": "OrExample",
      "description": "This is an example of a required field that needs to meet at least one of multiple conditions.",
      "$formType": "standalone",
      "$validFor": "12",
      "$period": "month",
      "properties": {
        "fieldOne": {
          "type": "string",
          "title": "Field One",
          "description": "The value of the field must be 'Yes'.",
          "enum": [
            "Yes"
          ]
        },
        "fieldTwo": {
          "type": "number",
          "title": "Field Two",
          "description": "The value of the field must be greater than 10.",
          "exclusiveMinimum": 10
        }
      },
      // anyOf: At least ONE of these sub-schemas must validate (OR logic)
      "anyOf": [
        {
          // Option 1: fieldOne must be present
          "required": [
            "fieldOne"
          ]
        },
        {
          // Option 2: fieldTwo must be present
          "required": [
            "fieldTwo"
          ]
        }
      ]
    },


    // ============================================================
    // PATTERN 7: COMBINED AND + OR (One mandatory + choice of two)
    // ============================================================
    // USE CASE: One mandatory field PLUS at least one of alternatives
    // EXAMPLE: "Always require patient ID AND (either CD4 test OR symptoms)"
    //
    // WHAT THIS VALIDATES:
    // - fieldThree MUST be present (AND condition)
    // - PLUS at least ONE of (fieldOne OR fieldTwo) must be present
    // - Both "required" and "anyOf" must be satisfied simultaneously
    //
    // LOGIC: AND + OR
    // Mandatory field is required, PLUS at least one of the optional fields
    //
    // REAL-WORLD EXAMPLES:
    // - SA2139: Requires patient identifier AND (CD4 count OR viral load)
    // - SA1859: Requires diagnosis AND (BMI < 18.5 OR weight loss > 10%)
    // ============================================================
    "conditionAndOr": {
      "type": "object",
      "title": "And and Or Example",
      "description": "This is an example of a required field that needs to meet a combination of conditions.",
      "$formType": "standalone",
      "$validFor": "12",
      "$period": "month",
      "properties": {
        "fieldOne": {
          "type": "string",
          "title": "Field One",
          "description": "The value of the field must be 'Yes'.",
          "enum": [
            "Yes"
          ]
        },
        "fieldTwo": {
          "type": "number",
          "title": "Field Two",
          "description": "The value of the field must be greater than 10.",
          "exclusiveMinimum": 10
        },
        "fieldThree": {
          "type": "boolean",
          "title": "Field Three",
          "description": "The value of the field must be true."
        }
      },
      // required: fieldThree is unconditionally required (AND)
      "required": [
        "fieldThree"
      ],
      // anyOf: In addition to fieldThree, at least one of fieldOne/fieldTwo (OR)
      "anyOf": [
        {
          "required": [
            "fieldOne"
          ]
        },
        {
          "required": [
            "fieldTwo"
          ]
        }
      ]
    },


    // ============================================================
    // PATTERN 8: NESTED AND + OR (Multiple grouped conditions)
    // ============================================================
    // USE CASE: Complex logic with multiple condition groups
    // EXAMPLE: "(fieldOne OR fieldTwo) AND (fieldThree OR fieldFour)"
    //
    // WHAT THIS VALIDATES:
    // - groupOne must be present AND satisfy its internal anyOf
    //   → At least one of (fieldOne OR fieldTwo) must be present
    // - groupTwo must be present AND satisfy its internal anyOf
    //   → At least one of (fieldThree OR fieldFour) must be present
    // - BOTH groups must be valid (AND at top level)
    //
    // LOGIC: Complex Boolean Expression
    // (Group1a OR Group1b) AND (Group2a OR Group2b)
    //
    // REAL-WORLD EXAMPLES:
    // - SA1859: Complex rheumatology criteria with multiple grouped symptoms
    // - SA2525: Multiple disease categories with OR within each, AND between
    // ============================================================
    "conditionAndSubOr": {
      "type": "object",
      "title": "And and Sub-Or Example",
      "description": "This is an example of a required field that needs to meet a combination of conditions with a nested OR condition.",
      "$formType": "standalone",
      "$validFor": "12",
      "$period": "month",
      "properties": {
        // GROUP ONE: Must satisfy internal OR condition
        "groupOne": {
          "type": "object",
          "description": "This group needs to meet at least one of the conditions.",
          "properties": {
            "fieldOne": {
              "type": "string",
              "title": "Field One",
              "description": "The value of the field must be 'Yes'.",
              "enum": [
                "Yes"
              ]
            },
            "fieldTwo": {
              "type": "number",
              "title": "Field Two",
              "description": "The value of the field must be greater than 10.",
              "exclusiveMinimum": 10
            }
          },
          // Internal OR: At least one field required in this group
          "anyOf": [
            {
              "required": [
                "fieldOne"
              ]
            },
            {
              "required": [
                "fieldTwo"
              ]
            }
          ]
        },
        // GROUP TWO: Must satisfy internal OR condition
        "groupTwo": {
          "type": "object",
          "description": "This group needs to meet at least one of the conditions.",
          "properties": {
            "fieldThree": {
              "type": "boolean",
              "title": "Field Three",
              "description": "The value of the field must be true."
            },
            "fieldFour": {
              "type": "string",
              "title": "Field Four",
              "description": "The value of the field must be 'Yes'.",
              "enum": [
                "Yes"
              ]
            }
          },
          // Internal OR: At least one field required in this group
          "anyOf": [
            {
              "required": [
                "fieldThree"
              ]
            },
            {
              "required": [
                "fieldFour"
              ]
            }
          ]
        }
      },
      // External AND: BOTH groups must be present
      "required": [
        "groupOne",
        "groupTwo"
      ]
    },


    // ============================================================
    // PATTERN 9: DURATION WITH TIME PERIOD UNITS
    // ============================================================
    // USE CASE: Time-based values (validity periods, treatment durations)
    // EXAMPLE: "SA approval valid for 12 months"
    //
    // WHAT THIS VALIDATES:
    // - Value must be numeric
    // - Value must be >= 0 (0 allowed, negative not allowed)
    // - Value must be <= 6
    // - Custom $period keyword indicates units: "months"
    //
    // CUSTOM KEYWORDS:
    // - $period: "weeks" | "months" | "years" (unit indicator)
    // - $validFor: Duration as number (applies at form level)
    //
    // REAL-WORLD EXAMPLES:
    // - SA1683: Valid for 12 months
    // - SA2139 (Renewal): Valid for 12 months
    // - SA9999 (Example): Valid for 6 years
    // ============================================================
    "durationExample": {
      "type": "object",
      "title": "Duration Example",
      "description": "This is an example of a required field that needs to be a duration of time measured in months.",
      "$formType": "initial",
      "$validFor": "12",
      "$period": "month",
      "$note": "Custom field used to display additional notes at the end of a section",
      "properties": {
        "specialAuthorityValidFor": {
          "type": "number",
          "title": "Special Authority Validity Period",
          "description": "Duration in months. Must be at least 0 and at most 6 months.",
          // $period: Indicates the unit of time for this duration field
          "$period": "months",
          // minimum: >= 0 (allows zero-length periods)
          "minimum": 0,
          // maximum: <= 6 months
          "maximum": 6
        }
      },
      "required": [
        "specialAuthorityValidFor"
      ]
    },


    // ============================================================
    // PATTERN 10: PERCENTAGE RANGES WITH DIFFERENT CONSTRAINTS
    // ============================================================
    // USE CASE: Percentage-based thresholds with flexible boundaries
    // EXAMPLE: "PASI improvement >= 75% OR DLQI improvement < 5%"
    //
    // WHAT THIS VALIDATES:
    // - anyPercentage: 0 to 100 inclusive (full range)
    // - lowPercentage: 0 to < 20 exclusive (not including 20)
    // - At least ONE of these fields must be present (OR logic)
    //
    // PERCENTAGE BOUNDARIES:
    // - 0-100 inclusive: minimum: 0, maximum: 100
    // - > 0 to < 100 exclusive: exclusiveMinimum: 0, exclusiveMaximum: 100
    // - >= 75% to <= 100%: minimum: 75, maximum: 100
    // - < 20%: exclusiveMaximum: 20
    //
    // REAL-WORLD EXAMPLES:
    // - SA2525: PASI/DLQI improvement thresholds (50%, 75%, 90%)
    // - SA1859: Weight loss percentage (>10% vs specific thresholds)
    // ============================================================
    "percentageExample": {
      "type": "object",
      "description": "This is an example of required fields with percentage values.",
      "$formType": "initial",
      "$validFor": "6",
      "$period": "years",
      "$note": "Percentage fields can have different range constraints",
      "properties": {
        "anyPercentage": {
          "type": "number",
          "title": "Percentage",
          "description": "A percentage value. Must be between 0 and 100 percent (inclusive).",
          // $measure: Indicates unit of measurement for display
          "$measure": "percent",
          // minimum: >= 0 (includes 0)
          "minimum": 0,
          // maximum: <= 100 (includes 100)
          "maximum": 100
        },
        "lowPercentage": {
          "type": "number",
          "title": "Percentage (Less Than 20%)",
          "description": "A percentage value. Must be greater than or equal to 0 and strictly less than 20 percent.",
          "$measure": "percent",
          // minimum: >= 0 (includes 0)
          "minimum": 0,
          // exclusiveMaximum: < 20 (20 is NOT allowed)
          "exclusiveMaximum": 20
        }
      },
      // anyOf: At least one percentage field must be present
      "anyOf": [
        {
          "required": [
            "anyPercentage"
          ]
        },
        {
          "required": [
            "lowPercentage"
          ]
        }
      ]
    }
  },

  // ============================================================
  // TOP-LEVEL FORM SELECTION (anyOf)
  // ============================================================
  // PURPOSE: Allow submission of any ONE of the example forms above
  //
  // WHAT THIS MEANS:
  // When a doctor submits data to this schema, it must match at least
  // ONE of these form types. For example:
  // - Submitting just freeText data → Valid
  // - Submitting just age data → Valid
  // - Submitting conditionOr data → Valid
  // - Submitting mix of age + conditionOr → Usually invalid
  //
  // REAL-WORLD USE:
  // In PHARMAC Special Authorities, each SA can have multiple
  // application types (initial, renewal, standard). Submitted data
  // must match one of the defined types.
  //
  // REFERENCES ($ref):
  // "#/properties/freeText" points to the "freeText" form defined above
  // This creates reusable schema components
  // ============================================================
  "anyOf": [
    {
      "$ref": "#/properties/freeText"
    },
    {
      "$ref": "#/properties/clinicalMeasurement"
    },
    {
      "$ref": "#/properties/age"
    },
    {
      "$ref": "#/properties/sevenOfNine"
    },
    {
      "$ref": "#/properties/conditionAnd"
    },
    {
      "$ref": "#/properties/conditionOr"
    },
    {
      "$ref": "#/properties/conditionAndOr"
    },
    {
      "$ref": "#/properties/conditionAndSubOr"
    },
    {
      "$ref": "#/properties/durationExample"
    },
    {
      "$ref": "#/properties/percentageExample"
    }
  ]
}

```

-------

### How to Use This Schema

1. **Copy this schema**for your own SA definitions
1. **Modify the properties**to match your specific form fields
1. **Adjust validation rules**(ranges, required fields, conditional logic)
1. **Base64-encode it**and embed in the`authorizationSchema`extension
1. **Validate test data**using an AJV validator or similar

### Validation Examples

#### Example 1: Valid freeText submission

```
{
  "freeText": {
    "field": "Patient presents with severe symptoms"
  }
}

```

✅ **Valid** — `field` is present and is a string

#### Example 2: Invalid freeText submission

```
{
  "freeText": {}
}

```

❌ **Invalid** — `field` is required but missing

#### Example 3: Valid sevenOfNine submission

```
{
  "sevenOfNine": {
    "fieldOne": true,
    "fieldTwo": true,
    "fieldThree": true,
    "fieldFour": true,
    "fieldFive": true,
    "fieldSix": true,
    "fieldSeven": true
  }
}

```

✅ **Valid** — 7 fields present (meets `minProperties: 7`)

#### Example 4: Invalid sevenOfNine submission

```
{
  "sevenOfNine": {
    "fieldOne": true,
    "fieldTwo": true,
    "fieldThree": true,
    "fieldFour": true,
    "fieldFive": true,
    "fieldSix": true
  }
}

```

❌ **Invalid** — Only 6 fields present (needs at least 7)

#### Example 5: Valid conditionOr submission

```
{
  "conditionOr": {
    "fieldOne": "Yes"
  }
}

```

✅ **Valid** — `fieldOne` is present (satisfies `anyOf`)

#### Example 6: Invalid conditionOr submission

```
{
  "conditionOr": {
    "fieldThree": true
  }
}

```

❌ **Invalid** — Neither `fieldOne` nor `fieldTwo` is present

#### Example 7: Valid durationExample submission

```
{
  "durationExample": {
    "specialAuthorityValidFor": 6
  }
}

```

✅ **Valid** — Duration is 6 months (within 0 to 6 months inclusive)

#### Example 8: Invalid durationExample submission

```
{
  "durationExample": {
    "specialAuthorityValidFor": 12
  }
}

```

❌ **Invalid** — Duration exceeds maximum of 6 months

#### Example 9: Valid percentageExample submission (full range)

```
{
  "percentageExample": {
    "anyPercentage": 75
  }
}

```

✅ **Valid** — 75% is within 0-100 inclusive range

#### Example 10: Valid percentageExample submission (threshold)

```
{
  "percentageExample": {
    "lowPercentage": 15
  }
}

```

✅ **Valid** — 15% is >= 0 and < 20 (meets exclusiveMaximum: 20)

#### Example 11: Invalid percentageExample submission

```
{
  "percentageExample": {
    "lowPercentage": 20
  }
}

```

❌ **Invalid** — 20% is NOT strictly less than 20 (exclusiveMaximum rejects it)

-------

## Pattern Explanations

### Pattern 9: Duration with Time Period Units

Used for time-based values like Special Authority validity periods or treatment durations.

**Key Keywords:**

* `$validFor`: Duration number (how long the approval lasts)
* `$period`: Unit of time — "week", "month", or "year"
* `minimum`/`maximum`: Numeric range for the duration value

**Real-World Example:**

```
"$formType": "initial",
"$validFor": "12",
"$period": "month"
// This form is valid for 12 months when approved

```

**Use in PHARMAC:**

* SA1683: Initial approval valid for 12 months
* SA2139 (Renewal): Renewal approval valid for 12 months
* Custom durations for different SAs

-------

### Pattern 10: Percentage Ranges with Different Constraints

Used for percentage-based eligibility criteria with flexible boundary conditions (inclusive vs exclusive).

**Key Patterns:**

* **Full range (0-100%):** `minimum: 0, maximum: 100` (both inclusive)
* **Threshold exclusion (<20%):** `minimum: 0, exclusiveMaximum: 20`
* **High improvement (≥75%):** `minimum: 75, maximum: 100`

**Real-World Examples:**

* SA2525 (Adalimumab): PASI improvement >= 75% OR DLQI improvement < 5%
* SA1859 (Supplements): Weight loss > 10% requirement
* Various disease-specific improvement thresholds (50%, 75%, 90%)

**Custom Keyword:**

* `$measure: "percent"` — Indicates this is a percentage for form rendering

-------

### Related Documentation

* [JSON Schema for SAs Guide](sa-json-schema-guide.md) — Detailed explanation of patterns and concepts
* [SA9999 Resource](ChargeItemDefinition-ChargeItemDefinition-SA9999-Authorization.md) — FHIR resource containing this schema
* [JSON Schema Draft-07 Spec](https://json-schema.org/draft-07/json-schema-core.html) — Official specification

