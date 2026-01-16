# Car-Auction-SOLID-principle
A cleanly architected car auction web application designed to demonstrate SOLID principles, layered architecture, and domain-driven backend design using ASP.NET Core and Entity Framework.  
This project intentionally focuses on software design quality, separation of concerns, and extensibility, rather than UI complexity.

## 📌 Project Purpose

The primary goal of this application is to showcase:

- Proper application of SOLID principles  
- Clean separation between Domain, Application, Infrastructure, and Presentation layers  
- Realistic auction domain modeling  
- Scalable backend architecture suitable for enterprise systems  

## Core Workflow (High Level)

- User Registration & Authentication
- Car Listing by Seller  
- Auction Creation
- Bidding by Buyers
- Auction Completion
- Payment Processing
- Notification to Buyer & Seller
- Analytics & Reporting

Each step is handled by a dedicated service, ensuring strict responsibility boundaries.

## Technology Stack

- **Backend**: ASP.NET Core, C#
- **ORM**: Entity Framework Core
- **Database**: SQL Server
- **Architecture**: Clean Architecture, SOLID
- **Dependency Injection**: Built-in .NET DI
- **Testing**: xUnit / NUnit (configurable)

## System Overview

The system allows users to:

- Register and authenticate
- List cars for auction
- Participate in bidding
- Complete auction payment
- Notify buyer and seller upon auction completion
- Analyze auction and seller performance

All workflows are implemented using service abstractions and dependency inversion, ensuring loose coupling and high testability.
