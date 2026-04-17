<?xml version="1.0" encoding="UTF-8"?>
<sch:schema xmlns:sch="http://purl.oclc.org/dsdl/schematron" queryBinding="xslt2">
  <sch:ns prefix="f" uri="http://hl7.org/fhir"/>
  <sch:ns prefix="h" uri="http://www.w3.org/1999/xhtml"/>
  <!-- 
    This file contains just the constraints for the profile ChargeItemDefinition
    It includes the base constraints for the resource as well.
    Because of the way that schematrons and containment work, 
    you may need to use this schematron fragment to build a, 
    single schematron that validates contained resources (if you have any) 
  -->
  <sch:pattern>
    <sch:title>f:ChargeItemDefinition</sch:title>
    <sch:rule context="f:ChargeItemDefinition">
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date']) &gt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date': minimum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-expiry-date']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-expiry-date': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-form']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-form': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-title']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-title': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-case-count']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-case-count': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/cost-brand-source']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/cost-brand-source': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/wastage-claimable']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/wastage-claimable': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/contract-type']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/contract-type': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/dv-limit-percent']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/dv-limit-percent': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/brand-switch-fee']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/brand-switch-fee': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/statim']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/statim': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/in-combination']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/in-combination': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-schema']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-schema': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-section-29']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-section-29': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-not-combined']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-not-combined': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-copayment-max']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-copayment-max': maximum cardinality of 'extension' is 1</sch:assert>
    </sch:rule>
  </sch:pattern>
  <sch:pattern>
    <sch:title>f:ChargeItemDefinition/f:applicability</sch:title>
    <sch:rule context="f:ChargeItemDefinition/f:applicability">
      <sch:assert test="count(f:description) &gt;= 1">description: minimum cardinality of 'description' is 1</sch:assert>
    </sch:rule>
  </sch:pattern>
  <sch:pattern>
    <sch:title>f:ChargeItemDefinition/f:propertyGroup/f:applicability</sch:title>
    <sch:rule context="f:ChargeItemDefinition/f:propertyGroup/f:applicability">
      <sch:assert test="count(f:id) &lt;= 1">id: maximum cardinality of 'id' is 1</sch:assert>
      <sch:assert test="count(f:description) &gt;= 1">description: minimum cardinality of 'description' is 1</sch:assert>
      <sch:assert test="count(f:description) &lt;= 1">description: maximum cardinality of 'description' is 1</sch:assert>
      <sch:assert test="count(f:language) &lt;= 1">language: maximum cardinality of 'language' is 1</sch:assert>
      <sch:assert test="count(f:expression) &lt;= 1">expression: maximum cardinality of 'expression' is 1</sch:assert>
    </sch:rule>
  </sch:pattern>
  <sch:pattern>
    <sch:title>f:ChargeItemDefinition/f:propertyGroup/f:priceComponent</sch:title>
    <sch:rule context="f:ChargeItemDefinition/f:propertyGroup/f:priceComponent">
      <sch:assert test="count(f:code) &gt;= 1">code: minimum cardinality of 'code' is 1</sch:assert>
      <sch:assert test="count(f:amount) &gt;= 1">amount: minimum cardinality of 'amount' is 1</sch:assert>
    </sch:rule>
  </sch:pattern>
  <sch:pattern>
    <sch:title>f:ChargeItemDefinition/f:propertyGroup/f:priceComponent/f:code</sch:title>
    <sch:rule context="f:ChargeItemDefinition/f:propertyGroup/f:priceComponent/f:code">
      <sch:assert test="count(f:id) &lt;= 1">id: maximum cardinality of 'id' is 1</sch:assert>
      <sch:assert test="count(f:text) &gt;= 1">text: minimum cardinality of 'text' is 1</sch:assert>
      <sch:assert test="count(f:text) &lt;= 1">text: maximum cardinality of 'text' is 1</sch:assert>
    </sch:rule>
  </sch:pattern>
</sch:schema>
