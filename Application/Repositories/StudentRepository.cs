using Application.Helpers.Errors;
using Application.Interfaces;
using Domain.Entities;
using Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public readonly DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Course>> GetAllCourses(Guid id)
        {
            var coursesEnrollment = await _context.StudentCourses.Where(x => x.StudentId == id).ToListAsync();
            List<Course> course = new List<Course>();
            foreach(var item in coursesEnrollment)
            {
                course.Add(_context.Courses.Where(x => x.Id == item.Id).FirstOrDefault());
            }
            if (course == null)
            {
                throw new RestException(HttpStatusCode.BadRequest, "There are no courses!");
            }

            return course;
           
        }

        public async Task<List<Student>> GetAllStudents()
        {
            List<Student> students= await  _context.Students.ToListAsync();
            if (students == null)
            {
                throw new RestException(HttpStatusCode.BadRequest, "There are no courses!");
            }
            return students;
        }

        public decimal GetAverage(Guid id)
        {
            int Courses = 0;
            int sumOfMarks = 0;
            List<StudentCourse> studentCourses = _context.StudentCourses.Where(x => x.Id == id && x.IsMarked==true).ToList();
            Courses = studentCourses.Count();
           foreach(var item in studentCourses)
            {
                sumOfMarks += item.Mark;
                
            }
            decimal average = sumOfMarks / Courses;

            return average;

        }

        public Student GetStudentbyId(Guid id)
        {
            var student = _context.Students.Where(x => x.Id == id).FirstOrDefault();
            if (student == null)
            {
                throw new RestException(HttpStatusCode.BadRequest, "There are no courses!");
            }
            return student;
        }

        public async Task<List<StudentCourse>> GetTranskripten(Guid Id) 
        {
            var transkript = await _context.StudentCourses.Where(x => x.StudentId == Id).Include(x => x.Student).Include(x => x.Course).ToListAsync();

            if(transkript == null)
            {
                throw new RestException(HttpStatusCode.BadRequest, "There are no courses!");
            }
            return transkript;
        }
        
    }
}
