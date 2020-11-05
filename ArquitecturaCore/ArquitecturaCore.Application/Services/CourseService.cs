using ArquitecturaCore.Application.Interfaces;
using ArquitecturaCore.Application.ViewModels;
using ArquitecturaCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquitecturaCore.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
