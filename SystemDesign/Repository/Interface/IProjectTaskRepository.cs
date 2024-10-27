using System.Collections.Generic;
using Model;

namespace Repository.Interface;

public interface IProjectTaskRepository
{
    System.Data.DataTable GetTasksOnProject(int projectId);
}