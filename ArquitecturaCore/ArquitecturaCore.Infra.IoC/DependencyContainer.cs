using ArquitecturaCore.Application.Interfaces;
using ArquitecturaCore.Application.Services;
using ArquitecturaCore.Domain.Interfaces;
using ArquitecturaCore.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquitecturaCore.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application Layer
            services.AddScoped<ICourseService, CourseService>();

            // Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
