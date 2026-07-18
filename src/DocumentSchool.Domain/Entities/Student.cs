using DocumentSchool.Domain.Core;

namespace DocumentSchool.Entities
{
    public class Student : BaseEntity
    {
        

        public string Name { get; set; }
        public string LastNAme { get; set; }
        public string Tel { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        public ICollection<Request> Requests { get; set; } 
    }
}
