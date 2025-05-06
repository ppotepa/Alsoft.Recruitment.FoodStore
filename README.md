# Alsoft Recruitment FoodStore

> **❗️ THIS PROJECT IS A RECRUITMENT TASK**

A C# sample application demonstrating a layered architecture for a Food Store system, including domain models, data access, business logic, a discount proof-of-concept, and a web UI.

## Table of Contents

- [About](#about)
- [Features](#features)
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

## Prerequisites

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- (Optional) Visual Studio 2022 or later / JetBrains Rider

## Setup & Run

![image](https://github.com/user-attachments/assets/530fde18-2c5b-40a3-b129-d238e740864f)
Please make sure you set both starting projects as shown above.

OR JUST USE START.BAT

## Testing

_No automated tests included in this solution._

## Contributing

Contributions are welcome! Feel free to open issues or submit pull requests to:
- Add unit/integration tests
- Enhance the discount engine
- Implement additional features (e.g., shopping cart, user management)

## License

This repository does not include an explicit license. For reuse, please contact the author for permission.
