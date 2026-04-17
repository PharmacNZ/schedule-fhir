<?xml version="1.0" encoding="UTF-8"?>
<sch:schema xmlns:sch="http://purl.oclc.org/dsdl/schematron" queryBinding="xslt2">
  <sch:ns prefix="f" uri="http://hl7.org/fhir"/>
  <sch:ns prefix="h" uri="http://www.w3.org/1999/xhtml"/>
  <!-- 
    This file contains just the constraints for the profile PharmacChargeItemDefinition
    It includes the base constraints for the resource as well.
    Because of the way that schematrons and containment work, 
    you may need to use this schematron fragment to build a, 
    single schematron that validates contained resources (if you have any) 
  -->
  <sch:pattern>
    <sch:title>f:ChargeItemDefinition</sch:title>
    <sch:rule context="f:ChargeItemDefinition">
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-effective-date': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-expiry-date']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-expiry-date': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-form']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-form': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-title']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-title': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-case-count']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-case-count': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/cost-brand-source']) &lt;= 0">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/cost-brand-source': maximum cardinality of 'extension' is 0</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/wastage-claimable']) &lt;= 0">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/wastage-claimable': maximum cardinality of 'extension' is 0</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/contract-type']) &lt;= 0">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/contract-type': maximum cardinality of 'extension' is 0</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/dv-limit-percent']) &lt;= 0">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/dv-limit-percent': maximum cardinality of 'extension' is 0</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/brand-switch-fee']) &lt;= 0">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/brand-switch-fee': maximum cardinality of 'extension' is 0</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/statim']) &lt;= 0">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/statim': maximum cardinality of 'extension' is 0</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/in-combination']) &lt;= 0">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/in-combination': maximum cardinality of 'extension' is 0</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-schema']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-schema': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-section-29']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-section-29': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-not-combined']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-not-combined': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-copayment-max']) &lt;= 1">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pricing-copayment-max': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:code) &gt;= 1">code: minimum cardinality of 'code' is 1</sch:assert>
      <sch:assert test="count(f:instance) &gt;= 1">instance: minimum cardinality of 'instance' is 1</sch:assert>
    </sch:rule>
  </sch:pattern>
  <sch:pattern>
    <sch:title>f:ChargeItemDefinition/f:code</sch:title>
    <sch:rule context="f:ChargeItemDefinition/f:code">
      <sch:assert test="count(f:id) &lt;= 1">id: maximum cardinality of 'id' is 1</sch:assert>
      <sch:assert test="count(f:coding) &gt;= 1">coding: minimum cardinality of 'coding' is 1</sch:assert>
      <sch:assert test="count(f:text) &gt;= 1">text: minimum cardinality of 'text' is 1</sch:assert>
      <sch:assert test="count(f:text) &lt;= 1">text: maximum cardinality of 'text' is 1</sch:assert>
    </sch:rule>
  </sch:pattern>
  <sch:pattern>
    <sch:title>f:ChargeItemDefinition/f:code/f:coding</sch:title>
    <sch:rule context="f:ChargeItemDefinition/f:code/f:coding">
      <sch:assert test="count(f:id) &lt;= 1">id: maximum cardinality of 'id' is 1</sch:assert>
      <sch:assert test="count(f:system) &gt;= 1">system: minimum cardinality of 'system' is 1</sch:assert>
      <sch:assert test="count(f:system) &lt;= 1">system: maximum cardinality of 'system' is 1</sch:assert>
      <sch:assert test="count(f:version) &lt;= 1">version: maximum cardinality of 'version' is 1</sch:assert>
      <sch:assert test="count(f:code) &gt;= 1">code: minimum cardinality of 'code' is 1</sch:assert>
      <sch:assert test="count(f:code) &lt;= 1">code: maximum cardinality of 'code' is 1</sch:assert>
      <sch:assert test="count(f:display) &lt;= 1">display: maximum cardinality of 'display' is 1</sch:assert>
      <sch:assert test="count(f:userSelected) &lt;= 1">userSelected: maximum cardinality of 'userSelected' is 1</sch:assert>
    </sch:rule>
  </sch:pattern>
</sch:schema>
