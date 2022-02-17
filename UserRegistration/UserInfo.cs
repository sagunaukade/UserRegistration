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
        //UC-2 valid last name
        public static void ValidateLastName()
        {
            Console.WriteLine("\nPlease Enter your Last Name:");
            string lastName = Console.ReadLine();
            // Last name starts with Cap and has minimun 3 characters
            string lastName_pattern = "^[A-Z][a-zA-Z]{2,}$";

            if (Regex.IsMatch(lastName, lastName_pattern))
            {
                Console.WriteLine("Last Name is Valid");
            }
            else
            {
                Console.WriteLine("Last Name is InValid");
                ValidateLastName();
            }
        }
        //UC-3 valid email
        public static void ValidateEmail()
        {
            Console.WriteLine("\nPlease Enter your Email-ID:");
            Console.WriteLine("Note: E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl & co) and 2 optional (xyz & in) with precise @ and . positions");
            string email = Console.ReadLine();
            string email_pattern = @"^[a-zA-Z0-9]{3,10}([._+-][a-zA-Z0-9]{1,10})?@[a-zA-Z0-9]{1,10}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";

            if (Regex.IsMatch(email, email_pattern))
            {
                Console.WriteLine("Email is Valid");
            }
            else
            {
                Console.WriteLine("Email is InValid");
                ValidateEmail();
            }
        }
        //UC_4 valid mobile number
        public static void ValidateMobileNumber()
        {
            Console.WriteLine("\nPlease Enter your Mobie Number:");
            string mobNum = Console.ReadLine();
            // Country code follow by space and 10 digit number
            string mobNum_pattern = "^[+]?91[ -][1-9][0-9]{9}$";

            if (Regex.IsMatch(mobNum, mobNum_pattern))
            {
                Console.WriteLine("Mobie Number is Valid");
            }
            else
            {
                Console.WriteLine("Mobie Number is InValid");
                ValidateMobileNumber();
            }
        }
        //UC5 valid password 
        //UC6 Atleast one upper case
        //UC7
        //UC8
        public static void ValidatePassword()
        {
            Console.WriteLine("\nPlease Enter your Password:");
            string password = Console.ReadLine();
            //Password must contain one special character
            string password_pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@?^*!~]).{8,}$";  

            if (Regex.IsMatch(password, password_pattern))
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password is InValid");
                ValidatePassword();
            }
        }
    }
}
