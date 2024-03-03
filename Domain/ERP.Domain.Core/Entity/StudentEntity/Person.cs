using ERP.Domain.Core.Entity.DepartmentEntity.RecruimentEntity;
using System.Security.Cryptography.X509Certificates;

namespace ERP.Domain.Core.Entity.StudentEntity
{
    public class Person
    {
        public int PersonId { get; set; }   
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address1 { get; set; } = string.Empty;
        public string Address2 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public DateOnly DoB { get; set; }
        public string NationalID { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        public ICollection <RecruimentApplication> RecruimentsApplications { get; set;}

        public ICollection<Notification> Notifications { get; set;}


    }
}
