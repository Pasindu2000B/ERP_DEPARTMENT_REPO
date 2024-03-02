using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity.InternShips
{
    public class JobPost
    {
        public int Id { get; set; }

        public string Category { get; set; }
        public string ? CompanyName { get; set; }

        public string ? CompanyEmail { get; set; }

        public string ? InternPosition { get; set; }

        public string? JobDescriptionLink { get; set; }


    }
}
