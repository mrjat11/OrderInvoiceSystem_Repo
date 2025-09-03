🛒 Order Invoice System

Order Invoice System is a real-time Ecommerce web application built with ASP.NET Core MVC (.NET 8), Entity Framework Core, and SQL Server.
It helps customers place orders, process payments, and instantly generate invoices as dynamic PDFs.
Admins can manage invoice templates with a built-in editor, making the system flexible and customizable.

🚀 What’s Inside

👤 Authentication & Authorization

Customers can register, log in, and manage their accounts with cookie-based authentication.

Certain pages (like invoice template management) are restricted to admin users only.

🛍 Customer Order Flow

Browse products, adjust quantities, and create orders.

Choose from multiple payment methods (Credit Card, PayPal, Cash on Delivery).

After payment, the system automatically generates a PDF invoice with customer and order details.

Customers can download or view invoices directly.

🛠 Admin Tools

Manage invoice templates with full CRUD operations.

Templates use placeholders like {CustomerName} or {OrderDate} that are replaced at runtime.

Integrated CKEditor 5 makes template editing easy and user-friendly.

🏗 Tech Stack

ASP.NET Core MVC (.NET 8) – application framework

Entity Framework Core – ORM for SQL Server

SQL Server – relational database

IronPdf – invoice PDF generation

CKEditor 5 – HTML editor for templates

Bootstrap – responsive front-end framework

⚙️ Getting Started
Prerequisites

.NET 8 SDK

SQL Server

Visual Studio 2022 or VS Code

EF Core tools installed

Setup

Clone the repo

git clone https://github.com/mrjat11/OrderInvoiceSystem_Repo.git
cd OrderInvoiceSystem_Repo

Install dependencies

Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package IronPdf

Configure database
Copy the template settings file and update it:
cp appsettings.Template.json appsettings.json
Edit appsettings.json with your SQL Server connection string.

Apply migrations
Add-Migration Initial
Update-Database

Run the application
dotnet run

Open http://localhost:port.no in your browser.

📂 Project Structure
OrderInvoiceSystem_Repo/
│── Controllers/        # MVC controllers
│── Data/               # EF Core DbContext
│── Migrations/         # Database migrations
│── Models/             # Entity classes
│── ViewModels/         # View models for UI
│── Views/              # Razor views
│── wwwroot/            # Static files
│── appsettings.json    # Local configuration (ignored)
│── appsettings.Template.json # Safe template for sharing
│── OrderInvoiceSystem.csproj
│── OrderInvoiceSystem.sln
