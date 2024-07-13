using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCALIPTUS.Domain.Base;
using OCALIPTUS.Domain.Enums;

namespace OCALIPTUS.Domain.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Floor { get; set; }
        public string Photo { get; set; }
        public DepartmentType DepartmentType { get; set; }

        public List<Staff> Staves { get; set; }
    }
}
