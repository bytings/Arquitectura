using ArquitecturaCore.Application.Interfaces;
using ArquitecturaCore.Application.ViewModels;
using ArquitecturaCore.Domain.Commands;
using ArquitecturaCore.Domain.Core.Bus;
using ArquitecturaCore.Domain.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquitecturaCore.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            //var createCourseCommand = new CreateCourseCommand(
            //    courseViewModel.Name,
            //    courseViewModel.Description,
            //    courseViewModel.ImageUrl
            //    );


            //_bus.SendCommand(createCourseCommand);

            _bus.SendCommand(_autoMapper.Map<CreateCourseCommand>(courseViewModel));
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCourses().ProjectTo<CourseViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
