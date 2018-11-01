//Vincent DeStefano
//Implementing C# into my skill set


using System;
using First_App.Math;

namespace First_App
{

    class Program
    {


        static void Main()
        {

            var testCount = new divisable();
            testCount.count();

            var ok = new ok();
            ok.calcSum();

            Console.WriteLine("this is was the commit!");

        }


    }


    public class Person {

        public string FirstName;
        public string LastName;


        public void Introduce(string FirstName, string LastName)
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }

        public string insertName()
        {
            FirstName = Console.ReadLine();
            LastName = Console.ReadLine();

            Introduce(FirstName: FirstName, LastName: LastName);

            string nameDummy = string.Format("{0} {1}", FirstName, LastName);


            return nameDummy;


        }

        public void PersonName(string name)
        {

            char[] testChar = new char[100];

            for (var i = 0; i < name.Length; i++)
            {
                var t = name[i];
                testChar[i] = t;
                Console.WriteLine(testChar);
            }

            



        }
    


        public static int Calcultor(int a, int b)
        {
            return a + b;
        }

    }



    public class divisable
    {

        public void count()
        {
            int properlyDivisable = 0;
            int max = 100;
            for (var i = 0; i < max; i++)
            {
                if( i % 3 == 0)
                {
                    properlyDivisable++;

                } else
                {
                    continue;

                }

            }

            Console.WriteLine(properlyDivisable);

        }

    }





    public class ok
    {
       

        public void calcSum()
        {
            int count = 0;
            for (var i = 0; ; i++)
            {
                
                string number = Console.ReadLine();
                if(number == "ok")
                {
                    break;
                }
                else
                {
                    var test = Convert.ToInt32(number);
                    count = count + test;
                    Console.WriteLine(count);
                    
                }

            }

        }

    }




    public class Arraytest
    {

        int[] numberArray = new int[10];

        // use the @ for a verbatim string instead of an indexed string
        string verbatimPath = @"c:\projects\project1\folder1";



    }



}

