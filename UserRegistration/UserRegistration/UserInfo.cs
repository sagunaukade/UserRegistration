using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace UserRegistration
{
    public class UserInfo
    {
        //UC-1 valid first name
        public static void ValidateFirstName()
        {   
            Console.WriteLine("\nPlease Enter your First Name:");
            string firstName = Console.ReadLine();
            //First name starts with Cap and has minimun 3 characters
            string firstName_pattern = "^[A-Z][a-zA-Z]{2,}$";

            if (Regex.IsMatch(firstName, firstName_pattern))
            {
                Console.WriteLine("First Name is Valid");
            }
            else
            {
                Console.WriteLine("First Name is InValid");
                ValidateFirstName();
            }
        }
    }
}
