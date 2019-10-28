using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EfCoreCodeFirst.Context;
using EfCoreCodeFirst.Helper;
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
            //InnerJoin();
            SelectQuerable<Student>();
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


        public static void SelectQuerable<T>()
        {
            using (var context = new SchoolContext())
            {

                IQueryable<Student> resultQueryable = context.Students.Where(x => x.Id == 1);

                Console.WriteLine(resultQueryable.ToSql());

                /*********************/

                //https://stackoverflow.com/questions/8315819/expression-lambda-and-query-generation-at-runtime-simplest-where-example/8315901#8315901


                //IQueryable<Student> resultQueryable = context.Students.Where(item => item.Id == 1);

                var item = Expression.Parameter(typeof(Student), "item");
                var prop = Expression.Property(item, "Id");
                var numberId = Expression.Constant(1);
                var equal = Expression.Equal(prop, numberId);
                Expression<Func<Student, bool>> lambda = Expression.Lambda<Func<Student, bool>>(equal, item);

                IQueryable<Student> result = context.Students.Where(lambda);

                Console.WriteLine(resultQueryable.ToSql());


                var qq = result.ToList();

            }
        }



    }
}
