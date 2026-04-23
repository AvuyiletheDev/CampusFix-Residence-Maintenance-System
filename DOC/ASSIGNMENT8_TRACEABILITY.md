# Assignment 8 Traceability Matrix  
## CampusFix Residence Maintenance System

## Overview
This document establishes traceability between Assignment 8 diagrams and prior project artifacts, ensuring alignment with:

- Functional Requirements (Assignment 4)
- Use Cases (Assignment 5)
- User Stories (Assignment 6)

Traceability ensures that all system behavior modeled in state and activity diagrams is directly linked to stakeholder needs and system functionality.

---

## Traceability Matrix

| Diagram | Functional Requirement (A4) | Use Case (A5) | User Story (A6) |
|--------|----------------------------|--------------|----------------|
| Maintenance Request State Diagram | FR-001 Submit Maintenance Request | UC-01 Submit Maintenance Request | US-001 Create maintenance request |
| Maintenance Request State Diagram | FR-002 Review Request | UC-02 Review Request | US-002 Review submitted requests |
| Maintenance Request State Diagram | FR-004 Assign Technician | UC-03 Assign Technician | US-004 Assign technician to request |
| Maintenance Request State Diagram | FR-006 Close Request | UC-05 Resolve Maintenance Issue | US-006 Close maintenance request |
| Work Order State Diagram | FR-004 Assign Technician | UC-03 Assign Technician | US-004 Assign technician |
| Work Order State Diagram | FR-005 Track Progress | UC-04 Update Maintenance Progress | US-005 Update repair progress |
| Residence Room Issue State Diagram | FR-003 Log Issue | UC-01 Submit Maintenance Request | US-001 Submit issue |
| User Account State Diagram | FR-007 User Registration & Login | UC-06 User Authentication | US-007 User login and registration |
| Technician Assignment State Diagram | FR-004 Assign Technician | UC-03 Assign Technician | US-004 Assign technician |
| Notification State Diagram | FR-008 Send Notifications | UC-07 Notify Users | US-008 Receive notifications |
| Feedback Record State Diagram | FR-009 Submit Feedback | UC-08 Submit Feedback | US-009 Provide feedback |
| Asset/Equipment State Diagram | FR-010 Manage Equipment | UC-09 Manage Equipment | US-010 Track equipment usage |

---

## Activity Diagram Traceability

| Activity Workflow | Functional Requirement (A4) | Use Case (A5) | User Story (A6) |
|------------------|----------------------------|--------------|----------------|
| Student Submits Request | FR-001 Submit Request | UC-01 Submit Request | US-001 Create request |
| Admin Reviews Request | FR-002 Review Request | UC-02 Review Request | US-002 Review requests |
| Assign Technician Workflow | FR-004 Assign Technician | UC-03 Assign Technician | US-004 Assign technician |
| Technician Updates Progress | FR-005 Track Progress | UC-04 Update Progress | US-005 Update progress |
| Technician Marks Resolved | FR-006 Resolve Issue | UC-05 Resolve Issue | US-006 Complete repair |
| Student Confirms/Reopens | FR-006 Close/Reopen Request | UC-05 Resolve Issue | US-006 Confirm or reopen |
| Admin Generates Report | FR-011 Generate Reports | UC-10 Generate Reports | US-011 Generate maintenance reports |
| Notification Workflow | FR-008 Send Notifications | UC-07 Notify Users | US-008 Receive notifications |

---

## Summary

This traceability matrix demonstrates that:

- All diagrams in Assignment 8 are directly derived from earlier system requirements.
- Each workflow and object behavior supports a defined system function.
- The system design maintains consistency across all stages of development.

This ensures strong alignment between system design, stakeholder requirements, and Agile implementation planning.