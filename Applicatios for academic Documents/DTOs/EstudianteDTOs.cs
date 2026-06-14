using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tarea_1.DTOs
{
    public class EstudianteDTOs
    {

        [Required]      
        [JsonIgnore]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Grade { get; set; }
        [Required]
        public int Age { get; set; }


    }
}
