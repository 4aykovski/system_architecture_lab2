using System.Collections.Generic;
using System.Data.SqlClient;
using Model;
using Repository.Interface;
using Utils.Database;

namespace Repository.MSSQL;

public class ProjectTaskRepository : IProjectTaskRepository
{
    private readonly Database _database;

    public ProjectTaskRepository(Database database)
    {
        _database = database;
    }

    public System.Data.DataTable GetTasksOnProject(int projectId)
    {
        var sql = "SELECT * FROM project_tasks WHERE ProjectId = @projectId;";

        var command = new SqlCommand(sql, _database.GetConnection());
        command.Parameters.AddWithValue("@projectId", projectId);


        var adapter = new SqlDataAdapter(command);
        System.Data.DataTable dt = new System.Data.DataTable();
        adapter.Fill(dt);

        return dt;
    }
}