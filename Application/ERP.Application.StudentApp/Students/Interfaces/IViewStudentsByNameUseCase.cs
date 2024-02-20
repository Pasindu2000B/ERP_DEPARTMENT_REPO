using ERP.Domain.Core.Entity.StudentEntity;

namespace ERP.Application.StudentApp.Students.Interfaces
{
    public interface IViewStudentsByNameUseCase
    {
        Task<IEnumerable<Student>> ExecuteAsync(string name = "");
    }
}