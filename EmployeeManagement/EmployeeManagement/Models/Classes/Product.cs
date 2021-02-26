using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Models.Classes
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
    }
}
