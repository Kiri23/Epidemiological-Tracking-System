# Epidemiological Tracking System

## Description 
This the Solution to the exercise of Epidemiological Tracking System. It allows clients to create, read, update, and delete data on individuals who have been diagnosed with a certain illness.

## Getting Started 

### Prerequisities 
1. Have .net installed
2. Download Visual studio code or your favorite editor

### Installation 
1. Clone the repository
2. Open the solution in vs code
3. Install the C# extension kit extension
4. Restore Nugget package using `dotnet restore`
5. Build the project using `dotnet build`

### Run the application 
1. Run the application using `dotnet run`

### API Endpoints

- GET /api/individuals: Returns a list of all diagnosed individuals
- GET /api/individuals/{id}: Returns a specific individual by ID
- POST /api/individuals: Creates a new individual
- PUT /api/individuals/{id}: Updates an existing individual
- DELETE /api/individuals/{id}: Deletes an existing individual

### Data Model
The Individual model includes:

- Id: unique identifier (integer)
- Name: name of the individual (string)
- Age: age of the individual (integer)
- Symptoms: list of symptoms (string list)
- Diagnosed: boolean indicating diagnosis status
- DateDiagnosed: date of diagnosis (DateTime)

### Features

- CRUD operations for individual records
- In-memory database for quick setup and testing
- Error handling and appropriate status codes
- RESTful API design

