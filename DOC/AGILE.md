# AGILE.md

# CampusFix Residence Maintenance System
## Agile Planning Document – Assignment 6

**Student:** Avuyile Ngalwa  
**Module:** Software Engineering  
**Assignment:** Assignment 6 – Agile User Stories, Backlog, and Sprint Planning  
**Project:** CampusFix – Residence Maintenance System

---

## 1. Introduction

This document translates the system requirements from Assignment 4 and the use cases from Assignment 5 into Agile development artifacts for the **CampusFix Residence Maintenance System**. The aim is to apply Agile methodology by creating user stories, building a prioritized product backlog, and planning the first sprint for the Minimum Viable Product (MVP).

CampusFix is a residence maintenance management system designed to help students report maintenance problems, enable residence staff to review and assign requests, and allow technicians to update progress until completion.

This document maintains continuity with Assignments 3–5 by preserving the same system scope, stakeholder focus, and system behavior.

---

## 2. User Stories

The following user stories were derived from the functional requirements and use cases created in previous assignments. They follow the Agile user story format:

> **As a [role], I want [action] so that [benefit].**

### 2.1 User Stories Table

| Story ID | User Story | Acceptance Criteria | Priority |
|----------|------------|---------------------|----------|
| US-001 | As a student, I want to submit a maintenance request so that issues in my residence can be fixed quickly. | Request form must validate required fields; request must be saved successfully; confirmation message must be displayed. | High |
| US-002 | As a student, I want to view my submitted requests so that I can track the progress of reported issues. | Student must see a list of submitted requests; each request must show status, date, and issue category; page loads in ≤ 2 seconds. | High |
| US-003 | As a residence manager, I want to review maintenance requests so that I can verify and process valid issues. | Manager can open and review requests; approve or reject action must be available; decision must be stored. | High |
| US-004 | As a residence manager, I want to assign maintenance requests to technicians so that work is distributed efficiently. | Manager can select a technician; assignment must be saved; assigned request must appear in technician queue. | High |
| US-005 | As a technician, I want to view tasks assigned to me so that I know what work I am responsible for. | Technician must see assigned tasks only; tasks must display issue details, location, and status. | High |
| US-006 | As a technician, I want to update the status of a task so that progress can be tracked until completion. | Technician must be able to change status to In Progress, Pending, or Completed; update must be saved immediately. | High |
| US-007 | As an administrator, I want to manage user accounts so that system access is controlled correctly. | Admin can create, edit, activate, and deactivate users; changes must be saved and reflected in the system. | High |
| US-008 | As a user, I want to log into the system securely so that unauthorized users cannot access maintenance information. | Valid credentials must allow login; invalid credentials must be rejected; protected pages require login. | High |
| US-009 | As a student, I want to receive updates when my maintenance request status changes so that I stay informed. | Notifications must be triggered when request status changes; updated status must be visible on request history. | Medium |
| US-010 | As a residence manager, I want to view maintenance reports so that I can monitor workload and recurring issues. | Reports must display total requests, status distribution, and issue categories; filters must be available. | Medium |
| US-011 | As a system administrator, I want user data protected so that the system remains secure and compliant. | Sensitive data must be encrypted; password storage must be secure; unauthorized access must be prevented. | High |
| US-012 | As a user, I want the system to respond quickly so that I have a smooth and efficient experience. | Main pages must load in ≤ 2 seconds under normal usage conditions. | Medium |

---

## 3. INVEST Compliance

The user stories above were refined to align with the **INVEST** principle:

- **Independent:** Each story delivers a distinct piece of value.
- **Negotiable:** Stories can be adjusted as development progresses.
- **Valuable:** Each story benefits a real system user.
- **Estimable:** Stories can be assigned effort estimates.
- **Small:** Stories are scoped to fit within sprint planning.
- **Testable:** Each story includes measurable acceptance criteria.

---

## 4. Product Backlog

The product backlog organizes the user stories into a prioritized list of work using **MoSCoW prioritization** and story point estimates.

### 4.1 Product Backlog Table

| Story ID | User Story Summary | MoSCoW Priority | Story Points | Dependencies |
|----------|--------------------|-----------------|--------------|--------------|
| US-008 | Secure user login | Must-have | 5 | None |
| US-001 | Submit maintenance request | Must-have | 3 | US-008 |
| US-002 | View submitted requests | Must-have | 2 | US-001 |
| US-003 | Review maintenance requests | Must-have | 3 | US-001 |
| US-004 | Assign requests to technicians | Must-have | 3 | US-003 |
| US-005 | View assigned tasks | Must-have | 2 | US-004 |
| US-006 | Update task status | Must-have | 3 | US-005 |
| US-007 | Manage user accounts | Must-have | 5 | US-008 |
| US-011 | Protect user data and security controls | Must-have | 3 | US-008 |
| US-009 | Notify students of status updates | Should-have | 3 | US-006 |
| US-012 | Improve system response speed | Should-have | 2 | None |
| US-010 | Generate maintenance reports | Could-have | 5 | US-001, US-003, US-006 |

---

## 5. Backlog Prioritization Justification

The **Must-have** stories were selected because they deliver the core value of the CampusFix MVP. Without authentication, request submission, request review, assignment, and task updates, the system cannot support the end-to-end maintenance workflow.

The **Should-have** stories improve usability and user experience. Notifications and performance optimization are highly valuable, but the system can still operate at a basic level without them in the first release.

The **Could-have** story (reporting) is useful for management oversight but is not essential for the initial MVP.

This prioritization reflects stakeholder needs identified in Assignment 4, especially those of students, residence managers, technicians, and administrators.

---

## 6. Traceability to Previous Assignments

To maintain consistency with previous work, the following traceability matrix maps Assignment 4 requirements and Assignment 5 use cases to Assignment 6 user stories.

| Assignment 4 Requirement | Assignment 5 Use Case | Assignment 6 User Story |
|--------------------------|----------------------|--------------------------|
| Student can log in securely | Login | US-008 |
| Student can submit maintenance request | Submit Maintenance Request | US-001 |
| Student can track own requests | View Request Status | US-002 |
| Manager can review requests | Review Request | US-003 |
| Manager can assign technician | Assign Task | US-004 |
| Technician can view assigned work | View Assigned Tasks | US-005 |
| Technician can update progress | Update Task Status | US-006 |
| Admin manages system users | Manage Users | US-007 |
| System must be secure | Security Controls | US-011 |
| System should perform efficiently | Performance Expectations | US-012 |

---

## 7. Reflection

One of the main challenges in this assignment was moving from traditional requirements and use case thinking into Agile planning. In earlier assignments, the work focused on defining the system in a structured and detailed way. Assignment 6 required those same ideas to be broken down into smaller, more actionable development items. This was not always straightforward because use cases often describe complete workflows, while user stories focus on user value in smaller increments.

Another challenge was prioritization. As the sole person planning the system, it was tempting to treat almost every feature as equally important. However, Agile requires disciplined decision-making. I had to distinguish between what the system absolutely needs for an MVP and what could be added later. For example, reporting and notifications are important features, but they are not as critical as login, request submission, request review, assignment, and status updates. This forced me to think practically rather than ideally.

Estimation was also difficult. Assigning story points requires judgment, and since this is an academic project rather than a full team environment, there is naturally some uncertainty. Features like authentication or user management appear simple at first, but they often involve validation, authorization, error handling, and testing. This made effort estimation more challenging than expected.

A further difficulty was maintaining continuity with previous assignments. Since Assignment 6 builds directly on Assignments 3, 4, and 5, I had to make sure that the stories, backlog items, and sprint scope all matched the project definition, stakeholder concerns, and use cases already developed. Any inconsistency would weaken the overall quality of the project and reduce traceability.

Finally, there was an internal challenge in balancing user value with technical convenience. As the person planning the work, I had to avoid prioritizing features simply because they seemed easier to implement. Instead, the focus needed to remain on what would give the most value to the users of CampusFix. This reflects a realistic Agile challenge, because development decisions must be guided by stakeholder benefit rather than developer preference.

Overall, this assignment helped me understand how Agile planning connects strategy, requirements, and implementation. It also showed that good sprint planning depends on clear prioritization, realistic estimation, and strong traceability to earlier analysis work.

---

## 8. Conclusion

This Agile planning document translates the CampusFix system into a practical development plan. It defines user stories, a prioritized backlog, and clear traceability to previous assignments. These artifacts establish the foundation for sprint planning and MVP delivery in a structured Agile process.
