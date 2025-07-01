## Library Management System

## Installation
Intall the followings: Visual Studio 2022, SQL server and Microsoft SQL Server Management Studio.

## NuGet Packages
In Visual Studio, Go to Tools > NuGet Package Manager > Manage NuGet Packages for Solutions.

Go on Browse tab and download the followings: `Microsoft.EntityFrameworkCore` | `Microsoft.EntityFrameworkCore.SqlServer` | `Microsoft.EntityFrameworkCore.Tools`

 
## Create Database

My SQL Server needs to be running in background.

On Microsoft SQL Server Management Studio(MSSQL):

- Connect to the server using `(local)` as server name
- Right-click on `Database`
- Add a New Database with the name **`LibraryDB`**

On Visual Studio 2022:

- Go on Tools > Connect to Database
- server name = `(local)`
- databse name = `LibraryDB`

## Update Database

- Go to Tools > NuGet Package Manager > Package Manager Console.
- In the console, Write `Add-Migration initial`
- Next `Update-Database`.

  This 2 commands will create the database and fill in dummy data.
