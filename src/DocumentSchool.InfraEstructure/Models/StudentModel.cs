using DocumentSchool.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSchool.InfraEstructure.Models
{
    public class StudentModel : BaseEntity
    {

        public string Name { get; set; }
        public string LastNAme { get; set; }
        public string Tel { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public ICollection<RequestModel> Requests { get; set; }
    }
}
