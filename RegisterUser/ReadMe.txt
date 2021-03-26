Challenge Statement

Prerequisites
	- Any IDE
	- .NET Core SDK 5.0.101

=====================================
Development Environment
=====================================

dotnet run

- The application will be listening on http://localhost:44332
- Now you can call the api using any tool, like Postman, Curl, etc (See "Some Curl command examples" section)

Reports
- For report all users https://localhost:44332/api/Users
- For report users by name https://localhost:44332/api/Users/name/'filter name'
- For report users by status (Active? True or false) https://localhost:44332/api/Users/status/'filter status' 