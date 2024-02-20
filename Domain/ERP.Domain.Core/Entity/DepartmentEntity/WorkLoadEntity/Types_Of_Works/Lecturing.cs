using ERP.Domain.Core.Entity.StudentEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Module = ERP.Domain.Core.Entity.StudentEntity.Module;

namespace ERP.Domain.Core.Entity.DepartmentEntity.WorkLoadEntity.Types_Of_Works
{
    public class Lecturing : Tasks_Base_Class
    {
        public int Lecturing_Module_Plan_Id { get; set; }
        public Module? Module { get; set; }

        public string? Specilizaions { get; set; }

        public int Module_Id { get; set; }

        public double Preparation_Hours { get; set; }

        public double Contact_Hours { get; set; }

        public double Lecturing_Hours { get; set; }
        
        public Batch Batch { get; set; }

        public int Batch_Id { get; set; }
    }
}
