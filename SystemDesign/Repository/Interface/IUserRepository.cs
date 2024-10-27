using System.Collections.Generic;
using Model;

namespace Repository.Interface;

public interface IUserRepository
{
    System.Data.DataTable GetAllUsers();
}