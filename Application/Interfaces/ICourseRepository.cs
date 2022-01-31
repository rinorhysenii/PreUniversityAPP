using Application.ViewModels;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICourseRepository
    {
        Task<Course> GetCourse(Guid courseId);
        Task<List<Course>> GetAllCourses();
        Task<int> GetMark(Guid courseId, Guid studentId);
        Task<StudentCourse> AddMark(Guid courseId, Guid studentId, int mark);
        Task<StudentCourse> EditMark(Guid courseId, Guid studentId, int mark);
        Task<StudentCourse> DeleteMark(Guid courseId, Guid studentId);

        Task<MarksReportViewModel> GenerateMarksReport(Guid studentId);
    }
}
