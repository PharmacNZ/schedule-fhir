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
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-form']) &lt;= 0">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-form': maximum cardinality of 'extension' is 0</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-title']) &lt;= 0">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-title': maximum cardinality of 'extension' is 0</sch:assert>
      <sch:assert test="count(f:extension[@url = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-case-count']) &lt;= 0">extension with URL = 'https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-case-count': maximum cardinality of 'extension' is 0</sch:assert>
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
      <sch:assert test="count(f:code) &lt;= 0">code: maximum cardinality of 'code' is 0</sch:assert>
    </sch:rule>
  </sch:pattern>
  <sch:pattern>
    <sch:title>f:ChargeItemDefinition/f:extension</sch:title>
    <sch:rule context="f:ChargeItemDefinition/f:extension">
      <sch:assert test="count(f:id) &lt;= 1">id: maximum cardinality of 'id' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'type']) &gt;= 1">extension with URL = 'type': minimum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'type']) &lt;= 1">extension with URL = 'type': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:url) &gt;= 1">url: minimum cardinality of 'url' is 1</sch:assert>
      <sch:assert test="count(f:url) &lt;= 1">url: maximum cardinality of 'url' is 1</sch:assert>
      <sch:assert test="count(f:value[x]) &lt;= 0">value[x]: maximum cardinality of 'value[x]' is 0</sch:assert>
    </sch:rule>
  </sch:pattern>
  <sch:pattern>
    <sch:title>f:ChargeItemDefinition/f:extension/f:extension</sch:title>
    <sch:rule context="f:ChargeItemDefinition/f:extension/f:extension">
      <sch:assert test="count(f:id) &lt;= 1">id: maximum cardinality of 'id' is 1</sch:assert>
      <sch:assert test="count(f:url) &gt;= 1">url: minimum cardinality of 'url' is 1</sch:assert>
      <sch:assert test="count(f:url) &lt;= 1">url: maximum cardinality of 'url' is 1</sch:assert>
      <sch:assert test="count(f:value[x]) &lt;= 1">value[x]: maximum cardinality of 'value[x]' is 1</sch:assert>
      <sch:assert test="count(f:id) &lt;= 1">id: maximum cardinality of 'id' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'type']) &gt;= 1">extension with URL = 'type': minimum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'type']) &lt;= 1">extension with URL = 'type': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'value']) &lt;= 1">extension with URL = 'value': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'attribute']) &lt;= 1">extension with URL = 'attribute': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:extension[@url = 'href']) &lt;= 1">extension with URL = 'href': maximum cardinality of 'extension' is 1</sch:assert>
      <sch:assert test="count(f:url) &gt;= 1">url: minimum cardinality of 'url' is 1</sch:assert>
      <sch:assert test="count(f:url) &lt;= 1">url: maximum cardinality of 'url' is 1</sch:assert>
      <sch:assert test="count(f:value[x]) &lt;= 0">value[x]: maximum cardinality of 'value[x]' is 0</sch:assert>
    </sch:rule>
  </sch:pattern>
  <sch:pattern>
    <sch:title>f:ChargeItemDefinition/f:extension/f:extension/f:extension</sch:title>
    <sch:rule context="f:ChargeItemDefinition/f:extension/f:extension/f:extension">
      <sch:assert test="count(f:id) &lt;= 1">id: maximum cardinality of 'id' is 1</sch:assert>
      <sch:assert test="count(f:url) &gt;= 1">url: minimum cardinality of 'url' is 1</sch:assert>
      <sch:assert test="count(f:url) &lt;= 1">url: maximum cardinality of 'url' is 1</sch:assert>
      <sch:assert test="count(f:value[x]) &lt;= 1">value[x]: maximum cardinality of 'value[x]' is 1</sch:assert>
      <sch:assert test="count(f:id) &lt;= 1">id: maximum cardinality of 'id' is 1</sch:assert>
      <sch:assert test="count(f:url) &gt;= 1">url: minimum cardinality of 'url' is 1</sch:assert>
      <sch:assert test="count(f:url) &lt;= 1">url: maximum cardinality of 'url' is 1</sch:assert>
      <sch:assert test="count(f:id) &lt;= 1">id: maximum cardinality of 'id' is 1</sch:assert>
      <sch:assert test="count(f:url) &gt;= 1">url: minimum cardinality of 'url' is 1</sch:assert>
      <sch:assert test="count(f:url) &lt;= 1">url: maximum cardinality of 'url' is 1</sch:assert>
      <sch:assert test="count(f:value[x]) &lt;= 1">value[x]: maximum cardinality of 'value[x]' is 1</sch:assert>
      <sch:assert test="count(f:id) &lt;= 1">id: maximum cardinality of 'id' is 1</sch:assert>
      <sch:assert test="count(f:url) &gt;= 1">url: minimum cardinality of 'url' is 1</sch:assert>
      <sch:assert test="count(f:url) &lt;= 1">url: maximum cardinality of 'url' is 1</sch:assert>
      <sch:assert test="count(f:value[x]) &lt;= 1">value[x]: maximum cardinality of 'value[x]' is 1</sch:assert>
    </sch:rule>
  </sch:pattern>
  <sch:pattern>
    <sch:title>f:ChargeItemDefinition/f:propertyGroup/f:priceComponent/f:amount</sch:title>
    <sch:rule context="f:ChargeItemDefinition/f:propertyGroup/f:priceComponent/f:amount">
      <sch:assert test="count(f:id) &lt;= 1">id: maximum cardinality of 'id' is 1</sch:assert>
      <sch:assert test="count(f:value) &lt;= 1">value: maximum cardinality of 'value' is 1</sch:assert>
      <sch:assert test="count(f:currency) &lt;= 1">currency: maximum cardinality of 'currency' is 1</sch:assert>
    </sch:rule>
  </sch:pattern>
</sch:schema>
