using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class CourseController : BaseApiController
    {
        private readonly ICourseRepository courseReporsitory;

        public CourseController(ICourseRepository courseReporsitory)
        {
            this.courseReporsitory = courseReporsitory;
        }

        [HttpGet("getAllCourses")]
        public async Task<IActionResult> GetAllCourses()
        {
            var result = await courseReporsitory.GetAllCourses();
            return Ok(result);
        }
        [HttpGet("getCourse/{courseId}")]
        public async Task<IActionResult> GetCourse(Guid courseId)
        {
            var result = await courseReporsitory.GetCourse(courseId);
            return Ok(result);
        }
    }
}
