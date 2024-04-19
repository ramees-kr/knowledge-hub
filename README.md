# Knowledge Hub - Library Management System

Welcome to the Knowledge Hub project README. This document provides an overview of the project, its features, installation instructions, and other important information.

## Project Overview:

The Knowledge Hub project is a library management system designed to facilitate the management of books, users, fines, and transactions in a library setting. It provides features for both librarians and users to interact with the system efficiently.

## Key Features:

1. **Book Management:**

   - Add, update, and delete books from the library inventory.
   - View details of books, including title, author, publisher, and availability.

2. **User Management:**

   - Register new users and manage their information.
   - Assign roles and permissions to users (e.g., librarian, patron).

3. **Transaction Handling:**

   - Check out and return books.
   - Keep track of transaction history, including dates and users involved.

4. **Fine Management:**
   - Track fines accrued by users for overdue books.
   - Mark fines as paid or unpaid.

## Technologies Used:

- C# Programming Language
- .NET Framework
- Entity Framework Core (EF Core) for data access
- Windows Forms for the user interface

## Architecture and Design Patterns:

- Model-View-ViewModel (MVVM) architectural pattern for separation of concerns
- Dependency Injection (DI) for managing component dependencies
- Repository Pattern for abstracting data access operations
- Multithreading for improving responsiveness and performance

## Installation Instructions:

1. Clone the repository to your local machine.
2. Open the project in Visual Studio or any compatible IDE.
3. Build the solution to restore dependencies and compile the code.
4. Run the project to launch the Knowledge Hub application.

### Setting Up Database:

1. Locate the `create_database.sql` script in the `database` folder.
2. Run the script in your preferred SQL Server Management Tool to create the database schema and populate initial data.

### EF Core Scaffold Command:

```bash
Scaffold-DbContext "Connection String Here" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models\Entities -Context LibDbContext -DataAnnotations -Force
```

## Usage:

- Upon launching the application, users can log in with their credentials (username and password).
- Librarians have access to administrative functionalities, while patrons have limited access to borrowing and returning books.
- Navigate through the application using the provided menu options and forms.

## Contributing:

- Contributions to the project are welcome. Fork the repository, make your changes, and submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
