using ArquitecturaCore.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquitecturaCore.Application.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
        void Create(CourseViewModel courseViewModel);
    }
}
