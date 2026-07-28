# 🎬 Cinema Booking System

A C# Console Application that simulates a **Cinema Booking System**, built incrementally to demonstrate Object-Oriented Programming (OOP) principles and C# programming concepts. Each update extends the existing system with new features while maintaining a clean and modular architecture

The project begins with basic ticket booking functionality and gradually evolves into a more complete cinema management system.


## 📖 Project Overview

The application allows users to book and manage movie tickets through a console interface. It now supports ticket creation, seat assignment, pricing, tax calculation, ticket management, movie searching, automatic ticket identification, booking reference generation, and group discount calculations while demonstrating core Object-Oriented Programming (OOP) principles in C#.

---

## ✨ Features

- Book movie tickets through a console interface.
- Choose a ticket type:
  - Standard
  - VIP
  - IMAX
- Assign seats using a custom `SeatLocation` struct.
- Create tickets using overloaded constructors.
- Encapsulate ticket data using properties with validation.
- Automatically calculate the ticket price after 14% tax.
- Generate unique ticket IDs automatically.
- Track the total number of tickets created.
- Store and manage tickets inside a `Cinema` class.
- Retrieve tickets by index using an indexer.
- Search for tickets by movie name.
- Generate unique booking reference numbers.
- Calculate discounted prices for group bookings.

---

## 🧠 OOP Concepts Covered

- Enums
- Structs
- Classes
- Encapsulation
- Properties
- Constructor Overloading
- Constructor Chaining
- Static Fields
- Static Methods
- Static Utility Classes
- Indexers
- Arrays
- Data Validation
- Console Input & Output

---

## 💻 Sample Output

```text
========== Ticket Booking ==========

Enter data for Ticket 1:
Movie Name: Inception
Ticket Type (0=Standard, 1=VIP, 2=IMAX): 1
Seat Row (A-Z): B
Seat Number: 5
Price: 120

Enter data for Ticket 2:
Movie Name: Avengers
Ticket Type (0=Standard, 1=VIP, 2=IMAX): 0
Seat Row (A-Z): A
Seat Number: 3
Price: 80

Enter data for Ticket 3:
Movie Name: Dune
Ticket Type (0=Standard, 1=VIP, 2=IMAX): 2
Seat Row (A-Z): C
Seat Number: 10
Price: 200

========== All Tickets ==========

Ticket #1 | Inception | VIP | Seat: B-5 | Price: 120 EGP | After Tax: 136.8 EGP
Ticket #2 | Avengers | Standard | Seat: A-3 | Price: 80 EGP | After Tax: 91.2 EGP
Ticket #3 | Dune | IMAX | Seat: C-10 | Price: 200 EGP | After Tax: 228 EGP

========== Search by Movie ==========

Enter movie name to search: Avengers

Found:
Ticket #2 | Avengers | Standard | Seat: A-3 | Price: 80 EGP

Booking References:
BK-1
BK-2

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
