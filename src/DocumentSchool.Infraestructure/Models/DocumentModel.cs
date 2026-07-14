using DocumentSchool.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSchool.InfraEstructure.Models
{
    public class DocumentModel : BaseEntity
    {
        public string NameDocument { get; set; }

        public int RequestId { get; set; }
        public RequestModel Request { get; set; }
    }
}
