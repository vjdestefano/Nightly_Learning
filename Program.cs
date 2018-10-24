using System;
using First_App.Math;

namespace First_App
{

    class Program
    {


        static void Main()
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();


            Calculator calculator = new Calculator();
            var result = calculator.Add(3, 4);
            Console.WriteLine(result);
        }


    }


    public class Person{

        public string FirstName;
        public string LastName;


        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }



        public static int Calcultor(int a, int b)
        {
            return a + b;
        }

    }

   



}

