using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DapperExample
{
    internal class Postgres
    {
        NpgsqlConnection _con;

        public Postgres(NpgsqlConnection con )
        {
            _con = con;
        }

        List<User> GetUsers()
        {
            _con.Open();
            List<User> users = new List<User>();
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = _con;
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
