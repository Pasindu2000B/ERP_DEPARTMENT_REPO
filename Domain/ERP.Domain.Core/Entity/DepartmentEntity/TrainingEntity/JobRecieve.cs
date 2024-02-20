using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity
{
    public class JobRecieve
    {
        [Key]
        public required JobApplication Application { get; set; }
        public required JobPost JobPost { get; set; }

        public required byte[] ConfirmLetter { get; set; }




    }
}
