# Skill International School System

A **C# .NET-based** school management system where **admins** can log in and register students. The system allows only registered students to enroll in the school.

## Features
- Admin login system
- Student registration
- Secure access for registered students only
- User-friendly interface

## Screenshots
### Login UI
![Login UI](screenshots/login.png)

### Registration UI
![Registration UI](screenshots/registration.png)

## Installation Guide
### Prerequisites
Ensure your system has the following installed:
- **.NET Framework / .NET Core SDK**
- **Microsoft SQL Server** (for database management)
- **Visual Studio** (recommended for development)

### Steps to Install
1. **Clone the Repository**
   ```sh
   git clone https://github.com/yourusername/Skill-International-School-System.git
   cd Skill-International-School-System
   ```

2. **Open in Visual Studio**
   - Launch **Visual Studio**
   - Open the **Skill-International-School-System.sln** file

3. **Configure Database**
   - Open **SQL Server Management Studio (SSMS)**
   - Create a new database (e.g., `SchoolDB`)
   - Run the provided SQL script (`database/setup.sql`) to create tables
   - Update the connection string in `appsettings.json` or `Web.config`

4. **Build and Run the Application**
   - Click **Start** in Visual Studio
   - The system will open in your browser or as a Windows application

## Technologies Used
- **C# .NET (WinForms / ASP.NET Core)**
- **SQL Server**
- **Entity Framework**
- **Visual Studio**

## License
This project is **open-source**. Feel free to modify and enhance it!

---

Feel free to update this README file as per your project’s structure and features!

