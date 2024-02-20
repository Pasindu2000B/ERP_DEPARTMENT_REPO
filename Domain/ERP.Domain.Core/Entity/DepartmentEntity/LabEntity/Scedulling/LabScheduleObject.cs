using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity.DepartmentEntity.LabEntity.Scedulling
{
    public class LabScheduleObject
    {
        public LabSpace Space { get; set; }

        public int Lab_Space_Id { get; set; }

        public DateTime Start_Time { get; set; }

        public DateTime End_Time { get; set;}





    }
}
