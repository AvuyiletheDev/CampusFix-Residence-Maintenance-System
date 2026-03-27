# Use Case Specifications – CampusFix System

## UC-01: Log In
**Actor:** All Users  
**Description:** Authenticate user and grant access.  

**Preconditions:**
- User account exists

**Postconditions:**
- User is logged in

**Basic Flow:**
1. Enter credentials
2. System validates
3. User redirected

**Alternative Flows:**
- Invalid login → error message

---

## UC-02: Report Maintenance Issue
**Actor:** Student  

**Preconditions:**
- Student logged in

**Postconditions:**
- Issue stored with ID

**Basic Flow:**
1. Open form
2. Enter details
3. Upload image
4. Submit
5. System saves issue

**Alternative Flows:**
- Missing fields
- Upload error

---

## UC-03: Upload Issue Evidence
**Actor:** Student  

**Preconditions:**
- Issue form open

**Postconditions:**
- Images stored

**Basic Flow:**
1. Select file
2. Upload
3. Validate
4. Save

---

## UC-04: Review Issues
**Actor:** Admin  

**Basic Flow:**
1. View issues
2. Filter/search
3. Open issue

---

## UC-05: Assign Issue
**Actor:** Admin  

**Basic Flow:**
1. Select issue
2. Choose staff
3. Assign

---

## UC-06: Update Progress
**Actor:** Staff  

**Basic Flow:**
1. Open assigned issue
2. Add update
3. Save

---

## UC-07: Close Issue
**Actor:** Staff  

**Basic Flow:**
1. Mark completed
2. Confirm
3. Save

---

## UC-08: Generate Reports
**Actor:** Admin / Management  

**Basic Flow:**
1. Select report
2. Apply filters
3. Generate