using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Course
    {
        public Guid Id { get; set; }

        public string Category { get; set; }

        public Guid TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }

        public string Title { get; set; }
    }
}
