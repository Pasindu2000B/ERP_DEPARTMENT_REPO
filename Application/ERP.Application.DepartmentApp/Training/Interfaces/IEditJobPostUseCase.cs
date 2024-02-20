using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Training.Interfaces
{
    public interface IEditJobPostUseCase
    {
        Task ExcuteAsync(JobPost jobPost);
    }
}
