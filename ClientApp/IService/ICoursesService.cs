using ClientApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp.IService
{
    public interface ICoursesService
    {
        Task<IEnumerable<Course>> GetAll();
        Task Create(Course course);
        Task Delete(int id);
    }
}
