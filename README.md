# BulkyWeb E-commerce Project

BulkyWeb is a robust E-commerce project built on the powerful .NET Core 8 MVC framework. This project incorporates key features to ensure a scalable, maintainable, and secure application for your online business needs.

## Features

1. **.NET Core 8 MVC:** Leverage the latest advancements in .NET Core to build a modern, high-performance MVC application.

2. **Central Package Management System:** Efficiently manage dependencies using a centralized package management system, ensuring easy updates and version control.

3. **N Tier Architecture:** Organize your application into distinct layers (presentation, business logic, data access) for better separation of concerns, maintainability, and scalability.

4. **Repository Pattern:** Implement a repository pattern to abstract and encapsulate the data access logic, promoting a clean and testable codebase.

5. **Microsoft Identity Authentication:** Secure your application with Microsoft Identity for robust and customizable user authentication and authorization.

## Folder Structure

- **Bulky.DataAccess:**
  - *DbContext:* Houses the database context for the application.
  - *Migrations:* Contains database migration scripts for seamless database updates.
  - *Repositories:* Implement the repository pattern to manage data access.

- **Bulky.Models:**
  - *Models:* Define the data models used throughout the application.

- **BulkyWeb:**
  - *Controllers:* Handle user requests and manage the flow of data between the model and the view.
  - *Static Content:* Store static files such as CSS, JavaScript, and images.
  - *Program.cs:* Entry point for the application.
  - *Authentication Views:* Located in the `Areas/Identity` folder, these views handle user authentication features.

## Getting Started

1. Clone the repository.
2. Update the connection string in the DbContext to point to your database.
3. Run database migrations to create the necessary tables.

## Folder Structure
```
BulkyWeb
│   README.md
│   ...
├───Bulky.DataAccess
│   ├───DbContext
│   ├───Migrations
│   └───Repositories
├───Bulky.Models
│   └───Models
├───BulkyWeb
│   ├───Controllers
│   ├───wwwroot
│   ├───Views
│   │   └───Identity
│   └───Program.cs
└───...

