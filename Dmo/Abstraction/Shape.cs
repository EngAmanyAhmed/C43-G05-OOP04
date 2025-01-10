using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmo.Abstraction
{
    // Abstract Class   : Partial Class [Not Fully Implemented]
    // Concert Class    : Full Implemented Class
    internal abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        //public double GetArea()
        //{
        //    // How To calculate Area ??
        //}
        // Make This Method Abstract 

        // Abstract Method  : Like Virtual Method Without implementation
        public abstract double GetArea();

        // Abstract Poperty : Like Virtual Poperty Without implementation
        public abstract double Perimeter { get; }

        public void print()
        {
            Console.WriteLine(value: "I am Shape");
        }




    }
}
