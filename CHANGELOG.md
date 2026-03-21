# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

---

## [3.0.6] - 2026-03-21

### Changed
- CI/CD workflow refinements for automated publishing and coverage reporting
- Minor adjustments to Codecov configuration for status checks precision

## [3.0.5] - 2026-03-16

### Documentation

- Standardized `LICENSE` and `CI` badges across all project READMEs (English and Portuguese)

## [3.0.4] - 2026-03-15

### Removed

- Removed tools folder

## [3.0.3] - 2026-03-15

### Added

- `DaliboExplain` connector implementation in `MVFC.Connectors.Developer`

### Removed

- `MysqlExplain` connector implementation

### Tests

- Replaced `MysqlExplain` tests with `DaliboExplain` tests

## [3.0.2] -  2026-03-15

### Added

- MysqlExplain auth provider implementation

## [3.0.1] - 2026-03-16

### Changed

- Sicoob configuration updated to use ClientSecret instead of AccessToken

## [3.0.0] - 2026-03-15

### Added

- GitHub issue templates (bug report and feature request) and pull request template (`.github/`)
- CI workflow (`ci.yml`) with automated test execution
- `CONTRIBUTING.md` with contribution guidelines
- `SECURITY.md` with security policy
- `Directory.Build.target` for centralized build targets
- `codecov.yml` and `coverage.runsettings` for code coverage configuration
- `IImagemPollinationsProvider` interface in the IA (Pollinations) connector

### Changed

- Repository structure standardized across all `src/` and `tests/` projects
- `public` access modifier applied to interfaces and classes across all connectors
  (BancoData, BrasilApi, Sicoob, Conversores, Developer, Educacao, Financas, Geo, IA, Justica, Commons)
- `.editorconfig` expanded and restandarized
- `build.cake` refactored with pipeline improvements
- `Directory.Build.props` and `Directory.Packages.props` updated
- `.gitignore` updated
- `CobrancaBancaria`, `CobrancaBancariaPagamento` and `Pollinations` extension methods refactored
- `AuthTokenHandler` visibility and logic adjustments

### Removed

- `publish.yml` workflow removed (replaced by unified CI)

### Tests

- Expanded test coverage for: BancoData (Bruto and Tratado), BrasilApi (Bancos,
  CEP, CNPJ, Cambio, Corretoras, CPTEC, DDD, Feriado, FIPE, IBGE, ISBN, NCM, PIX, RegistroBR)
- Test structure refactored following the Arrange-Act-Assert pattern

## [2.1.4] - 2026-02-19

### Added
- Added MetaPackage support, allowing consumers to reference all `MVFC.Connectors.*` packages
  through a single unified package reference.

---

## [2.1.3] - 2026-02-19

### Added
- Added MetaPackage support (re-tag of 2.1.2 to correct versioning alignment).

---

## [2.1.2] - 2026-02-19

### Added
- Added MetaPackage support (initial tag for this feature set).

---

## [2.1.1] - 2026-01-19

### Added
- Added `MVFC.Connectors.Educacao` package with initial implementation for
  education-domain API connectors.

### Documentation
- Updated all package README files to reflect the .NET framework version
  in use and align with current project standards.

---

## [2.1.0] - 2026-01-19

### Added
- Added initial support for the Brazilian Central Bank (Banco Central do Brasil) API
  (`MVFC.Connectors.Financas`), enabling access to economic indicators, currency rates
  and financial data endpoints.

### Fixed
- Removed unnecessary `using` directive that was leaking into the public API surface.

---

## [2.0.5] - 2026-01-08

### Fixed
- Added SSL error bypass option in the HTTP client factory to handle self-signed or
  untrusted certificates in controlled environments (e.g., internal networks, staging).

---

## [2.0.4] - 2026-01-07

### Changed
- Migrated solution file from legacy `.sln` format to the new `.slnx` format
  introduced in Visual Studio 2022 / MSBuild 17.

---

## [2.0.3] - 2026-01-04

### Removed
- Removed an unused third-party library dependency, reducing the NuGet package
  size and eliminating unnecessary transitive dependencies.

### Documentation
- Fixed incorrect or outdated sections across multiple package README files.

---

## [2.0.2] - 2026-01-03

### Improved
- Replaced the previous serialization approach with a more robust and efficient
  JSON serialization strategy (`System.Text.Json`) for all HTTP request/response
  payloads across connectors.

---

## [2.0.1] - 2026-01-03

### Fixed
- Reduced the package icon file size to comply with NuGet icon size recommendations
  and decrease package download footprint.

---

## [2.0.0] - 2026-01-03

### Added
- Added `MVFC.Connectors.BancoData` package with initial connector implementation
  for the BancoData financial API.

### Documentation
- Updated project README with new v2 structure, available packages, and usage examples.

> ⚠️ **Breaking Changes:** This version introduces a major structural reorganization.
> All packages were re-namespaced and individual connector projects are now clearly
> domain-segregated (`BrasilApi`, `BancoData`, `Financas`, `Geo`, `IA`, `Justica`, `Sicoob`, etc.).

---

## [1.2.0] - 2025-11-16

### Added
- Added support for **.NET 10.0** across all packages in the solution,
  ensuring forward compatibility with the upcoming LTS release.

---

## [1.1.1] - 2025-11-10

### Added
- Added a new API connector within `MVFC.Connectors.BrasilApi` domain.

---

## [1.1.0] - 2025-11-10

### Added
- Added new API endpoints and connectors to the `MVFC.Connectors.BrasilApi` package,
  covering additional public data sources available through the BrasilAPI ecosystem.

### Fixed
- Corrected domain entity naming conventions across the `BrasilApi` connector,
  improving consistency with the upstream API contracts.

---

## [1.0.0] - 2025-11-10

### Added
- Initial project structure with solution, `Directory.Build.props`, `Directory.Packages.props`,
  `.editorconfig`, and CI/CD scaffolding via `build.cake`.
- First connector packages introduced:
  - `MVFC.Connectors.BrasilApi` — connector for the public BrasilAPI
  - `MVFC.Connectors.Commons` — shared utilities, base HTTP client factory and abstractions
  - `MVFC.Connectors.Conversores` — Brazilian currency/unit converters
  - `MVFC.Connectors.Developer` — developer-oriented tools and sandbox endpoints
  - `MVFC.Connectors.Financas` — financial data connectors (exchange rates, economic indices)
  - `MVFC.Connectors.Geo` — geolocation and address API connectors
  - `MVFC.Connectors.IA` — AI/ML API connectors
  - `MVFC.Connectors.Justica` — Brazilian justice system data connectors

---

[3.0.6]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v3.0.5...v3.0.6
[3.0.5]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v3.0.4...v3.0.5
[3.0.4]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v3.0.3...v3.0.4
[3.0.3]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v3.0.2...v3.0.3
[3.0.2]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v3.0.1...v3.0.2
[3.0.1]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v3.0.0...v3.0.1
[3.0.0]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v2.1.4...v3.0.0
[2.1.4]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v2.1.3...v2.1.4
[2.1.3]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v2.1.2...v2.1.3
[2.1.2]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v2.1.1...v2.1.2
[2.1.1]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v2.1.0...v2.1.1
[2.1.0]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v2.0.5...v2.1.0
[2.0.5]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v2.0.4...v2.0.5
[2.0.4]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v2.0.3...v2.0.4
[2.0.3]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v2.0.2...v2.0.3
[2.0.2]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v2.0.1...v2.0.2
[2.0.1]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v2.0.0...v2.0.1
[2.0.0]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v1.2.0...v2.0.0
[1.2.0]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v1.1.1...v1.2.0
[1.1.1]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v1.1.0...v1.1.1
[1.1.0]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/compare/v1.0.0...v1.1.0
[1.0.0]: https://github.com/Marcus-V-Freitas/MVFC.Connectors/releases/tag/v1.0.0
