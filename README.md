# Customer API

## Overview

The **Customer API** project is designed to manage customer data through a RESTful API. Built using ASP.NET Core, it provides endpoints to create, read, update, and delete customer information. This project serves as a practical example for understanding backend development and API creation in an ASP.NET environment.

## Features

- **Create Customer**: Add new customers to the database.
- **Read Customer**: Retrieve customer details.
- **Update Customer**: Modify existing customer information.
- **Delete Customer**: Remove customers from the database.
- **Error Handling**: Robust error handling for various scenarios.
- **Validation**: Data validation using middleware.

## Installation

To run the API locally:

1. Clone the repository:
    ```bash
    git clone https://github.com/Qyuzet/customerApi.git
    ```
2. Navigate to the project directory:
    ```bash
    cd customerApi
    ```
3. Install dependencies:
    ```bash
    dotnet restore
    ```
4. Run the application:
    ```bash
    dotnet run
    ```

## File Structure

- **Controllers/CustomerController.cs**: Contains the API endpoints for customer operations.
- **Models/Customer.cs**: Defines the customer schema.
- **Data/CustomerContext.cs**: Configures the database context.
- **Startup.cs**: Configures the application services and middleware.

## Usage

1. Start the server:
    ```bash
    dotnet run
    ```
2. Use an API client like Postman to interact with the API.

### Endpoints

- **GET /api/customers**: Retrieve all customers.
- **GET /api/customers/:id**: Retrieve a single customer by ID.
- **POST /api/customers**: Create a new customer.
- **PUT /api/customers/:id**: Update an existing customer by ID.
- **DELETE /api/customers/:id**: Delete a customer by ID.

### Code Explanation

#### Controllers/CustomerController.cs

Defines the API routes for customer operations, linking them to the corresponding service functions.

#### Models/Customer.cs

Defines the customer schema using Entity Framework Core, including fields like `name`, `email`, and `phone`.

#### Data/CustomerContext.cs

Configures the database context and establishes the connection to the SQL Server database.

#### Startup.cs

Configures services and middleware, including Entity Framework Core and routing.

### Detailed Explanation

#### Creating Customers
The `POST /api/customers` endpoint is used to add new customers. The data is validated using the model annotations before being saved to the database.

#### Reading Customers
The `GET /api/customers` endpoint retrieves all customers, while `GET /api/customers/:id` fetches a specific customer by their ID.

#### Updating Customers
The `PUT /api/customers/:id` endpoint updates an existing customer's information. It also uses the model annotations for data validation.

#### Deleting Customers
The `DELETE /api/customers/:id` endpoint removes a customer from the database based on their ID.

## Error Handling

The API includes robust error handling to manage issues such as missing fields, invalid data, and server errors. Middleware functions are used to catch and respond to errors appropriately.

## Academic Insights

This project illustrates fundamental concepts in backend development, including RESTful API design, middleware usage, data validation, and database interactions. Computer science students can learn:

- **ASP.NET Core**: Building scalable server-side applications.
- **Entity Framework Core**: Working with relational databases in a .NET environment.
- **API Design**: Structuring and documenting APIs.
- **Middleware**: Implementing middleware for validation and error handling.

## Contributing

Contributions are welcome! To contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes.
4. Commit your changes (`git commit -m 'Add some feature'`).
5. Push to the branch (`git push origin feature-branch`).
6. Open a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](https://github.com/Qyuzet/customerApi/blob/main/LICENSE) file for details.

## Contact

For any questions or suggestions, please contact Riki Awal Syahputra at [riqyuzet@gmail.com](mailto:riqyuzet@gmail.com).

For more details and to view the code, visit the [GitHub repository](https://github.com/Qyuzet/customerApi).
