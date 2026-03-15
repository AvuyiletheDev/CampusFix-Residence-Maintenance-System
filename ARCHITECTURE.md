# System Architecture

## Project Title
CampusFix: Student Residence Maintenance and Incident Reporting System

## Domain
Higher Education Facilities Management

## Problem Statement
Student residences frequently experience maintenance issues that are poorly tracked due to informal reporting systems. CampusFix introduces a structured digital platform for issue reporting, assignment, tracking, and resolution.

## Feasibility
The project is feasible for individual development because it focuses on core functionality such as issue reporting, assignment, and status tracking. More advanced features can be added in future versions.

---

# Architecture Overview

CampusFix follows a web-based architecture that separates the user interface, application logic, and data storage.

The architecture includes:

- Web Application (User Interface)
- Backend Application Services
- Database
- File Storage
- Notification Service

---


# C4 Architecture Model

## Level 1 – System Context Diagram

![Level 1 System Context Diagram](DiagramImages/Level%201%20Diagram.png)

## Level 2 – Container Diagram

![Level 2 Container Diagram](DiagramImages/Level%202%20Diagram.png)

## Level 3 – Component Diagram

![Level 3 Component Diagram](DiagramImages/Level%203%20Diagram.png)

# End-to-End System Workflow

1. Student logs into the system.
2. Student submits a maintenance issue.
3. Issue is stored in the database.
4. Administrator reviews the issue.
5. Administrator assigns the issue to maintenance staff.
6. Maintenance staff update repair progress.
7. Notification service sends updates.
8. Dashboard displays system statistics.

---

# Architectural Benefits

- Clear separation of concerns
- Scalable architecture
- Supports future integration with physical devices
- Easy maintenance and upgrades