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
   public  class ParentRepository : IParentRepository
    {
        public readonly DataContext _context;
        public readonly IStudentRepository _studentRepository;
        public ParentRepository(DataContext context,
            IStudentRepository studentRepository)
        {
            _context = context;
            _studentRepository = studentRepository;
        }
        public decimal getAvgForMyChild(Guid stId)
        {
            decimal avg = _studentRepository.getAverage(stId);
            return avg;
        }

        public async Task<List<Student>> getMyChildren(Guid parentid)
        {
            var students = await _context.Students.Where(x => x.ParentId == parentid).Include(x=>x.Parent).ToListAsync();
            if (students == null)
            {
                throw new RestException(HttpStatusCode.BadRequest, "There are no marks");
            }
            return students;
        }

        public async Task<List<StudentCourse>> getTranskciptForMyChild(Guid studentid)
        {
            var trascript= await _studentRepository.getTranskripten(studentid);
            if (trascript == null)
            {
                throw new RestException(HttpStatusCode.BadRequest, "There are no marks");

            }
            return trascript;
        }

      
    }
}
