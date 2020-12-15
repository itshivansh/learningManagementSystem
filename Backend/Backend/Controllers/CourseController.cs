using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Exception;
using Backend.Models;
using Backend.ServiceLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] Course course)
        {
            try
            {
                _courseService.AddCourse(course);
                return Created("api/Course", 201);
            }
            catch (CourseAlreadyexist ex)
            {
                return Conflict(ex.Message);
            }
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_courseService.GetCourses());
            }
            catch (CourseNotFound ex)
            {
                return Conflict(ex.Message);
            }
        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(_courseService.DeleteCourse(id));
            }
            catch (CourseNotFound ex)
            {
                return Conflict(ex.Message);
            }
        }
        [HttpGet("{id:int}")]

        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_courseService.GetCourseById(id));
            }
            catch (CourseNotFound ex)
            {
                return Conflict(ex.Message);
            }
        }


    }
}
