using ERP.Domain.Core.Entity.DepartmentEntity.LabEntity.Scedulling;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity.DepartmentEntity.LabEntity
{
    public class LabSpace
    {
        [Key]
        public int LabSpaceId { get; set; }
        public string LabSpaceName { get; set; }

        public ICollection<LabEquipment> labEquipments { get; set; }

        public ICollection<Booking_Lab> booking_Labs { get; set; }
       
           
    }
}
