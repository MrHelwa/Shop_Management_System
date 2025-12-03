🛒 Online Shop Management System (Demo)
This is a demo project for an online shop management system. It uses SQL Server as the database — just plug and play!

🚀 Getting Started
Clone the repository

bash
git clone put_github_link_here
Open the solution file

Navigate to the project folder.

Open the .sln file in Visual Studio (or VS Code with extensions).

Run the project

Click the Play ▶️ button at the top right in Visual Studio/VS Code.

⚙️ Database Setup
The project uses SQL Server Express by default.

If you’re using SQL Server Developer Edition, update the connection string:

csharp
Server=.\SQLEXPRESS;Database=ProductShopDB_ITP;Integrated Security=true;TrustServerCertificate=true;
📂 You’ll find this connection string in: Models/ShopDbContext.cs → replace the existing string with the one above.

🎉 Enjoy!
