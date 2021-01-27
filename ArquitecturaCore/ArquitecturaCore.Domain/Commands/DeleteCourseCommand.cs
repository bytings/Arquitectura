using System;
using System.Collections.Generic;
using System.Text;

namespace ArquitecturaCore.Domain.Commands
{
    public class DeleteCourseCommand : CourseCommand
    {
        public DeleteCourseCommand(string name, string description, string imageUrl)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }
    }
}
