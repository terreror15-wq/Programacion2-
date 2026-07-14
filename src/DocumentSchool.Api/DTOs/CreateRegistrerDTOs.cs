namespace DocumentSchool.DTOs
{
    public class CreateRegistrerDTOs
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? DeliveredAt { get; set; }
        
        public int Amount { get; set; }
        public int RequestId { get; set; }
    }
}
