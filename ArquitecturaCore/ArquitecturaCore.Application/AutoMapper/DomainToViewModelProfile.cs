using ArquitecturaCore.Application.ViewModels;
using ArquitecturaCore.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquitecturaCore.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Course, CourseViewModel>();
        }
    }
}
