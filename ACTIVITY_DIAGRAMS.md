# CampusFix Residence Maintenance System - Activity Diagrams

## Overview
This document presents activity workflow modeling for the CampusFix Residence Maintenance System.  
The aim is to show how major system processes are executed from start to finish, including actions, decisions, roles, and system responses.

These activity diagrams align with Assignment 8 by modeling workflow behavior and showing how the system supports user interaction and operational processes.

---

- **Activity Diagrams:**  
  📁 `DiagramImages/Activity Diagrams/` 

[Activity Diagrams Folder](./DiagramImages/Activity%20Diagrams/)

  These images correspond directly to the Mermaid diagrams included in the documentation files.

## 1. Student Submits Maintenance Request

    Description
    This workflow shows how a student reports a maintenance problem through CampusFix.

    Mermaid Diagram
    ```mermaid
    flowchart TD
        A([Start]) --> B[Student logs into CampusFix]
        B --> C[Open maintenance request form]
        C --> D[Enter room and issue details]
        D --> E[Upload image or supporting evidence]
        E --> F[Submit request]
        F --> G{Are all required fields valid?}
        G -- No --> H[Display validation errors]
        H --> C
        G -- Yes --> I[Save request in system]
        I --> J[Generate request ID]
        J --> K[Notify admin/residence office]
        K --> L([End])

    Explanation:
        Actors / Roles:
        Student
        System
        Admin/Residence Office

        How this workflow helps:

        Allows fast issue reporting.
        Reduces manual paperwork.
        Ensures requests are properly captured and traceable.

        Requirement Alignment:

        FR: Submit maintenance request
        FR: Capture request details
        FR: Notify relevant staff

### 2. Admin Reviews and Approves Request

    Description:
    This workflow models how an administrator reviews an incoming maintenance request and decides whether to approve or reject it.

    Mermaid Diagram:
    ```mermaid 
    flowchart TD
    A([Start]) --> B[Admin views submitted request]
    B --> C[Check request completeness and relevance]
    C --> D{Is the request valid?}
    D -- No --> E[Reject request and add reason]
    E --> F[Notify student of rejection]
    F --> G([End])
    D -- Yes --> H[Approve request]
    H --> I[Update status to Approved]
    I --> J[Notify student and maintenance office]
    J --> G 

Explanation:
    Actors / Roles:
    Admin
    System
    Student

    How this workflow helps:
    Prevents duplicate or invalid requests.
    Supports administrative control.
    Improves transparency through feedback to students.

    Requirement Alignment:

    FR: Review maintenance requests
    FR: Approve or reject requests
    FR: Update request status 

###3. Assign Technician to Approved Request
    
    Description:
    This workflow shows how the system and admin assign a technician after a request has been approved.

    Mermaid Diagram:
    ```mermaid
    flowchart TD
    A([Start]) --> B[Admin opens approved request]
    B --> C[Check technician availability]
    C --> D[Select technician]
    D --> E[Generate work order]
    E --> F[Send assignment notification]
    F --> G{Does technician accept?}
    G -- No --> H[Mark assignment declined]
    H --> I[Select another technician]
    I --> E
    G -- Yes --> J[Update request to Assigned]
    J --> K([End])

Explanation:
    Actors / Roles:
    Admin
    System
    Technician

    How this workflow helps:

    Ensures each request reaches the right technician.
    Handles reassignment if the first technician declines.
    Improves accountability in task allocation.

    Requirement Alignment:

    FR: Assign technician
    FR: Generate work order
    FR: Notify technician

### 4. Technician Updates Repair Progress
    
    Description:
    This workflow models how a technician records progress while carrying out a repair.

    Mermaid Diagram: 
    ```mermaid
    flowchart TD
    A([Start]) --> B[Technician logs in]
    B --> C[Open assigned work order]
    C --> D[Inspect maintenance issue]
    D --> E[Start repair work]
    E --> F[Update progress notes]
    F --> G{Are parts or extra help needed?}
    G -- Yes --> H[Mark task as Awaiting Parts or Escalation]
    H --> I[Notify admin]
    I --> J([End])
    G -- No --> K[Continue repair]
    K --> L[Record progress update]
    L --> J

Explanation:
    Actors / Roles:
    Technician
    System
    Admin

    How this workflow helps:
    Provides real-time visibility into maintenance progress.
    Allows delays and dependencies to be captured properly.
    Improves communication with administrators.

    Requirement Alignment:

    FR: Update work progress
    FR: Escalate blocked tasks
    FR: Track maintenance status

### 5. Technician Marks Issue Resolved
    
    Description:
    This workflow shows how a technician closes out a repair task after completing the work.

    Mermaid Diagram:
    ```mermaid
    flowchart TD
    A([Start]) --> B[Technician completes repair]
    B --> C[Capture final notes]
    C --> D[Upload proof/photo if needed]
    D --> E[Mark work order as completed]
    E --> F[System updates request status to Resolved]
    F --> G[Notify student and admin]
    G --> H([End]) 

Explanation:
    Actors / Roles:
    Technician
    System
    Student
    Admin

    How this workflow helps:

    Ensures repair completion is recorded.
    Provides evidence where needed.
    Triggers the next step of confirmation.

    Requirement Alignment:

    FR: Resolve maintenance issue
    FR: Update maintenance request status
    FR: Send completion notifications

### 6. Student Confirms Resolution or Reopens Issue

    Description:
    This workflow shows how a student responds after being notified that a repair has been completed.

    Mermaid Diagram:
    ```mermaid
    flowchart TD
        A([Start]) --> B[Student receives completion notification]
        B --> C[Student reviews repair result]
        C --> D{Is the issue fully resolved?}
        D -- Yes --> E[Confirm completion]
        E --> F[System updates request to Closed]
        F --> G([End])
        D -- No --> H[Reopen request]
        H --> I[Add comments on unresolved issue]
        I --> J[System updates request to Reopened]
        J --> K[Notify admin and technician]
        K --> G

    Explanation:
        Actors / Roles:
        Student
        System
        Admin
        Technician

        How this workflow helps:

        Gives students a voice in confirming service quality.
        Prevents premature closure of unresolved issues.
        Supports quality assurance and accountability.

        Requirement Alignment:

        FR: Confirm repair completion
        FR: Reopen unresolved request
        FR: Notify responsible staff 

###7. Admin Generates Maintenance Report

    Description:
    This workflow models how an administrator generates reports for monitoring residence maintenance performance.

    Mermaid Diagram:
    ```mermaid
    flowchart TD
    A([Start]) --> B[Admin selects report module]
    B --> C[Choose date range and filters]
    C --> D[Submit report request]
    D --> E[System retrieves maintenance data]
    E --> F[System compiles report]
    F --> G[Display report dashboard]
    G --> H{Export report?}
    H -- Yes --> I[Export as PDF/CSV]
    I --> J([End])
    H -- No --> J

Explanation:
    Actors / Roles:
    Admin
    System

    How this workflow helps:

    Supports decision-making with maintenance statistics.
    Helps identify recurring issues and backlog trends.
    Improves oversight and planning.

    Requirement Alignment:

    FR: Generate reports
    FR: Filter maintenance data
    FR: Export reports

###8. Notification Workflow

    Description:
    This workflow shows how the system sends notifications during important events in the maintenance lifecycle.

    Mermaid Diagram:
    ```mermaid
    flowchart TD
    A([Start]) --> B[System detects event trigger]
    B --> C[Create notification message]
    C --> D[Identify target recipient]
    D --> E[Queue notification]
    E --> F[Send notification]
    F --> G{Was delivery successful?}
    G -- No --> H[Log failure and retry]
    H --> F
    G -- Yes --> I[Mark as delivered]
    I --> J{Was notification opened?}
    J -- Yes --> K[Mark as read]
    J -- No --> L[Keep as unread]
    K --> M([End])
    L --> M

Explanation:
    Actors / Roles:
    System
    Student
    Admin
    Technician

    How this workflow helps:

    Keeps all stakeholders informed in real time.
    Supports transparency and response speed.
    Improves user experience and process visibility.

    Requirement Alignment:

    FR: Send automated notifications
    NFR: Reliability and communication effectiveness