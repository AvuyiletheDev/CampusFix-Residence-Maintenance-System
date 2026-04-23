# CampusFix Residence Maintenance System – Domain Model

## 1. Introduction
CampusFix is a residence maintenance management system designed to help students report maintenance issues in their campus residences, while allowing administrators and technicians to review, assign, track, and resolve those issues efficiently. This domain model identifies the core business entities, their attributes, responsibilities, relationships, and business rules.

The model aligns with the earlier CampusFix assignments by supporting the key requirements, use cases, agile user stories, and behavioral workflows already defined for the project.

## 2. Domain Entities

| Entity | Attributes | Responsibilities / Methods | Relationships |
|---|---|---|---|
| **Student** | studentId, fullName, email, phoneNumber, passwordHash, accountStatus | register(), login(), submitRequest(), viewRequestStatus(), confirmResolution(), reopenRequest() | Belongs to one Residence; occupies one Room; creates many MaintenanceRequests |
| **Residence** | residenceId, residenceName, campus, address, genderCategory, totalRooms | addRoom(), findRoom(), getResidents(), getRequests() | Contains many Rooms; houses many Students |
| **Room** | roomId, roomNumber, floorNumber, roomType, occupancyStatus | assignStudent(), updateOccupancy(), reportIssue() | Belongs to one Residence; may be occupied by one Student; linked to many MaintenanceRequests |
| **MaintenanceRequest** | requestId, title, description, category, priority, status, dateCreated, dateUpdated, studentId, roomId, technicianId | submit(), review(), approve(), reject(), assignTechnician(), startRepair(), markResolved(), closeRequest(), reopen() | Created by one Student; linked to one Room; may be assigned to one Technician; managed by one Admin; contains many MaintenanceUpdates |
| **Technician** | technicianId, fullName, email, phoneNumber, specialization, availabilityStatus | viewAssignedRequests(), acceptAssignment(), updateProgress(), completeRepair() | Handles many MaintenanceRequests; writes many MaintenanceUpdates |
| **Admin** | adminId, fullName, email, role, officeLocation | reviewRequest(), approveRequest(), rejectRequest(), assignTechnician(), generateReport() | Manages many MaintenanceRequests |
| **MaintenanceUpdate** | updateId, requestId, note, statusSnapshot, timestamp, updatedByRole | addNote(), recordStatusChange() | Belongs to one MaintenanceRequest; created by Admin or Technician |

## 3. Entity Descriptions

### 3.1 Student
The Student is the main end-user of CampusFix. A student uses the system to log maintenance complaints, track progress, confirm whether a repair has been completed, and reopen requests if the issue was not properly resolved.

### 3.2 Residence
Residence represents the physical student housing facility in which rooms are located. It groups rooms and students together and provides the location context for maintenance reporting.

### 3.3 Room
A Room represents the specific physical place where a maintenance issue occurs. Linking a request to a room helps ensure accurate dispatching, room-level issue history, and better reporting.

### 3.4 MaintenanceRequest
MaintenanceRequest is the core domain entity in CampusFix. It captures the maintenance problem submitted by a student, tracks its lifecycle from submission to closure, and records who is responsible for handling it.

### 3.5 Technician
The Technician is responsible for carrying out repairs assigned by the administrator. A technician updates request progress, records work completed, and marks requests as resolved when repairs are done.

### 3.6 Admin
The Admin acts as the coordinator of the process. This role reviews requests, validates submitted information, approves or rejects requests, assigns technicians, and monitors overall system performance.

### 3.7 MaintenanceUpdate
MaintenanceUpdate keeps a history of status changes and notes added during the maintenance process. It improves traceability, communication, and accountability.

## 4. Relationships Between Entities

### Main relationships
- A **Residence** contains many **Rooms**.
- A **Residence** houses many **Students**.
- A **Student** occupies one **Room**.
- A **Student** can create many **MaintenanceRequests**.
- A **Room** can be associated with many **MaintenanceRequests** over time.
- A **MaintenanceRequest** may be assigned to one **Technician** at a time.
- An **Admin** manages and assigns many **MaintenanceRequests**.
- A **MaintenanceRequest** contains many **MaintenanceUpdates**.
- A **Technician** or **Admin** can create **MaintenanceUpdates**.

## 5. Business Rules

1. A student may submit a maintenance request only for the room assigned to them.
2. Every maintenance request must be linked to exactly one student and one room.
3. A maintenance request must have a valid category, description, and status.
4. A request can only be assigned to one technician at a time.
5. A technician may handle multiple requests, depending on availability and specialization.
6. Only an admin may approve, reject, or assign a maintenance request.
7. A request may move through valid states such as Draft, Submitted, UnderReview, Approved, Assigned, InProgress, Resolved, Closed, and Reopened.
8. A resolved request can only be closed after student confirmation or administrative completion rules are satisfied.
9. A rejected request cannot move directly to Assigned unless it is reopened or resubmitted.
10. Each major status change should be recorded through a MaintenanceUpdate entry.

## 6. Alignment with Previous Assignments

This domain model supports the earlier CampusFix work as follows:

- **Assignment 4 (Requirements):** The entities reflect core functional requirements such as submitting requests, assigning technicians, tracking status, and managing maintenance workflows.
- **Assignment 5 (Use Cases):** Key use cases such as Submit Request, Review Request, Assign Technician, Update Progress, Resolve Request, and Confirm Resolution are represented through entity responsibilities.
- **Assignment 6 (Agile Planning):** User stories are translated into object responsibilities and interactions between classes.
- **Assignment 8 (State and Activity Modeling):** The request lifecycle and workflow actions are directly reflected in the MaintenanceRequest methods and status-related business rules.

## 7. Conclusion
The CampusFix domain model captures the most important structural elements of the residence maintenance system. It provides a strong foundation for class diagram development, object-oriented implementation, and future coding activities in the next assignments.
