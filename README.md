# APQuizApp
This ia Quiz application using Blazorserver template.


To Run the commands for sqlite:

dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add InitialCreate
dotnet ef database update
