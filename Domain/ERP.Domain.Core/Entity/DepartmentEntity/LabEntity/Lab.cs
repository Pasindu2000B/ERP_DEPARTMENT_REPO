using ERP.Domain.Core.Entity.StudentEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity.DepartmentEntity.LabEntity
{
    public class Lab
    {
        [Key] 
        public int LabId {  get; set; }

        public string LabName { get; set; }

        public Module module { get; set; }

        public Batch batch { get; set; }

        public ICollection<LabEquipment>labEquipments { get; set; }

        public DateTime date { get; set; }

        public LabSpace space { get; set; } 



        



        
    }
}
