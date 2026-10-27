# C# Refactoring Exercises

## Exercise 1 — User Registration

**Objective:** Refactor a user registration system by separating validation logic from the registration process.

The system validates a username and age before registering a user. The original implementation contains multiple validation rules within a single method.

**Requirements:**
- Extract username and age validation into separate methods.
- Prevent registration when validation fails.
- Display appropriate error messages.
- Reduce complexity without changing functionality.

**Concepts:** Decomposition, method extraction, validation, guard clauses.

## Exercise 2 — Price Calculator

**Objective:** Eliminate duplicated calculations for products with different tax rates.

The system calculates prices for books and games. Both calculations follow the same formula but use different tax percentages.

**Requirements:**
- Identify duplicated calculation logic.
- Extract a reusable price calculation method.
- Support different tax rates through parameters.
- Preserve the original calculation results.

**Concepts:** Code duplication, reusable methods, parameters, abstraction.

## Exercise 3 — Text Formatter

**Objective:** Refactor duplicated string-processing loops.

The system processes collections of strings, applying operations such as converting text to uppercase or lowercase.

**Requirements:**
- Identify the shared iteration logic.
- Separate string processing from formatting behavior.
- Reduce duplicated loops.
- Preserve the original formatting results.

**Concepts:** Decomposition, shared workflows, method extraction, varying behavior.

## Exercise 4 — Character Damage System

**Objective:** Refactor damage calculations for different character classes using inheritance and polymorphism.

Warriors and Mages share a common damage calculation but apply different class-specific multipliers. Additional character types may introduce further variations.

**Requirements:**
- Extract shared damage calculations.
- Allow individual character classes to customize their damage.
- Avoid duplicating the complete damage formula.
- Support additional character classes without unnecessarily modifying existing implementations.

**Concepts:** Inheritance, polymorphism, virtual methods, overriding, base classes.

## Exercise 5 — Notification Service

**Objective:** Remove duplicated validation and message-sending logic.

The system contains multiple notification methods that repeat similar operations, including input validation and displaying messages.

**Requirements:**
- Identify common validation logic.
- Extract reusable notification operations.
- Keep notification-specific behavior separate.
- Preserve existing validation and output behavior.

**Concepts:** Method extraction, reusable validation, code duplication, separation of concerns.

## Exercise 6 — Order Processor

**Objective:** Refactor online and in-store order processing into a shared workflow.

Both order types calculate a subtotal, apply a discount when eligible, and display the final price. Online orders additionally include shipping costs.

**Requirements:**
- Extract common order-processing logic.
- Support different shipping costs.
- Apply a 10% discount when the total exceeds 100.
- Preserve the distinction between online and store orders.
- Avoid duplicating calculations.

**Concepts:** Decomposition, optional parameters, constants, business logic, method reuse.

## Exercise 7 — Payroll Processor

**Objective:** Refactor a payroll system supporting full-time employees and freelancers.

Full-time employees receive a monthly salary with performance-based bonuses and optional health insurance. Freelancers receive hourly compensation with overtime pay. Both employee types are subject to the same tax rules.

**Requirements:**
- Extract shared tax calculations.
- Implement performance-based bonuses.
- Calculate freelancer overtime above 160 hours at 1.5 times the hourly rate.
- Support optional health insurance costs.
- Refactor duplicated validation logic.
- Introduce meaningful constants for business rules.
- Display gross pay, tax, insurance costs, and net pay.
- Preserve existing calculations and validation behavior.

**Concepts:** Advanced decomposition, switch expressions, pattern matching, reusable validation, short-circuit evaluation, constants.

## Exercise 8 — Notification System Architecture

**Objective:** Redesign a notification system using object-oriented design principles.

The system supports Email, SMS, and Push notifications. The original `NotificationManager` class handles validation, sending, output formatting, and notification statistics.

**Requirements:**
- Separate responsibilities into appropriate classes.
- Introduce a common abstraction for notification types.
- Apply polymorphism to support different notification channels.
- Encapsulate the notification counter.
- Extract shared validation and sending behavior.
- Preserve channel-specific validation rules.
- Increment the counter only when a notification is successfully sent.
- Preserve existing output messages and behavior.

**Bonus challenge:** Add support for Slack notifications without modifying the existing notification implementations or introducing another large method into the manager.

**Concepts:** Single Responsibility Principle (SRP), Open/Closed Principle (OCP), encapsulation, inheritance, interfaces, polymorphism, separation of concerns.

# Exercise 9 — Library Management System

**Difficulty:** Intermediate  
**Language:** C# (.NET 10)  
**Focus:** Object-Oriented Programming, Inheritance, Polymorphism, Encapsulation, Single Responsibility Principle (SRP), and Application Design

## Objective

Build a simple library management system entirely from scratch.

Unlike previous exercises, no existing implementation is provided. The goal is to independently design the application's classes, properties, methods, relationships, and responsibilities.

The application should operate entirely in memory and demonstrate its functionality through the console. No database, graphical interface, or external dependencies are required.

## Requirements

### 1. Library Items

The library manages three types of items:

**Books**
- Title
- Author
- ISBN
- Borrowing period: 21 days

**DVDs**
- Title
- Director
- Duration in minutes
- Borrowing period: 7 days

**Magazines**
- Title
- Issue number
- Publication date
- Borrowing period: 14 days

Each item must have a way to determine whether it is currently available for borrowing.

### 2. Library Members

Each library member must have:

- A unique member ID (`int` is recommended).
- A name.
- The ability to borrow and return library items.

**Business rules:**
- A member may borrow a maximum of three items simultaneously.
- A member cannot borrow another copy of an item they already have checked out.
- Member IDs must be unique.

### 3. Borrowing Items

When a member attempts to borrow an item, the application must:

1. Verify that the item is available.
2. Verify that the member has not reached the borrowing limit.
3. Verify that the member does not already have the same item checked out.
4. Record which member borrowed the item.
5. Record the borrowing date.
6. Calculate the return deadline based on the item's borrowing period.
7. Mark the item as unavailable.

If borrowing is not permitted, the application should display an appropriate message explaining why.

### 4. Returning Items

When an item is returned, the application must:

1. Verify that the item is currently borrowed.
2. Update its availability.
3. Remove the item from the member's active borrowed items.
4. Display a confirmation message.

### 5. Library Overview

The application must provide a way to:

- Display all library items.
- Display whether each item is available or borrowed.
- Display all items currently borrowed by a particular member.
- Display relevant borrowing information, including return deadlines.

## Bonus Challenge — Overdue Items

Implement an overdue tracking system.

**Requirements:**
- Determine whether a borrowed item is overdue.
- Calculate how many days the item is overdue.
- Apply a fine of €0.50 for each overdue day.
- Display overdue information and applicable fines.

## Project Structure

Keep the exercise within the existing `Decompositioning` project.

Suggested initial structure:

```text
Decompositioning/
├── Program.cs
├── Exercise.cs
├── Exercise_1.cs
├── ...
├── Exercise_8.cs
│
└── LibrarySystem/
    ├── Exercise_9.cs
    ├── Models/
    └── Services/
```

Use separate `.cs` files for individual classes and organize them into appropriate folders.

Additional folders may be introduced when necessary.

## Design Guidelines

- Apply inheritance where a genuine *is-a* relationship exists.
- Use polymorphism where different objects share a common operation but require different behavior.
- Encapsulate internal state and avoid unnecessary public setters.
- Follow the Single Responsibility Principle.
- Avoid duplicated logic.
- Prefer clear, meaningful class and method names.
- Keep responsibilities separated between domain objects and application coordination.
- Do not introduce interfaces or abstract classes without a meaningful reason.
- Keep the implementation simple and understandable.

## Implementation Approach

**Phase 1 — Architecture**

Identify the required classes, their responsibilities, and relationships before writing the implementation.

**Phase 2 — Models**

Implement the domain objects and their properties, constructors, and relevant behavior.

**Phase 3 — Business Logic**

Implement borrowing, returning, availability checks, and borrowing limits.

**Phase 4 — Demonstration**

Use `Exercise_9.cs` to demonstrate the application with multiple members and library items.

Include successful operations and invalid scenarios to verify the business rules.

**Phase 5 — Bonus**

Implement overdue detection and fine calculations.

## Completion Criteria

The exercise is complete when:

- All three library item types are supported.
- Members can borrow and return items.
- Borrowing restrictions are enforced.
- Borrowing and due dates are recorded correctly.
- Item availability is updated correctly.
- Library and member overviews work.
- Invalid operations are handled appropriately.
- The application demonstrates appropriate object-oriented design.

**Important:** The purpose of this exercise is not simply to produce working code, but to practice designing a maintainable object-oriented application independently.