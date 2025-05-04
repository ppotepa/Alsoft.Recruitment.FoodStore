# Alsoft Recruitment FoodStore

> **❗️ THIS PROJECT IS A RECRUITMENT TASK**

A C# sample application demonstrating a layered architecture for a Food Store system, including domain models, data access, business logic, a discount proof-of-concept, and a web UI.

## Table of Contents

- [About](#about)
- [Features](#features)
- [Code Structure](#code-structure)
- [Prerequisites](#prerequisites)
- [Setup & Run](#setup--run)
- [Testing](#testing)
- [Contributing](#contributing)
- [License](#license)

## About

The FoodStore project was built to showcase clean architecture principles in a .NET environment, using
- SOLID and Domain-Driven Design
- Repository and Service layers
- Dependency Injection modules
- A proof-of-concept discount engine
- An ASP.NET Core Web API interface

This project was **solely done for the purpose of recruitment**.

## Features

- **Domain Models**: Strongly-typed entities representing products, orders, discounts, and more.
- **Repository Pattern**: Abstracted data access via interfaces, allowing for easy swapping of data stores.
- **Dependency Injection**: Modular registration of services and repositories for maintainability.
- **Discount PoC**: A standalone console demo to illustrate configurable discount rules.
- **Web API**: RESTful endpoints for product browsing, order creation, and discount evaluation.

## Code Structure

```
/           # Solution root
├── Alsoft.Recruitment.FoodStore.sln   # .NET solution file
├── .gitignore                         # Git ignore rules
├── .gitattributes                     # Git attributes

├── Alsoft.Recruitment.FoodStore.Abstractions  # Service and repository interface definitions
│   └── ... interfaces (.cs)

├── Alsoft.Recruitment.FoodStore.Entities      # Domain entity classes (Product, Order, etc.)
│   └── ... models (.cs)

├── Alsoft.Recruitment.FoodStore.DAL           # Data access layer (EF Core or in-memory implementations)
│   └── ... repository implementations

├── Alsoft.Recruitment.FoodStore.App           # Business logic / application services
│   └── ... service implementations

├── Alsoft.Recruitment.FoodStore.DiscountPocDemo  # Console demo for discount engine proof-of-concept
│   └── Program.cs

├── Alsoft.Recruitment.FoodStore.Tools         # Utility classes (mappers, extensions, logging)
│   └── ... helpers (.cs)

├── Alsoft.Recruitment.FoodStore.UI            # ASP.NET Core Web API project exposing endpoints
│   └── Controllers, Program.cs, Startup.cs

└── Modules                                    # Dependency Injection modules to wire up services
    └── ... module registration (.cs)
```

## Prerequisites

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- (Optional) Visual Studio 2022 or later / JetBrains Rider

## Setup & Run

1. **Clone and build**
   ```bash
   git clone https://github.com/ppotepa/Alsoft.Recruitment.FoodStore.git
   cd Alsoft.Recruitment.FoodStore
   dotnet build
   ```

2. **Run the Web API**
   ```bash
   dotnet run --project Alsoft.Recruitment.FoodStore.UI/Alsoft.Recruitment.FoodStore.UI.csproj
   ```
   The API will be available at `https://localhost:5001` (or port configured in launch settings).

3. **Run the Discount PoC Demo** (optional)
   ```bash
   dotnet run --project Alsoft.Recruitment.FoodStore.DiscountPocDemo/DiscountPocDemo.csproj
   ```

## Testing

_No automated tests included in this solution._

## Contributing

Contributions are welcome! Feel free to open issues or submit pull requests to:
- Add unit/integration tests
- Enhance the discount engine
- Implement additional features (e.g., shopping cart, user management)

## License

This repository does not include an explicit license. For reuse, please contact the author for permission.
