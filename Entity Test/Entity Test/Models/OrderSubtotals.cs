using System;
using System.Collections.Generic;

namespace Entity_Test.Models
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
