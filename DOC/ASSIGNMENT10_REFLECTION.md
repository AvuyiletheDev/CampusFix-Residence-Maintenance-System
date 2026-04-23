# Assignment 10 Reflection – Creational Design Patterns

## 1. Overview

In Assignment 10, the CampusFix system was extended by implementing all six creational design patterns using ASP.NET Core MVC. The objective was to apply design principles to improve system flexibility, maintainability, and scalability.

The patterns implemented include:

- Simple Factory
- Factory Method
- Abstract Factory
- Builder
- Prototype
- Singleton

Each pattern was integrated into the existing CampusFix domain model to ensure alignment with the system's functionality.

---

## 2. Design Decisions

The design patterns were applied in context to the CampusFix system:

- The **Simple Factory** was used to create different types of maintenance requests based on category.
- The **Factory Method** was used to create different user types (Student, Technician, Admin), allowing for extensibility.
- The **Abstract Factory** was implemented for the notification system, supporting multiple communication channels such as Email and SMS.
- The **Builder Pattern** was used to construct complex maintenance request objects step-by-step.
- The **Prototype Pattern** allowed cloning of request templates, improving efficiency in repeated request creation.
- The **Singleton Pattern** ensured a single shared configuration instance across the system.

These patterns helped enforce **low coupling** and **high cohesion**, which are key principles in software engineering.

---

## 3. Testing Approach

Unit testing was implemented using the xUnit framework.

Tests were created for each design pattern to validate:

- Object creation correctness
- Behaviour consistency
- Error handling (e.g., invalid inputs)
- Singleton instance integrity

A total of **13 unit tests** were executed.

### Test Results

- Total Tests: 13  
- Passed: 13  
- Failed: 0  
- Skipped: 0  

All tests passed successfully, confirming that the patterns were correctly implemented and function as expected.

---

## 4. Challenges Encountered

Several challenges were encountered during development:

- Initial mismatch between test cases and implemented pattern classes
- Namespace and reference issues when linking the test project to the main project
- Understanding how to correctly structure each creational pattern within the ASP.NET Core MVC architecture

These challenges were resolved through refactoring, aligning test cases with actual implementations, and improving project structure.

---

## 5. Lessons Learned

This assignment reinforced key software engineering concepts:

- The importance of aligning design patterns with real system requirements
- How design patterns improve maintainability and scalability
- The role of unit testing in verifying system correctness
- The value of proper project structure when working with multiple layers (Domain, Patterns, Tests)

---

## 6. Conclusion

The implementation of creational design patterns in the CampusFix system was successful. The use of structured patterns and unit testing significantly improved the robustness of the system.

This assignment provided practical experience in applying theoretical concepts to a real-world system, strengthening both design and development skills.