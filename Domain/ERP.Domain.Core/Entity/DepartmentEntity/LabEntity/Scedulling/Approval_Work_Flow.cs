using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity.DepartmentEntity.LabEntity.Scedulling
{
    public class Approval_Work_Flow
    {
        public Booking_Lab Booking_Lab { get; set; }

        public int Booking_Id { get; set; }

        public bool Approval_Status { get; set; }

       



    }
}
