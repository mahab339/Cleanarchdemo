using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
