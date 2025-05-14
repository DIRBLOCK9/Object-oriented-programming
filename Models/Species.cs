namespace lab_9.Models
{
    public class Species
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public required ICollection<Animal> Animals { get; set; }
    }
}
