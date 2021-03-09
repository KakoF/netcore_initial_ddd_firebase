using Api.Domain.Interfaces.Service.User;
using Api.Service.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection){
            serviceCollection.AddScoped<IUserService, UserService>();
        }
    }
}