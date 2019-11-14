# MyJobs
- Build Status: [![Build status](https://dev.azure.com/alexMaina/MyJobs/_apis/build/status/MyJobs-CI)](https://dev.azure.com/alexMaina/MyJobs/_build/latest?definitionId=54)

Hack friday sample application
Welcome to our Hack Friday job registry web application
Each one of our registered persons is fortunate enough to have as many jobs as they wish paying their desired amounts..

Go ahead, register your self and your desired jobs!

## Learn how to architect and build a modern web application using the below technologies, patterns and practices:
--Asp.net Core
- EntityFramework Core
- Dependency Injection- 
- Inversion Of Control
- Application Architecture - Hexagonal/Onion/Clean
- Testability - Unit testing

## How To Run:
- Make sure to update the connection string in the MyJobs\appsettings.json file to a valid MS SQL database server.
To Update the database using migrations run (from the web folder):
dotnet ef --startup-project ../MyJobs.Web/MyJobs.Web.csproj  migrations add newmigrationname
 then
dotnet ef --startup-project ../MyJobs.Web/MyJobs.Web.csproj  database update



## Sample Application:
- This repository has autoamted build and release to an azure web app:
- Migrations will also be automatically applied to the database.
https://mysamplejobs.azurewebsites.net
