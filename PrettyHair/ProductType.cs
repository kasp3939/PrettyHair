using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
    public class ProductType
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public ProductType()
        {

        }

        public ProductType(string description, decimal price, decimal amount)
        {
            Description = description;
            Price = price;
            Amount = amount;

        }



    }
}
