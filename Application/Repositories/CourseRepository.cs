using Application.Helpers.Errors;
using Application.Interfaces;
using Application.ViewModels;
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
    public class CourseRepository : ICourseRepository
    {
        private readonly DataContext context;

        private readonly IStudentRepository studentRepository;

        public CourseRepository(DataContext context, IStudentRepository studentRepository)
        {
            this.context = context;
            this.studentRepository = studentRepository;
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
        public async Task<StudentCourse> AddMark(Guid courseId, Guid studentId, int mark)
        {
            StudentCourse studentCourse = new StudentCourse();

            var exists = context.StudentCourses.Select(x => x.CourseId == courseId).FirstOrDefault();
            if (exists)
            {
                studentCourse = await context.StudentCourses.Where(x => x.CourseId == courseId).FirstOrDefaultAsync();
                studentCourse.Mark = mark;
                var res = context.Update(studentCourse);
            }
            else
            {
                studentCourse.Id = Guid.NewGuid();
                studentCourse.StudentId = studentId;
                studentCourse.CourseId = courseId;
                studentCourse.Mark = mark;
                studentCourse.IsMarked = true;
                var result = await context.StudentCourses.AddAsync(studentCourse);
            }

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
            studentCourse.IsMarked = false;
            context.StudentCourses.Update(studentCourse);
            await context.SaveChangesAsync();
            return studentCourse;
        }

        public async Task<MarksReportViewModel> GenerateMarksReport(Guid studentId)
        {
            var student = studentRepository.GetStudentbyId(studentId);
            var coursesTranscript = await studentRepository.GetTranskripten(studentId);

            MarksReportViewModel marksReport = new MarksReportViewModel()
            {
                StudentName = student.Name,
                CoursesTranscript = coursesTranscript,
                Average = studentRepository.GetAverage(studentId),
                Date = DateTime.Now,
                Group = await context.StudentGroups.Where(x => x.StudentId == studentId).Include(x => x.Group).FirstOrDefaultAsync()
            };
            return marksReport;
        }
    }
}
