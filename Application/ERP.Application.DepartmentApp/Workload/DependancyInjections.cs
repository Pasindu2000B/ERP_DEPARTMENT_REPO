using ERP.Application.DepartmentApp.Training.Interfaces;
using ERP.Application.DepartmentApp.Training.Usecases;
using ERP.Application.DepartmentApp.Workload.Interfaces;
using ERP.Application.DepartmentApp.Workload.UseCases;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Workload
{
    public static class DependancyInjections
    {
        public static IServiceCollection WorkLoadServices(
          this IServiceCollection services)
        {
            services.AddScoped<IWorkTaskCRUDUseCase, WorkTaskCrudUseCase>();

            return services;
        }
    }
}
