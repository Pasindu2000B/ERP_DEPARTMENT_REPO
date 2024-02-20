using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity.DepartmentEntity.LabEntity
{
    public class LabEquipment
    {
        [Key]
        public int LabEquipmentID { get; set; }

        
       
        public string LabEquipmentName { get; set; }

        public string condition { get; set; }

        public bool Avaialability { get; set; }

        public int LabSpaceId { get; set; }

      
    








    }



}
