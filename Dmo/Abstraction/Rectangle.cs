using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmo.Abstraction
{
    // Concert Class    : Fully Implemented Class
    internal class Rectangle : Shape /*: Implement And Inherit From Shape */
    {

        public override double GetArea()
        {

            return Dim01 * Dim02;
        }

        public override double Perimeter
        {
            get
            {
                return (Dim02 + Dim01) * 2;
            }
        }

    }
}
