using Microsoft.Extensions.DependencyInjection;
using WebSolution01.Application.Interfaces;
using WebSolution01.Application.Services;
using WebSolution01.Domain.Repository;
using WebSolution01.Infra.Repository;

namespace WebSolution01.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddDI(this IServiceCollection s)
        {
            s.AddScoped<IClientRepository, ClientRepository>();
            s.AddScoped<IClientServices, ClientServices>();
        }
    }
}
