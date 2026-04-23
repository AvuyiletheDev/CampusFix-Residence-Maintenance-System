# CampusFix Residence Maintenance System - State Transition Diagrams

## Overview
This document presents the object state modeling for the CampusFix Residence Maintenance System.  
The purpose of these diagrams is to model how important system objects change state over time in response to user actions, system events, and business rules.

These state transition diagrams support the dynamic behavior modeling required in Assignment 8 and align with the functional requirements and use cases defined in earlier assignments.

---
- **State Diagrams:**  
  📁 `DiagramImages/State Diagrams Workflow/`

  [State Diagrams Folder](./DiagramImages/State%20Diagrams%20Workflow/)

These images correspond directly to the Mermaid diagrams included in the documentation files.

## 1. Maintenance Request State Diagram

    Description
    The Maintenance Request is the core object in CampusFix. It represents a problem reported by a student or residence user and moves through several stages from initial creation to final closure.

    Mermaid Diagram
    ```mermaid
    stateDiagram-v2
        [*] --> Draft
        Draft --> Submitted : submitRequest()
        Submitted --> UnderReview : adminReviews()
        UnderReview --> Approved : approveRequest()
        UnderReview --> Rejected : rejectRequest()
        Approved --> Assigned : assignTechnician()
        Assigned --> InProgress : technicianAccepts()
        InProgress --> Resolved : repairCompleted()
        Resolved --> Closed : studentConfirms()
        Resolved --> Reopened : issueNotFixed()
        Reopened --> Assigned : reassignRequest()
        Rejected --> [*]
        Closed --> [*]

    Explanation:
        Key States

        Draft: Request started but not yet submitted.
        Submitted: Request formally sent to the system.
        UnderReview: Admin or residence office checks validity and urgency.
        Approved: Request accepted for action.
        Rejected: Request declined due to invalid or duplicate details.
        Assigned: Technician has been allocated.
        InProgress: Repair work has started.
        Resolved: Technician has completed the repair.
        Closed: Student confirms the issue is fixed.
        Reopened: Issue was not properly resolved and needs attention again.

        Requirement Alignment: 

        Supports FR for submitting maintenance requests.
        Supports FR for review and approval of requests.
        Supports FR for assigning technicians.
        Supports FR for tracking request progress.
        Supports FR for reopening unresolved issues.


### 2. Work Order State Diagram
 
    ###Description
    A Work Order is generated after a maintenance request is approved. It formalizes the maintenance task assigned to a technician.

    ###Mermaid Diagram
    ```mermaid
    stateDiagram-v2
        [*] --> Created
        Created --> PendingAssignment : generateWorkOrder()
        PendingAssignment --> Assigned : assignToTechnician()
        Assigned --> Accepted : technicianAccepts()
        Assigned --> Rejected : technicianDeclines()
        Rejected --> PendingAssignment : reassignWorkOrder()
        Accepted --> InProgress : beginRepair()
        InProgress --> AwaitingParts : partsRequired()
        AwaitingParts --> InProgress : partsReceived()
        InProgress --> Completed : finishRepair()
        Completed --> Verified : adminOrStudentVerifies()
        Completed --> Reopened : repairFailsValidation()
        Reopened --> Assigned : reassignRepair()
        Verified --> [*]

    Explanation
        Key States

        Draft: Request started but not yet submitted.
        Submitted: Request formally sent to the system.
        UnderReview: Admin or residence office checks validity and urgency.
        Approved: Request accepted for action.
        Rejected: Request declined due to invalid or duplicate details.
        Assigned: Technician has been allocated.
        InProgress: Repair work has started.
        Resolved: Technician has completed the repair.
        Closed: Student confirms the issue is fixed.
        Reopened: Issue was not properly resolved and needs attention again.

        Requirement Alignment:

        Supports FR for submitting maintenance requests.
        Supports FR for review and approval of requests.
        Supports FR for assigning technicians.
        Supports FR for tracking request progress.
        Supports FR for reopening unresolved issues.


### 3. Residence Room Issue State Diagram

    Description: 
    This object represents the physical problem affecting a room or residence area, such as a broken light, leaking pipe, or damaged lock.

    Mermaid Diagram:
    ```mermaid 
    stateDiagram-v2
        [*] --> Reported
        Reported --> Logged : systemCapturesIssue()
        Logged --> Diagnosed : technicianInspects()
        Diagnosed --> Scheduled : scheduleRepair()
        Scheduled --> BeingRepaired : repairStarts()
        BeingRepaired --> Fixed : repairEnds()
        Fixed --> Monitored : observeIssue()
        Monitored --> Escalated : problemReturns()
        Monitored --> Closed : noFurtherProblem()
        Escalated --> Scheduled : rescheduleRepair()
        Closed --> [*] 

    Explanation:
        Key States

        Reported: User raises the issue.
        Logged: Issue is recorded in the system.
        Diagnosed: Cause is identified.
        Scheduled: Repair planning completed.
        BeingRepaired: Technicians are actively addressing the problem.
        Fixed: Repair complete.
        Monitored: Issue observed for recurrence.
        Escalated: More serious intervention required.
        Closed: Problem permanently resolved.

        Requirement Alignment:

        Supports FR for issue logging and repair handling.
        Supports FR for escalation of unresolved issues.

### 4. User Account State Diagram 

    Description:
    The User Account object models the lifecycle of users such as students, residence managers, and technicians in the system.

    Mermaid Diagram:
    ```mermaid
    stateDiagram-v2
    [*] --> Registered
    Registered --> PendingVerification : submitRegistration()
    PendingVerification --> Active : verifyAccount()
    PendingVerification --> Suspended : invalidDetails()
    Active --> Locked : multipleFailedLogins()
    Locked --> Active : resetPassword()
    Active --> Suspended : policyViolation()
    Suspended --> Active : reinstateUser()
    Active --> Deactivated : deactivateAccount()
    Suspended --> Deactivated : removeAccess()
    Deactivated --> [*]


Explanation:
    Key States

    Registered: Account created.
    PendingVerification: Awaiting validation.
    Active: User can access the system.
    Locked: Access temporarily blocked due to security reasons.
    Suspended: Account restricted for policy or administrative reasons.
    Deactivated: Account permanently disabled.

    Requirement Alignment:

    Supports FR for user registration and authentication.
    Supports NFR for security and controlled access.

### 5. Technician Assignment State Diagram

    ###Description:
    This object tracks the assignment process between the system and a technician for a maintenance task.

    ###Mermaid Diagram: 
    ```mermaid
    stateDiagram-v2
    [*] --> Created
    Created --> Sent : notifyTechnician()
    Sent --> Accepted : acceptAssignment()
    Sent --> Declined : declineAssignment()
    Declined --> Reassigned : assignDifferentTechnician()
    Reassigned --> Sent : resendAssignment()
    Accepted --> InProgress : startTask()
    InProgress --> Completed : finishTask()
    Completed --> Confirmed : verifyCompletion()
    Confirmed --> [*] 

Explanation:
    Key States

    Created: Assignment generated.
    Sent: Technician notified.
    Accepted: Technician agrees to perform the task.
    Declined: Technician refuses or is unavailable.
    Reassigned: Assignment moved to another technician.
    InProgress: Task underway.
    Completed: Technician marks job as done.
    Confirmed: Repair confirmed by admin or student.

    Requirement Alignment:

    Supports FR for technician allocation.
    Supports FR for task progress tracking.

### 6. Notification State Diagram

    Description:
    Notifications keep users informed about request progress, assignment updates, and issue resolution.

    Mermaid Diagram: 
    ```mermaid
    stateDiagram-v2
    [*] --> Generated
    Generated --> Queued : enqueueNotification()
    Queued --> Sent : dispatchNotification()
    Sent --> Delivered : deliverySuccess()
    Sent --> Failed : deliveryFailure()
    Failed --> Queued : retryNotification()
    Delivered --> Read : userOpensNotification()
    Read --> Archived : archiveNotification()
    Archived --> [*]

Explanation:
    Key States

    Generated: Notification created by a system event.
    Queued: Waiting to be sent.
    Sent: Notification dispatched.
    Delivered: Received successfully.
    Failed: Delivery unsuccessful.
    Read: Opened by recipient.
    Archived: Removed from active view.

    Requirement Alignment:

    Supports FR for user notifications.
    Supports NFR for reliability and communication.

### 7. Feedback Record State Diagram
    Description:
    The Feedback Record captures student feedback after a maintenance issue has been resolved.

    Mermaid Diagram: 
    ```mermaid
    stateDiagram-v2
    [*] --> Submitted
    Submitted --> UnderReview : adminChecksFeedback()
    UnderReview --> Addressed : issueHandled()
    UnderReview --> Escalated : seriousComplaint()
    Addressed --> Closed : closeFeedback()
    Escalated --> Addressed : correctiveActionTaken()
    Closed --> [*]

Explanation
    Key States

    Submitted: Student sends feedback.
    UnderReview: Admin reviews feedback.
    Addressed: Action taken on the concern.
    Escalated: Serious complaint sent to higher authority.
    Closed: Feedback process completed.

    Requirement Alignment:

    Supports FR for feedback and complaint handling.
    Supports stakeholder need for service quality improvement.

### 8. Asset/Equipment Item State Diagram
    
    Description:
    This object models tools or maintenance-related equipment used in residence operations.

    Mermaid Diagram: 
    ```mermaid
    stateDiagram-v2
    [*] --> Available
    Available --> Allocated : reserveItem()
    Allocated --> InUse : technicianCollects()
    InUse --> Faulty : itemBreaks()
    InUse --> Returned : taskCompleted()
    Faulty --> UnderMaintenance : sendForRepair()
    UnderMaintenance --> Available : repairedItem()
    Returned --> Available : inspectAndStore()
    UnderMaintenance --> Retired : beyondRepair()
    Retired --> [*]

Explanation:
    Key States

    Available: Ready for use.
    Allocated: Reserved for a technician or task.
    InUse: Currently being used.
    Faulty: Equipment damaged.
    UnderMaintenance: Being repaired.
    Returned: Brought back after use.
    Retired: Removed permanently.

    Requirement Alignment:

    Supports FR for equipment tracking.
    Supports maintainability and operational readiness.

###