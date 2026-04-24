# Assignment 11 README Snippet

## Repository Layer

For Assignment 11, CampusFix now includes a persistence repository layer that abstracts storage details behind interfaces.
This keeps domain logic separate from storage implementation and allows the project to switch storage strategies later.

### Design Choices
- **Generic repository interface** was used to avoid repeating CRUD logic for each entity.
- **Entity-specific repositories** were added where CampusFix needs extra query methods, such as:
  - finding maintenance requests by student
  - finding requests by status
  - finding available technicians
- **In-memory repositories** were implemented first to keep testing simple and fast.
- **Factory Pattern** was chosen to align with Assignment 10 and allow storage backends to be swapped later.
- **DatabaseStudentRepository** was added as a stub to demonstrate future-proofing for SQL/NoSQL persistence.

### Current Supported Storage
- In-memory dictionary-based repositories

### Future Storage
- SQL database repository
- NoSQL repository
- File-based JSON/XML repository
- External REST API repository
