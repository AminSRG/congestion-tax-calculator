# congestion-tax-calculator

I completed this task, utilizing the Repository and Unit of Work pattern, with Entity Framework Core (EF Core) as the Object-Relational Mapping (ORM) framework.

## Project Overview

- The project is designed to calculate congestion taxes based on certain criteria.
- It employs the Repository and Unit of Work patterns to organize data access.
- Entity Framework Core is used as the ORM to interact with the database.

## Code Structure

- The application logic is encapsulated in the `CongestionTaxCalculator` class.
- Data access is abstracted through the use of the Repository pattern with `IQueryUnitOfWork`.
- `CongestionTaxEntry`, `CongestionTaxRate`, and other related classes are used to model data entities.

## Logic and Tax Calculation

I admit that the logic of the `TaxCalculator` isn't entirely clear, but I have made efforts to enhance the code with my backend programming knowledge. It calculates congestion taxes based on various conditions, such as entry time, vehicle type, and more. Further improvements and clarifications can be made in the future.

## Potential Future Enhancements

Here are some potential enhancements that could be considered:

- **CQRS Pattern**: Implement the Command Query Responsibility Segregation (CQRS) pattern to separate the command (write) and query (read) responsibilities of the application.

- **RESTful API**: Create a RESTful API layer to expose the congestion tax calculation functionality, making it accessible via HTTP endpoints.

- **Database Configuration**: Configure the DbContext to support different types of databases, allowing for flexibility in the choice of database technology.

- **Docker Compose/Runtime Migration**: Utilize Docker Compose or runtime migration scripts to automate the setup and initialization of the database instances, including seeding data.

## Contributing

Feel free to contribute to this project by submitting issues, suggesting improvements, or creating pull requests. Your feedback and contributions are highly appreciated!

