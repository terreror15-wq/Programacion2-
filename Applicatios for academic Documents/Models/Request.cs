using Tarea_1.Core;

namespace Tarea_1.Models
{
    public class Request : BaseEntity
    {
      
        public DateTime CreateDate { get; set; }
        public DateTime DeliveredTime { get; set; }
        public string RequestStatus { get; set; }

    }
}
