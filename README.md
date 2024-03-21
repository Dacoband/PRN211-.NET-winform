# PRN211_DotNet

- Basic Cross-Platform Application Programming With .NET

# Recipe for Cooking a Practical Exam App

## I. Create a Solution

- Follow the naming convention as in the exam paper instruction.
- Put your work in a folder on the desktop.
- Name of solution, main-GUI project: ..._YOURNAME

## II. Create 3 Different Projects

1. **Windows Forms App/Project**
   - Name: ..._YOURNAME
   - Choose: .NET 8.

2. **Class Library App/Project**
   - Name: Repositories
   - Choose: .NET 8.

3. **Class Library App/Project**
   - Name: Services
   - Choose: .NET 8.

### Dependency/Reference Between Projects

1. From Services project to Repositories:
   - Add reference (Copy Local).

2. From GUI project to Services:
   - Add reference (Copy Local).

## III. Check SQL Server Configuration & Services

- TCP/IP Protocol Enable
- Port 1433
- SQL Server Browser Service: Manual/Automatic | Running

## IV. Run .SQL Script to Create Database

- Open the .sql file attached with the exam paper in SQL Server Management Studio and execute (F5) to create the database.

## V. Install EF Core CLI

1. Open Command Prompt and run:
```dotnet tool install --global dotnet-ef --version 8.*```
```dotnet tool install --global dotnet-ef```

2. Check installation:
```dotnet tool list --global```
```dotnet-ef```

3. Uninstall EF Core CLI:
```dotnet tool uninstall dotnet-ef -g```

## VI. Declare/Download/Import EF Core Library
1. Declare in Repositories project.
2. Use NuGet Package Manager in Visual Studio.
3. Install 4 packages:
  - Microsoft.EntityFrameworkCore
  - Microsoft.EntityFrameworkCore.Design
  - Microsoft.EntityFrameworkCore.Tools
  - Microsoft.EntityFrameworkCore.SqlServer


### Update Visual Studio for EF Core

- Build solution to update EF Core library.

## VII. Generate Entity Classes from Database

- Use PowerShell to run the command within Repositories project.
- Modify Connection String to match SQL Server.
- Command:
```dotnet ef dbcontext scaffold "Server=(local);Database='Your Database';UID='Your UserName';PWD='Your Password';TrustServerCertificate=True" "Microsoft.EntityFrameworkCore.SqlServer" --output-dir "Entities" --context-dir ".\" ```

## VIII. No Hard-Coded Connection String

### Add JSON dependency into Repositories project:
  - Microsoft.Extensions.Configuration
  - Microsoft.Extensions.Configuration.Json
- Create appsettings.json in GUI project.
- Update content of appsettings.json.
   ```{
        "ConnectionStrings": {
          "DefaultConnectionStringDB": "server =(local); database= BookManagementDb;uid=sa;pwd=1234567890; TrustServerCertificate=True"
        }
      }```
- Update DbContext file to read Connection String from appsettings.json.
     ```private string? GetConnectionString()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true).Build();
            return configuration["ConnectionStrings:DefaultConnectionStringDB"];
        }```
- UPDATE method: OnConfiguring() to call the method GetConnectionString() by replace the hard-coded Connection String
- Set property "Copy to output Directory" of appsettings.json file to "Copy if newer"

#### Supervisor : doit-now - giao.lang

#### Connect me via: NhanHTSE171117@fpt.edu.vn  || bolicious123@gmail.com

#### &#169; 2024 Volka
