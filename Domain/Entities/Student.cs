using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Student
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string StudentNumber { get; set; }

        public string RoleId { get; set; }

        public Guid ParentId { get; set; }

        public virtual Parent Parent { get; set; }
    }
}
