using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class StudentGroup
    {
        public Guid Id { get; set; }

        public Guid GroupId { get; set; }

        public virtual Group Group { get; set; }

        public Guid StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
