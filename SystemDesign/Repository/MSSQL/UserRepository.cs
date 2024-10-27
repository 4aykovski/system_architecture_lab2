using System.Collections.Generic;
using System.Data.SqlClient;
using Model;
using Repository.Interface;
using Utils.Database;

namespace Repository.MSSQL;

public class UserRepository : IUserRepository
{
    private readonly Database _database;

    public UserRepository(Database database)
    {
        _database = database;
    }

    public System.Data.DataTable GetAllUsers()
    {
        var sql = "SELECT * FROM users;";

        var command = new SqlCommand(sql, _database.GetConnection());


        var adapter = new SqlDataAdapter(command);
        System.Data.DataTable dt = new System.Data.DataTable();
        adapter.Fill(dt);

        return dt;
    }
}