using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tarea_1.Core;

namespace Tarea_1.Models
{
    public class Estudiante : BaseEntity
    {
     
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Grade { get; set; }
        public int Age { get; set; }



    }
}
