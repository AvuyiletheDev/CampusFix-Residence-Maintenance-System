# SPRINT_PLANNING.md

# CampusFix Residence Maintenance System
## Sprint 1 Planning Document – Assignment 6

**Student:** Avuyile Ngalwa  
**Module:** Software Engineering  
**Project:** CampusFix – Residence Maintenance System  
**Sprint Duration:** 2 Weeks

---

## 1. Sprint Overview

This sprint plan defines the first development sprint for the **CampusFix Residence Maintenance System**. The purpose of Sprint 1 is to deliver the core workflow required for a basic but functional Minimum Viable Product (MVP).

---

## 2. Sprint Goal

> **Sprint Goal:** Deliver the core maintenance workflow by enabling users to log in, submit maintenance requests, review those requests, assign work to technicians, and update maintenance status.

This sprint contributes directly to the MVP because it establishes the complete end-to-end flow of the system’s primary business process.

---

## 3. Selected User Stories for Sprint 1

The following stories were selected from the product backlog because they represent the most critical system functionality.

| Story ID | User Story | Reason for Inclusion |
|----------|------------|----------------------|
| US-008 | As a user, I want to log into the system securely so that unauthorized users cannot access the system. | Authentication is required before protected system use. |
| US-001 | As a student, I want to submit a maintenance request so that issues in my residence can be fixed quickly. | This is the primary entry point for the maintenance workflow. |
| US-002 | As a student, I want to view my submitted requests so that I can track progress. | Users must be able to monitor reported issues. |
| US-003 | As a residence manager, I want to review maintenance requests so that I can verify and process them. | Requests need managerial control before work allocation. |
| US-004 | As a residence manager, I want to assign maintenance requests to technicians so that work is distributed efficiently. | Assignment is central to moving work into action. |
| US-006 | As a technician, I want to update the status of a task so that progress can be tracked until completion. | Status progression is essential for visible system value. |

---

## 4. Sprint Backlog

### 4.1 Sprint Tasks Table

| Task ID | Task Description | Linked Story | Assigned To | Estimated Hours | Status |
|---------|------------------|--------------|-------------|-----------------|--------|
| T-001 | Design users table and maintenance request table | US-008, US-001 | Dev Team | 6 | To Do |
| T-002 | Create login page UI | US-008 | Dev Team | 4 | To Do |
| T-003 | Implement authentication logic and session control | US-008 | Dev Team | 8 | To Do |
| T-004 | Build maintenance request submission form | US-001 | Dev Team | 8 | To Do |
| T-005 | Add request form validation and error handling | US-001 | Dev Team | 4 | To Do |
| T-006 | Develop student request history page | US-002 | Dev Team | 6 | To Do |
| T-007 | Create manager request review page | US-003 | Dev Team | 6 | To Do |
| T-008 | Implement approve/reject request logic | US-003 | Dev Team | 5 | To Do |
| T-009 | Create technician assignment functionality | US-004 | Dev Team | 6 | To Do |
| T-010 | Build technician task status update page | US-006 | Dev Team | 6 | To Do |
| T-011 | Implement task status persistence in database | US-006 | Dev Team | 4 | To Do |
| T-012 | Conduct functional testing for Sprint 1 stories | All | Dev Team | 8 | To Do |
| T-013 | Fix defects found during sprint testing | All | Dev Team | 6 | To Do |

---

## 5. Definition of Done

A story in Sprint 1 will be considered **Done** only when:

- functionality has been implemented,
- validation and error handling work correctly,
- data is stored correctly in the database,
- the feature has been tested,
- defects have been resolved,
- the feature is demonstrable in the system.

---

## 6. Sprint Capacity Summary

| Category | Hours |
|----------|-------|
| Design and setup | 6 |
| Authentication | 12 |
| Request submission | 12 |
| Request tracking | 6 |
| Request review and assignment | 11 |
| Status updates | 10 |
| Testing and bug fixing | 14 |
| **Total Estimated Hours** | **71** |

---

## 7. MVP Contribution

Sprint 1 contributes directly to the MVP by delivering the first working version of the system’s core business flow:

1. User logs in.  
2. Student submits maintenance request.  
3. Student views submitted request.  
4. Residence manager reviews request.  
5. Residence manager assigns technician.  
6. Technician updates maintenance status.  

Once these features are complete, CampusFix will already demonstrate meaningful value to users, even before advanced features such as notifications, reports, or analytics are added.

---

## 8. GitHub Board Setup

The assignment brief asks you to use **GitHub Issues**, **Projects**, and **Milestones** for Agile traceability. Use the setup below in your repository.

### 8.1 GitHub Labels

Create these labels:

- `user-story`
- `task`
- `must-have`
- `should-have`
- `could-have`
- `sprint-1`
- `backend`
- `frontend`
- `testing`

### 8.2 GitHub Milestones

Create these milestones:

- **Sprint 1**
- **MVP Release**

### 8.3 GitHub Project Board Columns

Create a project board with the following columns:

- **Backlog**
- **To Do**
- **In Progress**
- **Review**
- **Done**

### 8.4 GitHub Issues to Create

Create one issue for each user story:

- `US-008 Secure user login`
- `US-001 Submit maintenance request`
- `US-002 View submitted requests`
- `US-003 Review maintenance requests`
- `US-004 Assign maintenance requests`
- `US-006 Update task status`

Create one issue for each task:

- `T-001 Design database tables`
- `T-002 Create login page UI`
- `T-003 Implement authentication logic`
- `T-004 Build request submission form`
- `T-005 Add form validation`
- `T-006 Develop request history page`
- `T-007 Create manager review page`
- `T-008 Implement approve/reject logic`
- `T-009 Create assignment functionality`
- `T-010 Build technician update page`
- `T-011 Implement status persistence`
- `T-012 Conduct functional testing`
- `T-013 Fix sprint defects`

### 8.5 Issue Description Template for User Stories

Use this template for each user story issue:

```md
## User Story
As a [role], I want [action] so that [benefit].

## Acceptance Criteria
- [ ] Criterion 1
- [ ] Criterion 2
- [ ] Criterion 3

## Priority
Must-have / Should-have / Could-have

## Story Points
[1, 2, 3, 5]

## Linked Sprint
Sprint 1
```

### 8.6 Issue Description Template for Tasks

Use this template for each task issue:

```md
## Task Description
[Describe the technical task clearly]

## Linked User Story
US-XXX

## Estimated Hours
[Enter hours]

## Status
To Do
```

---

## 9. Ready-to-Create GitHub Board Mapping

| Item | Type | Milestone | Labels | Initial Column |
|------|------|-----------|--------|----------------|
| US-008 Secure user login | User Story | Sprint 1 | user-story, must-have, sprint-1 | Backlog |
| US-001 Submit maintenance request | User Story | Sprint 1 | user-story, must-have, sprint-1 | Backlog |
| US-002 View submitted requests | User Story | Sprint 1 | user-story, must-have, sprint-1 | Backlog |
| US-003 Review maintenance requests | User Story | Sprint 1 | user-story, must-have, sprint-1 | Backlog |
| US-004 Assign maintenance requests | User Story | Sprint 1 | user-story, must-have, sprint-1 | Backlog |
| US-006 Update task status | User Story | Sprint 1 | user-story, must-have, sprint-1 | Backlog |
| T-001 to T-013 | Tasks | Sprint 1 | task, sprint-1 | To Do |

---

## 10. Conclusion

Sprint 1 has been planned to deliver the most essential workflow of the CampusFix system. The selected stories and tasks support the MVP and provide a realistic structure for GitHub-based Agile project management.
