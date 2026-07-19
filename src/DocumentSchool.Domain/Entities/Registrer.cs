namespace DocumentSchool.Entities
{
    public class Registrer
    {
         public DateTime CreatedAt { get; set; }
        public DateTime? DeliveredAt { get; set; }
        public int TotalDocuments { get; set; }
        public int Amount { get; set; }
        public int RequestId { get; set; }
        public Request Request { get; set; }
    }
}
