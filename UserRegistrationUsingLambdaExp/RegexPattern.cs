using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingLambdaExp
{
    internal class RegexPattern
    {
        public static Func<string, string> CheckFirstName = (firstName) =>
        {
            // first character in capital and minimum 3 characters name
            string pattern = "(^[^a-z][A-z]{1}[a-z]{2,}$)";
            if (Regex.IsMatch(firstName, pattern))
            {
                Console.WriteLine("Name is valid");
                return firstName;
            }
            else
            {
                Console.WriteLine("Name is Invalid ");
            }
            return firstName;
        };
        public static Func<string, string> CheckLastName = (lastName) =>
        {
            //first character in capital and minimum 3 characters name
            string pattern = "(^[^a-z][A-z]{1}[a-z]{2,}$)";
            if (Regex.IsMatch(lastName, pattern))
            {
                Console.WriteLine("Name is valid");
                return lastName;
            }
            else
            {
                Console.WriteLine("name is Invalid");
            }
            return lastName;
        };
        //UC-3
        public static Func<string, string> CheckEmail = (email) =>
        {
            string pattern = "^[a-zA-Z0-9]{3,}([._+-][0-9a-zA-Z]{2,})*@[0-9a-zA-Z]+[.]?([a-zA-Z]{2,4})+[.]?([a-zA-Z]{2,3})*$";
            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine("entered email is valid");
                Nlog.SuccessLog("Entered mail is valid  " + email);
                return email;
            }
            else
            {
                Console.WriteLine("Entered email is Invalid");
                Nlog.ErrorInfo("Entered mail not valid  " + email);
            }
            return email;
        };
    }
}

