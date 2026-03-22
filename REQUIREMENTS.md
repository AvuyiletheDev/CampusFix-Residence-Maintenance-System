# System Requirements Document (SRD)
## CampusFix – Residence Maintenance System

---

# 1. Introduction

CampusFix is a web-based maintenance management system designed to streamline the reporting, tracking, and resolution of maintenance issues within university residences.

---

# 2. Functional Requirements

## 2.1 Core Functional Requirements

FR1: The system shall allow students to log maintenance issues via a web interface.  
Acceptance Criteria:
- Issue submission must take ≤ 2 minutes
- Required fields must be validated before submission

---

FR2: The system shall categorize issues (e.g., plumbing, electrical, furniture).  
Acceptance Criteria:
- Categories must be selectable via dropdown
- Categories must be configurable by admin

---

FR3: The system shall assign reported issues to maintenance staff automatically or manually.  
Acceptance Criteria:
- Assignment must occur within ≤ 5 seconds
- Assigned staff must receive notification within system

---

FR4: The system shall provide real-time status tracking of issues.  
Acceptance Criteria:
- Status updates must reflect immediately after change
- Users must see statuses: Logged, In Progress, Completed

---

FR5: The system shall provide an internal messaging module for communication between users.  
Acceptance Criteria:
- Messages must be delivered in ≤ 2 seconds
- Users must be able to view conversation history

---

FR6: The system shall allow maintenance staff to update issue progress and mark completion.  
Acceptance Criteria:
- Updates must be timestamped
- Completion must require confirmation

---

FR7: The system shall allow administrators to generate reports on maintenance activities.  
Acceptance Criteria:
- Reports must be downloadable
- Reports must include issue counts, resolution times

---

FR8: The system shall allow uploading of images for maintenance issues.  
Acceptance Criteria:
- Minimum of 3 images per issue
- Images must be viewable in system

---

FR9: The system shall maintain a history log of all issues and actions.  
Acceptance Criteria:
- Logs must be immutable
- Logs must include user, action, timestamp

---

FR10: The system shall support role-based access control.  
Acceptance Criteria:
- Users must only access permitted features
- Roles: Student, Staff, Admin

---

FR11: The system shall provide notification modules for future SMS and Email integration.  
Acceptance Criteria:
- Notification service must be modular
- Internal messaging must function independently

---

# 3. Non-Functional Requirements

## 3.1 Usability
NFR1: The system shall provide an intuitive and user-friendly interface.  
NFR2: The interface shall be accessible on both desktop and mobile devices.

---

## 3.2 Deployability
NFR3: The system shall be deployable on Windows-based servers using ASP.NET Core.  
NFR4: The system shall support cloud or on-premise deployment.

---

## 3.3 Maintainability
NFR5: The system shall be modular to allow future integration of SMS/Email services.  
NFR6: Documentation shall include API and system architecture guides.

---

## 3.4 Scalability
NFR7: The system shall support at least 1000 concurrent users.  
NFR8: The system shall handle increasing load without performance degradation.

---

## 3.5 Security
NFR9: All user data shall be encrypted in transit (HTTPS).  
NFR10: Authentication shall require secure login with role-based authorization.

---

## 3.6 Performance
NFR11: System response time shall be ≤ 2 seconds for standard operations.  
NFR12: Issue logging shall complete within ≤ 5 seconds.

---

# 4. Traceability (Distinction Level)

| Stakeholder | Requirement |
|------------|------------|
| Students | FR1, FR4, FR5 |
| Maintenance Staff | FR3, FR6 |
| Admin | FR7, FR10 |
| IT | NFR3, NFR5 |
| Management | FR7, NFR7 |
| Contractors | FR3 |

---