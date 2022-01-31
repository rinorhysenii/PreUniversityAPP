using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class MarksReportViewModel
    {
        public string StudentName { get; set; }

        public List<StudentCourse> CoursesTranscript { get; set; }  

        public decimal Average { get; set; }

        public DateTime Date { get; set; }

        public StudentGroup Group { get; set; }
    }
}
