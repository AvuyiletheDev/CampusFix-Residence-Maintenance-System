# Use Case Diagram – CampusFix System

## Overview
This diagram illustrates how different users (actors) interact with the CampusFix system.  
It is based directly on the functional requirements defined in Assignment 4.

![Use Case Diagram](DiagramImages/USE_CASE_Diagram.png)

## Diagram (Mermaid)

```mermaid
flowchart LR
    Student[Student]
    Admin[Residence Administrator]
    Staff[Maintenance Staff]
    SysAdmin[System Administrator]
    Mgmt[University Management]
    Contractor[External Contractor]
    Helpdesk[Helpdesk / Support Staff]

    UC1((Log In))
    UC2((Report Maintenance Issue))
    UC3((Upload Issue Evidence))
    UC4((View / Track Issue Status))
    UC5((Send Internal Message))
    UC6((Review Reported Issues))
    UC7((Assign Issue))
    UC8((Update Repair Progress))
    UC9((Close Issue))
    UC10((View Dashboard))
    UC11((Generate Reports))
    UC12((Manage Users & Roles))
    UC13((Maintain Categories))
    UC14((View Assigned Jobs))

    Student --> UC1
    Student --> UC2
    Student --> UC3
    Student --> UC4
    Student --> UC5

    Admin --> UC1
    Admin --> UC6
    Admin --> UC7
    Admin --> UC10
    Admin --> UC11

    Staff --> UC1
    Staff --> UC8
    Staff --> UC9
    Staff --> UC14

    SysAdmin --> UC12
    SysAdmin --> UC13

    Mgmt --> UC10
    Mgmt --> UC11

    Contractor --> UC14
    Contractor --> UC8
    Contractor --> UC9

    Helpdesk --> UC6
    Helpdesk --> UC4