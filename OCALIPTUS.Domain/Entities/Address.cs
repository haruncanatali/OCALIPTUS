using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCALIPTUS.Domain.Base;

namespace OCALIPTUS.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string Title { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string Description { get; set; }
    }
}
