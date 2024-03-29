﻿using ERP.Domain.Core.Entity.DepartmentEntity.GraduatesEntity;
using ERP.Domain.Core.Entity.DepartmentEntity.LabEntity;
using ERP.Domain.Core.Entity.DepartmentEntity.LabEntity.Scedulling;
using ERP.Domain.Core.Entity.DepartmentEntity.RecruimentEntity;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity.InternShips;
using ERP.Domain.Core.Entity.DepartmentEntity.WorkLoadEntity;
using ERP.Domain.Core.Entity.StudentEntity;
using ERP.Repository.PgSql.Configurations;
using ERP.Repository.PgSql.Configurations.DepartmentPortalConfigurations;
using ERP.Repository.PgSql.Configurations.DepartmentPortalConfigurations.GraduateConfigurations;
using ERP.Repository.PgSql.Configurations.DepartmentPortalConfigurations.LabConfigurations;
using ERP.Repository.PgSql.Configurations.DepartmentPortalConfigurations.TrainingConfigurations;
using ERP.Repository.PgSql.Migrations;
using Microsoft.EntityFrameworkCore;

namespace ERP.Repository.PgSql
{
    public class PgSqlDbContext : DbContext
    {
        public PgSqlDbContext(DbContextOptions<PgSqlDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfigurations());
            modelBuilder.ApplyConfiguration(new LabSpaceConfiguration());
            modelBuilder.ApplyConfiguration(new LabEquipmentConfiguration());
            
            modelBuilder.ApplyConfiguration(new GraduateConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.DepartmentPortalConfigurations.TrainingConfigurations.TrainingConfigurations());


            modelBuilder.Entity<ModuleOfferingTeacher>()
            .HasKey(mt => new { mt.ModuleOfferingId, mt.TeacherId });

         
            modelBuilder.Entity<ModuleOfferingTeacher>()
                .HasOne(mt => mt.ModuleOffering)
                .WithMany(mt => mt.Teachers)
                .HasForeignKey(mt => mt.ModuleOfferingId);

           
            modelBuilder.Entity<ModuleOfferingTeacher>()
                .HasOne(mt => mt.Teacher)
                .WithMany(mt => mt.TeachingModules)
                .HasForeignKey(mt => mt.TeacherId);


            modelBuilder.Entity<ModuleOfferingFirstExaminer>()
                .HasKey(mf => new {mf.ModuleOfferingId,mf.TeacherId});

            modelBuilder.Entity<ModuleOfferingFirstExaminer>()
                .HasOne(mf => mf.ModuleOffering)
                .WithMany(mf => mf.FirstExaminers)
                .HasForeignKey(mf => mf.TeacherId);

            modelBuilder.Entity<ModuleOfferingFirstExaminer>()
                .HasOne(mf => mf.Teacher)
                .WithMany(mf => mf.FirstExaminersModules)
                .HasForeignKey(mf =>mf.TeacherId);


            modelBuilder.Entity<ModuleOfferingSecondExaminer>()
                .HasKey(ms => new { ms.ModuleOfferingId, ms.TeacherId });

            modelBuilder.Entity<ModuleOfferingSecondExaminer>()
                .HasOne(ms => ms.ModuleOffering)
                .WithMany(ms => ms.SecondExaminers)
                .HasForeignKey(ms => ms.TeacherId);

            modelBuilder.Entity<ModuleOfferingSecondExaminer>()
                .HasOne(ms => ms.Teacher)
                .WithMany(ms => ms.SecondExaminersModules)
                .HasForeignKey(ms => ms.TeacherId);

            modelBuilder.Entity<StudentRequest>()
                 .HasOne(ms => ms.Student)
                 .WithMany(ms => ms.StudentRequests)
                 .HasForeignKey(ms => ms.StudentId);

            // job post
            modelBuilder.Entity<JobPost>()
             .HasKey(mt => new { mt.Id });

            //WorkTask
            modelBuilder.Entity<WorkingTask>()
                .HasKey(mt => new { mt.WorkingTaskId });

            modelBuilder.Entity<WorkingTask>()
                .HasOne(mt=>mt.Teacher)
                .WithMany(mt => mt.WorkingTasks)
                .HasForeignKey(mt => mt.TeacherId);

            // Recruiment
            modelBuilder.Entity<Person>()
                .HasKey(mt => mt.PersonId);

            modelBuilder.Entity<RecruimentJobPost>()
                .HasKey(mt => new { mt.JobId });

            modelBuilder.Entity<RecruimentApplication>()
                .HasKey(mt=> new {mt.RecruimentJobPostId});
            modelBuilder.Entity<Notification>()
                .HasKey(mt=>mt.NotificationId);

            modelBuilder.Entity<RecruimentApplication>()
                .HasOne(mt=>mt.Person)
                .WithMany(mt=>mt.RecruimentsApplications)
                .HasForeignKey(ms=>ms.PersonId);

            modelBuilder.Entity<RecruimentApplication>()
                .HasOne(mt => mt.RecruimentJobPost)
                .WithMany(mt => mt.recruimentApplications)
                .HasForeignKey(ms => ms.RecruimentJobPostId);

            modelBuilder.Entity<LabEquipment>()
                .HasOne(mt => mt.LabSpace)
                .WithMany(mt => mt.labEquipments)
                .HasForeignKey(mt => mt.LabSpaceId);





        }

        public DbSet<LabEquipment> LabEquipments { get; set; }

       public DbSet<Booking_Lab> Booking_Labs { get; set; }
        public DbSet<LabSpace> LabSpaces { get; set; }
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<ModuleOfferingTeacher> ModuleTeachers { get; set;}
        public DbSet<ModuleOfferingFirstExaminer> ModuleFirstExaminers { get; set; }
        public DbSet<ModuleOfferingSecondExaminer> ModuleSecondExaminers { get; set; }

        //Graduate
        public DbSet<Graduate> Graduates { get; set; }

        // Training 
        public DbSet<StudentRequest> StudentRequests { get; set; }

        public DbSet<JobPost> JobPosts { get; set; }


        // Recruiments

        public DbSet<RecruimentJobPost> RecruimentJobs { get; set; }

        //working Task

        public DbSet <WorkingTask> WorkingTasks { get; set; }



        public DbSet<FileUpload> Files { get; set; }


    }
}
