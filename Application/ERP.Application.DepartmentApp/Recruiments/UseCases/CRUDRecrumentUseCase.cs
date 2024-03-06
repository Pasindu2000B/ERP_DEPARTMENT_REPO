using ERP.Application.DepartmentApp.Recruiments.Interfaces;
using ERP.Domain.Core.Entity.DepartmentEntity.RecruimentEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Recruiments.UseCases
{
    public class CRUDRecrumentUseCase : IRecruimentCrudUseCase
    {
        private IRecrumentRepository _repository;

        public CRUDRecrumentUseCase(IRecrumentRepository repository)
        {
            _repository = repository;
            
        }

        public async Task AddRecruimentExecuteAsync(RecruimentJobPost recruimentJobPost)
        {
           await _repository.AddJobpostAsync(recruimentJobPost);
        }

        public async Task DeleteRecruimentExecuteAsync(RecruimentJobPost recruimentJobPost)
        {
           await _repository.DeleteJobpostAsync(recruimentJobPost);
        }

        public async Task EditRecruimentExecteAsync(RecruimentJobPost recruimentJobPost)
        {
           await _repository.UpdateJobpostAsync(recruimentJobPost);
        }
    }
}
