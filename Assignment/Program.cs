using System.Security.Claims;
using System.Threading;
using Assignment.Project1;
using Assignment.Project2;
using Assignment.Project3;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region First Project

            // 1. Define 3D Point Class and the basic Constructors (use chaining in constructors).
            // 2. Override the ToString Function to produce this output:
            /*Point3D P = new Point3D (10,10,10);
            Console. WriteLine (P. ToString( ));
            Output: “Point Coordinates: (10, 10, 10)”.*/
            // 3. Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).
            // 4. Try to use == , If (P1 == P2)   Does it work properly? 
            // 5. Define an array of points and sort this array based on X & Y coordinates.
            // 6. Implement ICloneable interface to be able to clone the object.To implement more than one interface.
            // class Point3D:IComparable ,ICloneable

            Point3D p1 = new Point3D(10, 10, 10);
            Point3D p2 = new Point3D(10, 10, 10);
            Point3D p3 = new Point3D(5, 5, 5);

            Console.WriteLine(p1); // Output: Point Coordinates: (10, 10, 10)
            Console.WriteLine(p1 == p2); // Output: True
            Console.WriteLine(p1 == p3); // Output: False


            #endregion


            #region Second Project

            // Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters. Call each method in Main ().
            // Modify the program so that you do not have to create an instance of class to call the four methods.

            int sum = Maths.Add(5, 3);
            int difference = Maths.Subtract(10, 4);
            int product = Maths.Multiply(2, 6);
            double quotient = Maths.Divide(15, 3);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");

            try
            {
                quotient = Maths.Divide(10, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion


            #region Third Project

            // 1. Define Class Duration To include Three Attributes Hours, Minutes and Seconds.

            // 2. Override All System.Object Members(ToString, Equals, GetHasCode) .


            Duration duration1 = new Duration(1, 30, 45);
            Duration duration2 = new Duration(1, 30, 45);
            Duration duration3 = new Duration(2, 15, 0);

            Console.WriteLine(duration1); // Output: 01:30:45
            Console.WriteLine(duration2); // Output: 01:30:45

            Console.WriteLine($"duration1 equals duration2: {duration1.Equals(duration2)}"); // Output: True
            Console.WriteLine($"duration1 equals duration3: {duration1.Equals(duration3)}"); // Output: False

            Console.WriteLine($"duration1 hash code: {duration1.GetHashCode()}");
            Console.WriteLine($"duration2 hash code: {duration2.GetHashCode()}");

            #endregion

        }
    }
}
