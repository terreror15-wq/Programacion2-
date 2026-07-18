namespace DocumentSchool.Aplication.DTOs
{
    public class RegistrerDTOs
    {

        public DateTime CreatedAt { get; set; }
        public DateTime? DeliveredAt { get; set; }
        public int TotalDocuments { get; set; }
        public int Amount { get; set; }
        public int RequestId { get; set; }
    }
}
