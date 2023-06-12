using Article_MiniWeb._2_Service.Service;
using Article_MiniWeb._2_Service.Service.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Article_MiniWeb._2_Service
{
    public class ServiceDependency
    {
        public static void Register(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>();
        }
    }
}
