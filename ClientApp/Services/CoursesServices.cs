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
    public class CoursesServices : ICoursesService
    {
        string url = "http://localhost:8080/courses";
        private HttpClient client;

        public async Task Create(Course course)
        {
            client = new HttpClient();
            await client.PostJsonAsync<Course>(url, course) ;            
        }

        public async Task Delete(int id)
        {
            client = new HttpClient();
            await client.DeleteAsync(url+"/"+id);
        }

        public async Task<IEnumerable<Course>> GetAll()
        {
            client = new HttpClient();
            var courses = await client.GetJsonAsync<Course[]>(url);
            return courses;
        }

        public async Task<Course> GetCourse(int id)
        {
            client = new HttpClient();
            return await client.GetJsonAsync<Course>(url + "/" + id);
        }
    }
}
