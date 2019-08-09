using ClientApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp.IService
{
    public interface ISessionsService
    {
        Task<IEnumerable<Session>> GetAll();
        Task Create(Session session);
        Task Delete(int id);
    }
}
