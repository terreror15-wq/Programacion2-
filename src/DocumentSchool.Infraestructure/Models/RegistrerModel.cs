using DocumentSchool.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSchool.InfraEstructure.Models
{
    public class RegistrerModel : BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? DeliveredAt { get; set; }
        public int TotalDocuments { get; set; }
        public int Amount { get; set; }
        public int RequestId { get; set; }
        public RequestModel Request { get; set; }
    }
}
