using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {   //Display Welcome message
            Console.WriteLine("Welcome to the user registration programs");
            //UC-1 
            UserInfo.ValidateFirstName();
            Console.ReadLine();
        }
    }
}
