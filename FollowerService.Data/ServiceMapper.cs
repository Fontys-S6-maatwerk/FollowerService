using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;

namespace FollowerService.Data
{
    public static class ServiceMapper
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(ConnectionStringUtil.GetConnectionString(), new MySqlServerVersion(new Version(8, 0, 26)))
            );


            //services.AddTransient<IUserLogic, UserLogic>();
        }
    }
}
