using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Entities
{
   public  class Product: Base
    {
        public decimal price { get; set; }
        public Category category { get; set; }
    }
}
