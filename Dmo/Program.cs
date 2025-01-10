using System.Numerics;
using Dmo.Mapping;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Dmo.Static;

namespace Dmo
{
    internal class Program
    {
        static void Main()
        {

            #region Revision

            // Interface : Reference Type
            // Code Contract
            // Shallow Copy Vs Deep Shallow

            #endregion

            #region Abstraction

            //4. Abstraction
            // abstract: C# Keyword [class methods properties]
            // abstract class
            // abstract method
            // abstract property

            // 2D Shape

            //Shape shape new Shape();
            //NOTE: Can't Create Object From Abstract Class

            //shape.GetArea();

            //Rectangle rectangle = new Rectangle() { Dime1 = 12, Dim02 = 3 };

            ////rectangle.Perimeter = 12;

            //Console.WriteLine(rectangle.Perimeter);

            //Console.WriteLine(rectangle.GetArea());

            //rectangle.Print();

            #endregion

            #region Interface Vs Abstract Class

            // 1. Definition:
            // Interface: Defines a code contract without implementation (prior to C# 8.0). Starting with C# 8.0, interfaces can include default implementations for methods.
            // Abstract Class: A partially implemented class that may contain both abstract and fully implemented members.

            // 2. Members:
            // Interface: Can include the following:
            //   - Signatures for properties, methods, and events.
            //   - Default implemented methods (C# 8.0 and later).
            // Abstract Class: Can include:
            //   - Fields (attributes), methods, properties, and events.
            //   - Abstract members (methods, properties, events) that must be implemented by derived classes.

            // 3. Default Access Modifiers:
            // Interface: Members are implicitly public.
            // Abstract Class: Members are private by default, but can be explicitly declared as protected, internal, or public.

            // 4. Implementation:
            // Interface: 
            //   - A class or struct implements an interface using the : keyword.
            //   - Does not inherit implementation from any interface.
            //   - A class can implement multiple interfaces simultaneously.
            // Abstract Class: 
            //   - A class inherits from an abstract class using the : keyword.
            //   - Can inherit implementation from a base abstract class.
            //   - Requires the override keyword to implement abstract members.

            // 5. Multiple Inheritance:
            // Interface: A class or struct can implement multiple interfaces.
            // Abstract Class: A class cannot inherit from multiple abstract classes (or any other classes). C# does not support multiple inheritance for classes.

            // 6. Full Implementation:
            // Interface: 
            //   - Before .NET Core 3.1 and C# 8.0, interfaces could not have any implementation.
            //   - Starting with C# 8.0, interfaces can include default implementations for methods.
            // Abstract Class: Always allowed to have implemented methods and other members.







            #endregion

            #region  Operator Overloading - (+ Operator)

            // Operator Overloading

            // + - * / % > < >= <= != == || && ! | & ^ >> 

            // +

            // int X = 3 + 4;

            // string Y = "Hello" + "World";

            // Comlex Number

            // Complex Number: Real + Imag

            // 4 + 3 i
            // 4 + 3 ت

            //Complex C01 = new Complex() { Real = 3, Imag = 4 };
            //Complex C02 = new Complex() { Real = 4, Imag = 2 };

            //Console.WriteLine(C01);
            //Console.WriteLine(C02);

            // Complex C03 = C01 + C02;
            // Complex C03 = C01 - C02;


            //Complex C03 = C01 - null;

            //Console.WriteLine(C03);

            #endregion

            #region Operator Overloading - (++ Operator)

            //Complex C01 = new Complex() { Real = 3, Imag = 4 };
            //Complex C02 = new Complex() { Real = 4, Imag = 2 };

            // ++ -- 
            // Unray Operator

            // int X = 12;

            // X++;

            // Console.WriteLine(X);

            //Console.WriteLine(C01);
            //Complex C03 = C01++;

            //Console.WriteLine(C01);


            //Console.WriteLine(C01);
            //Complex C03 = C01--;

            //Console.WriteLine(C01);

            #endregion

            #region  Operator Overloading - (Comparision  Operator)


            //Complex C01 = new Complex() { Real = 3, Imag = 4 };
            //Complex C02 = new Complex() { Real = 4, Imag = 2 };

            //if (C01 >= C02)
            //{
            //    Console.WriteLine(value: "C01 is greater than C02");
            //}
            //else
            //{
            //    Console.WriteLine(value: "C01 is NOT greater than C02");
            //}

            //bool X = true || true;


            #endregion

            #region User-Defined Casting Operator (Manual Mapping)



            //int Y = (int) X;
            //// (int): Casting Operator

            //Complex C01 = new Complex() { Real = 3, Imag 4 };

            //string = (string) C81;
            //// (string): Convert Complex Number To String
            ///
            //// Operator Overloading
            //// User-Defined Casting Operator

            //Console.WriteLine(S);

            //int X = (int) C01;

            //Console.WriteLine(X);

            //int X = (int)new Complex() { Real = 4, Imag = 7 };

            // Mapping: Convert From Datatype To Datatype

            // Code First
            //// DB First

            // User [Id, Name, Email, Password, UserName, Phone Number, CardNumber, ExipreDate]

            // UserViewModel
            // UserDto
            // [Name, Email, PhoneNumber] 

            //User user = new User();
            //// From DB
            //// Mannual Mapping
            //UserDto userDto = new UserDto()
            //{
            //Email = user.Email,
            //Name = user.Name,
            //PhoneNumber = user.PhoneNumber
            //};

            // Casting Operator
            // Automapper Mapping Automatic


            #endregion

            #region Static [Class, Method, Consteuctor, Property, Attributes]

            // static: C# Keyword [class method property constructor attributes]
            // static class
            // static mehtod
            // static property
            // static constructor
            //static attribute

            //Utilities U01 = new Utilities();
            //Utilities U02 = new Utilities();
            //Utilities U03 = new Utilities();

            //Console.WriteLine(U01.CmToInch(254)); // 100
            //Console.WriteLine(U02.CmToInch(254)); // 100
            //Console.WriteLine(U03.CmToInch(254)); // 100

            //Console.WriteLine(Utilities.CmToInch(254)); // 100
            //Console.WriteLine(Utilities.CmToInch(254)); // 100
            //Console.WriteLine(Utilities.CmToInch(254)); // 100 

            //Console.WriteLine(U01.PI);
            //Console.WriteLine(U02.PI);
            //Console.WriteLine(U03.PI);

            //Console.WriteLine(Utilities.PI);
            //Console.WriteLine(Utilities.PI);
            //Console.WriteLine(Utilities.PI);

            //Utilities UI = new Utilities();

            #endregion

            #region Sealed (Class, Method, Property)

            // Sealed : C# Keyword [class - Method - Property]





            #endregion

            #region Partial Classes

            // Partial

            // Employee employee = new Employee()
            // employee





            #endregion

        }
    }
}
