using ClientApp.IService;
using ClientApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp.Services
{
    public class SessionsService : ISessionsService
    {
        public Task Create(Session session)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Session>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
