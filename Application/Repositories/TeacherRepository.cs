using Application.Helpers.Errors;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {

        private readonly DataContext context;

        public TeacherRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<StudentCourse> AddMark(Guid courseId, Guid studentId, int mark)
        {
            var studentCourse = new StudentCourse()
            {
                Id = Guid.NewGuid(),
                StudentId = studentId,
                CourseId = courseId,
                Mark = mark,
                IsMarked = true
            };

            var result = await context.AddAsync(studentCourse);
            await context.SaveChangesAsync();

            return studentCourse;
        }

        public async Task<StudentCourse> EditMark(Guid courseId, Guid studentId, int mark)
        {
            var studentCourse = await context.StudentCourses.Where(x => x.StudentId == studentId && x.CourseId == courseId).FirstOrDefaultAsync();
            studentCourse.Mark = mark;
            context.StudentCourses.Update(studentCourse);
            await context.SaveChangesAsync();
            return studentCourse;
        }

        public async Task<StudentCourse> DeleteMark(Guid courseId, Guid studentId)
        {
            var studentCourse = await context.StudentCourses.Where(x => x.StudentId == studentId && x.CourseId == courseId).FirstOrDefaultAsync();
            studentCourse.Mark = 0;
            context.StudentCourses.Update(studentCourse);
            await context.SaveChangesAsync();
            return studentCourse;
        }

        public async Task<List<Teacher>> GetAllTeachers()
        {
            var teachers = await context.Teachers.ToListAsync();
            if (teachers == null)
                throw new RestException(HttpStatusCode.BadRequest, "There are no teachers!");
            return teachers;
        }

        public async Task<List<Course>> GetAllCourses()
        {
            var courses = await context.Courses.ToListAsync();
            if (courses == null)
                throw new RestException(HttpStatusCode.BadRequest, "There are no courses!");
            return courses;
        }

        public async Task<Course> GetCourse(Guid courseId)
        {
            var course = await context.Courses.FindAsync(courseId);
            if (course == null)
                throw new RestException(HttpStatusCode.BadRequest, "There are no course!");
            return course;
        }

        public async Task<int> GetMark(Guid courseId, Guid studentId)
        {
            var studentCourse = await context.StudentCourses.Where(x => x.StudentId == studentId && x.CourseId == courseId).FirstOrDefaultAsync();
            if (studentCourse == null)
                throw new RestException(HttpStatusCode.BadRequest, "There are no marks");
            return studentCourse.Mark;
        }
    }
}
