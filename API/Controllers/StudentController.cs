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

        public async Task<IActionResult> getAllStudents()
        {
            var resault = await _studentRepository.getAllStudents();
            return Ok(resault);


        }
        [HttpGet("id")]
        public async Task<IActionResult> getStudentById(Guid Id)
        {
            var student = _studentRepository.getStudentbyId(Id);
            return Ok(student);

        }
        [HttpGet("/allcourses")]
        public async Task<IActionResult> getAllCoursesForStudent(Guid Id)
        {
            var courses = _studentRepository.getAllCourses(Id);
            return Ok(courses);

        }
        [HttpGet("/average")]
        public async Task<IActionResult> getAverageForStudent(Guid Id)
        {
            var average = _studentRepository.getAverage(Id);
            return Ok(average);
        }
        [HttpGet("/transript")]
        public async Task<IActionResult> getTranskript(Guid Id)
        {
            var transcript = _studentRepository.getTranskripten(Id);
            return Ok(transcript);
        }


        //}
    }
}
