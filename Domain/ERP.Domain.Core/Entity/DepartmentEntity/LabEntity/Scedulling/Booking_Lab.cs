using ERP.Domain.Core.Entity.StudentEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity.DepartmentEntity.LabEntity.Scedulling
{
    public class Booking_Lab
    {
        public int BookingID { get; set; }
        public LabSpace Space { get; set; }

        public int LabSpaceId { get; set; }

        public Teacher Module_Coordinator { get; set; }

        public int Module_Coordinator_Id { get; set; }

        public DateTime Start_Time { get; set; }

        public DateTime End_Time { get; set;}

       public ICollection<LabEquipment> Needed_Lab_Equipments { get; set; }

       

       public DateOnly Date_Of_Booking { get; set; }

       






    }
}





