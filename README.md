# 🎬 Cinema Booking System

A C# Console Application that simulates a **Cinema Booking System**, built incrementally to demonstrate Object-Oriented Programming (OOP) principles and C# programming concepts. Each update extends the existing system with new features while maintaining a clean and modular architecture

The project begins with basic ticket booking functionality and gradually evolves into a more complete cinema management system.


## 📖 Project Overview

The Cinema Booking System has evolved into a modular, object-oriented console application that demonstrates core and intermediate C# concepts. The system now supports multiple ticket types, cinema management, runtime polymorphism, method overloading, and reusable ticket processing while maintaining a clean and extensible architecture.

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
- Store and manage tickets inside a cinema.
- Search and retrieve tickets.
- Generate unique booking references.
- Calculate group booking discounts.
- Open and close the cinema using a projector.
- Print ticket information polymorphically.
- Process any ticket type through a common interface.

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
- Inheritance
- Composition
- Static Members
- Static Utility Classes
- Indexers
- Arrays
- Data Validation
- Console Applications

---

## 💻 Sample Output

```text
========== Cinema Opened ==========
Projector started.

========== Ticket Booking ==========

Enter data for Ticket 1:
Movie Name: Inception
Ticket Type (0 = Standard, 1 = VIP, 2 = IMAX): 0
Seat Row: A
Seat Number: 5
Price: 150

Enter data for Ticket 2:
Movie Name: Avengers
Ticket Type (0 = Standard, 1 = VIP, 2 = IMAX): 1
Seat Row: B
Seat Number: 5
Price: 200

Enter data for Ticket 3:
Movie Name: Dune
Ticket Type (0 = Standard, 1 = VIP, 2 = IMAX): 2
Seat Row: B
Seat Number: 8
Price: 180

========== SetPrice Test ==========

Setting price directly: 150
Setting price using multiplier: 1.5

========== All Tickets ==========

Ticket #1 | Type: Standard | Inception | Price: 150 EGP | After Tax: 171 EGP | Seat: A-5

Ticket #2 | Type: VIP | Avengers | Price: 200 EGP | After Tax: 228 EGP | Lounge Access: Yes | Service Fee: 50 EGP

Ticket #3 | Type: IMAX | Dune | Price: 210 EGP | After Tax: 239.4 EGP | IMAX 3D: Yes

========== Statistics ==========

Total Tickets Created: 4

========== Process Single Ticket ==========

Ticket #4 | Type: VIP | Avengers | Price: 225 EGP | After Tax: 256.5 EGP | Lounge Access: Yes | Service Fee: 50 EGP

========== Generating Booking References ==========

Booking Reference 1: BK-1
Booking Reference 2: BK-2

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
