using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        public decimal BaseAmount { get; set; }
        public virtual decimal CalculateTotal()
        {
            return BaseAmount;
        }
    }
}