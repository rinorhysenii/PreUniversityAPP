using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class TeacherController : BaseApiController
    {
        private readonly ITeacherRepository teacherReporsitory;

        public TeacherController(ITeacherRepository teacherReporsitory)
        {
            this.teacherReporsitory = teacherReporsitory;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTeachers()
        {
            var result = await teacherReporsitory.GetAllTeachers();
            return Ok(result);
        }
    }
}
