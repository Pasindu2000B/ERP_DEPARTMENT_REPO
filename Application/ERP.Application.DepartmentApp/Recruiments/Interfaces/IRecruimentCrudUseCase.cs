using ERP.Domain.Core.Entity.DepartmentEntity.RecruimentEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Recruiments.Interfaces
{
    public interface IRecruimentCrudUseCase 
    {
        Task AddRecruimentExecuteAsync(RecruimentJobPost recruimentJobPost);
        Task DeleteRecruimentExecuteAsync(RecruimentJobPost recruimentJobPost);

        Task EditRecruimentExecteAsync(RecruimentJobPost recruimentJobPost);
    }
}
