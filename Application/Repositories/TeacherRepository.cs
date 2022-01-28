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

        public async Task<List<Teacher>> GetAllTeachers()
        {
            var teachers = await context.Teachers.ToListAsync();
            if (teachers == null)
                throw new RestException(HttpStatusCode.BadRequest, "There are no teachers!");
            return teachers;
        }
    }
}
