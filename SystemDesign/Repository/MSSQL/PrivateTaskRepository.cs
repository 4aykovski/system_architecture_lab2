using System.Collections.Generic;
using System.Data.SqlClient;
using Model;
using Repository.Interface;
using Utils.Database;

namespace Repository.MSSQL;

public class PrivateTaskRepository : IPrivateTaskRepository
{
    private readonly Database _database;

    public PrivateTaskRepository(Database database)
    {
        _database = database;
    }

    public System.Data.DataTable GetTasksOnUser(string userId)
    {
        var sql = "SELECT * FROM private_tasks WHERE UserId = @userId;";

        var command = new SqlCommand(sql, _database.GetConnection());
        command.Parameters.AddWithValue("@userId", userId);

        var adapter = new SqlDataAdapter(command);
        System.Data.DataTable dt = new System.Data.DataTable();
        adapter.Fill(dt);

        return dt;
    }
}