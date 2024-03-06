using ERP.Application.DepartmentApp.Graduates.Interfaces;
using ERP.Application.DepartmentApp.Graduates.UseCases;
using ERP.Application.DepartmentApp.Recruiments.Interfaces;
using ERP.Application.DepartmentApp.Recruiments.UseCases;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Recruiments
{
    public static class DependancyInjectionsINrRecruiment
    {
        public static IServiceCollection RecruimentServices(
             this IServiceCollection services)
        {
            //services.AddScoped<IGetLabEquipmentListUseCase, GetLabEquipmentlistUseCase>();
            services.AddScoped<IRecruimentCrudUseCase, CRUDRecrumentUseCase>();
            return services;


        }
    }
}
