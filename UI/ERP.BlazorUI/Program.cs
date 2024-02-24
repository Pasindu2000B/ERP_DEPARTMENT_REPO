using ERP.Application.DepartmentApp.Labs.Repository;

using ERP.Application.StudentApp.Interfaces;
using ERP.Application.StudentApp.Students;
using ERP.Application.StudentApp.Students.Interfaces;
using ERP.BlazorUI.Components;
using ERP.Repository.InMemory;
using ERP.Repository.PgSql;
using ERP.Repository.SQLite;
using Microsoft.EntityFrameworkCore;

using MudBlazor.Services;
using ERP.Repository.PgSql.Department.Lab;
using ERP.Application.DepartmentApp.Labs.UseCases.Inventor_Lab;
using ERP.Application.DepartmentApp.Labs.Interfaces.Inventory_Lab;
using ERP.Application.DepartmentApp.Graduates.Repository;
using ERP.Repository.PgSql.Department.Graduate;
using ERP.Application.DepartmentApp.Graduates.Interfaces;
using ERP.Application.DepartmentApp.Graduates.UseCases;
using ERP.Application.DepartmentApp.Training.Interfaces;
using ERP.Application.DepartmentApp.Training.Usecases;
using ERP.Application.DepartmentApp.Training;
using ERP.Repository.PgSql.Department.Training;
using MudBlazor;
using NuGet.Protocol.Core.Types;

var builder = WebApplication.CreateBuilder(args);

// Configuration of EF Core SQLite
ConfigurationManager configuration = builder.Configuration;

//builder.Services.AddDbContext<BaseDbContext>(opt => opt.UseSqlite(configuration.GetConnectionString("StudentDatabase"),
//     b => b.MigrationsAssembly("ERP.Repository.SQLite")));

//builder.Services.AddDbContext<PgSqlDbContext>(opt => opt.UseNpgsql(configuration.GetConnectionString("PgSqlConnection"),
//     b => b.MigrationsAssembly("ERP.Repository.PgSql")));

builder.Services.AddDbContextFactory<PgSqlDbContext>(opt => opt.UseNpgsql(configuration.GetConnectionString("PgSqlConnection"),
     b => b.MigrationsAssembly("ERP.Repository.PgSql")));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMudServices();


builder.Services.AddScoped<IStudentRepository, StudentRepositoryPgSql>();
builder.Services.AddScoped<ILabRepository,LabRepositoryPgSql>();
builder.Services.AddScoped<IGraduateRepository, GraduateRepositoryPgSql>();
builder.Services.AddScoped<TrainingRepository, TraininiRepositoryPgSQL>();
builder.Services.AddScoped<IGetLabEquipmentListUseCase, GetLabEquipmentlistUseCase>();
builder.Services.AddScoped<IViewStudentsByNameUseCase, ViewStudentsByNameUseCase>();
builder.Services.AddScoped<IAddStudentUseCase, AddStudentUseCase>();
builder.Services.AddScoped<IViewStudentById, ViewStudentById>();
builder.Services.AddScoped<IEditStudentUseCase, EditStudentUseCase>();
builder.Services.AddScoped<IAddLabEquipmentUseCase,AddNewLabEquipmentUseCase>();
builder.Services.AddScoped<IAddGraduateUseCase, AddGraduateUseCase>();
builder.Services.AddScoped<IStudentRequestCreateUseCase,StudentRequestUseCase>();
builder.Services.AddScoped<IGetGraduateListUseCase, GetGraduateListUseCase>();
builder.Services.AddScoped<IEditGraduateUseCase, EditGraduateUseCase>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
