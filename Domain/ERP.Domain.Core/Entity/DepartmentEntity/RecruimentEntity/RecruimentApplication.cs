using ERP.Domain.Core.Entity.StudentEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace ERP.Domain.Core.Entity.DepartmentEntity.RecruimentEntity
{
    public class RecruimentApplication
    {
        public int ApplicationId { get; set; }

        public Person Person { get; set; }


        public int PersonId { get; set; }

        public RecruimentJobPost RecruimentJobPost { get; set; }

        public int RecruimentJobPostId {  get; set; }

        public DateOnly submissionDate {  get; set; }

        public string Status { get; set; }

        public String CvFilePath { get; set; }

        public string CoverLetter { get; set; }
    }
}
