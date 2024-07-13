using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCALIPTUS.Domain.Base;
using OCALIPTUS.Domain.Enums;

namespace OCALIPTUS.Domain.Entities
{
    public class Appointment : BaseEntity
    {
        public long StaffId { get; set; }
        public long PatientId { get; set; }
        public DateTime Date { get; set; }
        public string Hour { get; set; }
        public EntityStatus EntityStatus { get; set; }

        public Staff Staff { get; set; }
        public Patient Patient { get; set; }
        public List<Medicine> Medicines { get; set; }
        public List<Diagnosis> Diagnoses { get; set; }
        public List<AppointmentDocument> AppointmentDocuments { get; set; }
    }
}
