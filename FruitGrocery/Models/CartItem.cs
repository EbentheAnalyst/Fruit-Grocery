using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitGrocery.Models
{
    public class CartItem
    {
        public Fruit Fruit { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => Fruit.Price * Quantity;
    }
}
