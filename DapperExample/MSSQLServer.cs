using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DapperExample
{
    internal class MSSQLServer
    {
        SqlConnection _con;

        public MSSQLServer(SqlConnection con )
        {
            _con = con;
        }

        List<User> GetUsers()
        {
            _con.Open();
            List<User> users = new List<User>();
            using (var cmd = new SqlConnection())
            {
                users = _con.Query<User>($"SELECT * FROM \"Users\"").ToList();
            }
            return users;
        }
        
        public void PrintUsers()
        {
            List<User> users = this.GetUsers();
            foreach (var user in users)
            {
                string result = (user.LastName + ": " + user.Name + " : " + user.IsActive + " : " + user.Birthdate);
                Console.WriteLine(result);
            }
        }

    }
}
