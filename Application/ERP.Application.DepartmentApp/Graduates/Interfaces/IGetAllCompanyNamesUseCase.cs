﻿using ERP.Domain.Core.Entity.DepartmentEntity.GraduatesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Graduates.Interfaces
{
    public interface IGetAllCompanyNamesUseCase
    {
        Task<List<string>> ExecuteAsync();
    }
}
