# XML to FHIR Mapping - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* **XML to FHIR Mapping**

## XML to FHIR Mapping

# Legacy Schedule XML to FHIR mapping

This page describes how fields in the legacy PHARMAC Schedule XML are transformed into the FHIR resources used by this Implementation Guide.

The mapping is not a direct copy of the XML hierarchy. The XML stores product, funding, and Special Authority information in a nested structure. The FHIR representation separates those concerns into linked resources:

```
Medication
  ├── Funding Rules ChargeItemDefinition
  └── Special Authority ChargeItemDefinition

```

The profiles used by this mapping are:

| | | |
| :--- | :--- | :--- |
| Scheduled pharmaceutical product | `PharmacMedication` | `pharmac-medication` |
| Funding and reimbursement case | `PharmacChargeItemDefinitionFundingRules` | `pharmac-charge-item-definition-funding-rules` |
| Special Authority definition | `PharmacChargeItemDefinitionSpecialAuthority` | `pharmac-charge-item-definition-special-authority` |

## Mapping conventions

The tables on this page use the following mapping classifications:

| | |
| :--- | :--- |
| Direct | The XML value is copied to the FHIR element with only datatype or formatting conversion |
| Derived | The FHIR value is calculated, normalised, or assembled from one or more XML values |
| Inherited | The XML value is declared above the pack level and applies to descendant packs |
| Enriched | The FHIR value is obtained from another authoritative source, such as NZULM or WHO ATC data |
| Not currently represented | The legacy value has no approved location in the current FHIR profiles |

XML paths are shown without namespace prefixes for readability.

## Transformation unit and hierarchy

The primary product unit in the FHIR model is the XML `Pack` carrying an `nzmt:ctpp_id`.

While the existing XML uses a structured hierarchy, the new FHIR service flattens the structure and provides the information at a Pack level.

```
Section
  ATC1
    ATC2
      ATC3
        Chemical
          Formulation
            Brand
              Pack[@nzmt:ctpp_id]

```

For each qualifying `Pack`:

1. One`Medication`resource is created using the CTPP identifier.
1. Product values are taken from the`Pack`and its ancestor`Brand`,`Formulation`, and`Chemical`elements.
1. Rules, flags, and notes declared at any ancestor level are inherited by the descendant pack.
1. The inherited values are normalised into one or more Funding Rules`ChargeItemDefinition`resources.
1. Any applicable`Request`elements are resolved to Special Authority definitions and linked to the relevant product and funding case.

This means an XML rule declared on `Chemical` can result in a separate Funding Rules record for every descendant pack.

## Schedule-level metadata

| | | | | |
| :--- | :--- | :--- | :--- | :--- |
| `/Schedule/Front/Title` | `Pharmaceutical Schedule` | IG or release metadata | Not currently represented | Static publication title; not repeated on each clinical resource |
| `/Schedule/Front/Country` | `New Zealand` | IG or release metadata | Not currently represented | Static publication metadata |
| `/Schedule/Front/Edition` | `February 2026` | Release metadata | Not currently represented | Retained as source-release metadata rather than repeated on every resource |
| `/Schedule/Front/Volume` | `33` | Release metadata | Not currently represented | Retained for source lineage if required |
| `/Schedule/Front/Number` | `0` | Release metadata | Not currently represented | Retained for source lineage if required |
| `/Schedule/Front/Published` | `2026-02-01` | `Medication.extension:medication-price.extension:scheduleDate.valueDate` | Direct | Used as the Schedule date associated with the product price |
| `/Schedule/Front/Published` | `2026-02-01` | `ChargeItemDefinition.extension:pricing-effective-date.valueDate` | Derived/fallback | Used as the effective date where a more specific effective date is not available; this is distinct from`ChargeItemDefinition.date` |
| `/Schedule/Section/@ID` | `B` | Funding case classification | Derived | Contributes to determining the funding context and section-specific processing |
| `/Schedule/Section/Name` | `Community Pharmaceuticals` | `ChargeItemDefinition.extension:funding-rule.extension:type.valueCode` | Derived | A community section contributes`community`; other sections require an explicit mapping rule rather than a literal copy |

## Medication mapping

Each XML pack with an NZMT CTPP identifier becomes one `Medication` resource.

### Identification and coding

| | | | | |
| :--- | :--- | :--- | :--- | :--- |
| `.../Pack/@nzmt:ctpp_id` | `50014861000117106` | `Medication.id` | Direct | The CTPP identifier becomes the FHIR resource id |
| `.../Pack/@nzmt:ctpp_id` | `50014861000117106` | `Medication.code.coding`using`http://nzmt.org.nz` | Direct | The same value is carried as the NZMT CTPP coding |
| `.../Pack/@ID` | `P2086522` | `Medication.code.coding`using the PHARMAC subsidy-code system | Derived | The leading`P`is removed, producing subsidy code`2086522` |
| `.../Pack/@ID` | `P2086522` | `Medication.code.coding.extension:pharmac-is-primary-coding.valueBoolean` | Derived | The primary PHARMAC subsidy coding is marked`true` |
| CTPP concept type | `ctpp` | `Medication.extension:medication-nzmt-type.valueCodeableConcept` | Derived | Fixed to the NZMT type represented by the resource |
| GTIN | — | `Medication.code.coding` | Enriched | GTIN is not present in the legacy XML and is supplied from another product source where available |

### Product description, form, and ingredient

| | | | | |
| :--- | :--- | :--- | :--- | :--- |
| `.../Chemical/Name` | `Mifepristone` | `Medication.ingredient.itemCodeableConcept.text` | Direct | Used as ingredient text where a coded ingredient is not available |
| `.../Formulation/Name` | `Tab 200 mg` | `Medication.form.text` | Direct | Used as the human-readable dose-form/formulation text |
| `.../Brand/Name` | `Mifegyne` | `Medication.code.text`and coding displays | Derived/enriched | Contributes to the product display; the preferred CTPP term is sourced from NZMT/NZULM where available |
| `.../Formulation/@Weight` | `200` | Included in product/form display or coded ingredient strength where available | Derived | The current examples do not carry this as a standalone Medication extension |
| `.../Formulation/@Rank` | `1` | — | Not currently represented | The previous rank extension is not part of the current Medication model |
| `.../Chemical/@ID` | `C1325014129` | — | Not currently represented | Legacy chemical identifier retained only for source lineage |
| `.../Formulation/@ID` | `F132501412925` | — | Not currently represented | Legacy formulation identifier retained only for source lineage |
| `.../Brand/@ID` | `B13250141292525` | — | Not currently represented | Legacy brand identifier retained only for source lineage |
| NZMT preferred term | `Mifegyne 200 mg tablet: uncoated, 3 tablets, blister pack` | `Medication.extension:medication-description`and`Medication.code.text` | Enriched | The preferred term is supplied by NZMT/NZULM rather than reconstructed solely from the XML hierarchy |

### Pack details

| | | | | |
| :--- | :--- | :--- | :--- | :--- |
| `.../Pack/Quantity` | `3` | `Medication.extension:medication-pack.extension:quantity.valueQuantity.value` | Direct | Pack quantity value |
| `.../Formulation/@Units` | `tab` | `Medication.extension:medication-pack.extension:quantity.valueQuantity.unit` | Inherited/direct | The formulation unit is applied to the pack quantity |
| `.../Pack/@Specified` | `true` | No declared child in the current`MedicationPack`extension | Not currently represented | Examples using a`specified`child will not conform unless the extension definition is updated to declare it |
| NZMT medicine code | — | `Medication.extension:medication-pack.extension:nzmtMedicineCode.valueCodeableConcept` | Enriched | This is not the legacy`Pack/@ID`; it must come from an NZMT source if populated |
| Structured pack size | — | `Medication.extension:medication-pack.extension:size.valueQuantity` | Derived/enriched | Populate only when a distinct pack-size value and unit are available |

### Product price and classification

| | | | | |
| :--- | :--- | :--- | :--- | :--- |
| `.../Pack/Price` | `180.00` | `Medication.extension:medication-price.extension:price.valueMoney.value` | Direct | Currency is set to`NZD` |
| `/Schedule/Front/Published` | `2026-02-01` | `Medication.extension:medication-price.extension:scheduleDate.valueDate` | Direct | Schedule publication date associated with the price |
| Legacy`ATC1`,`ATC2`, and`ATC3`IDs/names | `A132501`,`Antiprogesterones` | — | Not directly represented | These legacy hierarchy values are not copied into the current Medication profile |
| WHO ATC code and display | `G03XB01`,`mifepristone` | `Medication.extension:medication-atc.valueCodeableConcept` | Enriched | Supplied through the approved WHO ATC mapping, not directly from the legacy XML category ID |
| Legal classification text | — | `Medication.extension:medication-legal-classification.valueString` | Enriched | Not present as a dedicated field in the legacy XML |
| Legal class code | — | `Medication.extension:medication-legal-class.extension:code.valueCodeableConcept` | Enriched | Supplied from an authoritative legal-class source where available |

## Funding Rules ChargeItemDefinition mapping

Each normalised funding case becomes a separate `ChargeItemDefinition` conforming to `PharmacChargeItemDefinitionFundingRules`.

The generated resource id follows this pattern:

```
ChargeItemDefinition-{CTPP}-{Community|Hospital}-Case-{sequence}

```

### Resource identity and association

| | | | |
| :--- | :--- | :--- | :--- |
| Descendant`Pack/@nzmt:ctpp_id` | `ChargeItemDefinition.instance` | Direct | References`Medication/{ctpp_id}` |
| Funding context derived from section and case processing | `ChargeItemDefinition.extension:funding-rule.extension:type.valueCode` | Derived | Normalised to values such as`community`or`hospital` |
| Order of normalised funding cases | `ChargeItemDefinition.extension:funding-rule.extension:rule[type=CaseSequence].extension:value` | Derived | A sequence number is assigned within the product and funding context |
| Source product and case details | `ChargeItemDefinition.description` | Derived | Human-readable summary generated from the product and case |
| Source product and case details | `ChargeItemDefinition.applicability.description` | Derived | Concise case summary; not the location for machine-readable rule content |
| Source effective date or`/Schedule/Front/Published`fallback | `ChargeItemDefinition.extension:pricing-effective-date.valueDate` | Direct/derived | Represents when the funding case applies |
| FHIR artifact generation timestamp | `ChargeItemDefinition.date` | Generated | Represents creation or revision of the definitional resource, not the Schedule effective date |

### Legacy Rule mapping

`Rule` elements can occur at `ATC2`, `ATC3`, `Chemical`, `Formulation`, or `Brand` level. A rule applies to descendant packs unless a narrower scope overrides it.

| | | | | |
| :--- | :--- | :--- | :--- | :--- |
| `Rule/@Type` | `FormMax` | `extension:funding-rule.extension:rule.extension:type.valueCode` | Direct/inherited | Rule type is copied using the agreed code form |
| `Rule/@Value` | `15` | `extension:funding-rule.extension:rule.extension:value.valueInteger`or`.valueDecimal` | Direct/inherited | Datatype is selected from the source value |
| `Rule/@Attribute` | `PSO` | `extension:funding-rule.extension:rule.extension:attribute.valueCode` | Direct/inherited | Qualifies the rule or identifies the funding mechanism |
| `Rule/@xlink:href` | `SA2535` | `extension:funding-rule.extension:rule.extension:href.valueCode` | Direct/inherited | Reference code is copied without the XML namespace wrapper |
| `Rule/@Waiver` | `Special` | — | Not currently represented | The current FundingRule extension has no`waiver`child; retain in transformation input or represent in condition content if required |
| `Rule/@NonPrinting` | `true` | — | Not currently represented | Presentation control from the legacy format is not part of the current FHIR extension |

### Funding mechanism normalisation

The funding mechanism is carried as a generated FundingRule entry:

```
rule.type = FundingMechanism
rule.attribute = {normalised mechanism}

```

| | |
| :--- | :--- |
| `Rule/@Attribute = Rx` | `Prescription` |
| `Rule/@Attribute = PSO` | `PSO` |
| `Rule/@Attribute = BSO` | `BSO` |
| Rural practitioner supply context | `RuralPSO` |
| Pharmacy-specific supply context | `Pharmacy` |
| No applicable mechanism | `na` |

The mechanism is not always a direct copy of one XML attribute. It may be derived from the rule type, attribute, section, and surrounding narrative.

### Subsidy mapping

| | | | | |
| :--- | :--- | :--- | :--- | :--- |
| `.../Pack/Subsidy` | `180.00` | `extension:funding-subsidy-amount.extension:amount.valueMoney.value` | Direct | Currency is set to`NZD` |
| `.../Pack/Subsidy`and`.../Pack/Price` | both`180.00` | `extension:funding-subsidy-amount.extension:subsidyStatus.valueCode` | Derived | Common derivation:`full`when subsidy equals price,`partial`when subsidy is greater than zero but below price, and`none`where no subsidy applies |
| Funding case type | `subsidy` | `extension:funding-subsidy-amount.extension:subsidyType.valueCode` | Derived | Set according to the funding outcome represented by the case |
| Funding outcome | `Subsidy` | `extension:funding-subsidy-amount.extension:display.valueString` | Derived | Human-readable label generated from type/status |
| `.../Pack/Alternate` | `180.00` | `extension:funding-subsidy-amount.extension:subsidyStatus.valueCode` | Derived | Follows the same structure and field as Subsidy, where`alternate`will be used instead of`subsidy` |
| `.../Pack/Surcharge` | `0.00000` | — | Not currently represented | The current model does not carry the legacy surcharge as a standalone value |

### Schedule funding attributes

| | | | | |
| :--- | :--- | :--- | :--- | :--- |
| `Chemical/@Statim`or`Formulation/@Statim` | `Must` | `extension:schedule-funding-attributes.extension:statim.valueString` | Inherited/direct | The nearest applicable Statim value is used |
| `Brand/@S29` | `true` | `extension:schedule-funding-attributes.extension:section29.valueBoolean` | Direct | XML boolean converted to FHIR boolean |
| `Brand/@PSS` | `2028-06-30` | `extension:schedule-funding-attributes.extension:contractType.valueString` | Derived | Presence maps to contract type`PSS`; the date is not separately represented by the current extension |
| `Brand/@ToBePSS` | date | `extension:schedule-funding-attributes.extension:contractType.valueString` | Derived | Indicates a future PSS state; the current extension does not preserve the transition date separately |
| `Brand/@SoleSupply` | date | `extension:schedule-funding-attributes.extension:contractType.valueString` | Derived | Contributes to contract classification where used |
| `Pack/@OP` | `true` | `extension:schedule-funding-attributes.extension:originalPack.valueBoolean` | Direct | Original-pack flag |
| `Pack/@CBS` | `true` | `extension:schedule-funding-attributes.extension:costBrandSource.valueBoolean` | Direct | Cost-brand-source flag |
| `Pack/Multiple` | `1` | `extension:schedule-funding-attributes.extension:productMultiple.valueBoolean` | Derived | Presence produces`true` |
| `Pack/Multiple` | `1` | `extension:schedule-funding-attributes.extension:productMultiplier.valueInteger` | Direct | Numeric multiplier value |
| `Rule/@Type = Wastage` | — | `extension:schedule-funding-attributes.extension:wastageClaimable.valueBoolean` | Derived/inherited | Presence of an applicable Wastage rule produces`true` |
| `Rule/@Type = Brandswitch` | — | `extension:schedule-funding-attributes.extension:brandSwitchFee.valueBoolean` | Derived/inherited | Presence of an applicable brand-switch rule produces`true` |
| `Rule/@Type = MaxCoPayment`and`Rule/@Value` | `0`or`5` | `extension:schedule-funding-attributes.extension:coPaymentMax.valueCode` | Derived | Requires a controlled transformation because the current target is coded rather than numeric |
| Section/rule information | — | `extension:schedule-funding-attributes.extension:coPaymentMin.valueCode` | Derived | No single direct XML field; derive only where a defined business rule exists |
| Rule/narrative information | — | `extension:schedule-funding-attributes.extension:inCombination.valueCode` | Derived | Derived from explicit rule or narrative content; not a simple element copy |
| Other Schedule source data | — | `extension:schedule-funding-attributes.extension:dvLimitPercent.valueDecimal` | Enriched/derived | No consistent dedicated field was identified in the legacy XML |
| Other Schedule source data | — | `extension:schedule-funding-attributes.extension:safetyListMedicine.valueBoolean` | Enriched/derived | No consistent dedicated field was identified in the legacy XML |

### Funding conditions and narrative

The legacy XML can express conditions as `Rule` elements and XHTML narrative blocks at several hierarchy levels.

| | | |
| :--- | :--- | :--- |
| `div[@class='Note']`and descendant XHTML | `ChargeItemDefinition.extension:authorization-schema`and/or generated`applicability.description` | Narrative is normalised into the condition representation; the original XHTML hierarchy is not copied directly |
| `div[@class='Xref']`,`p/@href`, or link targets | Funding rule reference or condition content | Retain the target as a reference where supported; otherwise preserve in descriptive condition content |
| `Rule/@Type = Special`with`@xlink:href = SA####` | FundingRule`href`and authority condition content | Establishes the logical relationship to the corresponding Special Authority definition |
| Provider or endorsement wording in notes | `authorization-schema` | Converted into the appropriate condition representation for that funding case |

## Special Authority ChargeItemDefinition mapping

Each distinct legacy `Request/@Form` value becomes or refers to a Special Authority `ChargeItemDefinition` conforming to `PharmacChargeItemDefinitionSpecialAuthority`.

A single request can appear at `ATC2`, `ATC3`, `Chemical`, or `Formulation` level. Its scope determines which descendant Medication resources are associated with the form.

| | | | | |
| :--- | :--- | :--- | :--- | :--- |
| `Request/@Form` | `SA2535` | `ChargeItemDefinition.code.coding.code` | Direct | SA code is represented as a code value |
| `Request/@Form` | `SA2535` | `extension:authorization-form.valueString` | Direct | Form identifier is copied |
| Distinct descendant`Case`elements | `4`cases | `extension:authorization-case-count.valueInteger` | Derived | Count of application pathways represented for the SA definition |
| Request scope and explicit`Title/range/instance`values | product references | `ChargeItemDefinition.instance` | Derived | Associates the SA definition with applicable Medication resources |
| `Request/Title/range` | `Budesonide - Cap 3 mg Controlled Release` | `ChargeItemDefinition.description`and code display where appropriate | Derived | Used to create the human-readable form description |
| `/Schedule/Front/Published`or a more specific effective date | `2026-02-01` | `extension:pricing-effective-date.valueDate` | Direct/derived | Effective date for the SA definition |
| `Request/Case/@When` | `Initial application`,`Renewal` | `extension:authorization-schema` | Derived | Identifies the application pathway within the form content |
| `Request/Case/@Category` | `Crohn's disease` | `extension:authorization-schema` | Direct/derived | Used as pathway title or classification |
| `Request/Case/@Form` | related SA codes | `extension:authorization-schema` | Derived | Retained as related-form information where applicable |
| `Request/Case/Applicant` | `any relevant practitioner` | `extension:authorization-schema` | Direct/derived | Applicant requirement |
| `Request/Case/Applicant/@Referring` | specialist list | `extension:authorization-schema` | Direct/derived | Referring-provider requirement |
| `Request/Case/Term`and`@Measure` | `6`,`month` | `extension:authorization-schema` | Direct/derived | Approval validity period |
| `Request/Case/Lapse`and`@Measure` | `6`,`year` | `extension:authorization-schema` | Direct/derived | Lapse or reapplication period where present |
| `Request/Case/math`and descendant MathML | logical criteria | `extension:authorization-schema` | Transformed | MathML logic is converted into the approved structured SA condition representation |
| `Request/Case/div`and request-level`div` | notes and explanatory text | `extension:authorization-schema` | Transformed | Notes are preserved within the form/condition content |
| `Request/@To` | `HealthPAC` | SA description or form metadata | Derived | No dedicated current core field |
| `Request/@For` | `Subsidy` | SA description or form metadata | Derived | No dedicated current core field |
| `Request/@Confidential` | `true` | — | Not currently represented | Requires an explicit profile decision if confidentiality metadata must be preserved |

The XML MathML and XHTML are transformation inputs. JSON Schema condition logic will be provided within the `valueBase64Binary` field held on the Special Authority CID

## Fields not carried directly into the current FHIR model

The following legacy fields do not currently have a direct, approved target:

| | |
| :--- | :--- |
| `ATC1/@ID`,`ATC2/@ID`,`ATC3/@ID`and their names | Retained for source hierarchy and lineage; not used as the WHO ATC extension value |
| `Chemical/@ID`,`Formulation/@ID`,`Brand/@ID` | Retained as legacy source identifiers; not exposed as Medication identifiers in the current profile |
| `Formulation/@Rank` | Not represented |
| `Pack/@Specified` | Mapping gap until`MedicationPack`declares a`specified`child or the examples stop using it |
| `Pack/Alternate` | Not carried as a separate value in the current approved extensions |
| `Pack/Surcharge` | Not carried as a separate value in the current approved extensions |
| `Brand/@Update`,`Chemical/@Update`,`Formulation/@Update` | Change-event metadata is not currently represented |
| `Brand/@ToBeDelisted` | No direct approved target |
| PSS, sole-supply, or future-contract dates | Contract type can be represented, but the associated dates do not currently have a dedicated child |
| `Rule/@Waiver` | No child exists in the current FundingRule extension |
| `Rule/@NonPrinting` | Legacy presentation control is not carried into FHIR |
| `Request/@Confidential` | No current SA profile element; requires a separate design decision |

These are deliberate mapping gaps or profile decisions that must be resolved before claiming full one-to-one source coverage.

## Worked example: Mifegyne

The legacy XML contains the following values for the Mifegyne pack:

```
<Chemical ID="C1325014129">
  <Name>Mifepristone</Name>
  <Formulation ID="F132501412925" Rank="1" Units="tab" Weight="200">
    <Name>Tab 200 mg</Name>
    <Rule Type="FormMax" Value="15" Attribute="PSO"/>
    <Brand ID="B13250141292525">
      <Name>Mifegyne</Name>
      <Pack ID="P2086522" Specified="true" nzmt:ctpp_id="50014861000117106">
        <Quantity>3</Quantity>
        <Subsidy>180.00</Subsidy>
        <Price>180.00</Price>
        <Alternate>180.00</Alternate>
        <Surcharge>0.00000</Surcharge>
      </Pack>
    </Brand>
  </Formulation>
</Chemical>

```

The primary FHIR mappings are:

| | |
| :--- | :--- |
| `Pack/@nzmt:ctpp_id = 50014861000117106` | `Medication.id = 50014861000117106`and NZMT coding |
| `Pack/@ID = P2086522` | PHARMAC subsidy coding`2086522`marked as primary |
| `Chemical/Name = Mifepristone` | `Medication.ingredient.itemCodeableConcept.text` |
| `Formulation/Name = Tab 200 mg` | `Medication.form.text` |
| `Pack/Quantity = 3`plus`Formulation/@Units = tab` | `medication-pack.quantity = 3 tab` |
| `Pack/Price = 180.00` | `medication-price.price = NZD 180.00` |
| `Pack/Subsidy = 180.00` | Funding Rules subsidy amount`NZD 180.00`, normally derived as fully subsidised because price and subsidy are equal |
| `Rule Type=FormMax Value=15 Attribute=PSO` | FundingRule entry with type`FormMax`, value`15`, and attribute`PSO`; contributes to the applicable PSO funding case |
| `Pack/@Specified = true` | Current mapping gap because`specified`is not declared by`MedicationPack` |

## Related pages

* [Data Models](datamodel.md)
* [Resource Relationships](relationships.md)
* [FHIR API search examples](api.md)
* [Examples](examples.md)
* [Funding Rules JSON Schema guide](fr-json-schema-guide.md)
* [Special Authority JSON Schema guide](sa-json-schema-guide.md)

