using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity.DepartmentEntity.RecruimentEntity
{
    public class RecruimentJobPost
    {
        public int JobId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string QualificationsRequired { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime DeadlineDate { get; set;}

        public string Status { get; set; }

        public ICollection<RecruimentApplication> recruimentApplications { get; set; }

    }
}
