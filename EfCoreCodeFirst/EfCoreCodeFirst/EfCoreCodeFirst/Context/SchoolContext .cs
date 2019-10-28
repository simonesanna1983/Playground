using System;
using System.Collections.Generic;
using System.Text;
using EfCoreCodeFirst.Poco;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace EfCoreCodeFirst.Context
{
    public class SchoolContext : DbContext
    {
        //public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public static readonly ILoggerFactory loggerFactory
            = LoggerFactory.Create(builder =>
            {
                builder
                    .AddFilter((category, level) =>
                        category == DbLoggerCategory.Database.Command.Name
                        && level == LogLevel.Information)
                    .AddConsole();
            });

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(loggerFactory);
            //optionsBuilder.UseNpgsql(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
            optionsBuilder.UseNpgsql("Host=ec2-54-247-178-166.eu-west-1.compute.amazonaws.com;Database=ddj8nmfv3iar60;Username=tfxyicadvqupzo;Password=fd62e90c66905fe63ecd8f5cde70a406da47fc7946ba5ce50a343946a1b94bc9;SSL Mode=Require;Trust Server Certificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //one-to-many relationship
            modelBuilder.Entity<Student>()
                .HasOne<Grade>(s => s.Grade)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.GradeId);


            // add-migration CreateSchoolDB ( or dotnet ef migrations add CreateSchoolDB by its CLI)
            //update-database –verbose   ( or dotnet ef database update by its CLI)

            // add a column into poco
            // Add-Migration Name

        }

    }
}
