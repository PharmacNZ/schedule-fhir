# Examples - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* **Examples**

## Examples

# Worked Schedule examples

This page uses a small set of worked scenarios to explain how PHARMAC Schedule information is represented across `Medication`, Funding Rules `ChargeItemDefinition`, and Special Authority `ChargeItemDefinition` resources.

The examples are deliberately selective. They demonstrate the main modelling patterns and condition types rather than reproduce every generated example in the Implementation Guide. The complete set remains available from the **Artifacts** page.

## Coverage provided by these scenarios

| | | |
| :--- | :--- | :--- |
| Fluanxol Depot | Prescription, BSO, Rural PSO, PSO, and hospital | Limit and provider |
| Etoposide | Prescription, BSO, Rural PSO, and hospital | Provider and endorsement |
| Famotidine | Prescription and hospital | Provider, endorsement, and note |
| Nitisinone | Prescription and hospital | Authority, restriction, and provider |

Together, the scenarios cover all current funding condition types:

* authority;
* restriction;
* limit;
* provider;
* endorsement; and
* note.

-------

## Scenario 1: One Medication with multiple community and hospital pathways

### Fluanxol Depot 40 mg/2 mL injection

This scenario demonstrates that each distinct funding pathway is represented by a separate Funding Rules `ChargeItemDefinition`.

The product has:

* community Prescription, BSO, Rural PSO, and PSO pathways;
* a provider requirement and quantity limit on the PSO pathway; and
* a separate hospital funding record.

The Medication remains the common product record referenced by each Funding Rules resource through `ChargeItemDefinition.instance`.

### Medication

### Standard community Prescription pathway

### PSO pathway with limit and provider conditions

### Hospital pathway

### Combined retrieval example

-------

## Scenario 2: Specialist endorsement

### Etoposide (Rex) 100 mg/5 mL injection

This scenario demonstrates specialist endorsement requirements across several community funding mechanisms.

The product has:

* community Prescription, BSO, and Rural PSO pathways;
* provider and specialist endorsement conditions on each community pathway; and
* a separate hospital funding record with no additional conditions.

### Medication

### Community Prescription pathway

### Community BSO pathway

### Community Rural PSO pathway

### Combined retrieval example

-------

## Scenario 3: Endorsement and a Schedule note

### Famotidine (Mylan) 40 mg/4 mL injection

This scenario demonstrates a funding pathway where an endorsement condition is accompanied by human-readable Schedule memoranda.

The community case contains:

* an authorised-prescriber requirement;
* subsidy by endorsement; and
* the note that subsidy applies to patients receiving treatment as part of palliative care.

### Medication

### Community endorsement and note pathway

### Combined retrieval example

-------

## Scenario 4: Community Special Authority and hospital restriction

### Nitisinone (Logixx Pharma) 2 mg capsule

This scenario demonstrates how the same Medication can have different conditions in community and hospital settings.

The product has:

* a community Prescription pathway requiring `SA2561`;
* an authorised-provider requirement on the community pathway;
* a separate hospital pathway subject to restriction `RS2164`; and
* a related Special Authority definition represented by a separate `ChargeItemDefinition`.

### Medication

### Community pathway with Special Authority

### Hospital pathway with restriction

### Related Special Authority definition

### Combined retrieval example

-------

## Additional generated examples

These worked scenarios are not the complete example set. The **Artifacts** page provides the full generated collection of:

* Medication resources;
* Funding Rules `ChargeItemDefinition` resources;
* Special Authority `ChargeItemDefinition` resources; and
* search and `_revinclude` Bundles.

