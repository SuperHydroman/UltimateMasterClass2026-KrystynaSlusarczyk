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