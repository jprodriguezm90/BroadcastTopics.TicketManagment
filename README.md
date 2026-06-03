# BroadcastTopics.TicketManagement

## Overview

BroadcastTopics.TicketManagement is a sample ticket management platform built following Clean Architecture principles using ASP.NET Core and .NET.

This project was created as part of a learning process focused on understanding enterprise application architecture, separation of concerns, dependency management, and scalable application design.

The implementation is based on concepts presented in Gill Cleeren's Clean Architecture training while extending the solution for experimentation and deeper understanding.

---

## Architecture

This solution follows Clean Architecture principles with clear separation between business logic, application behavior, infrastructure concerns, and presentation layers.

### Architecture Layers

```text
API Layer
    ↓

Application Layer
    ↓

Domain Layer
    ↑

Infrastructure Layer
```

### Main Goals

* Separate business logic from implementation details
* Reduce coupling between layers
* Improve maintainability and testability
* Enable easier replacement of infrastructure concerns
* Support scalable application growth

---

## Solution Structure

```text
src/

├── API
│   └── BroadcastTopics.TicketManagement.Api

├── Core
│   ├── BroadcastTopics.TicketManagement.Application
│   └── BroadcastTopics.TicketManagement.Domain

├── Infrastructure
│   ├── BroadcastTopics.TicketManagement.Infrastructure
│   ├── BroadcastTopics.TicketManagement.Persistence
│   └── BroadcastTopics.TicketManagement.Identity

├── UI
│   └── BroadcastTopics.TicketManagement.App

test/

├── API Integration Tests

├── Application Unit Tests

└── Persistence Integration Tests
```

---

## Technologies Used

* .NET 10
* ASP.NET Core
* Clean Architecture
* Dependency Injection
* Entity Framework Core
* MediatR
* Unit Testing
* Integration Testing

---

## Concepts Explored

This repository is used to practice and understand:

* Clean Architecture
* CQRS patterns
* Dependency Injection
* MediatR
* Domain Modeling
* Repository Pattern
* Separation of Concerns
* Testing Strategies
* API Design
* Entity Framework Core

---

## Running the Project

Restore dependencies:

```bash
dotnet restore
```

Run API:

```bash
dotnet run --project src/API/BroadcastTopics.TicketManagement.Api
```

Run tests:

```bash
dotnet test
```

---

## Learning Purpose

This repository is intended for learning, experimentation, and architecture practice.

The objective is not only to reproduce course content but also to understand architectural decisions, tradeoffs, and implementation details behind modern .NET applications.
