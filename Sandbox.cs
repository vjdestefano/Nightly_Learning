// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Sandbox
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {

//             var user = new User();

//             user.GetUserInfo();
            
//         }
//     }

//     public class User
//     {
        

//         public void GetUserInfo()
//         {

//             Console.WriteLine("Please write your first name!");
//             string infoFirst = Console.ReadLine();
           
//             Console.WriteLine("Please write your last name!");
//             string infoLast = Console.ReadLine();


//             string[] UserName = new string[2] { infoFirst , infoLast };
            
//             var userNameString = string.Join(",", UserName);

//             string fullName = string.Format("Hello {0} {1}", infoFirst , infoLast);

//             Console.WriteLine(fullName);
//             Console.WriteLine(userNameString);

//             return userNameString;
//         }



//     }



// }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace APIcaller
{
    class UserName
    {
        private string _userName;
        private string _passWord;
        private List<string> _userDetails = new List<string>();
        
        public void SetName(string userName)
        {
            if (!string.IsNullOrEmpty(userName))
            {
                _userName = userName;
            } else
            {
                Console.WriteLine("please enter a valid User Name!");
            }
        }

        public string GetName(string userName)
        {
            return userName;
        }

        public List<string> UserInput()
        {

            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            Console.WriteLine("Please type your desired user name");
            var userInputName = Console.ReadLine();

            while (userInputName.Length <= 5) 
            {

                Console.WriteLine(userInputName.Length <= 5);

                Console.WriteLine(regexItem.IsMatch(userInputName));


                Console.WriteLine("Please make your user name longer than 5 characters");

                userInputName = Console.ReadLine();
            }


            Console.WriteLine("Please type your desired password");
            var userInputPass = Console.ReadLine();

           

            while (userInputPass.Length <= 5)
            {
                Console.WriteLine("Please make your password longer than 5 characters");
                userInputPass = Console.ReadLine();
            }


            _userDetails.Add(userInputName);
            _userDetails.Add(userInputPass);

            Console.WriteLine("Username: {0} Password:{1}", _userDetails[0], _userDetails[1]);

            return _userDetails;                     
            
        }



    }

    class SelectOption
    {
        private string _state;

        public void SetState(string state, List<string> user)
        {

            if (state == "main menu" || state == "mainmenu")
            {
                Console.WriteLine("_____________Main Menu____________");
                //Console.WriteLine("Edit Inventory");
                //Console.WriteLine("Browse Inventory");
                Console.WriteLine("options");
                Console.WriteLine("*EXIT*");

                _state = state;
                InputState(user);

            }
            if (state == "options" || state == "option")
            {
                Console.WriteLine("_____________Options____________");

                Console.WriteLine("Username: {0} Password:{1}", user[0], user[1]);

                Console.WriteLine("Main Menu");
                //Console.WriteLine("Edit Inventory");
                //Console.WriteLine("Browse Inventory");
                Console.WriteLine("*EXIT*");

                _state = state;
                InputState(user);


            }
            else
            {
                Console.WriteLine("Please Select a Vaild option");
                InputState(user);
            }

        }

        public void InputState(List<string> user)
        {
            Console.WriteLine("Please Enter your state");
            string state = Console.ReadLine().ToLower();
            SetState(state, user);

        }

        public string GetState()
        {
            return _state;
        }













    }
}



}
