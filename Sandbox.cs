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

            user.GetUserInfo();
        }
    }

    public class User
    {
        

        public void GetUserInfo()
        {

            Console.WriteLine("Please write your first name!");
            string infoFirst = Console.ReadLine();
           
            Console.WriteLine("Please write your last name!");
            string infoLast = Console.ReadLine();


            string[] UserName = new string[2] { infoFirst , infoLast };
            var userName2 = string.Join(",", UserName);

            string fullName = string.Format("Hello {0} {1}", infoFirst , infoLast);

            Console.WriteLine(fullName);
            Console.WriteLine(userName2);


        }



    }



}
