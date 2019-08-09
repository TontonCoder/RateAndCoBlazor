using ClientApp.IService;
using ClientApp.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientApp.Services
{
    public class UsersService : IUsersService
    {
        private HttpClient client;
        private string url = "http://localhost:8080/users";
        public async Task Create(User user)
        {
            client = new HttpClient();
            await client.PostJsonAsync<User>(url, user);
        }

        public async Task Delete(int id)
        {
            client = new HttpClient();
            await client.DeleteAsync(url + "/" + id);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            client = new HttpClient();
            var users = await client.GetJsonAsync<User[]>(url);
            return users;
        }
    }
}
