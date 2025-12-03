🛒 Online Shop Management System – Demo

Welcome to the Online Shop Management System demo project.
This application uses SQL Server as its database and is ready to run with minimal setup — just plug and play!

🚀 Getting Started

Follow the steps below to set up and run the project:

📥 1. Clone the Repository
git clone PUT_GITHUB_LINK_HERE

🧪 2. Open the Solution

Open the .sln file using Visual Studio.

▶️ 3. Run the Application

Click the Run / Play button at the top right corner in Visual Studio to start the project.

🗄️ Database Configuration
🔧 4. Default Connection

The project is configured to use SQL Server Express by default.

🛠️ 5. Using SQL Server Developer Edition?

Replace the existing connection string with the following:

Server=.\SQLEXPRESS;Database=ProductShopDB_ITP;Integrated Security=true;TrustServerCertificate=true;

📂 6. Where to Update the Connection String

Navigate to:

Models → ShopDbContext.cs


Replace the current connection string inside this file with the provided one above.

✅ You're All Set!

Enjoy exploring and testing the Online Shop Management System! If you like the project, feel free to ⭐ star the repo.
