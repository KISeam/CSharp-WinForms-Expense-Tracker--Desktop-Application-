# CSharp-WinForms-Expense-Tracker-(Desktop-Application)

A modern Windows Forms Expense Tracker application developed using C# and .NET 10.0.
This project demonstrates GUI application development, event-driven programming, object-oriented programming, and dynamic UI updates for personal finance tracking.

---

## 📌 Project Overview

This application provides a clean and interactive graphical interface where users can track daily expenses by title, amount, and category.
The system automatically calculates total spending and maintains a live expense history.

### Features:

* Add personal expenses
* Category-based expense tracking 
* Real-time total expense calculation
* Dynamic expense history display
* Input validation and error handling
* Modern Windows Forms UI design
* Interactive event-driven functionality

---

## 🧠 Key Concepts Demonstrated

* Object-Oriented Programming (OOP)
* Windows Forms Application Development
* Event-Driven Programming
* Dynamic UI Rendering
* Collections using `List<T>`
* LINQ (`Sum`)
* Input validation using `TryParse`
* Custom UI styling and layout
* User interaction handling

---

## 🛠 Technologies Used

* C#
* .NET 10.0
* Windows Forms (WinForms)
* LINQ
* System.Drawing

---

## 📂 Project Structure

```bash
CSharp-WinForms-Expense-Tracker/
│── Program.cs
│── Form1.cs
│── Expense.cs
│── CSharp-WinForms-Expense-Tracker.csproj
│── README.md
```

---

## ▶️ How to Run

### Clone the Repository

```bash
git clone <your-repository-url>
```

### Navigate to Project Folder

```bash
cd CSharp-WinForms-Expense-Tracker
```

### Run the Application

```bash
dotnet run
```

---

## 💻 Application Interface

The application includes:

* Expense title input
* Amount input field
* Expense category selector
* Add Expense button
* Total spending display
* Expense history section

---

## 🧾 Supported Categories

Users can organize expenses into categories such as:

* Food
* Transport
* Bills
* Entertainment
* Others

---

## 💻 Sample Expense History

```text
[Food] Burger Meal     -> $12.50
[Transport] Uber Ride  -> $8.75
[Bills] Internet Bill  -> $45.00
```

---

## 📊 Real-Time Expense Calculation

The application automatically updates the total spending amount using LINQ:

```csharp
double totalSpent = _expenses.Sum(x => x.Amount);
```

This ensures instant feedback whenever a new expense is added.

---

## 🎨 UI Design Features

* Modern clean interface
* Custom button styling
* Centered application window
* Color-based summary section
* Responsive control placement
* Readable expense history formatting

---

## 🎯 Learning Objectives

* Building desktop applications using WinForms
* Understanding event-driven programming
* Managing dynamic user interfaces
* Implementing real-time data updates
* Structuring scalable desktop applications
* Applying OOP concepts in GUI applications

---

## 👨‍💻 Author

Seam
Full-stack Developer

---
