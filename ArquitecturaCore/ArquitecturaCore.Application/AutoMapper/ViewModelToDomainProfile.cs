using ArquitecturaCore.Application.ViewModels;
using ArquitecturaCore.Domain.Commands;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquitecturaCore.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>()
                .ConstructUsing(c => new CreateCourseCommand(c.Name, c.Description, c.ImageUrl));
        }
    }
}
