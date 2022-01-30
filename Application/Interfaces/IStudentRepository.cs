using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
   public  interface IStudentRepository
    {
        Task<List<Student>> GetAllStudents(); 
        Student GetStudentbyId(Guid Id);
        Task<List<Course>> GetAllCourses(Guid id);
        decimal GetAverage(Guid id);
        Task<List<StudentCourse>> GetTranskripten(Guid Id);

        
    }


}
