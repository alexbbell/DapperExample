using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DapperExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var con = new NpgsqlConnection(
                connectionString: "Server=localhost;Port=49153;User Id=postgres;Password=postgrespw;Database=postgres;");
            Postgres postgres = new Postgres(con);
            postgres.PrintUsers();


            var mssqlConnectionString = "Server=localhost; Database=TicketsDB; User Id=SA; Password=<YourStrong@Passw0rd>; Trusted_Connection=False; MultipleActiveResultSets=true";
            var connection = new SqlConnection(mssqlConnectionString);
            MSSQLServer mSSQLServer = new MSSQLServer(connection);
            mSSQLServer.PrintUsers();

        }


    }
}
