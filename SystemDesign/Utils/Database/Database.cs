using Npgsql;
using System.Data;
using System.Data.SqlClient;

namespace Utils.Database;

public class Database
{
    private readonly NpgsqlConnection _connection;

    public Database(string connectionString)
    {
        _connection = new NpgsqlConnection(connectionString);
    }

    public void OpenConnection()
    {
        if (!_connection.State.Equals(ConnectionState.Open))
        {
            _connection.Open();
        }
    }

    public void CloseConnection()
    {
        if (_connection.State.Equals(ConnectionState.Open))
        {
            _connection.Close();
        }
    }

    public NpgsqlConnection GetConnection()
    {
        return _connection;
    }
}