using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IParentRepository
    {
        Task<List<Student>> GetMyChildren(Guid parentid);
        Task<List<StudentCourse>> GetTranskciptForMyChild(Guid studentid);
        decimal GetAvgForMyChild(Guid stId); 
    }
}
