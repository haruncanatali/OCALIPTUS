using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCALIPTUS.Domain.Base;
using OCALIPTUS.Domain.Identity;

namespace OCALIPTUS.Domain.Entities
{
    public class Patient : BaseEntity
    {
        public string Photo { get; set; }
        public string Description { get; set; }
        public long UserId { get; set; }

        public User User { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
