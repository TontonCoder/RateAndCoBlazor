using ClientApp.IService;
using ClientApp.Services;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ClientApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ICoursesService, CoursesServices>();
            services.AddTransient<IUsersService, UsersService>();
            services.AddTransient<ISessionsService, SessionsService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
