using System.Collections.Generic;
using System.Data.SqlClient;
using Model;
using Repository.Interface;
using Utils.Database;

namespace Repository.MSSQL;

public class ProjectRepository : IProjectRepository
{
    private readonly Database _database;

    public ProjectRepository(Database database)
    {
        _database = database;
    }

    public System.Data.DataTable GetAllUsersProjects(string userId)
    {
        var sql = "SELECT * FROM projects WHERE OwnerId = @userId;";

        var command = new SqlCommand(sql, _database.GetConnection());
        command.Parameters.AddWithValue("@userId", userId);


        var adapter = new SqlDataAdapter(command);
        System.Data.DataTable dt = new System.Data.DataTable();
        adapter.Fill(dt);

        return dt;
    }
}