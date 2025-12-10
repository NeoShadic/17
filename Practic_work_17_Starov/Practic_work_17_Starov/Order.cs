using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_work_17_Starov
{
    internal class Order
    {
        public int Id { get; set; }
        public decimal Total { get; set; }

        public override string ToString()
        {
            return $"Order #{Id}, Total: {Total:C}";
        }
    }
}
