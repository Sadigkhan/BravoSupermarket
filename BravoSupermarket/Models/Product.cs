using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BravoSupermarket.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
