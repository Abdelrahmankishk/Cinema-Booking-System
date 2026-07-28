# 🎬 Cinema Booking System

A C# Console Application that simulates a **Cinema Booking System**, built incrementally to demonstrate Object-Oriented Programming (OOP) principles and C# programming concepts. Each update extends the existing system with new features while maintaining a clean and modular architecture

The project begins with basic ticket booking functionality and gradually evolves into a more complete cinema management system.


## 📖 Project Overview

The application allows users to book movie tickets through a console interface. The current implementation focuses on the core ticket booking process, including ticket creation, seat assignment, pricing, tax calculation, and discount handling.

---

## ✨ Features

- Book a movie ticket through the console.
- Choose a ticket type:
  - Standard
  - VIP
  - IMAX
- Assign a seat using a custom `Seat` structure.
- Create tickets using overloaded constructors.
- Use constructor chaining to eliminate duplicate initialization logic.
- Calculate the total ticket price including tax.
- Apply discounts with validation.
- Display a formatted ticket summary.

---

## 🧠 OOP Concepts Covered

- Enums
- Structs
- Classes
- Encapsulation
- Constructor Overloading
- Constructor Chaining
- Methods
- Console Input & Output

---

## 💻 Sample Output

```text
Enter Movie Name: Obsession
Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): 2
Enter Seat Row (A, B, C...): d
Enter Seat Number: 6
Enter Price: 200
Enter Discount Amount: 30

===== Ticket Info =====
Movie   : Obsession
Type    : IMAX
Seat    : D6
Price   : 200.00
Total (14% tax)   : 228.00

===== After Discount =====
Discount Before     : 30.00
Discount After      : 0.00
Price After Discount: 198.00
Movie : Obsession
Type  : IMAX
```

---


## 🚀 Getting Started

1. Clone the repository.

```bash
git clone https://github.com/<your-username>/Cinema-Booking-System.git
```

2. Open the solution in Visual Studio.

3. Build and run the project.


---

## 👨‍💻 Author

**Abdelrahman Keshk**

Full Stack Developer (.NET & Angular)
