using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copiaValor = originalValue;
            copiaValor++;

            Product copiaProd = product;

           copiaProd.Description = "Descripción Modificada";

            return $"{originalValue}-{copiaValor}-{product.Description}";
        }
    }
}
