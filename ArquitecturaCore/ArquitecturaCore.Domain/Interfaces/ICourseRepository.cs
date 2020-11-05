using ArquitecturaCore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquitecturaCore.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
