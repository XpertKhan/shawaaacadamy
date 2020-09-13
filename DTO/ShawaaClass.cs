using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ShawaaClass
    {
        public int ClassId { get; set; }

        public string ClassName { get; set; }

        public TimeSpan? ClassStartTime { get; set; }

        public TimeSpan? ClassEndTime { get; set; }

        public DateTime? ClassStartDate { get; set; }

        public DateTime? ClassEndDate { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? DeletedDate { get; set; }

        public int? DeletedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? UpdatedBy { get; set; }

    }
}
