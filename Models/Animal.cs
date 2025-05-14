namespace lab_9.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int SpeciesId { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }

        public required Species Species { get; set; }
    }
}