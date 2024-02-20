using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Domain.Core.Entity.StudentEntity;

namespace ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity
{
    public class JobApplication
    {
        [Key]
        public int JobApplicationId { get; set; }

        public required Student student { get; set; }

        public required byte[] CV { get; set; }




    }
}
