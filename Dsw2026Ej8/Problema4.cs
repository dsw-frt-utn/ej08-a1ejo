using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double sumaNotas= 0;
            int validas = 0;

            if (nota1.HasValue && nota1.Value >= 0 && nota1.Value <= 10)
            {
                sumaNotas += nota1.Value;
                validas++;
            }

            if (nota2.HasValue && nota2.Value >= 0 && nota2.Value <= 10)
            {
                sumaNotas += nota2.Value;
                validas++;
            }

            if (nota3.HasValue && nota3.Value >= 0 && nota3.Value <= 10)
            {
                sumaNotas += nota3.Value;
                validas++;
            }

            if (validas == 0)
            {
                return 0.0; 
            }

            return sumaNotas / validas;
        }
    }
}
