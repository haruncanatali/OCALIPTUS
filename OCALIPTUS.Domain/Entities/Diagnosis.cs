using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCALIPTUS.Domain.Base;

namespace OCALIPTUS.Domain.Entities
{
    public class Diagnosis : BaseEntity
    {
        public string Description { get; set; }
        public DiagnosisType DiagnosisType { get; set; }
        public long AppointmentId { get; set; }

        public Appointment Appointment { get; set; }
    }
}
