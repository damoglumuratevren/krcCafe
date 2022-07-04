using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE.Entity.Concrete
{
    public class BaseEntity
    {

        public int CreatedUserId { get; set; }
        public DateTime CreatedDtm { get; set; } = DateTime.Now;


        public int? ModifiedUserId { get; set; }
        public DateTime? ModifiedDtm { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
