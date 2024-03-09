using ERP.Domain.Core.Entity.StudentEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity
{
    public class StudentRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RequestId { get; set; }

        public Student? Student { get; set; }

        public int StudentId { get; set; }

        public string? CompanyName { get; set; }

        public string? CompanySendersName { get; set; }

        public string? CompanySendersDesignation { get; set; }

        public bool IsResponsed { get; set; } = false;

        public DateTime RequestedDate { get; set; } = DateTime.Now;

      
    }
}
