# 🎬 Cinema Booking System

A C# Console Application that simulates a **Cinema Booking System**, built incrementally to demonstrate Object-Oriented Programming (OOP) principles and C# programming concepts. Each update extends the existing system with new features while maintaining a clean and modular architecture

The project begins with basic ticket booking functionality and gradually evolves into a more complete cinema management system.


## 📖 Project Overview

The Cinema Booking System has evolved into a modular, extensible console application that demonstrates object-oriented design using C#. The project now incorporates interfaces, polymorphism, object cloning, and ticket lifecycle management, making the system more flexible, reusable, and maintainable.

---

## ✨ Features

- Book movie tickets through a console interface.
- Support multiple ticket types:
  - Standard Ticket
  - VIP Ticket
  - IMAX Ticket
- Automatically generate unique ticket IDs.
- Calculate ticket prices with 14% tax.
- Update ticket prices using overloaded methods.
- Store and manage tickets within a cinema.
- Search and retrieve tickets.
- Generate unique booking references.
- Calculate group booking discounts.
- Open and close the cinema using composition.
- Print ticket information using runtime polymorphism.
- Process tickets through a common base class.
- Standardize printing using custom interfaces.
- Track ticket booking and cancellation status.
- Clone tickets using deep copying.
- Print collections of printable objects using interface polymorphism.

---

## 🧠 OOP Concepts Covered

- Classes & Objects
- Enums
- Structs
- Encapsulation
- Properties
- Constructor Overloading
- Constructor Chaining
- Method Overloading
- Method Overriding
- Runtime Polymorphism
- Interface Polymorphism
- Custom Interfaces
- Multiple Interface Implementation
- Inheritance
- Composition
- Static Members
- Static Utility Classes
- Indexers
- Arrays
- Object Cloning (`ICloneable`)
- Deep Copy
- Data Validation
- Console Applications

---

## 💻 Sample Output

```text
========== Cinema Opened ==========
Projector started.

========== All Tickets ==========

[Ticket #1] Type: Standard | Inception | Price: 80 EGP | After Tax: 91.2 EGP | Seat: A-5 | Booked: No

[Ticket #2] Type: VIP | Avengers | Price: 200 EGP | After Tax: 228 EGP | Lounge Access: Yes | Service Fee: 50 EGP | Booked: No

[Ticket #3] Type: IMAX | Dune | Price: 160 EGP | After Tax: 182.4 EGP | IMAX 3D: Yes | Booked: No

========== Clone Test ==========

Cloned:
[Ticket #4] Type: Standard | Interstellar | Price: 80 EGP | After Tax: 91.2 EGP | Seat: Z-99 | Booked: Yes

Original:
[Ticket #1] Type: Standard | Inception | Price: 80 EGP | After Tax: 91.2 EGP | Seat: A-5 | Booked: No

========== After Booking ==========

Ticket booked successfully.

[Ticket #1] Type: Standard | Inception | Price: 80 EGP | After Tax: 91.2 EGP | Seat: A-5 | Booked: Yes

========== After Canceling ==========

Ticket cancelled successfully.

[Ticket #1] Type: Standard | Inception | Price: 80 EGP | After Tax: 91.2 EGP | Seat: A-5 | Booked: No

========== BookingHelper.PrintAll ==========

[Ticket #1] Type: Standard | Inception | Price: 80 EGP | After Tax: 91.2 EGP | Seat: A-5 | Booked: No

[Ticket #2] Type: VIP | Avengers | Price: 200 EGP | After Tax: 228 EGP | Lounge Access: Yes | Service Fee: 50 EGP | Booked: No

[Ticket #3] Type: IMAX | Dune | Price: 160 EGP | After Tax: 182.4 EGP | IMAX 3D: Yes | Booked: No

Projector stopped.

========== Cinema Closed ==========
```

---


## 🚀 Getting Started

1. Clone the repository.

```bash
git clone https://github.com/Abdelrahmankishk/Cinema-Booking-System.git
```

2. Open the solution in Visual Studio.

3. Build and run the project.


---

## 👨‍💻 Author

**Abdelrahman Keshk**

Full Stack Developer (.NET & Angular)
