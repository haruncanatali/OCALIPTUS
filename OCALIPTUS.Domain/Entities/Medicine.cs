using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCALIPTUS.Domain.Base;
using OCALIPTUS.Domain.Enums;

namespace OCALIPTUS.Domain.Entities
{
    public class Medicine : BaseEntity
    {
        public string Name { get; set; }
        public int Piece { get; set; }
        public DateTime EndTime { get; set; }
        public bool UntilIsOver { get; set; }
        public MedicineFrequency MedicineFrequency { get; set; }

        public long AppointmentId { get; set; }

        public Appointment Appointment { get; set; }
    }
}
