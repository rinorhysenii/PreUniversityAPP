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
        [HttpGet("getMark/{studentId}")]
        public async Task<IActionResult> GetMark(Guid courseId, Guid studentId)
        {
            var result = await courseReporsitory.GetMark(courseId,studentId);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddMark(Guid courseId,Guid studentId, int mark)
        {
            var result = await courseReporsitory.AddMark(courseId, studentId, mark);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> EditMark(Guid courseId, Guid studentId, int mark)
        {
            var result = await courseReporsitory.EditMark(courseId,studentId,mark);
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteMark(Guid courseId, Guid studentId)
        {
            var result = await courseReporsitory.DeleteMark(courseId, studentId);
            return Ok(result);
        }
    }
}
