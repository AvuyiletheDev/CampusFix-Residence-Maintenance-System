# Changelog

## Assignment 10

- Migrated CampusFix project to ASP.NET Core MVC (Visual Studio Community)
- Organized project structure into src, DOC, and tests
- Implemented core domain classes (Student, Technician, Admin, MaintenanceRequest, etc.)
- Implemented creational design patterns:
  - Simple Factory
  - Factory Method
  - Abstract Factory
  - Builder
  - Prototype
  - Singleton
- Added unit tests for all design patterns using xUnit
- Successfully executed all tests (13/13 passed)
- Improved repository structure and Git tracking (.gitignore fixes)

### Note to Lecturer
Kindly refer to the document located at:

`DOC/ASSIGNMENT10_REFLECTION.md`

This document provides a detailed reflection on the design decisions, implementation approach, challenges encountered, and testing outcomes for Assignment 10. 

# Assignment 12

- Added CampusFix.Application layer
- Implemented service layer architecture
- Added StudentService
- Added TechnicianService
- Added MaintenanceRequestService
- Configured dependency injection
- Implemented Swagger/OpenAPI integration
- Added REST API controllers
- Added StudentsApiController
- Added TechniciansApiController
- Added MaintenanceRequestsApiController
- Implemented CRUD REST endpoints
- Successfully tested API endpoints using Swagger UI
- Implemented API validation handling
- Improved layered architecture and separation of concerns

DOC/ASSIGNMENT12_REFLECTION.md`

This document provides a detailed reflection on the design decisions, implementation approach, challenges encountered, and testing outcomes for Assignment 12.

## Assignment 13

- Added GitHub Actions CI/CD workflow for CampusFix.
- Configured workflow to run on push and pull requests to `main`.
- Automated dependency restore, build, and unit test execution.
- Configured release artifact generation for the CampusFix web application.
- Verified successful GitHub Actions workflow run.
- Added branch protection rules for the `main` branch.
- Required pull requests and approvals before merging.
- Added Assignment 13 documentation:
  - `DOC/PROTECTION.md`
  - `DOC/CI_CD_WORKFLOW.md`
  - `DOC/ASSIGNMENT13_REFLECTION.md`

  - Added Assignment 13 evidence screenshots in the `Assignment13` images folder, including:
  - Successful GitHub Actions workflow execution
  - Generated CI/CD release artifact
  - Branch protection configuration
  - Pull request workflow validation