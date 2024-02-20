using ERP.Domain.Core.Entity.StudentEntity;

namespace ERP.Application.StudentApp.Students.Interfaces
{
    public interface IAddStudentUseCase
    {
        Task ExecuteAsync(Student student);
    }
}