using ArquitecturaCore.Domain.Interfaces;
using ArquitecturaCore.Domain.Models;
using ArquitecturaCore.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquitecturaCore.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx;

        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
