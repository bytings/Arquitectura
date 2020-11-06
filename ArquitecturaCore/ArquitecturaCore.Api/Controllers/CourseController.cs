﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArquitecturaCore.Application.Interfaces;
using ArquitecturaCore.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ArquitecturaCore.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CourseViewModel courseViewModel)
        {
            _courseService.Create(courseViewModel);

            return Ok(courseViewModel);
        }
    }
}
