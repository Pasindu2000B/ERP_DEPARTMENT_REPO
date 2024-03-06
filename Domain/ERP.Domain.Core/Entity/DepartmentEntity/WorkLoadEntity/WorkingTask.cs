using ERP.Domain.Core.Entity.StudentEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity.DepartmentEntity.WorkLoadEntity
{
    public class WorkingTask
    {
        public int WorkingTaskId { get; set; }

        public Teacher ? Teacher { get; set; }

        public int TeacherId { get; set; }

        public string ? Decription {  get; set; }

        public bool Assign {  get; set; }

        public double TimeAllocated { get; set; }



    }
}
