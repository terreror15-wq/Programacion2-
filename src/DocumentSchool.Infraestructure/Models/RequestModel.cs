using DocumentSchool.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSchool.InfraEstructure.Models
{
    public class RequestModel : BaseEntity
    {
        public DateTime CreatedAt { get; set; }

        public string Status { get; set; }

        public int StudentId { get; set; }
        public StudentModel Student { get; set; }

        public ICollection<DocumentModel> Documents { get; set; }

    }
}
