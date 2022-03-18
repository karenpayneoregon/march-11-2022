@echo off
cls



dotnet new webapp -o Demo3 
dotnet add Demo3\Demo3.csproj package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation -v 5.0.11
dotnet add Demo3\Demo3.csproj package Microsoft.VisualStudio.Web.BrowserLink -v 2.2.0
dotnet add Demo3\Demo3.csproj package Microsoft.EntityFrameworkCore.SqlServer -v 5.0.9
dotnet add Demo3\Demo3.csproj package Microsoft.Extensions.Configuration -v 5.0.0
dotnet add Demo3\Demo3.csproj package Microsoft.Extensions.Configuration.Binder -v 5.0.0
dotnet add Demo3\Demo3.csproj package Microsoft.Extensions.Configuration.FileExtensions -v 5.0.0
dotnet add Demo3\Demo3.csproj package Microsoft.Extensions.Configuration.Json -v 5.0.0




dotnet sln RazorSolution.sln add Demo3\Demo3.csproj --solution-folder RazorPages

pause




