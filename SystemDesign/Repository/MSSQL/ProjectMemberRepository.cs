using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using Model;
using Repository.Interface;
using Utils.Database;

namespace Repository.MSSQL;

public class ProjectMemberRepository : IProjectMemberRepository
{
    private readonly Database _database;

    public ProjectMemberRepository(Database database)
    {
        _database = database;
    }

    public System.Data.DataTable GetAllUsersOnProjectWithUserData(int projectId)
    {
        var sql = "SELECT * " +
                  "FROM projects_members " +
                  "JOIN users ON projects_members.UserId = users.Id " +
                  "WHERE ProjectId = @projectId;";

        var command = new SqlCommand(sql, _database.GetConnection());
        command.Parameters.AddWithValue("@projectId", projectId);


        var adapter = new SqlDataAdapter(command);
        System.Data.DataTable dt = new System.Data.DataTable();
        adapter.Fill(dt);

        return dt;
    }
}