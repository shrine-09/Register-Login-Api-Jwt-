# Register-Login-Api-Jwt --- Reusable JWT Authentication Base

This repository contains a **ready-to-use user authentication and authorization system** built with **ASP.NET Core 9 Web API**, **Entity Framework Core**, and **JWT**. It supports:

- User registration and login
- Role-based authorization (Admin/User)
- JWT token generation and validation
- Swagger UI for testing endpoints

This project is designed as a **template/base** for other projects.

----------------------------------------------------------------------------

## Folder Structure
```
RegisterLoginJwt/             <– main project folder
├─ Controllers/               <– AuthController, DevController, etc.
├─ Data/                      <– ApplicationDbContext
├─ Migrations/                <– EF Core migrations
├─ Models/                    <– User.cs
├─ Properties/                <- launchSettings.json
├─ Program.cs 
├─ RegisterLoginJwt.csproj
├─ RegisterLoginJwt.http
├─ appsettings.json
.gitignore
README.md
RegisterLoginJwt.sln          <– solution file
```

----------------------------------------------------------------------------

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- SQLite (included via EF Core provider)
- IDE: Visual Studio, Rider, or VS Code

----------------------------------------------------------------------------

### Setup

**1. Clone the repository**

(In terminal, inside the path to you project):
```
git clone https://github.com/shrine-09/RegisterLoginJwt.git
cd RegisterLoginJwt
```


**2.	Open the solution**

Open "_RegisterLoginJwt.sln_" in your IDE.


**3.	Install dependencies**

Dependencies are restored automatically on build. To restore manually:
```
dotnet restore
```

**4.	Configure JWT**

Update "_appsettings.json_":
```
"Jwt": {
  "Issuer": "https://localhost:5001",
  "Key": "supersecretkey_supersecretkey1234"
}
```
Make sure to use a strong key in production.

----------------------------------------------------------------------------

**Running the API**

Run the project via IDE or CLI:
```
dotnet run --project RegisterLoginJwt/RegisterLoginJwt.csproj
```

Swagger UI will be available at:
  - https://localhost:7001/swagger/index.html


Use Swagger to test endpoints:
  - POST /api/Auth/register → Register a new user
  - POST /api/Auth/login → Login and get JWT token
  - GET /api/Auth/admin-only → Protected endpoint, requires Admin role
  - DELETE /api/dev/delete-admin → Use to delete the test admin, requires the test admin email from database

----------------------------------------------------------------------------

**Reuse in Other Projects**
 1.	Clone this repo in your new project folder.
 2.	Open the solution (RegisterLoginJwt.sln) or reference the RegisterLoginJwt project.
 3.	Configure your new project to use ApplicationDbContext and AuthController.
 4.	Update JWT settings in your new project.
 5.	Run migrations to initialize the database.

----------------------------------------------------------------------------

**Notes**
 - This is a base template — you can modify roles, JWT expiry, or claims as needed.
 - Never commit sensitive keys to public repositories; use environment variables or secrets for production.

----------------------------------------------------------------------------

MIT License

Copyright (c) 2025 Shrine Ghimire

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES, OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

