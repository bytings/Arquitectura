using ArquitecturaCore.Application.AutoMapper;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArquitecturaCore.Api.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ArquitecturaCore.Application.AutoMapper.AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();
        }
    }
}
