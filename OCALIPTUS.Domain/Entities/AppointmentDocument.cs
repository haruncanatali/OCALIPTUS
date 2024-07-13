using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCALIPTUS.Domain.Base;
using OCALIPTUS.Domain.Identity;

namespace OCALIPTUS.Domain.Entities
{
    public class AppointmentDocument : BaseEntity
    {
        public string Path { get; set; }
        public long AppointmentId { get; set; }

        public Appointment Appointment { get; set; }
    }
}
