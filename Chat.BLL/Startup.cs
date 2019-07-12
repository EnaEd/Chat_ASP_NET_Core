using Chat.DAL.AppContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Chat.BLL
{
    public class Startup
    {
        public static void Init(IServiceCollection services, IConfiguration configuration)
        {
            DAL.Startup.Init(services, configuration);

            string connection = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppContext>(option =>
             option.UseSqlServer(connection)) ;
        }
    }
}
