# Car Auction System - Clean Architecture

A comprehensive example of Clean Architecture with proper project separation and SOLID principles in C#/.NET.

## 📁 Project Structure

```
CarAuctionSystem/
├── src/
│   ├── Core/
│   │   ├── CarAuction.Domain/          # Domain Layer
│   │   └── CarAuction.Application/     # Application Layer
│   ├── Infrastructure/
│   │   └── CarAuction.Infrastructure/  # Infrastructure Layer
│   └── Presentation/
│       └── CarAuction.Console/         # Console Application
├── tests/                               # Unit Tests
└── docs/                                # Documentation
```

## 🚀 Getting Started

1. Open `CarAuctionSystem.sln` in Visual Studio 2022 or later
2. Restore NuGet packages
3. Build the solution
4. Run `CarAuction.Console` project

## Architecture Layers

- **Domain Layer**: Core business entities and interfaces
- **Application Layer**: Business logic and services
- **Infrastructure Layer**: Data access and external services
- **Console Layer**: User interface

## SOLID Principles

All code follows SOLID principles for professional, maintainable code.
