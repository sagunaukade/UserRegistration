using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Program
    {
        public void Main(string[] args)
        {   //Display Welcome message
            Console.WriteLine("Welcome to the user registration programs");
            Console.WriteLine("choose an choice");
            Console.WriteLine("\n1. First Name \n2. Last Name \n3. Email-ID");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                //UC-1
                case 1:
                    UserInfo.ValidateFirstName();
                    break;
                //UC-2
                case 2:
                    UserInfo.ValidateLastName();
                    break;
                //UC-3
                case 3:
                    UserInfo.ValidateEmail();
                    break;
                default:
                    Console.WriteLine("choose a right option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
