[![uUFsRW.png](https://i.im.ge/2022/07/04/uUFsRW.png)](https://im.ge/i/uUFsRW)
# DisAdvantages
Dependency – Removing dependency in the monolithic application is not easy

# Architecture
Product, Coupon, Shopping cart, orders – OWN Project /API
Payment – Will have its own API Endpoint

MVC will not directly interact with any of the MVC Application.
MVC Application will work with the Identity server in order to get the access token, or verify the authentication and Authorization

To Communicate with any of the microservices, To interact with any of the Microservice, Gateway will be used. Gateway will make a final communication to the individual microservice.

Solid Red line, indicates synchronous communication. One Microservice can directly interact with another microservice. 

The Red dotted lines indicates the asynchronous communication.

For asynchronous communication, Service bus will be used – Azure service bus, rabbit mq, 

# Tools
VS 2019+
SSMS
.NET 6
Azure Subscription

# Nuget Packages in the services(Web API Project)
1. Auto mapper for mapping DTOS to Entity
2. JWT Bearer for Authentication
3. EFCore Tools and SQL for DB & migration
4. Swashbuckle for Documentation

For Microservices, there will be different API and datbase setup has to be different for Each of the API.

In the current project we are using the EF Core. The details can be understood from the [link](https://medium.com/executeautomation/asp-net-core-6-0-minimal-api-with-entity-framework-core-69d0c13ba9ab).

Installing SQL Server in Mac [doc](https://setapp.com/how-to/install-sql-server) /[create own sqlImage](https://www.sqlshack.com/creating-your-own-sql-server-docker-image/). Below steps are used to spin up the database.
1. docker pull mcr.microsoft.com/mssql/server:2022-latest
2. docker run --name sql3 -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=P@ssw0rd01' -e 'MSSQL_PID=Express' -p 1401:1433 -d mcr.microsoft.com/mssql/server
3. Connect to database using : server - "localhost,1401" (localhost,externalPort)

In visual studio for mac, the package manager console doesn't exist. Hennce use dotnet CLI to for migrations.
The connection string should be exactly as below:
"ConnectionStrings": {
    "DefaultConnection": "server=localhost,1401;Database=MangoProductAPI;User ID=SA;Password=P@ssw0rd01;MultipleActiveResultSets=true"
 }
 
 for Package manager console
 1. add migration AddProductModeToDb
 2. update database
 
 For dotnet CLI, Open the terminal from the project location folder (eg. (base) sunilkumaradhya@Admins-MacBook-Pro-3 Mango.Services.ProductAPI % )
 1. dotnet tool install --global dotnet-ef (works)
 2. dotnet tool install --global dotnet-ef --version 3.1.4 (To install a specific version of the tool, use the following command)
 3. dotnet restore
 4. dotnet ef 
 5. dotnet ef migrations add initial
 6. dotnet ef database update


 








