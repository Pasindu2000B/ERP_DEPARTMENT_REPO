using ERP.Domain.Core.Entity.StudentEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity.DepartmentEntity.RecruimentEntity
{
    public class Notification
    {
        public int NotificationId { get; set; }

        public Person Person { get; set; }

        public int userId { get; set; }

        public string Content { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
