using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{

    public class StudentController : BaseApiController
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]

        public async Task<IActionResult> GetAllStudents()
        {
            var resault = await _studentRepository.GetAllStudents();
            return Ok(resault);


        }
        [HttpGet("id")]
        public async Task<IActionResult> GetStudentById(Guid Id)
        {
            var student = _studentRepository.GetStudentbyId(Id);
            return Ok(student);

        }
        [HttpGet("/allcourses")]
        public async Task<IActionResult> GetAllCoursesForStudent(Guid Id)
        {
            var courses = _studentRepository.GetAllCourses(Id);
            return Ok(courses);

        }
        [HttpGet("/average")]
        public async Task<IActionResult> GetAverageForStudent(Guid Id)
        {
            var average = _studentRepository.GetAverage(Id);
            return Ok(average);
        }
        [HttpGet("/transript")]
        public async Task<IActionResult> GetTranskript(Guid Id)
        {
            var transcript = _studentRepository.GetTranskripten(Id);
            return Ok(transcript);
        }


        //}
    }
}
