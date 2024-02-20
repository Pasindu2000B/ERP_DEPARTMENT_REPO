using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity.DepartmentEntity.LabEntity
{
    public class LabRepair
    {
        public int LabEquipmentId { get; set; }

        public required LabEquipment LabEquipment { get; set; }

        public double Cost { get; set; }

        public bool CostRecieved { get; set; }

        public bool Repaired { get; set; }



    }
}
