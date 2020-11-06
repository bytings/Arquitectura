using ArquitecturaCore.Application.Interfaces;
using ArquitecturaCore.Application.Services;
using ArquitecturaCore.Domain.CommandHandlers;
using ArquitecturaCore.Domain.Commands;
using ArquitecturaCore.Domain.Core.Bus;
using ArquitecturaCore.Domain.Interfaces;
using ArquitecturaCore.Infra.Bus;
using ArquitecturaCore.Infra.Data.Context;
using ArquitecturaCore.Infra.Data.Repository;
using MediatR;
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

            // Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // Domain Handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            // Application Layer
            services.AddScoped<ICourseService, CourseService>();

            // Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDBContext>();
        }
    }
}
