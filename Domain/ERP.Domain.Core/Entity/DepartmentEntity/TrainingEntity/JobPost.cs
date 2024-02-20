using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity
{
    public class JobPost
    { 
        [Key]
        public int JobPostId { get; set; }

        public string JobPostName { get; set; }

        [ForeignKey(nameof(Company))]
        public  string CompanyId { get; set; }

        public  string Description { get; set; }

        public string JobCategory  { get; set; }




    }
}
