using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal total1;

            if (quantity <= 0)
            {
                total1 = 0m;
            }
            else
            {
                total1 = quantity * unitPrice;
            }

            var resumen = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = total1
            };

            return $"{resumen.Code}-{resumen.Description}-{resumen.Total}";
        }
    }
}
