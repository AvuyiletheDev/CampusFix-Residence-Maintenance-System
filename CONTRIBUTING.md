# Contributing to CampusFix

Thank you for your interest in contributing to the CampusFix Residence Maintenance System project.

## Project Overview

CampusFix is an ASP.NET Core MVC-based residence maintenance management system developed as part of the PGDip Software Engineering coursework project.

The system assists students, technicians, administrators, and maintenance teams in managing residence maintenance requests efficiently through a centralized platform.

Repository:  
https://github.com/AvuyiletheDev/CampusFix-Residence-Maintenance-System

---

## Getting Started

### Prerequisites

Before running the project, ensure you have the following installed:

- Visual Studio 2022 Community or Enterprise
- .NET 8 SDK
- SQL Server LocalDB or SQL Server Express
- Git
- ASP.NET Core Runtime

---

## Clone the Repository

```bash
git clone https://github.com/AvuyiletheDev/CampusFix-Residence-Maintenance-System.git
```

## Open the Project

1. Navigate to the cloned repository.
2. Open the solution file in Visual Studio 2022.
3. Restore all NuGet packages.
4. Build the solution.

---

## Running the Project

1. Open the solution in Visual Studio.
2. Restore NuGet packages.
3. Build the solution.
4. Run database migrations if applicable.
5. Start the application using IIS Express or Kestrel.
6. Open the Swagger documentation if enabled.

---

## Project Structure

```text
/src            -> Main application source code
/tests          -> Unit and integration tests
/DOC            -> Assignment reflections and documentation
/DiagramImages  -> UML, Mermaid, and architecture diagrams
/.github        -> GitHub workflows and CI/CD pipelines
```

---

## Coding Standards

Please follow these development standards:

- Use meaningful variable, method, and class names.
- Follow Microsoft C# naming conventions.
- Keep methods small and maintainable.
- Write clean and readable code.
- Add comments only where necessary.
- Ensure new functionality includes unit tests.
- Avoid duplicated code.
- Follow SOLID design principles where applicable.

---

## Branching Workflow

1. Fork the repository.
2. Create a new feature branch:

```bash
git checkout -b feature/my-feature
```

3. Make your changes.
4. Commit your changes:

```bash
git commit -m "Add feature or fix issue"
```

5. Push your branch:

```bash
git push origin feature/my-feature
```

6. Open a Pull Request against the `main` branch.

---

## Pull Request Requirements

Before submitting a Pull Request, ensure:

- The solution builds successfully.
- All tests pass successfully.
- No existing functionality is broken.
- Code is properly formatted.
- CI/CD checks pass.
- PR descriptions clearly explain the changes made.
- Screenshots are included for UI-related changes.

---

## Issue Labels

The repository uses the following issue labels:

| Label | Description |
|---|---|
| good-first-issue | Beginner-friendly tasks for contributors |
| feature-request | Proposed enhancements or new features |
| bug | Defects requiring fixes |
| documentation | Documentation improvements |
| enhancement | Improvements to existing functionality |
| testing | Tasks related to unit or integration testing |

---

## Features Open for Contribution

Contributors may assist with:

- UI/UX improvements
- Validation enhancements
- API improvements
- Additional unit testing
- Performance optimization
- Swagger/OpenAPI documentation
- Accessibility improvements
- Dashboard enhancements
- Reporting features

---

## Reporting Bugs

When reporting bugs, please include:

- Steps to reproduce the issue
- Expected behavior
- Actual behavior
- Screenshots if applicable
- Browser or environment information
- Error logs if available

---

## Suggesting Enhancements

Feature requests should include:

- Clear description of the feature
- Reason for the enhancement
- Proposed implementation idea, if applicable
- Screenshots or examples, if applicable

---

## Testing

Before submitting contributions:

1. Run all unit tests.
2. Verify API endpoints function correctly.
3. Ensure no breaking changes are introduced.
4. Verify GitHub Actions CI workflow passes successfully.

---

## Code of Conduct

Please be respectful and professional when collaborating on this project.

Constructive feedback and teamwork are encouraged.

---

## License

This project is licensed under the MIT License.

---

## Thank You

Thank you for contributing to CampusFix and helping improve the project for future contributors and users.
