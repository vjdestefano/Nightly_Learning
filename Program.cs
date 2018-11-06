//Vincent DeStefano
//Implementing C# into my skill set

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really long text. ";
            var test = thisDate.sentenceManipulator(sentence, 25);
            Console.WriteLine(test);


        }
    }


    public class arrayMethods
    {

        public int[] testArray = new[] { 2, 3, 4, 5, 6 };


        public void doThis()
        {
            //length
            Console.WriteLine("Lenght: " + testArray.Length);

            //IndexOf()
            var index = Array.IndexOf(testArray, 3);

            Console.WriteLine("index of item at 3: " + index);


            Array.Clear(testArray, 0, 3);

            Console.WriteLine("Effects of Clear()");

            foreach (var n in testArray)
                Console.WriteLine(n);




            int[] another = new int[3];
            Array.Copy(testArray, another, 3);

            foreach (var n in another)
                Console.WriteLine(n);



        }


        public void listThings()
        {


            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });
            foreach (var number in numbers)
                Console.WriteLine(number);


        }


    }


    public class thisDate
    {
        public void thisDateNow()
        {

            var dateTime = new DateTime(2015, 2, 2);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToString("yyyy-MM-dd"));


        }

        public void timeSpanned()
        {

            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            TimeSpan.FromHours(1);


        }

        public void stringstome()
        {

            var fullname = "Vincent DeStefano ";

            Console.WriteLine("Trim: '{0}'", fullname.Trim());

            Console.WriteLine("To Upper: '{0}'", fullname.Trim().ToUpper());


            var index = fullname.IndexOf(' ');

            var firstName = fullname.Substring(0, index);

            var lastName = fullname.Substring(index + 1);

            Console.WriteLine("First Name: '{0}' and Last Name: '{1}'", firstName, lastName);


            var name = fullname.Split(' ');

            var str = "25";
            var age = Convert.ToSByte(str);

            Console.WriteLine(age);

            float money = 90.99f;
            string cash = money.ToString("C");
            Console.WriteLine(cash);
        }

        public static string sentenceManipulator(string sentence, int maxLenght = 20)
        {

            if (sentence.Length < maxLenght)
            {
                return sentence;
            }
            else
            {

                var words = sentence.Split(' ');
                var totalCharacters = 0;

                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLenght)
                    {
                        break;
                    }
                }
                var summary = String.Join(" ", summaryWords) + "...";
                return summary;
            }




        }
    }


}
