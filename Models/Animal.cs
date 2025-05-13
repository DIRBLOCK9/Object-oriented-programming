using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Species { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

}
