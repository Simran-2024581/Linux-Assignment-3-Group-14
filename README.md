# Linux Assignment #3 – Group 14

## Course
COMP 2018 – Linux   System Administration
Instructor: **Anmar Jarjees**

## Group Members
- **Student 1 – Gursimranpreet Kaur**
- **Student 2 – Prakarsh**
- **Student 3 – Rohan**

---

# Project Overview

This project is a **.NET C# Console Application** created for **Linux Assignment #3**.  
The purpose of the application is to help students learn commonly used **Linux commands** through a simple program that reads command data from a **JSON file** and displays them using a **Blueprint class**.

The application demonstrates:

- Reading JSON files using `System.Text.Json`
- Object-Oriented Programming (OOP)
- Blueprint classes (custom classes)
- Constructors & Methods
- Lists & collections (`List<T>`)
- Exception handling (try/catch)
- Clean folder structure in GitHub & Codespaces

---

#  Project Files

Inside the `LinuxCommandsApp` project folder:

### ** Program.cs**
- Contains the `Main()` method  
- Reads the JSON file  
- Deserializes it into C# objects  
- Displays each command using the class method

### ** LinuxCommand.cs (Blueprint Class)**
Includes:
- `Command`  
- `Description`  
- `Category`  
- Optional: `CommandId`  
- Public Method → `ShowCommandInfo()`  
- Constructors (default + custom)

### ** linux-commands.json**
A JSON file containing **at least 7 Linux commands**, each with:
- `Command`
- `Description`
- `Category`

### ** LinuxCommandsApp.csproj**
- .NET project configuration  
- Ensures JSON file is copied to output folder using:

```xml
<CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
