using System.Collections.Generic;
using Model;

namespace Repository.Interface;

public interface IProjectRepository
{
    System.Data.DataTable GetAllUsersProjects(string userId);
}