using ClientApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp.IService
{
    public interface IUsersService
    {
        Task<IEnumerable<User>> GetAll();
        Task Create(User user);
        Task Delete(int id);
    }
}
