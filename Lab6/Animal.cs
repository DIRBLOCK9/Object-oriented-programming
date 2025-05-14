using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Animal
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public string Name { get; set; } = string.Empty; // встановлення значення за замовчуванням
        public string Species { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {

            return $"{Name} - {Species} - {Price:C} - {Stock} шт.";
        }
}
}