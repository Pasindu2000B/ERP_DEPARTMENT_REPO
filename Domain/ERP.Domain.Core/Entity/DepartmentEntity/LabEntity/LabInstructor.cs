using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity.DepartmentEntity.LabEntity
{
    public class LabInstructor
    {
        [Key]
        public int InstructorId { get; set; }   

        public string InstructorName { get; set; }
        
      
        public int  LabId { get; set; }
    }
}
