# fhir-usage

A sample .NET console application for querying the PHARMAC Schedule FHIR API.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- The FHIR server running locally 

## FHIR Examples

This FHIR API runs in docker.

The server will be available at `http://localhost:8080/fhir/r4`

It can be spun up locally, and will be seeded with data located in the .fhir-seed folder.

A list of the fhir endpoints is available in fhir-server.http

Start the FHIR server with:

```bash
cd /workspaces/schedule-fhir
docker compose up
```
If the server hangs on 'Attaching to fhir-candle' then it probably closed badly last time.

Use `Ctrl + C` to cancel the action and try starting the server again.

## Running the app

From the workspace root or the project directory:

```bash
dotnet run --project examples/fhir-usage/fhir-usage.csproj <command> [options]
```
If you are in the project directory you can skip the --project flag.

## Commands

### `metadata`

Fetches the FHIR server capability statement.
This is too long for the console window, so instead saves to the file metadata.json

```bash
dotnet run metadata
```

---

### `search`

Searches for FHIR resources. Requires `--resource`.

```bash
dotnet run search --resource <ResourceType> [options]
```

#### Options

| Option | Alias | Description |
|--------|-------|-------------|
| `--resource` | `--r` | **(Required)** Resource type to search. See supported types below. |
| `--name` | `--n` | Filter by name, e.g. `Leuprorelin` |
| `--id` | `--i` | Filter by resource ID, e.g. `SA9999` |
| `--brand` | `--b` | Filter by brand name, e.g. `Ricovir` |
| `--category` | `--c` | Filter by category, e.g. `Special Foods` |
| `--instance` | `--ins` | Filter by instance, e.g. `Ricovir-Tenofovir` |
| `--lastUpdated` | `--lu` | Filter by last updated date (inclusive), e.g. `2024-01-01` |
| `--authSchema` | `--a` | Decode and write the authorisation schema of the result to file |

## Resource types

### `Medication`

| Goal | Options required |
|------|-----------------|
| List all medications | _(none)_ |
| Search by name | `--name <value>` |
| Search by ID | `--id <value>` |
| Search by brand | `--brand <value>` |
| Search by category | `--category <value>` |
| Search by instance | `--instance <value>` |
| Filter by last updated | `--lastUpdated <date>` |

```bash
dotnet run search --resource Medication
dotnet run search --resource Medication --name Leuprorelin
dotnet run search --resource Medication --id Medication-Lucrin-Depot-1-Month
dotnet run search --resource Medication --brand Ricovir
dotnet run search --resource Medication --category "Special Foods"
dotnet run search --resource Medication --instance Ricovir-Tenofovir
dotnet run search --resource Medication --lastUpdated 2024-01-01
```

---

### `SpecialAuthority`

| Goal | Options required |
|------|-----------------|
| List all Special Authorities | _(none)_ |
| Get by ID | `--id <value>` |
| Get by ID and decode authorization schema | `--id <value> --authSchema` |
| Search by instance | `--instance <value>` |
| Filter by last updated | `--lastUpdated <date>` |

```bash
dotnet run search --resource SpecialAuthority
dotnet run search --resource SpecialAuthority --id SA9999
dotnet run search --resource SpecialAuthority --id SA9999 --authSchema
dotnet run search --resource SpecialAuthority --instance Ricovir-Tenofovir
dotnet run search --resource SpecialAuthority --lastUpdated 2024-01-01
```

---

### `FundingRule`

| Goal | Options required |
|------|-----------------|
| List all Funding Rules | _(none)_ |
| Get by ID | `--id <value>` |
| Get by ID and decode authorization schema | `--id <value> --authSchema` |
| Search by instance | `--instance <value>` |
| Filter by last updated | `--lastUpdated <date>` |

```bash
dotnet run search --resource FundingRule
dotnet run search --resource FundingRule --id ChargeItemDefinition-Hospital-Sequence-1
dotnet run search --resource FundingRule --id ChargeItemDefinition-Hospital-Sequence-1 --authSchema
dotnet run search --resource FundingRule --instance Ricovir-Tenofovir
dotnet run search --resource FundingRule --lastUpdated 2024-01-01
```

---

### `PricingRule`

| Goal | Options required |
|------|-----------------|
| List all Pricing Rules | _(none)_ |
| Get by ID | `--id <value>` |
| Search by instance | `--instance <value>` |
| Filter by last updated | `--lastUpdated <date>` |

```bash
dotnet run search --resource PricingRule
dotnet run search --resource PricingRule --id ChargeItemDefinition-Ricovir-Pricing
dotnet run search --resource PricingRule --instance Ricovir-Tenofovir
dotnet run search --resource PricingRule --lastUpdated 2024-01-01
```

## Project structure

```
fhir-usage/
├── Program.cs               # CLI entry point and command routing
└── Actions/
    ├── IAction.cs           # Action interface
    ├── IFhirClient.cs       # FHIR client abstraction
    ├── FhirClientAdapter.cs # Wraps the Firely FHIR client
    ├── HelperFunctions.cs   # Shared utilities
    ├── GetMetadata.cs       # Return the FHIR server Capability Statement
    ├── GetAll*.cs           # List all resources of a type
    ├── GetMedicationBy*.cs  # Medication search variants
    ├── GetSABy*.cs          # Special Authority search variants
    ├── GetFunding*.cs       # Funding Rule search variants
    └── GetPricing*.cs       # Pricing Rule search variants
```

## Running tests

From the workspace root or the project directory:

```bash
dotnet test examples/fhir-usage.Tests/fhir-usage.Tests.csproj
```
If you are in the project directory you can skip specifying the project.

If you want to run a single test, you will need to specify the class and method name:

```bash
dotnet test --filter "FullyQualifiedName=GetAllFundingRulesTests.Execute_NoFilter_AddsProfileParam"
```