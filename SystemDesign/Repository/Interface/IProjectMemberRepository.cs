using System.Collections.Generic;
using Model;

namespace Repository.Interface;

public interface IProjectMemberRepository
{
    System.Data.DataTable GetAllUsersOnProjectWithUserData(int projectId);
}