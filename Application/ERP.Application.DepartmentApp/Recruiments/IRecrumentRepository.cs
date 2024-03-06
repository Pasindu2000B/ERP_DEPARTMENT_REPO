using ERP.Domain.Core.Entity.DepartmentEntity.RecruimentEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Recruiments
{
    public interface IRecrumentRepository
    {
        Task AddJobpostAsync(RecruimentJobPost jobpost);

        Task UpdateJobpostAsync(RecruimentJobPost recruimentJobPost);

        Task DeleteJobpostAsync(RecruimentJobPost recruimentJobPost);
    }
}
