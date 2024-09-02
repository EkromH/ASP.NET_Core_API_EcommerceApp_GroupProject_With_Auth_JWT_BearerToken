# ASP.NET Core API E-Commerce App with Authentication and JWT Bearer Token
This is a sample e-commerce application built with ASP.NET Core, featuring authentication using JWT Bearer Tokens. The project showcases how to create a full-fledged API for an e-commerce application with authentication and authorization mechanisms in place.

# Features
* Product Management: CRUD operations for products.
* Category Management: CRUD operations for product categories.
* Cart Management: Add, remove, and manage items in the cart.
* Order Management: Place orders, view order details.
* Authentication: JWT Bearer Token-based authentication.
* User Registration and Login: Register new users and log in.
* Role-based Authorization: Different roles with specific permissions.
# Getting Started
* Prerequisites
.NET 8.0 or later

SQL Server or any other supported database

Visual Studio or VS Code (optional but recommended)

# Installation
* Clone the Repository:
git clone https://github.com/EkromH/ASP.NET_Core_API_EcommerceApp_GroupProject_With_Auth_JWT_BearerToken.git
cd ASP.NET_Core_API_EcommerceApp_GroupProject_With_Auth_JWT_BearerToken

* Set Up the Database:
Configure your database connection in appsettings.json.

Run the Entity Framework Core migrations to set up the database schema:

dotnet ef migrations add InitialCreate

dotnet ef database update

* Build and Run the Application:

dotnet build

dotnet run

# Test the API:

Use tools like Postman or cURL to test the API endpoints.
Refer to the API documentation for details on available endpoints and required parameters
