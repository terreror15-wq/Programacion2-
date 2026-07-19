namespace DocumentSchool.Entities
{
    public class Docment
    {
        public string NameDocument { get; set; }

        public int RequestId { get; set; }
        public Request Request { get; set; }
    }
}
