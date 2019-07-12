using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Chat.BLL
{
    public class Startup
    {
        public static void Init(IServiceCollection services, IConfiguration configuration)
        {
            DAL.Startup.Init(services, configuration);
        }
    }
}
