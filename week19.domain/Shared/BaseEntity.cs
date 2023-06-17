using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week19.domain.Shared
{
    public class BaseEntity
    {
        public DateTime CreatedTIme { get; set; }
        public DateTime? LastModifiedTIme { get;set; }
        public DateTime? DeletedTime { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public int DeletedBy { get; set;}
        public bool IsDeleted { get; set;}
    }
}
