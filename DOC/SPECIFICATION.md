# System Specification

## Project Title
CampusFix: Student Residence Maintenance and Incident Reporting System

## Domain
Higher Education Facilities and Residence Management

## Problem Statement
University student residences frequently experience maintenance issues such as broken appliances, water leaks, electricity failures, damaged infrastructure, and sanitation problems. In many institutions these issues are reported through informal channels such as phone calls, WhatsApp messages, or physical logbooks.

These approaches often result in lost requests, delayed responses, lack of accountability, and limited oversight by residence administrators.

A centralized digital platform is required to streamline the process of reporting, assigning, tracking, and resolving maintenance issues within student residences.

## Project Objectives

The objectives of this system are to:

- Provide students with an easy way to report maintenance issues
- Enable administrators to assign tasks to maintenance personnel
- Track issue progress and resolution status
- Improve maintenance response times
- Provide management with visibility through dashboards and reports

## Target Users

The system will support the following users:

### Students
Students living in residences who report maintenance issues.

### Residence Administrators
Responsible for reviewing submitted issues and assigning them to maintenance staff.

### Maintenance Staff
Technicians responsible for fixing the reported issues.

### System Administrator
Responsible for managing system configuration and users.

## System Scope

The system will provide the following core functionality:

- User authentication and login
- Maintenance issue reporting
- Issue categorization
- Image upload for issue evidence
- Task assignment by administrators
- Issue status tracking
- Dashboard and reporting tools

The first version will focus on core functionality suitable for development by a single developer.

## Proposed Technology Stack

### Frontend
- HTML
- CSS
- JavaScript

### Backend
- ASP.NET Core MVC using C#

### Native / Hardware Integration
- C++ module or service for future integration with machines, sensors, or physical devices

### Database
- SQL Server

### Hosting
- Cloud-based deployment or on-premises/server-side deployment, with the architecture designed to support both options

### File Storage
- Cloud storage or server-side file storage for images and supporting documents

### Notification
- Email service integration using Microsoft-based technologies, with future support for Azure-style notification services

## Functional Requirements

1. Users must be able to log into the system securely.
2. Students must be able to submit maintenance issue reports.
3. Students must be able to upload supporting images.
4. Issues must be categorized by type and priority.
5. Administrators must be able to view reported issues.
6. Administrators must be able to assign issues to maintenance staff.
7. Maintenance staff must be able to update repair progress.
8. The system must track issue status.
9. The system must provide a dashboard for administrators.
10. The system must maintain a record of issue history.

## Non-Functional Requirements

### Usability
The system must be easy to use for students and staff.

### Availability
The system must be accessible online when required.

### Performance
The system should respond quickly to user requests.

### Security
User authentication and authorization must be implemented.

### Scalability
The system must be able to support multiple residences.

### Maintainability
The system architecture should support future updates.

## Use Case Summary

| Use Case | Actor | Description |
|--------|------|-------------|
| Report Issue | Student | Student reports a maintenance problem |
| Upload Evidence | Student | Student uploads images of the issue |
| Assign Issue | Administrator | Administrator assigns issue to technician |
| Update Issue Status | Maintenance Staff | Staff updates repair progress |
| View Dashboard | Administrator | Administrator views system statistics |

## Assumptions

- Users have internet access.
- Students are registered within the system.
- Maintenance staff accounts are available.

## Constraints

- The system will initially be developed by one developer.
- Development time is limited to the academic semester.
- The first version will be web-based only.

## Future Enhancements

- Mobile application support
- Real-time notifications
- Predictive maintenance analytics
- Integration with campus infrastructure systems