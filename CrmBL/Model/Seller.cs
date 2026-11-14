using System;
using System.Collections.Generic;
using System.Text;

namespace CrmBL.Model
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Sell> Sells{ get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
