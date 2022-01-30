using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class MarksViewModel
    {
        public Guid courseId { get; set; }
        public Guid studentId { get; set; }
        public int mark { get; set; }

    }
}
