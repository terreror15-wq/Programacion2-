using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tarea_1.DTOs
{
    public class RequestDTOs
    {
        [Required]
        [JsonIgnore]
        public int Id { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public DateTime DeliveredTime { get; set; }
        [Required]
        public string RequestStatus { get; set; }
    }
}
