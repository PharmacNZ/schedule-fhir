# SearchSet-Bundle-All-Medications - Pharmac Schedules FHIR API v1.1.0

* [**Table of Contents**](toc.md)
* [**Artifacts Summary**](artifacts.md)
* **SearchSet-Bundle-All-Medications**

## Example Bundle: SearchSet-Bundle-All-Medications



## Resource Content

```json
{
  "resourceType" : "Bundle",
  "id" : "SearchSet-Bundle-All-Medications",
  "type" : "searchset",
  "total" : 30,
  "link" : [{
    "relation" : "self",
    "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/Medication?_count=1000&_total=accurate"
  }],
  "entry" : [{
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50003171000117108",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50003171000117108",
              "display" : "Remicade 100 mg injection: powder for, 1 x 100 mg vial"
            }],
            "text" : "Remicade 100 mg injection: powder for, 1 x 100 mg vial"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "L04AB02",
            "display" : "infliximab"
          }],
          "text" : "infliximab"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 1,
            "unit" : "vial"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 428,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50003171000117108",
          "display" : "Remicade 100 mg injection: powder for, 1 x 100 mg vial"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "9317376141802"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2016710"
        }],
        "text" : "Remicade 100 mg injection: powder for, 1 x 100 mg vial"
      },
      "status" : "active",
      "form" : {
        "text" : "Inj 100 mg"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Infliximab"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50014861000117106",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50014861000117106",
              "display" : "Mifegyne 200 mg tablet: uncoated, 3 tablets, blister pack"
            }],
            "text" : "Mifegyne 200 mg tablet: uncoated, 3 tablets, blister pack"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "G03XB01",
            "display" : "mifepristone"
          }],
          "text" : "mifepristone"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 3,
            "unit" : "tablet"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 180,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50014861000117106",
          "display" : "Mifegyne 200 mg tablet: uncoated, 3 tablets, blister pack"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2086522"
        }],
        "text" : "Mifegyne 200 mg tablet: uncoated, 3 tablets, blister pack"
      },
      "status" : "active",
      "form" : {
        "text" : "Tab 200 mg"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Mifepristone"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50021691000117107",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50021691000117107",
              "display" : "Seretide Accuhaler 250/50 inhalation: powder for, 60 actuations, blister pack"
            }],
            "text" : "Seretide Accuhaler 250/50 inhalation: powder for, 60 actuations, blister pack"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "R03AK06",
            "display" : "salmeterol and fluticasone"
          }],
          "text" : "salmeterol and fluticasone"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 60,
            "unit" : "actuation"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 44.08,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50021691000117107",
          "display" : "Seretide Accuhaler 250/50 inhalation: powder for, 60 actuations, blister pack"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "9300670198443"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2120224"
        }],
        "text" : "Seretide Accuhaler 250/50 inhalation: powder for, 60 actuations, blister pack"
      },
      "status" : "active",
      "form" : {
        "text" : "Powder for inhalation 250 mcg with salmeterol 50 mcg"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Fluticasone with salmeterol"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50021721000117104",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50021721000117104",
              "display" : "Rectogesic 0.2% (2 mg/g) ointment, 30 g, tube"
            }],
            "text" : "Rectogesic 0.2% (2 mg/g) ointment, 30 g, tube"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "C05AE01",
            "display" : "glyceryl trinitrate"
          }],
          "text" : "glyceryl trinitrate"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 30,
            "unit" : "g"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 22,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50021721000117104",
          "display" : "Rectogesic 0.2% (2 mg/g) ointment, 30 g, tube"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "9325728000035"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2120313"
        }],
        "text" : "Rectogesic 0.2% (2 mg/g) ointment, 30 g, tube"
      },
      "status" : "active",
      "form" : {
        "text" : "Oint 0.2%"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Glyceryl trinitrate"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50021991000117100",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50021991000117100",
              "display" : "Sulphur Precipitated (Midwest) powder, 100 g, jar"
            }],
            "text" : "Sulphur Precipitated (Midwest) powder, 100 g, jar"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "D10AB02",
            "display" : "sulfur"
          }],
          "text" : "sulfur"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 100,
            "unit" : "g"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 6.35,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50021991000117100",
          "display" : "Sulphur Precipitated (Midwest) powder, 100 g, jar"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2121158"
        }],
        "text" : "Sulphur Precipitated (Midwest) powder, 100 g, jar"
      },
      "status" : "active",
      "form" : {
        "text" : "Precipitated"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Sulphur"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50038111000117102",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50038111000117102",
              "display" : "EpiPen Auto-Injector 300 microgram/0.3 mL injection: solution, 1 x 0.3 mL prefilled injection device"
            }],
            "text" : "EpiPen Auto-Injector 300 microgram/0.3 mL injection: solution, 1 x 0.3 mL prefilled injection device"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "C01CA24",
            "display" : "epinephrine"
          }],
          "text" : "epinephrine"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 1,
            "unit" : "prefilled injection device"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 85.5,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50038111000117102",
          "display" : "EpiPen Auto-Injector 300 microgram/0.3 mL injection: solution, 1 x 0.3 mL prefilled injection device"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "9323610006158"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "223972"
        }],
        "text" : "EpiPen Auto-Injector 300 microgram/0.3 mL injection: solution, 1 x 0.3 mL prefilled injection device"
      },
      "status" : "active",
      "form" : {
        "text" : "Inj 0.3 mg per 0.3 ml auto-injector"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Adrenaline"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50046921000117106",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50046921000117106",
              "display" : "Deprim oral liquid+E15:Y15: suspension, 100 mL, bottle"
            }],
            "text" : "Deprim oral liquid+E15:Y15: suspension, 100 mL, bottle"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "J01EE01",
            "display" : "sulfamethoxazole and trimethoprim"
          }],
          "text" : "sulfamethoxazole and trimethoprim"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 100,
            "unit" : "ml"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 4.95,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50046921000117106",
          "display" : "Deprim oral liquid+E15:Y15: suspension, 100 mL, bottle"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "5290665002128"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2309718"
        }],
        "text" : "Deprim oral liquid+E15:Y15: suspension, 100 mL, bottle"
      },
      "status" : "active",
      "form" : {
        "text" : "Oral liq 8 mg sulphamethoxazole 40 mg per ml"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Trimethoprim with sulphamethoxazole [Co-trimoxazole]"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50046931000117109",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50046931000117109",
              "display" : "Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules"
            }],
            "text" : "Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "C01CA24",
            "display" : "epinephrine"
          }],
          "text" : "epinephrine"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 5,
            "unit" : "ampoule"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 4.98,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50046931000117109",
          "display" : "Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "9331134001405"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2309823"
        }],
        "text" : "Adrenaline (Aspen) 1 in 1000 (1 mg/mL) injection: solution, 5 x 1 mL ampoules"
      },
      "status" : "active",
      "form" : {
        "text" : "Inj 1 in 1,000, 1 ml ampoule"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Adrenaline"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50048881000117104",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50048881000117104",
              "display" : "Hydrocortisone (ABM) powder, 25 g, jar"
            }],
            "text" : "Hydrocortisone (ABM) powder, 25 g, jar"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "D07AA02",
            "display" : "hydrocortisone"
          }],
          "text" : "hydrocortisone"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 25,
            "unit" : "g"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 49.95,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50048881000117104",
          "display" : "Hydrocortisone (ABM) powder, 25 g, jar"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2322420"
        }],
        "text" : "Hydrocortisone (ABM) powder, 25 g, jar"
      },
      "status" : "active",
      "form" : {
        "text" : "Powder"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Hydrocortisone"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50055641000117102",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50055641000117102",
              "display" : "Thio-Tepa 15 mg injection: powder for, 1 x 15 mg vial"
            }],
            "text" : "Thio-Tepa 15 mg injection: powder for, 1 x 15 mg vial"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "L01AC01",
            "display" : "thiotepa"
          }],
          "text" : "thiotepa"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 1,
            "unit" : "vial"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 0,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50055641000117102",
          "display" : "Thio-Tepa 15 mg injection: powder for, 1 x 15 mg vial"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "256811"
        }],
        "text" : "Thio-Tepa 15 mg injection: powder for, 1 x 15 mg vial"
      },
      "status" : "active",
      "form" : {
        "text" : "Inj 15 mg vial"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Thiotepa"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50058961000117103",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50058961000117103",
              "display" : "Solu-Cortef ACT-O-VIAL 100 mg injection: powder for, 1 x 100 mg dual chamber vial"
            }],
            "text" : "Solu-Cortef ACT-O-VIAL 100 mg injection: powder for, 1 x 100 mg dual chamber vial"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "H02AB09",
            "display" : "hydrocortisone"
          }],
          "text" : "hydrocortisone"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 1,
            "unit" : "vial"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 3.96,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50058961000117103",
          "display" : "Solu-Cortef ACT-O-VIAL 100 mg injection: powder for, 1 x 100 mg dual chamber vial"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "9313212102938"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "265284"
        }],
        "text" : "Solu-Cortef ACT-O-VIAL 100 mg injection: powder for, 1 x 100 mg dual chamber vial"
      },
      "status" : "active",
      "form" : {
        "text" : "Inj 100 mg vial"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Hydrocortisone"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50074861000117103",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50074861000117103",
              "display" : "Laevolac 3.34 g/5 mL oral liquid: solution, 500 mL, bottle"
            }],
            "text" : "Laevolac 3.34 g/5 mL oral liquid: solution, 500 mL, bottle"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "A06AD11",
            "display" : "lactulose"
          }],
          "text" : "lactulose"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 500,
            "unit" : "ml"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 6.16,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50074861000117103",
          "display" : "Laevolac 3.34 g/5 mL oral liquid: solution, 500 mL, bottle"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2440210"
        }],
        "text" : "Laevolac 3.34 g/5 mL oral liquid: solution, 500 mL, bottle"
      },
      "status" : "active",
      "form" : {
        "text" : "Oral liq 10 g per 15 ml"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Lactulose"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50083491000117102",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50083491000117102",
              "display" : "Clexane 80 mg/0.8 mL injection: solution, 10 x 0.8 mL syringes"
            }],
            "text" : "Clexane 80 mg/0.8 mL injection: solution, 10 x 0.8 mL syringes"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "B01AB05",
            "display" : "enoxaparin"
          }],
          "text" : "enoxaparin"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 10,
            "unit" : "syringe"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 56.62,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50083491000117102",
          "display" : "Clexane 80 mg/0.8 mL injection: solution, 10 x 0.8 mL syringes"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "09312319039673"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "09319733003464"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2581892"
        }],
        "text" : "Clexane 80 mg/0.8 mL injection: solution, 10 x 0.8 mL syringes"
      },
      "status" : "active",
      "form" : {
        "text" : "Inj 80 mg in 0.8 ml syringe"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Enoxaparin sodium"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50085781000117107",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50085781000117107",
              "display" : "Fluanxol Depot 40 mg/2 mL injection: modified release, 5 x 2 mL ampoules"
            }],
            "text" : "Fluanxol Depot 40 mg/2 mL injection: modified release, 5 x 2 mL ampoules"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "N05AF01",
            "display" : "flupentixol"
          }],
          "text" : "flupentixol"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 5,
            "unit" : "ampoule"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 20.9,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50085781000117107",
          "display" : "Fluanxol Depot 40 mg/2 mL injection: modified release, 5 x 2 mL ampoules"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "5702157120116"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "437301"
        }],
        "text" : "Fluanxol Depot 40 mg/2 mL injection: modified release, 5 x 2 mL ampoules"
      },
      "status" : "active",
      "form" : {
        "text" : "Inj 20 mg per ml, 2 ml"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Flupenthixol decanoate"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50120021000117104",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50120021000117104",
              "display" : "Fludara Oral 10 mg tablet: film-coated, 20 tablets, blister pack"
            }],
            "text" : "Fludara Oral 10 mg tablet: film-coated, 20 tablets, blister pack"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "L01BB05",
            "display" : "fludarabine"
          }],
          "text" : "fludarabine"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 20,
            "unit" : "tablet"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 412,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50120021000117104",
          "display" : "Fludara Oral 10 mg tablet: film-coated, 20 tablets, blister pack"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "9323911001814"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2327988"
        }],
        "text" : "Fludara Oral 10 mg tablet: film-coated, 20 tablets, blister pack"
      },
      "status" : "active",
      "form" : {
        "text" : "Tab 10 mg"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Fludarabine phosphate"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50121491000117102",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50121491000117102",
              "display" : "Estradot 75 microgram/24 hours patch, 8, sachet"
            }],
            "text" : "Estradot 75 microgram/24 hours patch, 8, sachet"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "G03CA03",
            "display" : "estradiol"
          }],
          "text" : "estradiol"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 8,
            "unit" : "patch"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 16.53,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50121491000117102",
          "display" : "Estradot 75 microgram/24 hours patch, 8, sachet"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2514346"
        }],
        "text" : "Estradot 75 microgram/24 hours patch, 8, sachet"
      },
      "status" : "active",
      "form" : {
        "text" : "Patch 75 mcg per day"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Oestradiol"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50148261000117103",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50148261000117103",
              "display" : "Apo-Azithromycin 250 mg tablet: film-coated, 30 tablets, bottle [Obsolete]"
            }],
            "text" : "Apo-Azithromycin 250 mg tablet: film-coated, 30 tablets, bottle [Obsolete]"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "J01FA10",
            "display" : "azithromycin"
          }],
          "text" : "azithromycin"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 30,
            "unit" : "tablet"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 8.19,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50148261000117103",
          "display" : "Apo-Azithromycin 250 mg tablet: film-coated, 30 tablets, bottle [Obsolete]"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "9416966008287"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2405296"
        }],
        "text" : "Apo-Azithromycin 250 mg tablet: film-coated, 30 tablets, bottle [Obsolete]"
      },
      "status" : "active",
      "form" : {
        "text" : "Tab 250 mg"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Azithromycin"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50225401000117106",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50225401000117106",
              "display" : "Etoposide (Rex) 100 mg/5 mL injection: concentrated, 1 x 5 mL vial"
            }],
            "text" : "Etoposide (Rex) 100 mg/5 mL injection: concentrated, 1 x 5 mL vial"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "L01CB01",
            "display" : "etoposide"
          }],
          "text" : "etoposide"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 1,
            "unit" : "vial"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 7.9,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50225401000117106",
          "display" : "Etoposide (Rex) 100 mg/5 mL injection: concentrated, 1 x 5 mL vial"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2480913"
        }],
        "text" : "Etoposide (Rex) 100 mg/5 mL injection: concentrated, 1 x 5 mL vial"
      },
      "status" : "active",
      "form" : {
        "text" : "Inj 20 mg per ml, 5 ml vial"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Etoposide"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50227471000117107",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50227471000117107",
              "display" : "Mini-Wright Peak Flow Meter AFS Low Range diagnostic test: peak flow meter, 1 device"
            }],
            "text" : "Mini-Wright Peak Flow Meter AFS Low Range diagnostic test: peak flow meter, 1 device"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "TODO",
            "display" : "No WHO ATC identified - medical device"
          }],
          "text" : "No WHO ATC identified - medical device"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 1,
            "unit" : "device"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 9.54,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50227471000117107",
          "display" : "Mini-Wright Peak Flow Meter AFS Low Range diagnostic test: peak flow meter, 1 device"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "5023323040503"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2489945"
        }],
        "text" : "Mini-Wright Peak Flow Meter AFS Low Range diagnostic test: peak flow meter, 1 device"
      },
      "status" : "active",
      "form" : {
        "text" : "Low range"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Peak flow meter"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50242281000117106",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50242281000117106",
              "display" : "Agrylin (Shire) 500 microgram capsule: hard, 100 capsules, bottle"
            }],
            "text" : "Agrylin (Shire) 500 microgram capsule: hard, 100 capsules, bottle"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "L01XX35",
            "display" : "anagrelide"
          }],
          "text" : "anagrelide"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 100,
            "unit" : "capsule"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 1175.87,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50242281000117106",
          "display" : "Agrylin (Shire) 500 microgram capsule: hard, 100 capsules, bottle"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "9344359000016"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2583054"
        }],
        "text" : "Agrylin (Shire) 500 microgram capsule: hard, 100 capsules, bottle"
      },
      "status" : "active",
      "form" : {
        "text" : "Cap 0.5 mg"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Anagrelide hydrochloride"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50248381000117100",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50248381000117100",
              "display" : "Pregabalin Pfizer 75 mg capsule: hard, 56 capsules, blister pack"
            }],
            "text" : "Pregabalin Pfizer 75 mg capsule: hard, 56 capsules, blister pack"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "N02BF02",
            "display" : "pregabalin"
          }],
          "text" : "pregabalin"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 56,
            "unit" : "capsule"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 2.65,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50248381000117100",
          "display" : "Pregabalin Pfizer 75 mg capsule: hard, 56 capsules, blister pack"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2534088"
        }],
        "text" : "Pregabalin Pfizer 75 mg capsule: hard, 56 capsules, blister pack"
      },
      "status" : "active",
      "form" : {
        "text" : "Cap 75 mg"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Pregabalin"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50270251000117100",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50270251000117100",
              "display" : "Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials"
            }],
            "text" : "Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "A02BA03",
            "display" : "famotidine"
          }],
          "text" : "famotidine"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 10,
            "unit" : "vial"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 57.02,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50270251000117100",
          "display" : "Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2602776"
        }],
        "text" : "Famotidine (Mylan) 40 mg/4 mL injection: concentrated, 10 x 4 mL vials"
      },
      "status" : "active",
      "form" : {
        "text" : "Inj 10 mg per ml, 4 ml"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Famotidine"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50277841000117102",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50277841000117102",
              "display" : "MiniMed Sure-T MMT-864A insulin pump infusion set (6 mm x 29 gauge steel needle x 10, 60 cm line x 10), 1 pack, composite pack"
            }],
            "text" : "MiniMed Sure-T MMT-864A insulin pump infusion set (6 mm x 29 gauge steel needle x 10, 60 cm line x 10), 1 pack, composite pack"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "TODO",
            "display" : "No WHO ATC identified - medical device"
          }],
          "text" : "No WHO ATC identified - medical device"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 1,
            "unit" : "pack"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 219,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50277841000117102",
          "display" : "MiniMed Sure-T MMT-864A insulin pump infusion set (6 mm x 29 gauge steel needle x 10, 60 cm line x 10), 1 pack, composite pack"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "5705244019294"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2591685"
        }],
        "text" : "MiniMed Sure-T MMT-864A insulin pump infusion set (6 mm x 29 gauge steel needle x 10, 60 cm line x 10), 1 pack, composite pack"
      },
      "status" : "active",
      "form" : {
        "text" : "6 mm steel needle; 60 cm tubing x 10"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Insulin pump infusion set (steel cannula)"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50283011000117109",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50283011000117109",
              "display" : "Estradiol Transdermal System (Mylan) (Twice weekly) 25 microgram/24 hours patch, 8, sachet"
            }],
            "text" : "Estradiol Transdermal System (Mylan) (Twice weekly) 25 microgram/24 hours patch, 8, sachet"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "G03CA03",
            "display" : "estradiol"
          }],
          "text" : "estradiol"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 8,
            "unit" : "patch"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 8.89,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50283011000117109",
          "display" : "Estradiol Transdermal System (Mylan) (Twice weekly) 25 microgram/24 hours patch, 8, sachet"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "303784644164"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "00303784619261"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2601583"
        }],
        "text" : "Estradiol Transdermal System (Mylan) (Twice weekly) 25 microgram/24 hours patch, 8, sachet"
      },
      "status" : "active",
      "form" : {
        "text" : "Patch 25 mcg per day"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Oestradiol"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50289761000117107",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50289761000117107",
              "display" : "Heparon Junior (2021 Formulation) oral liquid: powder for, 400 g, can"
            }],
            "text" : "Heparon Junior (2021 Formulation) oral liquid: powder for, 400 g, can"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "V06DB",
            "display" : "fat/carbohydrates/proteins/minerals/vitamins, combinations"
          }],
          "text" : "fat/carbohydrates/proteins/minerals/vitamins, combinations"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 400,
            "unit" : "g"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 93.97,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50289761000117107",
          "display" : "Heparon Junior (2021 Formulation) oral liquid: powder for, 400 g, can"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "4008976458876"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2615568"
        }],
        "text" : "Heparon Junior (2021 Formulation) oral liquid: powder for, 400 g, can"
      },
      "status" : "active",
      "form" : {
        "text" : "Powder (unflavoured)"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Enteral/oral feed 1kcal/ml"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50301271000117101",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50301271000117101",
              "display" : "Oralcon 30 ED tablet: film-coated, 84 tablets [3 x 28 tablets], blister pack"
            }],
            "text" : "Oralcon 30 ED tablet: film-coated, 84 tablets [3 x 28 tablets], blister pack"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "G03AA07",
            "display" : "levonorgestrel and ethinylestradiol"
          }],
          "text" : "levonorgestrel and ethinylestradiol"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 84,
            "unit" : "tablet"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 2.3,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50301271000117101",
          "display" : "Oralcon 30 ED tablet: film-coated, 84 tablets [3 x 28 tablets], blister pack"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "9417924006895"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2637138"
        }],
        "text" : "Oralcon 30 ED tablet: film-coated, 84 tablets [3 x 28 tablets], blister pack"
      },
      "status" : "active",
      "form" : {
        "text" : "Tab 30 mcg with levonorgestrel 150 mcg and 7 inert tablets"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Ethinyloestradiol with levonorgestrel"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50308221000117108",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50308221000117108",
              "display" : "Vegzelma 100 mg/4 mL injection: concentrated, 1 x 4 mL vial"
            }],
            "text" : "Vegzelma 100 mg/4 mL injection: concentrated, 1 x 4 mL vial"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "L01FG01",
            "display" : "bevacizumab"
          }],
          "text" : "bevacizumab"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 1,
            "unit" : "vial"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 69,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50308221000117108",
          "display" : "Vegzelma 100 mg/4 mL injection: concentrated, 1 x 4 mL vial"
        },
        {
          "system" : "https://www.gs1.org/gtin",
          "code" : "9356004000203"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2700700"
        }],
        "text" : "Vegzelma 100 mg/4 mL injection: concentrated, 1 x 4 mL vial"
      },
      "status" : "active",
      "form" : {
        "text" : "Inj 25 mg per ml, 4 ml vial"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Bevacizumab"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50320741000117103",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50320741000117103",
              "display" : "Vitamin B6 25 (Evara) 25 mg tablet: uncoated, 90 tablets, bottle"
            }],
            "text" : "Vitamin B6 25 (Evara) 25 mg tablet: uncoated, 90 tablets, bottle"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "A11HA02",
            "display" : "pyridoxine (vit B6)"
          }],
          "text" : "pyridoxine (vit B6)"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 90,
            "unit" : "tablet"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 3.43,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50320741000117103",
          "display" : "Vitamin B6 25 (Evara) 25 mg tablet: uncoated, 90 tablets, bottle"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2473534"
        }],
        "text" : "Vitamin B6 25 (Evara) 25 mg tablet: uncoated, 90 tablets, bottle"
      },
      "status" : "active",
      "form" : {
        "text" : "Tab 25 mg"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Pyridoxine hydrochloride"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50324571000117108",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50324571000117108",
              "display" : "Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle"
            }],
            "text" : "Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "A16AX04",
            "display" : "nitisinone"
          }],
          "text" : "nitisinone"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 60,
            "unit" : "capsule"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 676,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50324571000117108",
          "display" : "Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2677687"
        }],
        "text" : "Nitisinone (Logixx Pharma) 2 mg capsule: hard, 60 capsules, bottle"
      },
      "status" : "active",
      "form" : {
        "text" : "Cap 2 mg"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Nitisinone"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  },
  {
    "resource" : {
      "resourceType" : "Medication",
      "id" : "50350151000117104",
      "meta" : {
        "profile" : ["https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-medication"]
      },
      "extension" : [{
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-nzmt-type",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "https://standards.digital.health.nz/ns/nzmt-type-code",
            "code" : "ctpp"
          }],
          "text" : "ctpp"
        }
      },
      {
        "extension" : [{
          "url" : "type",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "20069071000116107",
              "display" : "Preferred Term"
            }],
            "text" : "Preferred Term"
          }
        },
        {
          "url" : "term",
          "valueCodeableConcept" : {
            "coding" : [{
              "system" : "http://nzmt.org.nz",
              "code" : "50350151000117104",
              "display" : "Teevir tablet: film-coated, 30 tablets, bottle"
            }],
            "text" : "Teevir tablet: film-coated, 30 tablets, bottle"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-description"
      },
      {
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc",
        "valueCodeableConcept" : {
          "coding" : [{
            "system" : "http://www.whocc.no/atc",
            "code" : "J05AR06",
            "display" : "emtricitabine, tenofovir disoproxil and efavirenz"
          }],
          "text" : "emtricitabine, tenofovir disoproxil and efavirenz"
        }
      },
      {
        "extension" : [{
          "url" : "quantity",
          "valueQuantity" : {
            "value" : 30,
            "unit" : "tablet"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-pack"
      },
      {
        "extension" : [{
          "url" : "price",
          "valueMoney" : {
            "value" : 106.88,
            "currency" : "NZD"
          }
        }],
        "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-price"
      }],
      "code" : {
        "coding" : [{
          "system" : "http://nzmt.org.nz",
          "code" : "50350151000117104",
          "display" : "Teevir tablet: film-coated, 30 tablets, bottle"
        },
        {
          "extension" : [{
            "url" : "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-is-primary-coding",
            "valueBoolean" : true
          }],
          "system" : "https://standards.digital.health.nz/ns/pharmac-subsidy-code",
          "code" : "2705508"
        }],
        "text" : "Teevir tablet: film-coated, 30 tablets, bottle"
      },
      "status" : "active",
      "form" : {
        "text" : "Tab 600 mg with emtricitabine 200 mg and tenofovir disoproxil 245 mg (300 mg as a fumarate)"
      },
      "ingredient" : [{
        "itemCodeableConcept" : {
          "text" : "Efavirenz with emtricitabine and tenofovir disoproxil"
        },
        "isActive" : true
      }]
    },
    "search" : {
      "mode" : "match"
    }
  }]
}

```
