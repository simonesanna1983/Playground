using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreCodeFirst.Poco
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        //If you want to make the foreign key GradeId as nullable, then use nullable int data type (Nullable<int> or int?),
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}



//public DateTime DateOfBirth { get; set; }