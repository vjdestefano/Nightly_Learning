using System;
using First_App.Math;

namespace First_App
{

    class Program
    {


        static void Main()
        {
            //var john = new Person();
            //john.FirstName = "John";
            //john.LastName = "Smith";
            //john.Introduce();


            Calculator calculator = new Calculator();
            var result = calculator.Add(3, 4);
            Console.WriteLine(result);


            var firstname = "Vinny";
            var lastname = "DeStefano";

            var fullname = firstname + " " + lastname;
            var myFullName = string.Format("My name is  {0} {1}", firstname, lastname);
            var names = new string[3] { "John", "Jack", "Mary" };
            var formatedNames = string.Join(",", names);

            Console.WriteLine(fullname);
            Console.WriteLine(myFullName);
            Console.WriteLine(names);
            Console.WriteLine(formatedNames);



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



    public class Arraytest
    {

        int[] numberArray = new int[10];

        // use the @ for a verbatim string instead of an indexed string
        string verbatimPath = @"c:\projects\project1\folder1";



    }



}

