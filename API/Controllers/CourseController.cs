using Application.Interfaces;
using Application.ViewModels;
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
        [HttpGet("getMark/{courseId}/{studentId}")]
        public async Task<IActionResult> GetMark(Guid courseId, Guid studentId)
        {
            var result = await courseReporsitory.GetMark(courseId,studentId);
            return Ok(result);
        }

        [HttpPost("addMark")]
        public async Task<IActionResult> AddMark(MarksViewModel mark)
        {
            var result = await courseReporsitory.AddMark(mark.courseId, mark.studentId, mark.mark);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> EditMark(MarksViewModel mark)
        {
            var result = await courseReporsitory.EditMark(mark.courseId,mark.studentId,mark.mark);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMark(DeleteMarkViewModel del)
        {
            var result = await courseReporsitory.DeleteMark(del.courseId, del.studentId);
            return Ok(result);
        }

        [HttpGet("generateMarksReport/{studentId}")]
        public async Task<IActionResult> GenerateMarksReport(Guid studentId) 
        {
            var result = await courseReporsitory.GenerateMarksReport(studentId);
            return Ok(result);
        }
    }
}
