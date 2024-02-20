using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Domain.Core.Entity.StudentEntity;

namespace ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public  string CompanyName { get; set; }
        public  string CompanyEmail { get; set; }
        public  Person ContactPerson { get; set; }
        public  string CompanyLocation { get; set; }


    }
}
