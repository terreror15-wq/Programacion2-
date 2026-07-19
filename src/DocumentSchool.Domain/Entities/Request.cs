namespace DocumentSchool.Entities
{
    public class Request : BaseEntity
    {
         public DateTime CreatedAt { get; set; }

         public string Status { get; set; }

         public int StudentId { get; set; }
         public Student Student { get; set; }

        public ICollection<Document> Documents { get; set; } 
    }
}
