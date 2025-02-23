using Microsoft.Extensions.DependencyInjection;

namespace Cleanarch.Infra.Ioc
{
    public class Dependencycontainer
    {
        public static void Registerservices(IServiceCollection services)
        {
            // Application layer
            services.AddScoped<Application.Interfaces.Icourseservice, Application.Services.Course>();
            //Infra.Data layer
            services.AddScoped<Domain.Interfaces.Icourserepository, Data.Repositories.Course>();
        }
    }
}
