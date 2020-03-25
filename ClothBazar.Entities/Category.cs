using System.Collections.Generic;

namespace ClothBazar.Entities
{
    public class Category: Base
    {
        public List<Product> products { get; set; }
    }
}