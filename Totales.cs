using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iva_y_Total_de_5_productos
{
    class Totales
    {
        public double TotalValor(double n1, double n2, double n3, double n4, double n5, double Rs = 0)
        {
            return Rs = n1 + n2 + n3 + n4 + n5;
        }
        public double TotalValor2(double n1, double n2, double n3, double n4, double n5, double Ri = 0)
        {
            return Ri = n1 * 0.12 + n2*0.12 + n3*0.12 + n4*0.12 + n5*0.12;
            
        }
    }
}
