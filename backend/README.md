# ApiProject
If you want to use project in your device :

-Add proper ConnectionString (e.g your local server) -Update database (vs: update-database, vsc with cmd: dotnet ef database update)

######//.net core creating with cmd 1.crete folder 2.create solution file ( dotnet new sln --name MySolution ) 3.create Api project ( dotnet new webapi -o YourprojectName ) 4.add project to solution file ( dotnet sln [<SOLUTION_FILE>] add [--in-root] [-s|--solution-folder ] <PROJECT_PATH> [<PROJECT_PATH>...])

######//packages for downloading with cmd dotnet tool uninstall --global dotnet-aspnet-codegenerator dotnet tool install --global dotnet-aspnet-codegenerator dotnet tool uninstall --global dotnet-ef dotnet tool install --global dotnet-ef dotnet add package Microsoft.EntityFrameworkCore.Design dotnet add package Microsoft.EntityFrameworkCore.SQLite

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design dotnet add package Microsoft.EntityFrameworkCore.SqlServer dotnet add package Microsoft.EntityFrameworkCore.Tools

######//migrations with cmd dotnet tool install --global dotnet-ef dotnet ef migrations add yourMigrationName dotnet ef database update dotnet ef migrations remove

######//migrations with Visual Studio add-migration yourMigrationName update-database
#####//for adding migrations add data folder  ( dotnet ef migrations add Initial --context AppDbContext -o Data/Migrations)
#####// dotnet add package FluentValidation.AspNetCore
#####// Packes For AutoMap  dotnet add package AutoMapper
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
