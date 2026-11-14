using System;
using System.Collections.Generic;
using System.Text;

namespace CrmBL.Model
{
    public class Sell
    {
        public int Id{ get; set; }
        public int ProductId{ get; set; }
        public virtual Product Product { get; set; }
        public int CheckId{ get; set; }
        public virtual Check Check { get; set; }

    }
}
