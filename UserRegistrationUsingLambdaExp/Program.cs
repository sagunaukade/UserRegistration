using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationUsingLambdaExp
{
    internal class Program
    {
        //Instance Variable
        public static string firstName, lastName, email;
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the User Registration using Lambda Expression");
            Console.WriteLine("Choose an Option:\n1. First Name \n2.Last Name \n3.Email \n4.Mobile Number");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //first letter should be in capital format
                    Console.WriteLine("Enter your first name");
                    firstName = Console.ReadLine();
                    RegexPattern.CheckFirstName(firstName);
                    break;
                case 2:
                    //first letter should be in capital format
                    Console.WriteLine("Enter your Last Name");
                    lastName = Console.ReadLine();
                    RegexPattern.CheckLastName(lastName);
                    break;
                case 3:
                    //UC-3
                    Console.WriteLine("Enter your email");
                    email = Console.ReadLine();
                    RegexPattern.CheckEmail(email);
                    break;
                case 4:
                    //UC-4
                    Console.WriteLine("Enter your mobile number");
                    string mobileNumber = Console.ReadLine();
                    RegexPattern.CheckMobileNumber(mobileNumber);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.ReadLine();
        }
    }
}
