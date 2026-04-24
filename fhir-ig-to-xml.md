# XML to FHIR Mapping - Pharmac Schedules FHIR API v1.0.1

* [**Table of Contents**](toc.md)
* **XML to FHIR Mapping**

## XML to FHIR Mapping

The examples used in this section are limited to the published example instances listed in the current IG Artifacts page. Clexane is used as the worked example for product, pricing, funding rules, and retrieval. The published `SA9999` example is included separately to illustrate the FHIR structure of a Special Authority record and is not presented as a real Clexane Special Authority.

The legacy XML presents schedule content as a nested structure. In the current Pharmac FHIR service, core product information is held in `Medication`, while pricing, funding rules, and Special Authority content are held in related `ChargeItemDefinition` resources using the profiles `pharmac-charge-item-definition-pricing`, `pharmac-charge-item-definition-funding-rules`, and `pharmac-charge-item-definition-special-authority`. The recommended retrieval pattern is to retrieve the `Medication` and include related `ChargeItemDefinition` resources using `_revinclude=ChargeItemDefinition:instance`.

## Product and identifiers

Product identity is anchored in `Medication`. In the Pharmac FHIR service, ATC hierarchy values, identifiers, brand name, pack size, unit of measure, rank, and strength are held on the `Medication` resource using core fields and named extensions such as `MedicationATCCategory1`, `MedicationATCCategory2`, `MedicationATCCategory3`, `MedicationBrandName`, `MedicationPackageSize`, `MedicationUnitOfMeasure`, `MedicationRank`, and `MedicationStrength`. The published Clexane example is the reference point for the FHIR examples below.

| | | | | |
| :--- | :--- | :--- | :--- | :--- |
| `ATC1` | `<ATC1 ID="..."><Name>...</Name>` | `Medication`/`pharmac-medication` | `extension:MedicationATCCategory1` | `Medication.extension[MedicationATCCategory1].valueString = "Blood and Blood Forming Organs"` |
| `ATC2` | `<ATC2 ID="..."><Name>...</Name>` | `Medication`/`pharmac-medication` | `extension:MedicationATCCategory2` | `Medication.extension[MedicationATCCategory2].valueString = "Antithrombotic Agents"` |
| `ATC3` | `<ATC3 ID="..."><Name>...</Name>` | `Medication`/`pharmac-medication` | `extension:MedicationATCCategory3` | `Medication.extension[MedicationATCCategory3].valueString = "Heparin and Antagonist Preparations"` |
| `Chemical/@ID` | `<Chemical ID="...">` | `Medication`/`pharmac-medication` | identifier for chemical | `Medication.identifier[chemicalId].value = "C0407043893"` |
| `Chemical/Name` | `<Chemical><Name>...</Name>` | `Medication`/`pharmac-medication` | `ingredient.itemCodeableConcept.text` | `Medication.ingredient.itemCodeableConcept.text = "Enoxaparin sodium"` |
| `Formulation/@ID` | `<Formulation ID="...">` | `Medication`/`pharmac-medication` | identifier for formulation | `Medication.identifier[formulationId].value = "F040704389329"` |
| `Formulation/Name` | `<Formulation><Name>...</Name>` | `Medication`/`pharmac-medication` | `form`,`extension:MedicationStrength` | `Medication.form = "Solution for injection"`and`Medication.extension[MedicationStrength].valueString = "100 mg in 1 ml"` |
| `Formulation/@Rank` | `Rank="4"` | `Medication`/`pharmac-medication` | `extension:MedicationRank` | `Medication.extension[MedicationRank].valueInteger = 4` |
| `Formulation/@Units` | `Units="syringe"` | `Medication`/`pharmac-medication` | `extension:MedicationUnitOfMeasure` | `Medication.extension[MedicationUnitOfMeasure].valueString = "syringe"` |
| `Brand/@ID` | `<Brand ID="...">` | `Medication`/`pharmac-medication` | identifier for brand | `Medication.identifier[brandId].value = "B04070438932925"` |
| `Brand/Name` | `<Brand><Name>...</Name>` | `Medication`/`pharmac-medication` | `code.text`,`extension:MedicationBrandName` | `Medication.code.text = "Clexane"`and`Medication.extension[MedicationBrandName].valueString = "Clexane"` |
| `Pack/@ID` | `<Pack ID="...">` | `Medication`/`pharmac-medication` | identifier for pack | `Medication.identifier[packId].value = "P2581906"` |
| `Pack/@nzmt:ctpp_id` | `nzmt:ctpp_id="..."` | `Medication`/`pharmac-medication` | `code` | `GET [base]/Medication?code=<NZMT/CTPP code>` |
| `Pack/Quantity` | `<Quantity>10</Quantity>` | `Medication`/`pharmac-medication` | `extension:MedicationPackageSize` | `Medication.extension[MedicationPackageSize].valueString = "10"` |

The published `Medication-Clexane-100mg-1ml-Syringe` example is the reference point for the values shown above, including brand name `Clexane`, package size `10`, unit of measure `syringe`, rank `4`, ATC Category 1 `Blood and Blood Forming Organs`, ATC Category 2 `Antithrombotic Agents`, ATC Category 3 `Heparin and Antagonist Preparations`, and strength `100 mg in 1 ml`.

## Pricing

Pricing is held in a linked `ChargeItemDefinition` conforming to `pharmac-charge-item-definition-pricing`. Listed price, PHARMAC subsidy, patient surcharge, and patient co-payment are carried in `propertyGroup.priceComponent`, and pricing-specific attributes such as `contractType`, `costBrandSource`, `wastageClaimable`, `dvLimitPercent`, and `brandSwitchFee` are carried as extensions. The published Clexane pricing example is the reference point for the FHIR examples below.

| | | | | |
| :--- | :--- | :--- | :--- | :--- |
| `Pack/Price` | `<Price>...</Price>` | `ChargeItemDefinition`/`pharmac-charge-item-definition-pricing` | `propertyGroup.priceComponent.type`,`propertyGroup.priceComponent.amount` | `type = "base"`and`amount = 70.91 NZD` |
| `Pack/Subsidy` | `<Subsidy>...</Subsidy>` | `ChargeItemDefinition`/`pharmac-charge-item-definition-pricing` | `propertyGroup.priceComponent.type`,`propertyGroup.priceComponent.amount` | `type = "discount"`and`amount = 70.91 NZD` |
| `Pack/Surcharge` | `<Surcharge>...</Surcharge>` | `ChargeItemDefinition`/`pharmac-charge-item-definition-pricing` | `propertyGroup.priceComponent.type`,`propertyGroup.priceComponent.amount` | `type = "surcharge"`and`amount = 0 NZD` |
| patient co-payment outcome | derived from the price block | `ChargeItemDefinition`/`pharmac-charge-item-definition-pricing` | `propertyGroup.priceComponent.type`,`propertyGroup.priceComponent.amount` | `type = "informational"`and`amount = 0 NZD` |
| pricing effective date | pricing date attribute in the published schedule context | `ChargeItemDefinition`/`pharmac-charge-item-definition-pricing` | `extension:pricingEffectiveDate` | `ChargeItemDefinition.extension[pricingEffectiveDate].valueDate = "2026-05-01"` |
| contract type | legacy commercial contract marker | `ChargeItemDefinition`/`pharmac-charge-item-definition-pricing` | `extension:contractType` | `ChargeItemDefinition.extension[contractType].valueString = "PSS"` |
| cost brand source indicator | legacy cost brand context | `ChargeItemDefinition`/`pharmac-charge-item-definition-pricing` | `extension:costBrandSource` | `ChargeItemDefinition.extension[costBrandSource].valueBoolean = false` |
| wastage claimable indicator | legacy wastage-related pricing context | `ChargeItemDefinition`/`pharmac-charge-item-definition-pricing` | `extension:wastageClaimable` | `ChargeItemDefinition.extension[wastageClaimable].valueBoolean = false` |
| daily volume limit percent | legacy DV limit context | `ChargeItemDefinition`/`pharmac-charge-item-definition-pricing` | `extension:dvLimitPercent` | `ChargeItemDefinition.extension[dvLimitPercent].valueDecimal = 5` |
| brand switch fee | legacy switch-fee context | `ChargeItemDefinition`/`pharmac-charge-item-definition-pricing` | `extension:brandSwitchFee` | `ChargeItemDefinition.extension[brandSwitchFee].valueBoolean = false` |

The published `Clexane - Pricing` example is the reference point for the pricing values shown above.

## Funding rules

Funding rules are held in linked `ChargeItemDefinition` resources conforming to `pharmac-charge-item-definition-funding-rules`. Each Funding Rules CID represents a single funding case. The required complex extension `fundingRule` carries the dispensary type in `type`, and carries rule content through `rule[].type`, `rule[].value`, and `rule[].attribute`. A single product can have multiple funding-rule instances representing different pathways. The published Clexane funding-rule examples are the reference point for the FHIR examples below.

| | | | | |
| :--- | :--- | :--- | :--- | :--- |
| `Rule Type="FormMax" Value="..." Attribute="Rx"` | `<Rule Type="FormMax" Value="..." Attribute="Rx"/>` | `ChargeItemDefinition`/`pharmac-charge-item-definition-funding-rules` | `extension:fundingRule.type`,`rule[].type`,`rule[].value`,`rule[].attribute` | `fundingRule.type = "community"`,`rule.type = "CaseSequence"`,`rule.value = 1`,`rule.attribute = "Prescription"` |
| prescription funding pathway | `Attribute="Rx"` | `ChargeItemDefinition`/`pharmac-charge-item-definition-funding-rules` | `rule[].type = "FundingMechanism"`,`rule[].attribute` | `rule.type = "FundingMechanism"`and`rule.attribute = "Prescription"` |
| subsidy type | subsidy outcome implied by the XML rule set | `ChargeItemDefinition`/`pharmac-charge-item-definition-funding-rules` | `rule[].type = "SubsidyType"`,`rule[].attribute` | `rule.type = "SubsidyType"`and`rule.attribute = "Full"` |
| community dispensary type | community branch in the published schedule context | `ChargeItemDefinition`/`pharmac-charge-item-definition-funding-rules` | `extension:fundingRule.type` | `fundingRule.type = "community"` |
| case sequencing | ordered rule grouping in XML | `ChargeItemDefinition`/`pharmac-charge-item-definition-funding-rules` | `rule[].type = "CaseSequence"`,`rule[].value` | `rule.type = "CaseSequence"`and`rule.value = 1` |
| structured rule logic | inline rule combinations in XML | `ChargeItemDefinition`/`pharmac-charge-item-definition-funding-rules` | `extension:authorizationSchema`where present in the example | published example includes a Base64 JSON Schema value for the case structure |

The published `ChargeItemDefinition-Clexane-100mg-1ml-Syringe-Case-1` example is the reference point for the funding-rule values shown above. The Artifacts page also lists `Case-2` and `Case-3` for the same Clexane product.

## Special Authority

Special Authority is held in a linked `ChargeItemDefinition` conforming to `pharmac-charge-item-definition-special-authority`. The published IG currently includes `ChargeItemDefinition-SA9999-Authorization` as an illustrative example of the SA structure. It shows the SA identifier in `code`, linked products in `instance`, the number of cases in `extension:authorizationCaseCount`, and the structured form logic in `extension:authorizationSchema`. This example illustrates the FHIR representation of an SA record and is not a real Clexane Special Authority.

| | | | | |
| :--- | :--- | :--- | :--- | :--- |
| `Rule Attribute="Subsidy" Type="Special" xlink:href="SAxxxx"` | `<Rule Attribute="Subsidy" Type="Special" xlink:href="SAxxxx"/>` | `ChargeItemDefinition`/`pharmac-charge-item-definition-special-authority` | `code.coding.code`,`code.text` | `ChargeItemDefinition.code.coding.code = "SA9999"`and`ChargeItemDefinition.code.text = "SA9999"` |
| `Request/@Form` | `<Request ... Form="SAxxxx">` | `ChargeItemDefinition`/`pharmac-charge-item-definition-special-authority` | `code.coding.code` | `GET [base]/ChargeItemDefinition?cid-code=SA9999` |
| `Request/Title` | `<Title><range>...</range></Title>` | `ChargeItemDefinition`/`pharmac-charge-item-definition-special-authority` | SA title field on the CID | published example is titled`ChargeItemDefinition-SA9999-Authorization`and described as`Special Authorization SA9999` |
| `Request/Case` | `<Case When="...">...</Case>` | `ChargeItemDefinition`/`pharmac-charge-item-definition-special-authority` | `extension:authorizationCaseCount` | `ChargeItemDefinition.extension[authorizationCaseCount].valueInteger = 4` |
| `Case/math` | `<math>...</math>` | `ChargeItemDefinition`/`pharmac-charge-item-definition-special-authority` | `extension:authorizationSchema` | `ChargeItemDefinition.extension[authorizationSchema].valueBase64Binary = "...base64..."` |
| linked product reference | same XML branch contains the request and the related product | `ChargeItemDefinition`/`pharmac-charge-item-definition-special-authority` | `instance` | published example links by`instance`to`Medication/Nutrison-800-Complete-Multi-Fibre` |

The published `ChargeItemDefinition-SA9999-Authorization` example is used here only to show the Special Authority structure in FHIR.

## Retrieval pattern

The legacy XML presents product, pricing, rules, and SA content as a single nested structure. In the Pharmac FHIR service, the same content is separated into linked resources. Product identity is held in `Medication`, pricing attributes are held in `pharmac-charge-item-definition-pricing`, funding pathways are held in `pharmac-charge-item-definition-funding-rules`, and Special Authority definitions are held in `pharmac-charge-item-definition-special-authority`. Complete schedule context is retrieved by starting from `Medication` and returning related CID records using `_revinclude=ChargeItemDefinition:instance`.

| | | | |
| :--- | :--- | :--- | :--- |
| single nested XML branch containing product, price, rules, and SA together | `ATC1 > ATC2 > ATC3 > Chemical > Formulation > Brand > Pack`, with inline`Rule`and`Request/Case`content | anchor-and-linked-resource model | `GET [base]/Medication?name=Clexane&_revinclude=ChargeItemDefinition:instance` |
| inline pack pricing beneath the branded product | `<Pack>...<Subsidy>...<Price>...<Surcharge>...</Pack>` | linked Pricing CID | bundle returns`Medication`plus`pharmac-charge-item-definition-pricing` |
| inline reimbursement rules beneath the product | `<Rule Type="FormMax".../>`and related rule content | linked Funding Rules CID | bundle returns`pharmac-charge-item-definition-funding-rules` |
| inline SA request beneath the product | `<Rule Attribute="Subsidy" Type="Special".../>`and`<Request ...>` | linked Special Authority CID | bundle returns`pharmac-charge-item-definition-special-authority`where applicable |

