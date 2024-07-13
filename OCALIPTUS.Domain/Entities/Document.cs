using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCALIPTUS.Domain.Base;
using OCALIPTUS.Domain.Identity;

namespace OCALIPTUS.Domain.Entities
{
    public class Document : BaseEntity
    {
        public string Path { get; set; }
        public long UserId { get; set; }

        public User User { get; set; }
    }
}
