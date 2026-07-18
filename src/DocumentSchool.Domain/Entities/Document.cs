using DocumentSchool.Domain.Core;

namespace DocumentSchool.Entities
{
    public class Docment : BaseEntity
    {
      

        public string NameDocument { get; set; }

        public int RequestId { get; set; }
        public Request Request { get; set; }
    }
}
