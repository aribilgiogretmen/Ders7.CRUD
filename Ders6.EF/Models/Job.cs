namespace Ders6.EF.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Person>Person { get; set; }
    }
}
