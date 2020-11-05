using ArquitecturaCore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquitecturaCore.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
