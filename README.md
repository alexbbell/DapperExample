# DapperExample
Create a console app with .Net Framework 4.7.2 with Dapper 
If you create this ancient app, you should only add Dapper and NPGSQL packages from Nuget. The support of MS SQL Server is already built in. The scenario for .Net Framework is from real life, several applications still require this framework.

Add PostgreSQL
Add Nuget packages npgsql and dapper to your project. Postgres is executed from Docker-container and it’s connection string us ‘postgres://postgres:postgrespw@localhost:49153’

MSSQL server is also run with docker, you can read about how to start it here (http://markimarta.com/sql/install-and-run-mssql-server-in-docker/). There is no need to add something for MS SQL Server to the solution.

For demo I will use only 1 class model
   public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public bool IsActive { get; set; }
        public DateTime Birthdate { get; set; } 
    }

The demo is not about SOLID, it’s just a demo!
