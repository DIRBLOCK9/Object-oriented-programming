<<<<<<< HEAD
﻿namespace lab_9.Models
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
=======
﻿using System;
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
>>>>>>> ddc7f721d9fe2b425a25fb1dff10ffc705fe33ef
