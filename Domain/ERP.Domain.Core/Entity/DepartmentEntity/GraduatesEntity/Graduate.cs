using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity.DepartmentEntity.GraduatesEntity
{
    public class Graduate
    {
        [Key]
        public int GraduateID { get; set; }
        public string GraduateName { get; set; }
        public string GraduateDescription { get; set; }
        public string GraduateContactNo { get; set; }
        public string GraduateCompany { get; set; }

    }
}
