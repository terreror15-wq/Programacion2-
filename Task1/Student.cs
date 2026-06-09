using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2HomeWork1.Models
{
    public class Student : ComunityMembers
    {
        public string Subject { get; set; }
        public string CourseLevel { get; set; }
        public double Grades { get; set; }
    }
}
