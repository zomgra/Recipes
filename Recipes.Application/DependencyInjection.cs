using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;
using Recipes.Application.Recipes.Queries.GetRecipeList;
using Recipes.Application.Common.Mapper;
using FluentValidation;

namespace Recipes.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                 cfg.RegisterServicesFromAssemblies(typeof(GetRecipeListQuery).Assembly); 
            });
            services.AddAutoMapper(typeof(ApplicationMapper));

            services.AddValidatorsFromAssemblies(new[] {Assembly.GetExecutingAssembly() });

            return services;
        }
    }
}
