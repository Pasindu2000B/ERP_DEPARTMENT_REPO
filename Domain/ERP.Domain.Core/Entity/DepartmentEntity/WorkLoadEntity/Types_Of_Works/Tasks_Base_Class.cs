using ERP.Domain.Core.Entity.StudentEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity.DepartmentEntity.WorkLoadEntity.Types_Of_Works
{
    public class Tasks_Base_Class
    {
        public double Time_Allocated {  get; set; }

        public Teacher ?  Task_Responsible_Lecturer { get; set; }

        public int Teacher_Id { get; set; }
    }
}
