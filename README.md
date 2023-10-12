# ASP.NET MVC Employee Management
This ASP.NET MVC Employee Management web application is a comprehensive example that demonstrates user registration and CRUD (Create, Read, Update, Delete) operations using Entity Framework. It features employee registration, login, and a simple Employee management system.

## Features
- Employee registration.
- CRUD operations on Employee records.
- Entity Framework for database management.
- EmpsController for managing Employee records.
- Emp model class with table name and key attribute for database table.
- Views and templates for list, create, edit, delete, and details operations.

## Getting Started
Follow these steps to set up and run the project on your local machine.

## Prerequisites
- [Visual Studio](https://visualstudio.microsoft.com/downloads/) with ASP.NET development tools.
- [SQL Server](https://www.microsoft.com/en-in/sql-server/sql-server-downloads) (LocalDB or a connection to a SQL Server instance).

## Installation
1. Clone the repository to your local machine.
   ```sh
   git clone https://github.com/ideepakpg/mvc.git
   
## Running the Application
1. Open the project in Visual Studio.
   
2. Build the project by selecting "Build" from the top menu or using the keyboard shortcut `Ctrl + Shift + B`.

3. Make sure you have a SQL Server instance available and update the connection string in the `web.config` file to point to your SQL Server database:
   ```sh
   <connectionStrings>
    <add name="DefaultConnection" connectionString="your-connection-string-here;Initial Catalog=your-database-name-here;Integrated Security=True" providerName="System.Data.SqlClient" />
   </connectionStrings>
   
4. Open the Package Manager Console in Visual Studio (Tools > NuGet Package Manager > Package Manager Console).

5. Run the following command to apply migrations and create the database:
   ```sh
   Update-Database
6. Ensure the application's startup project is set to the web project. Right-click the project in the Solution Explorer, select "Set as StartUp Project."

7. Press `F5` or select "`Start`" from the top menu to run the application.

8. Your default web browser will open, and the application will be accessible at the address (usually `http://localhost:port/`).

9. Register a user account or use an existing one to access the application.

10. Use the navigation menu to access Employee CRUD operations.

Now, you have the application up and running on your local machine. You can start using it for employee registration and performing CRUD operations on Employee records. Enjoy!

