using System.Collections.Generic;

namespace EfCoreCodeFirst.Poco
{
    //https://www.entityframeworktutorial.net/efcore/one-to-many-conventions-entity-framework-core.aspx

    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
