using System.Collections.Generic;
using Model;

namespace Repository.Interface;

public interface IPrivateTaskRepository
{
    System.Data.DataTable GetTasksOnUser(string userId);
}