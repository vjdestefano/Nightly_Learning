using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises1
{

    public class checkNumber{

        private int priv;

        public bool check()
        {

            Console.WriteLine("please enter a number 1 though 10");
            var userNum = Console.ReadLine();
            Console.WriteLine(userNum);
            int userNumInt = Convert.ToInt32(userNum);

            if (userNumInt >= 1 && userNumInt <= 10)
            {
                Console.WriteLine("this number is between 1 and 10");
                return true;
            }

            else
            {
                Console.WriteLine("this number is not between 1 and 10");
                return false;
            }
        }

        public int writeThis(string var)
        {
            priv = Convert.ToInt32(var);
            return priv;
        }

}



    



    class Program
    {
        static void Main(string[] args)
        {

            checkNumber checkThisInt = new checkNumber();
            var userBool = checkThisInt.check();

            if(userBool == true)
            {
                Console.WriteLine("Congrats your number was correctly picked");
            }
            else
            {
                checkThisInt.check();  
            }



        }
    }
}
