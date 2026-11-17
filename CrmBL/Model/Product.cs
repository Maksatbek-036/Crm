using System;
using System.Collections.Generic;
using System.Text;

namespace CrmBL.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public virtual ICollection<Sell> Sells { get; set; }
        public override int GetHashCode()
        {
            return Id;
        }
        public override bool Equals(object? obj)
        {
            if(obj is Product product)
            {
                return Id.Equals(product.Id);
            }
            return false;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
