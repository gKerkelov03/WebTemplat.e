using Microsoft.Extensions.DependencyInjection;
using Template.Services.Common;
using System;
using System.Linq;

namespace Template.Web.Infrastructure.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddConventionalServices(this IServiceCollection services)
        {
            Type transientServiceInterface = typeof(ITransientService),
                scopedServiceInterface = typeof(IScopedService),
                singletonServiceInterface = typeof(ISingletonService);

            var publicTypesFromServices = transientServiceInterface
                .Assembly
                .GetExportedTypes()
                .Where(t => t.IsClass && !t.IsAbstract)
                .Select(t => new
                {
                    Interface = t.GetInterface($"I{t.Name}"),
                    Implementation = t
                })
                .Where(t => t.Interface != null);

            foreach(var type in publicTypesFromServices)
            {
                if (transientServiceInterface.IsAssignableFrom(type.Interface))
                {
                    services.AddTransient(type.Interface, type.Implementation);
                }
                else if (scopedServiceInterface.IsAssignableFrom(type.Interface))
                {
                    services.AddScoped(type.Interface, type.Implementation);
                }
                else if (singletonServiceInterface.IsAssignableFrom(type.Interface))
                {
                    services.AddSingleton(type.Interface, type.Implementation);
                }
            }

            return services;
        }
    }
}
