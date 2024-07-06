namespace Ders6.EF.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ?Phone { get; set; }

        public string? Address { get; set; }
        public int? JobId { get; set; }

        public Job Job { get; set; }
    }
}
