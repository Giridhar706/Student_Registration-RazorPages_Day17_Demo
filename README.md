# Student Registration Portal - ASP.NET Core Razor Pages

## Project Overview
This project is a simple Student Registration Portal developed using ASP.NET Core Razor Pages.

The application allows students to:
- Enter their name
- Submit registration
- Receive an instant personalized confirmation message

The project demonstrates:
- Razor Pages
- Model Binding
- OnPost() Handling
- Dynamic UI Updates
- Form Processing

---

## Technologies Used
- ASP.NET Core
- Razor Pages
- C#
- HTML
- Bootstrap

---

## Features
✅ Student Name Input  
✅ Automatic Model Binding  
✅ OnPost() Request Handling  
✅ Personalized Confirmation Message  
✅ Simple and Clean UI  

---

## Project Flow

```text
Student enters name
        ↓
Clicks Register button
        ↓
Input binds to StudentName
        ↓
OnPost() method executes
        ↓
Confirmation message generated
        ↓
Response displayed on UI
```

---

## Project Structure

```text
StudentRegistrationPortal
│
├── Pages
│   ├── Register.cshtml
│   └── Register.cshtml.cs
│
├── wwwroot
│
└── Program.cs
```

---

## Sample Output

### Input

```text
Student Name : Giridhar Gopal
```

### Output

```text
Hello Giridhar Gopal, Registration Successful!
```

---

## How to Run

1. Open project in Visual Studio
2. Build the solution
3. Run the application using:

```text
Ctrl + F5
```

4. Open browser and navigate to:

```text
https://localhost:xxxx/Register
```

---

## Learning Outcomes
- Understanding Razor Pages
- Working with Model Binding
- Handling Form Submission
- Using OnPost() Method
- Displaying Dynamic Responses

---

## Author
Giridhar Gopal
