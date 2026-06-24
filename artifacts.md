# Artifacts Summary - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* **Artifacts Summary**

## Artifacts Summary

This page provides a list of the FHIR artifacts defined as part of this implementation guide.

### Behavior: Capability Statements 

The following artifacts define the specific capabilities that different types of systems are expected to have in order to comply with this implementation guide. Systems conforming to this implementation guide are expected to declare conformance to one or more of the following capability statements.

| | |
| :--- | :--- |
| [Pharmac Schedules Capability Statement](CapabilityStatement-PharmacSchedulesCapabilityStatement.md) | Pharmac Schedules Capability Statement. This FHIR resource declares the capabilities of the Pharmac Schedules FHIR API, including supported interactions, resources, and security mechanisms. |

### Behavior: Search Parameters 

These define the properties by which a RESTful server can be searched. They can also be used for sorting and including related resources.

| | |
| :--- | :--- |
| [ChargeItemDefinitionCodeSearchParam](SearchParameter-ChargeItemDefinitionCodeSearchParam.md) | Allow ChargeItemDefinition search by code (usually special authority code) |
| [ChargeItemDefinitionDeviceReferenceSearchParam](SearchParameter-ChargeItemDefinitionDeviceReferenceSearchParam.md) | Reference from ChargeItemDefinition to DeviceDefinition via IG extension. Enables searching for pricing and authorization rules by associated device. |
| [ChargeItemDefinitionInstanceSearchParam](SearchParameter-ChargeItemDefinitionInstanceSearchParam.md) | Allow _revinclude from Medication to ChargeItemDefinition |
| [ChargeItemDefinitionSACodeSearchParam](SearchParameter-ChargeItemDefinitionSACodeSearchParam.md) | Allow ChargeItemDefinition search by code eg special authority code |
| [MedicationCategorySearchParam](SearchParameter-MedicationCategorySearchParam.md) | Search for medications by ATC category |
| [MedicationNameSearchParam](SearchParameter-MedicationNameSearchParam.md) | Search for medications by the text representation of the medication code (e.g., 'Gaviscon Infant', 'Acidex oral liquid'). Enables discovery by the full medication name or formulation description. |

### Structures: Resource Profiles 

These define constraints on FHIR resources for systems conforming to this implementation guide.

| | |
| :--- | :--- |
| [PHARMAC Charge Item Definition](StructureDefinition-pharmac-charge-item-definition.md) | Profile for ChargeItemDefinition resources representing pricing, subsidy, and rules for devices and medications in the PHARMAC schedule. This profile allows FHIR consumers to use the _include search parameter to retrieve pricing information alongside device or medication resources. |
| [PHARMAC Charge Item Definition - Funding Rules](StructureDefinition-pharmac-charge-item-definition-funding-rules.md) | Profile for ChargeItemDefinition resources representing funding mechanisms and reimbursement rules in the PHARMAC schedule. This profile captures funding conditions, provider requirements, endorsement criteria, case sequences, and funding mechanism types (Prescription, BSO, Rural PSO, etc.). |
| [PHARMAC Charge Item Definition - Special Authority](StructureDefinition-pharmac-charge-item-definition-special-authority.md) | Profile for ChargeItemDefinition resources representing Special Authorization (SA) requirements and clinical eligibility criteria in the PHARMAC schedule. This profile captures SA codes, authorization case counts, clinical eligibility, and references to medications requiring special authorization. |
| [PHARMAC Medication](StructureDefinition-pharmac-medication.md) | Profile for Medication resources representing pharmaceutical products in the PHARMAC schedule. This profile defines the structure for medications including product names, coding, form, ingredients, and medication-level extensions such as ATC, pack, price, and legal class. |

### Structures: Extension Definitions 

These define constraints on FHIR data types for systems conforming to this implementation guide.

| | |
| :--- | :--- |
| [Authorization Case Count](StructureDefinition-authorization-case-count.md) | The number of authorization cases or approval criteria specified in the authorization requirement. This indicates how many different clinical scenarios or conditions have distinct approval pathways. |
| [Authorization Form](StructureDefinition-authorization-form.md) | The special authorization form code required for this medication (e.g., 'SA2535'). This identifies the specific PHARMAC authorization form that prescribers must complete for patient eligibility. |
| [Authorization Schema](StructureDefinition-authorization-schema.md) | Base64-encoded JSON Schema that defines the structure and validation rules for a Special Authorization application form. The decoded content is a JSON Schema (application/schema+json). |
| [Authorization Title](StructureDefinition-authorization-title.md) | A human-readable title for the authorization requirement (e.g., 'Budesonide - Special Authorization Required'). This provides context for the authorization need. |
| [Brand Switch Fee](StructureDefinition-brand-switch-fee.md) | Indicates whether a brand switch fee applies for this item. |
| [Contract Type](StructureDefinition-contract-type.md) | Type of PHARMAC contract that applies to this item (for example, sole-supply, preferred). |
| [Cost Brand Source](StructureDefinition-cost-brand-source.md) | Indicates whether pricing for this item is sourced from a cost brand. |
| [Daily Volume Limit Percent](StructureDefinition-dv-limit-percent.md) | Percentage daily volume limit that applies to this item. |
| [Device Definition Reference](StructureDefinition-device-definition-reference.md) | Reference to a DeviceDefinition that this pricing applies to. Used because ChargeItemDefinition.instance can only reference Device, Medication, or Substance instances, not DeviceDefinition. For Medication, use ChargeItemDefinition.instance directly. |
| [Funding Rule](StructureDefinition-funding-rule.md) | Funding rules that define medication and device funding conditions, restrictions, and special requirements |
| [Funding Subsidy Amount](StructureDefinition-funding-subsidy-amount.md) | Structured subsidy details for funding rule cases, including subsidy type, status, optional amount, and display label. |
| [In-Combination](StructureDefinition-in-combination.md) | Indicates whether this item is only subsidised when used in combination with other medicines or treatments. |
| [Medication ATC](StructureDefinition-medication-atc.md) | ATC code and display for the medication. |
| [Medication Description](StructureDefinition-medication-description.md) | Structured description fields for medication terms. |
| [Medication Legal Class](StructureDefinition-medication-legal-class.md) | Structured legal class code for a medication. |
| [Medication Legal Classification](StructureDefinition-medication-legal-classification.md) | Legal classification for a medication. |
| [Medication NZMT Type](StructureDefinition-medication-nzmt-type.md) | NZMT concept type for the medication code (for example CTPP). |
| [Medication Pack](StructureDefinition-medication-pack.md) | Pack details including NZMT medicine code, quantity, and size. |
| [Medication Price](StructureDefinition-medication-price.md) | Medication-level schedule date and display price information. |
| [Pharmac Is Primary Coding](StructureDefinition-pharmac-is-primary-coding.md) | Marks the primary pharmac subsidy coding within Medication.code.coding. |
| [Pricing Co-Payment Max](StructureDefinition-pricing-copayment-max.md) | Indicates whether Co-Payment Max applies to this pricing record. |
| [Pricing Effective Date](StructureDefinition-pricing-effective-date.md) | The date from which this pricing becomes effective. |
| [Pricing Expiry Date](StructureDefinition-pricing-expiry-date.md) | The date on which this pricing expires or ceases to be valid. |
| [Pricing Not Combined](StructureDefinition-pricing-not-combined.md) | Indicates whether Not Combined applies to this pricing record. |
| [Pricing Section 29](StructureDefinition-pricing-section-29.md) | Indicates whether Section 29 applies to this pricing record. |
| [Schedule Funding Attributes](StructureDefinition-schedule-funding-attributes.md) | Grouped funding attributes for schedule records, including contract and dispensing flags, co-payment markers, and related indicators. |
| [Statim (Urgent Dispensing)](StructureDefinition-statim.md) | Indicates whether stat (urgent) dispensing rules apply for this item. |
| [Wastage Claimable](StructureDefinition-wastage-claimable.md) | Indicates whether wastage for this item may be claimed. |

### Terminology: Value Sets 

These define sets of codes used by systems conforming to this implementation guide.

| | |
| :--- | :--- |
| [Medication Form Codes](ValueSet-medication-form-codes.md) |  |
| [PHARMAC Medication Code ValueSet](ValueSet-pharmac-medication-code.md) | ValueSet containing medication codes from NZMT CTPP, PackID, and SNOMED CT code systems used for PHARMAC pharmaceutical schedule medications. |
| [SNOMED CT Device Types](ValueSet-snomed-ct-device-types.md) |  |

### Example: Example Instances 

These are example instances that show what data produced and consumed by systems conforming with this implementation guide might look like.

| | |
| :--- | :--- |
| [APIError-Unauthorised](OperationOutcome-APIError-Unauthorised.md) | An example of an OperationOutcome resource representing an unauthorised access error. |
| [ChargeItemDefinition-50003171000117108-Hospital-Case-7](ChargeItemDefinition-ChargeItemDefinition-50003171000117108-Hospital-Case-7.md) | Rules for Remicade 100 mg injection: powder for, 1 x 100 mg vial. hospital Prescription. |
| [ChargeItemDefinition-50014861000117106-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Community-Case-1.md) | Rules for Mifegyne 200 mg tablet: uncoated, 3 tablets, blister pack. community Prescription. |
| [ChargeItemDefinition-50014861000117106-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Community-Case-2.md) | Rules for Mifegyne 200 mg tablet: uncoated, 3 tablets, blister pack. community BSO. |
| [ChargeItemDefinition-50014861000117106-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Community-Case-3.md) | Rules for Mifegyne 200 mg tablet: uncoated, 3 tablets, blister pack. community Rural PSO. |
| [ChargeItemDefinition-50014861000117106-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Community-Case-4.md) | Rules for Mifegyne 200 mg tablet: uncoated, 3 tablets, blister pack. community PSO. |
| [ChargeItemDefinition-50014861000117106-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50014861000117106-Hospital-Case-5.md) | Rules for Mifegyne 200 mg tablet: uncoated, 3 tablets, blister pack. hospital n/a. |
| [ChargeItemDefinition-50021691000117107-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50021691000117107-Community-Case-1.md) | Rules for Seretide Accuhaler 250/50 inhalation: powder for, 60 actuations, blister pack. community Prescription. |
| [ChargeItemDefinition-50021691000117107-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50021691000117107-Community-Case-2.md) | Rules for Seretide Accuhaler 250/50 inhalation: powder for, 60 actuations, blister pack. community BSO. |
| [ChargeItemDefinition-50021691000117107-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50021691000117107-Community-Case-3.md) | Rules for Seretide Accuhaler 250/50 inhalation: powder for, 60 actuations, blister pack. community Rural PSO. |
| [ChargeItemDefinition-50021691000117107-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50021691000117107-Hospital-Case-5.md) | Rules for Seretide Accuhaler 250/50 inhalation: powder for, 60 actuations, blister pack. hospital n/a. |
| [ChargeItemDefinition-50021721000117104-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50021721000117104-Community-Case-1.md) | Rules for Rectogesic 0.2% (2 mg/g) ointment, 30 g, tube. community Prescription. |
| [ChargeItemDefinition-50021721000117104-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50021721000117104-Hospital-Case-5.md) | Rules for Rectogesic 0.2% (2 mg/g) ointment, 30 g, tube. hospital n/a. |
| [ChargeItemDefinition-50021991000117100-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50021991000117100-Community-Case-1.md) | Rules for Sulphur Precipitated (Midwest) powder, 100 g, jar. community Prescription. |
| [ChargeItemDefinition-50021991000117100-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50021991000117100-Community-Case-2.md) | Rules for Sulphur Precipitated (Midwest) powder, 100 g, jar. community BSO. |
| [ChargeItemDefinition-50021991000117100-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50021991000117100-Community-Case-3.md) | Rules for Sulphur Precipitated (Midwest) powder, 100 g, jar. community Rural PSO. |
| [ChargeItemDefinition-50021991000117100-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50021991000117100-Hospital-Case-5.md) | Rules for Sulphur Precipitated (Midwest) powder, 100 g, jar. hospital n/a. |
| [ChargeItemDefinition-50038111000117102-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50038111000117102-Community-Case-1.md) | Rules for EpiPen Auto-Injector 300 microgram/0.3 mL injection: solution, 1 x 0.3 mL prefilled injection device. community Prescription. |
| [ChargeItemDefinition-50038111000117102-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50038111000117102-Hospital-Case-5.md) | Rules for EpiPen Auto-Injector 300 microgram/0.3 mL injection: solution, 1 x 0.3 mL prefilled injection device. hospital n/a. |
| [ChargeItemDefinition-50046921000117106-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Community-Case-1.md) | Rules for Deprim oral liquid+E15:Y15: suspension, 100 mL, bottle. community Prescription. |
| [ChargeItemDefinition-50046921000117106-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Community-Case-2.md) | Rules for Deprim oral liquid+E15:Y15: suspension, 100 mL, bottle. community BSO. |
| [ChargeItemDefinition-50046921000117106-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Community-Case-3.md) | Rules for Deprim oral liquid+E15:Y15: suspension, 100 mL, bottle. community Rural PSO. |
| [ChargeItemDefinition-50046921000117106-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Community-Case-4.md) | Rules for Deprim oral liquid+E15:Y15: suspension, 100 mL, bottle. community PSO. |
| [ChargeItemDefinition-50046921000117106-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50046921000117106-Hospital-Case-5.md) | Rules for Deprim oral liquid+E15:Y15: suspension, 100 mL, bottle. hospital n/a. |
| [ChargeItemDefinition-50046931000117109-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Community-Case-1.md) | Rules for Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules. community Prescription. |
| [ChargeItemDefinition-50046931000117109-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Community-Case-2.md) | Rules for Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules. community BSO. |
| [ChargeItemDefinition-50046931000117109-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Community-Case-3.md) | Rules for Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules. community Rural PSO. |
| [ChargeItemDefinition-50046931000117109-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Community-Case-4.md) | Rules for Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules. community PSO. |
| [ChargeItemDefinition-50046931000117109-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50046931000117109-Hospital-Case-5.md) | Rules for Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules. hospital n/a. |
| [ChargeItemDefinition-50048881000117104-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50048881000117104-Community-Case-1.md) | Rules for Hydrocortisone (ABM) powder, 25 g, jar. community Prescription. |
| [ChargeItemDefinition-50048881000117104-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50048881000117104-Community-Case-2.md) | Rules for Hydrocortisone (ABM) powder, 25 g, jar. community BSO. |
| [ChargeItemDefinition-50048881000117104-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50048881000117104-Community-Case-3.md) | Rules for Hydrocortisone (ABM) powder, 25 g, jar. community Rural PSO. |
| [ChargeItemDefinition-50048881000117104-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50048881000117104-Hospital-Case-5.md) | Rules for Hydrocortisone (ABM) powder, 25 g, jar. hospital n/a. |
| [ChargeItemDefinition-50055641000117102-Hospital-Case-7](ChargeItemDefinition-ChargeItemDefinition-50055641000117102-Hospital-Case-7.md) | Rules for Thio-Tepa 15 mg injection: powder for, 1 x 15 mg vial. hospital Prescription. |
| [ChargeItemDefinition-50058961000117103-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50058961000117103-Community-Case-1.md) | Rules for Solu-Cortef ACT-O-VIAL 100 mg injection: powder for, 1 x 100 mg dual chamber vial. community Prescription. |
| [ChargeItemDefinition-50058961000117103-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50058961000117103-Community-Case-3.md) | Rules for Solu-Cortef ACT-O-VIAL 100 mg injection: powder for, 1 x 100 mg dual chamber vial. community Rural PSO. |
| [ChargeItemDefinition-50058961000117103-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50058961000117103-Community-Case-4.md) | Rules for Solu-Cortef ACT-O-VIAL 100 mg injection: powder for, 1 x 100 mg dual chamber vial. community PSO. |
| [ChargeItemDefinition-50058961000117103-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50058961000117103-Hospital-Case-5.md) | Rules for Solu-Cortef ACT-O-VIAL 100 mg injection: powder for, 1 x 100 mg dual chamber vial. hospital n/a. |
| [ChargeItemDefinition-50074861000117103-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50074861000117103-Community-Case-1.md) | Rules for Laevolac 3.34 g/5 mL oral liquid: solution, 500 mL, bottle. community Prescription. |
| [ChargeItemDefinition-50074861000117103-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50074861000117103-Hospital-Case-5.md) | Rules for Laevolac 3.34 g/5 mL oral liquid: solution, 500 mL, bottle. hospital n/a. |
| [ChargeItemDefinition-50083491000117102-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50083491000117102-Community-Case-1.md) | Rules for Clexane 80 mg/0.8 mL injection: solution, 10 x 0.8 mL syringes. community Prescription. |
| [ChargeItemDefinition-50083491000117102-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50083491000117102-Hospital-Case-5.md) | Rules for Clexane 80 mg/0.8 mL injection: solution, 10 x 0.8 mL syringes. hospital n/a. |
| [ChargeItemDefinition-50085781000117107-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50085781000117107-Community-Case-1.md) | Rules for Fluanxol Depot 40 mg/2 mL injection: modified release, 5 x 2 mL ampoules. community Prescription. |
| [ChargeItemDefinition-50085781000117107-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50085781000117107-Community-Case-2.md) | Rules for Fluanxol Depot 40 mg/2 mL injection: modified release, 5 x 2 mL ampoules. community BSO. |
| [ChargeItemDefinition-50085781000117107-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50085781000117107-Community-Case-3.md) | Rules for Fluanxol Depot 40 mg/2 mL injection: modified release, 5 x 2 mL ampoules. community Rural PSO. |
| [ChargeItemDefinition-50085781000117107-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50085781000117107-Community-Case-4.md) | Rules for Fluanxol Depot 40 mg/2 mL injection: modified release, 5 x 2 mL ampoules. community PSO. |
| [ChargeItemDefinition-50085781000117107-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50085781000117107-Hospital-Case-5.md) | Rules for Fluanxol Depot 40 mg/2 mL injection: modified release, 5 x 2 mL ampoules. hospital n/a. |
| [ChargeItemDefinition-50120021000117104-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50120021000117104-Community-Case-1.md) | Rules for Fludara Oral 10 mg tablet: film-coated, 20 tablets, blister pack. community Prescription. |
| [ChargeItemDefinition-50120021000117104-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50120021000117104-Community-Case-2.md) | Rules for Fludara Oral 10 mg tablet: film-coated, 20 tablets, blister pack. community BSO. |
| [ChargeItemDefinition-50120021000117104-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50120021000117104-Community-Case-3.md) | Rules for Fludara Oral 10 mg tablet: film-coated, 20 tablets, blister pack. community Rural PSO. |
| [ChargeItemDefinition-50120021000117104-Hospital-Case-7](ChargeItemDefinition-ChargeItemDefinition-50120021000117104-Hospital-Case-7.md) | Rules for Fludara Oral 10 mg tablet: film-coated, 20 tablets, blister pack. hospital Prescription. |
| [ChargeItemDefinition-50121491000117102-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50121491000117102-Community-Case-1.md) | Rules for Estradot 75 microgram/24 hours patch, 8, sachet. community Prescription. |
| [ChargeItemDefinition-50121491000117102-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50121491000117102-Hospital-Case-5.md) | Rules for Estradot 75 microgram/24 hours patch, 8, sachet. hospital n/a. |
| [ChargeItemDefinition-50148261000117103-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50148261000117103-Community-Case-1.md) | Rules for Apo-Azithromycin 250 mg tablet: film-coated, 30 tablets, bottle [Obsolete]. community Prescription. |
| [ChargeItemDefinition-50148261000117103-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50148261000117103-Hospital-Case-5.md) | Rules for Apo-Azithromycin 250 mg tablet: film-coated, 30 tablets, bottle [Obsolete]. hospital n/a. |
| [ChargeItemDefinition-50225401000117106-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50225401000117106-Community-Case-1.md) | Rules for Etoposide (Rex) 100 mg/5 mL injection: concentrated, 1 x 5 mL vial. community Prescription. |
| [ChargeItemDefinition-50225401000117106-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50225401000117106-Community-Case-2.md) | Rules for Etoposide (Rex) 100 mg/5 mL injection: concentrated, 1 x 5 mL vial. community BSO. |
| [ChargeItemDefinition-50225401000117106-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50225401000117106-Community-Case-3.md) | Rules for Etoposide (Rex) 100 mg/5 mL injection: concentrated, 1 x 5 mL vial. community Rural PSO. |
| [ChargeItemDefinition-50225401000117106-Hospital-Case-7](ChargeItemDefinition-ChargeItemDefinition-50225401000117106-Hospital-Case-7.md) | Rules for Etoposide (Rex) 100 mg/5 mL injection: concentrated, 1 x 5 mL vial. hospital Prescription. |
| [ChargeItemDefinition-50227471000117107-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50227471000117107-Community-Case-4.md) | Rules for Mini-Wright Peak Flow Meter AFS Low Range diagnostic test: peak flow meter, 1 device. community PSO. |
| [ChargeItemDefinition-50227471000117107-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50227471000117107-Hospital-Case-5.md) | Rules for Mini-Wright Peak Flow Meter AFS Low Range diagnostic test: peak flow meter, 1 device. hospital n/a. |
| [ChargeItemDefinition-50242281000117106-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50242281000117106-Community-Case-1.md) | Rules for Agrylin (Shire) 500 microgram capsule: hard, 100 capsules, bottle. community Prescription. |
| [ChargeItemDefinition-50242281000117106-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50242281000117106-Community-Case-2.md) | Rules for Agrylin (Shire) 500 microgram capsule: hard, 100 capsules, bottle. community BSO. |
| [ChargeItemDefinition-50242281000117106-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50242281000117106-Community-Case-3.md) | Rules for Agrylin (Shire) 500 microgram capsule: hard, 100 capsules, bottle. community Rural PSO. |
| [ChargeItemDefinition-50242281000117106-Hospital-Case-7](ChargeItemDefinition-ChargeItemDefinition-50242281000117106-Hospital-Case-7.md) | Rules for Agrylin (Shire) 500 microgram capsule: hard, 100 capsules, bottle. hospital Prescription. |
| [ChargeItemDefinition-50248381000117100-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50248381000117100-Community-Case-1.md) | Rules for Pregabalin Pfizer 75 mg capsule: hard, 56 capsules, blister pack. community Prescription. |
| [ChargeItemDefinition-50248381000117100-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50248381000117100-Community-Case-2.md) | Rules for Pregabalin Pfizer 75 mg capsule: hard, 56 capsules, blister pack. community BSO. |
| [ChargeItemDefinition-50248381000117100-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50248381000117100-Community-Case-3.md) | Rules for Pregabalin Pfizer 75 mg capsule: hard, 56 capsules, blister pack. community Rural PSO. |
| [ChargeItemDefinition-50248381000117100-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50248381000117100-Hospital-Case-5.md) | Rules for Pregabalin Pfizer 75 mg capsule: hard, 56 capsules, blister pack. hospital n/a. |
| [ChargeItemDefinition-50270251000117100-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50270251000117100-Community-Case-1.md) | Rules for Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials. community Prescription. |
| [ChargeItemDefinition-50270251000117100-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50270251000117100-Hospital-Case-5.md) | Rules for Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials. hospital n/a. |
| [ChargeItemDefinition-50277841000117102-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50277841000117102-Community-Case-1.md) | Rules for MiniMed Sure-T MMT-864A insulin pump infusion set (6 mm x 29 gauge steel needle x 10, 60 cm line x 10), 1 pack, composite pack. community Prescription. |
| [ChargeItemDefinition-50277841000117102-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50277841000117102-Hospital-Case-5.md) | Rules for MiniMed Sure-T MMT-864A insulin pump infusion set (6 mm x 29 gauge steel needle x 10, 60 cm line x 10), 1 pack, composite pack. hospital n/a. |
| [ChargeItemDefinition-50283011000117109-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50283011000117109-Community-Case-1.md) | Rules for Estradiol Transdermal System (Mylan) (Twice weekly) 25 microgram/24 hours patch, 8, sachet. community Prescription. |
| [ChargeItemDefinition-50283011000117109-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50283011000117109-Hospital-Case-5.md) | Rules for Estradiol Transdermal System (Mylan) (Twice weekly) 25 microgram/24 hours patch, 8, sachet. hospital n/a. |
| [ChargeItemDefinition-50289761000117107-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50289761000117107-Community-Case-1.md) | Rules for Heparon Junior (2021 Formulation) oral liquid: powder for, 400 g, can. community Prescription. |
| [ChargeItemDefinition-50289761000117107-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50289761000117107-Hospital-Case-5.md) | Rules for Heparon Junior (2021 Formulation) oral liquid: powder for, 400 g, can. hospital n/a. |
| [ChargeItemDefinition-50301271000117101-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50301271000117101-Community-Case-1.md) | Rules for Oralcon 30 ED tablet: film-coated, 84 tablets [3 x 28 tablets], blister pack. community Prescription. |
| [ChargeItemDefinition-50301271000117101-Community-Case-2](ChargeItemDefinition-ChargeItemDefinition-50301271000117101-Community-Case-2.md) | Rules for Oralcon 30 ED tablet: film-coated, 84 tablets [3 x 28 tablets], blister pack. community BSO. |
| [ChargeItemDefinition-50301271000117101-Community-Case-3](ChargeItemDefinition-ChargeItemDefinition-50301271000117101-Community-Case-3.md) | Rules for Oralcon 30 ED tablet: film-coated, 84 tablets [3 x 28 tablets], blister pack. community Rural PSO. |
| [ChargeItemDefinition-50301271000117101-Community-Case-4](ChargeItemDefinition-ChargeItemDefinition-50301271000117101-Community-Case-4.md) | Rules for Oralcon 30 ED tablet: film-coated, 84 tablets [3 x 28 tablets], blister pack. community PSO. |
| [ChargeItemDefinition-50301271000117101-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50301271000117101-Hospital-Case-5.md) | Rules for Oralcon 30 ED tablet: film-coated, 84 tablets [3 x 28 tablets], blister pack. hospital n/a. |
| [ChargeItemDefinition-50308221000117108-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50308221000117108-Community-Case-1.md) | Rules for Vegzelma 100 mg/4 mL injection: concentrated, 1 x 4 mL vial. community Prescription. |
| [ChargeItemDefinition-50320741000117103-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50320741000117103-Community-Case-1.md) | Rules for Vitamin B6 25 (Evara) 25 mg tablet: uncoated, 90 tablets, bottle. community Prescription. |
| [ChargeItemDefinition-50320741000117103-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50320741000117103-Hospital-Case-5.md) | Rules for Vitamin B6 25 (Evara) 25 mg tablet: uncoated, 90 tablets, bottle. hospital n/a. |
| [ChargeItemDefinition-50324571000117108-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50324571000117108-Community-Case-1.md) | Rules for Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle. community Prescription. |
| [ChargeItemDefinition-50324571000117108-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50324571000117108-Hospital-Case-5.md) | Rules for Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle. hospital n/a. |
| [ChargeItemDefinition-50350151000117104-Community-Case-1](ChargeItemDefinition-ChargeItemDefinition-50350151000117104-Community-Case-1.md) | Rules for Teevir tablet: film-coated, 30 tablets, bottle. community Prescription. |
| [ChargeItemDefinition-50350151000117104-Hospital-Case-5](ChargeItemDefinition-ChargeItemDefinition-50350151000117104-Hospital-Case-5.md) | Rules for Teevir tablet: film-coated, 30 tablets, bottle. hospital n/a. |
| [ChargeItemDefinition-SA1098-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA1098-Authorization.md) | Special Authority SA1098. Detailed eligibility criteria available via authorization form. |
| [ChargeItemDefinition-SA1329-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA1329-Authorization.md) | Special Authority SA1329. Detailed eligibility criteria available via authorization form. |
| [ChargeItemDefinition-SA1683-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA1683-Authorization.md) | Special Authority SA1683. Detailed eligibility criteria available via authorization form. |
| [ChargeItemDefinition-SA2139-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2139-Authorization.md) | Special Authority SA2139. Detailed eligibility criteria available via authorization form. |
| [ChargeItemDefinition-SA2185-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2185-Authorization.md) | Special Authority SA2185. Detailed eligibility criteria available via authorization form. |
| [ChargeItemDefinition-SA2453-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2453-Authorization.md) | Special Authority SA2453. Detailed eligibility criteria available via authorization form. |
| [ChargeItemDefinition-SA2536-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2536-Authorization.md) | Special Authority SA2536. Detailed eligibility criteria available via authorization form. |
| [ChargeItemDefinition-SA2561-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2561-Authorization.md) | Special Authority SA2561. Detailed eligibility criteria available via authorization form. |
| [ChargeItemDefinition-SA2620-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2620-Authorization.md) | Special Authority SA2620. Detailed eligibility criteria available via authorization form. |
| [ChargeItemDefinition-SA2628-Authorization](ChargeItemDefinition-ChargeItemDefinition-SA2628-Authorization.md) | Special Authority SA2628. Detailed eligibility criteria available via authorization form. |
| [Medication-50003171000117108](Medication-50003171000117108.md) | Medication representation of Remicade 100 mg injection: powder for, 1 x 100 mg vial. |
| [Medication-50014861000117106](Medication-50014861000117106.md) | Medication representation of Mifegyne 200 mg tablet: uncoated, 3 tablets, blister pack. |
| [Medication-50021691000117107](Medication-50021691000117107.md) | Medication representation of Seretide Accuhaler 250/50 inhalation: powder for, 60 actuations, blister pack. |
| [Medication-50021721000117104](Medication-50021721000117104.md) | Medication representation of Rectogesic 0.2% (2 mg/g) ointment, 30 g, tube. |
| [Medication-50021991000117100](Medication-50021991000117100.md) | Medication representation of Sulphur Precipitated (Midwest) powder, 100 g, jar. |
| [Medication-50038111000117102](Medication-50038111000117102.md) | Medication representation of EpiPen Auto-Injector 300 microgram/0.3 mL injection: solution, 1 x 0.3 mL prefilled injection device. |
| [Medication-50046921000117106](Medication-50046921000117106.md) | Medication representation of Deprim oral liquid+E15:Y15: suspension, 100 mL, bottle. |
| [Medication-50046931000117109](Medication-50046931000117109.md) | Medication representation of Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules. |
| [Medication-50048881000117104](Medication-50048881000117104.md) | Medication representation of Hydrocortisone (ABM) powder, 25 g, jar. |
| [Medication-50055641000117102](Medication-50055641000117102.md) | Medication representation of Thio-Tepa 15 mg injection: powder for, 1 x 15 mg vial. |
| [Medication-50058961000117103](Medication-50058961000117103.md) | Medication representation of Solu-Cortef ACT-O-VIAL 100 mg injection: powder for, 1 x 100 mg dual chamber vial. |
| [Medication-50074861000117103](Medication-50074861000117103.md) | Medication representation of Laevolac 3.34 g/5 mL oral liquid: solution, 500 mL, bottle. |
| [Medication-50083491000117102](Medication-50083491000117102.md) | Medication representation of Clexane 80 mg/0.8 mL injection: solution, 10 x 0.8 mL syringes. |
| [Medication-50085781000117107](Medication-50085781000117107.md) | Medication representation of Fluanxol Depot 40 mg/2 mL injection: modified release, 5 x 2 mL ampoules. |
| [Medication-50120021000117104](Medication-50120021000117104.md) | Medication representation of Fludara Oral 10 mg tablet: film-coated, 20 tablets, blister pack. |
| [Medication-50121491000117102](Medication-50121491000117102.md) | Medication representation of Estradot 75 microgram/24 hours patch, 8, sachet. |
| [Medication-50148261000117103](Medication-50148261000117103.md) | Medication representation of Apo-Azithromycin 250 mg tablet: film-coated, 30 tablets, bottle [Obsolete]. |
| [Medication-50225401000117106](Medication-50225401000117106.md) | Medication representation of Etoposide (Rex) 100 mg/5 mL injection: concentrated, 1 x 5 mL vial. |
| [Medication-50227471000117107](Medication-50227471000117107.md) | Medication representation of Mini-Wright Peak Flow Meter AFS Low Range diagnostic test: peak flow meter, 1 device. |
| [Medication-50242281000117106](Medication-50242281000117106.md) | Medication representation of Agrylin (Shire) 500 microgram capsule: hard, 100 capsules, bottle. |
| [Medication-50248381000117100](Medication-50248381000117100.md) | Medication representation of Pregabalin Pfizer 75 mg capsule: hard, 56 capsules, blister pack. |
| [Medication-50270251000117100](Medication-50270251000117100.md) | Medication representation of Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials. |
| [Medication-50277841000117102](Medication-50277841000117102.md) | Medication representation of MiniMed Sure-T MMT-864A insulin pump infusion set (6 mm x 29 gauge steel needle x 10, 60 cm line x 10), 1 pack, composite pack. |
| [Medication-50283011000117109](Medication-50283011000117109.md) | Medication representation of Estradiol Transdermal System (Mylan) (Twice weekly) 25 microgram/24 hours patch, 8, sachet. |
| [Medication-50289761000117107](Medication-50289761000117107.md) | Medication representation of Heparon Junior (2021 Formulation) oral liquid: powder for, 400 g, can. |
| [Medication-50301271000117101](Medication-50301271000117101.md) | Medication representation of Oralcon 30 ED tablet: film-coated, 84 tablets [3 x 28 tablets], blister pack. |
| [Medication-50308221000117108](Medication-50308221000117108.md) | Medication representation of Vegzelma 100 mg/4 mL injection: concentrated, 1 x 4 mL vial. |
| [Medication-50320741000117103](Medication-50320741000117103.md) | Medication representation of Vitamin B6 25 (Evara) 25 mg tablet: uncoated, 90 tablets, bottle. |
| [Medication-50324571000117108](Medication-50324571000117108.md) | Medication representation of Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle. |
| [Medication-50350151000117104](Medication-50350151000117104.md) | Medication representation of Teevir tablet: film-coated, 30 tablets, bottle. |
| [SearchSet-Bundle-Adrenaline-Note-And-Limit](Bundle-SearchSet-Bundle-Adrenaline-Note-And-Limit.md) | Example search result demonstrating _revinclude to retrieve Adrenaline with separate community and hospital Funding Rules records. The current source demonstrates provider requirements and a PSO limit; it does not contain a note condition. |
| [SearchSet-Bundle-All-Funding-Rules](Bundle-SearchSet-Bundle-All-Funding-Rules.md) | Example search result demonstrating a search for all funding ChargeItemDefinition records. GET [base]/ChargeItemDefinition?_profile=pharmac-charge-item-definition-funding-rules&_count=1000&_total=accurate |
| [SearchSet-Bundle-All-Medications](Bundle-SearchSet-Bundle-All-Medications.md) | Example search result demonstrating a bulk medication search with GET [base]/Medication?_count=1000&_total=accurate |
| [SearchSet-Bundle-All-Special-Authorities](Bundle-SearchSet-Bundle-All-Special-Authorities.md) | Example search result demonstrating a search for all special authorization definitions. GET [base]/ChargeItemDefinition?_profile=pharmac-charge-item-definition-special-authority&_count=1000&_total=accurate |
| [SearchSet-Bundle-Estradiol-Limit](Bundle-SearchSet-Bundle-Estradiol-Limit.md) | Example search result demonstrating _revinclude to retrieve Estradiol Transdermal System with a community limit and provider requirement plus a hospital funding record. |
| [SearchSet-Bundle-Etoposide-Authority-Endorsement](Bundle-SearchSet-Bundle-Etoposide-Authority-Endorsement.md) | Example search result demonstrating _revinclude to retrieve Etoposide with separate Prescription, BSO, Rural PSO, and hospital Funding Rules records. The community pathways demonstrate provider and specialist endorsement conditions. No Special Authority resource applies to Etoposide. |
| [SearchSet-Bundle-Famotidine-Endorsement-And-Note](Bundle-SearchSet-Bundle-Famotidine-Endorsement-And-Note.md) | Example search result demonstrating _revinclude to retrieve Famotidine with an endorsement, provider requirement, and Schedule memoranda note on the community funding pathway. |
| [SearchSet-Bundle-Fluanxol-Multiple-Community-And-Hospital](Bundle-SearchSet-Bundle-Fluanxol-Multiple-Community-And-Hospital.md) | Example search result demonstrating _revinclude to retrieve Fluanxol Depot with separate community and hospital Funding Rules records. The example covers Prescription, BSO, Rural PSO, PSO, provider, and limit patterns. |
| [SearchSet-Bundle-Nitisinone-Hospital-Restriction](Bundle-SearchSet-Bundle-Nitisinone-Hospital-Restriction.md) | Example search result demonstrating _revinclude to retrieve Nitisinone with a community Special Authority requirement and a separate hospital restriction. |

