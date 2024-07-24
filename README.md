# ASP.NET Core Web App - Authentication and Authorization


https://github.com/user-attachments/assets/e4267bad-8fdd-42bf-8eb7-1c4204d55994


This project is an ASP.NET Core Web Application that demonstrates how to implement user registration, authentication, authorization, and role-based authorization using Identity, Entity Framework, SQL Server, and Razor Pages.

## Features

- User Registration
- User Authentication
- Role-based Authorization
- Scaffolding Identity UI items
- SQL Server with Entity Framework

## Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

## Getting Started

### Step 1: Clone the Repository

```bash
git clone https://github.com/yourusername/aspnet-core-authentication-authorization.git
cd aspnet-core-authentication-authorization
```
### Step 2: Configure the Database Connection
Open the appsettings.json file and update the connection string to point to your SQL Server instance:

```json

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  // Other settings
}
```

Create the database using Entity Framework migrations:

```bash

dotnet ef migrations add InitialCreate
dotnet ef database update
```

### Step 3: Run the Application

```bash
dotnet run
```
