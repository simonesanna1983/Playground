using System;
using System.Collections.Generic;
using System.Linq;
using EfCoreCodeFirst.Context;
using EfCoreCodeFirst.Poco;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EfCoreCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertInto();
            InnerJoin();

        }



        public static void InsertInto()
        {
            using (var context = new SchoolContext())
            {

                var grades = new Grade()
                {
                    GradeName = "First Class",
                    Section = "First",
                    Students = new List<Student>()
                    {
                        new Student()
                        {
                            Name = "Bill",
                            DateOfBirth = new DateTime(1992,10,18)
                            
                        },
                        new Student()
                        {
                            Name = "Steve",
                            DateOfBirth = new DateTime(1992,12,18)

                        }

                    }


                };

                context.Grades.Add(grades);
                context.SaveChanges();
            }

        }


        public static void InnerJoin()
        {

            //using (var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole()))
            using (var context = new SchoolContext())
            {
                //var innerJoin = context.Grades.Join(context.Students,
                //    a => a.GradeId,
                //    b => b.GradeId,
                //    (a, b) => new {
                //        grade = a,
                //        student = b}
                //    );

                //var resp = innerJoin.ToList();

                var queryInMemory = context.Grades.Include(x => x.Students);

                var result = queryInMemory.ToList();

                //context.DisposeLogging();
            }
            //Console.WriteLine();
        }




    }
}
