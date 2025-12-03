# Online Shop Management System (Demo)

This is a demo project for an Online Shop Management System built with .NET and SQL Server.  
The setup is simple — clone the project, open it, update the connection string, and run.

---

## Getting Started

Follow the steps below to run the project:

### 1. Clone the Repository
```bash
git clone PUT_GITHUB_LINK_HERE
```

### 2. Open the Solution

Open the `.sln` file using Visual Studio or Visual Studio Code (with the C# extension installed).

### 3. Run the Project

Click the **Run / Play** button in the top-right corner to start the application.

---

## Database Connection

The project uses SQL Server Express by default.  
If you are using SQL Server Developer Edition, replace the existing connection string.

### Default Connection String (SQL Server Express)

You will find the connection string in the file:

```
Models/ShopDbContext.cs
```

### Connection String for SQL Server Developer Edition
```csharp
Server=.\SQLEXPRESS;Database=ProductShopDB_ITP;Integrated Security=true;TrustServerCertificate=true;
```

Replace the existing connection string with the one above.

---

## Enjoy

You are all set. Run the application and explore the Online Shop Management System demo.

