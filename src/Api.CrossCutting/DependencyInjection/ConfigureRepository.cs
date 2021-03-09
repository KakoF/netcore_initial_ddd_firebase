using Api.Data.Context.Interface;
using Api.Data.Repositories;
using Api.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
          public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection){
            serviceCollection.AddScoped(typeof (IUserRepository), typeof(UserRepository));
             
            //serviceCollection.AddScoped<MyContext>();
        }
    }
}