# APICrudServer1
* This is a sample Customer Controller for an ASP.NET Core API that provides CRUD (Create, Read, Update, Delete) operations for customer data. It is designed to interact with a database using Entity Framework Core.

## Getting Started
* Before you begin, make sure you have the necessary tools and dependencies installed. This code assumes you have already set up your ASP.NET Core project and Entity Framework DbContext. If not, you can refer to official documentation or tutorials on how to set up an ASP.NET Core API with Entity Framework.

## Prerequisites
1 Visual Studio or Visual Studio Code (for development)
2 .NET Core SDK
3 Entity Framework Core
4 An SQL Server database or a database of your choice
## Installation
1 Clone this repository to your local machine.

    
``git clone https://github.com/your/repository ``
2 Open the project in your preferred development environment.

3 Configure the appsettings.json file to point to your database server and database name.



```
"ConnectionStrings": {
    "DefaultConnection": "Server=your-server;Database=your-database;Trusted_Connection=True;"
}
```
4 Open the Package Manager Console or run the following command in the terminal to apply Entity Framework migrations and update the database.
```
dotnet ef database update
Build and run the project.
```

## API Endpoints
* This API provides the following endpoints to manage customer data:

* GET /api/customer: Retrieve a list of all customers.
* GET /api/customer/{id}: Retrieve a specific customer by ID.
* POST /api/customer: Create a new customer.
* PUT /api/customer/{id}: Update an existing customer by ID.
* DELETE /api/customer/{id}: Delete a customer by ID.
  
### Example Requests
```
GET /api/customer
```
** Retrieve a list of all customers.

```
GET /api/customer
GET /api/customer/{id}
```
** Retrieve a specific customer by ID.

```
GET /api/customer/1
POST /api/customer
```
Create a new customer. Send a JSON request body with customer data.
```
POST /api/customer
Content-Type: application/json

{
    "name": "John Doe",
    "email": "john.doe@example.com"
}
```
```
PUT /api/customer/{id}
```

** Update an existing customer by ID. Send a JSON request body with the updated customer data.

```
PUT /api/customer/1
Content-Type: application/json

{
    "id": 1,
    "name": "Updated Name",
    "email": "updated.email@example.com"
}
```
```
DELETE /api/customer/{id}
Delete a customer by ID.

```
DELETE /api/customer/1

```
## Response Codes
```
200 OK: The request was successful.
201 Created: The resource was successfully created (for POST requests).
204 No Content: The request was successful (for DELETE requests).
400 Bad Request: The request is invalid.
404 Not Found: The requested resource does not exist.
500 Internal Server Error: An error occurred on the server.
```

## Technologies Used

* ASP.NET Core
* Entity Framework Core
* SQL Server (or your preferred database)
