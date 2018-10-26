using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            string userNameData = user.GetUserInfo();
            string arrayTested = user.arrayTest(userNameData);
           
        }
    }

    public class User
    {


        public string GetUserInfo()
        {

            Console.WriteLine("Please write your first name!");
            string infoFirst = Console.ReadLine();

            Console.WriteLine("Please write your last name!");
            string infoLast = Console.ReadLine();


            string[] UserName = new string[2] { infoFirst, infoLast };
            string userName2 = string.Join(" ", UserName);

            string fullName = string.Format("Hello {0} {1}", infoFirst, infoLast);

            //Console.WriteLine(fullName);
            

            return userName2;
        }

        public string arrayTest(string UserName)
        {
            Console.WriteLine(UserName);
            return UserName;

        }

        
    }



}
