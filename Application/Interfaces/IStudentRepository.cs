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
        Task<List<Student>> getAllStudents();
        Student getStudentbyId(Guid Id);
        Task<List<Course>> getAllCourses(Guid id);
        decimal getAverage(Guid id);
        Task<List<StudentCourse>> getTranskripten(Guid Id);

        
    }


}
