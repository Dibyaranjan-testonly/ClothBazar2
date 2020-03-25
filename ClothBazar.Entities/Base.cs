using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Entities
{
    public class Base
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
