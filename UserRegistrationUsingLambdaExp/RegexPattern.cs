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
                Console.WriteLine("email is valid");
                Nlog.SuccessLog("email is valid  " + email);
                return email;
            }
            else
            {
                Console.WriteLine("email is Invalid");
                Nlog.ErrorInfo("email is Invalid  " + email);
            }
            return email;
        };
        //UC-4
        public static Func<string, string> CheckMobileNumber = (mobileNumber) =>
        {
            string pattern = "^91[ ][1-9][0-9]{9}$";
            if (Regex.IsMatch(mobileNumber, pattern))
            {
                Console.WriteLine("Mobile number is valid");
                Nlog.SuccessLog("mobile number is valid  " + mobileNumber);
                return mobileNumber;
            }
            else
            {
                Console.WriteLine("mobile number is invalid");
                Nlog.ErrorInfo("mobile number is invalid  " + mobileNumber);
                return mobileNumber;
            }
        };
        //UC-5
        public static Func<string, string> CheckPassword = (password) =>
        {
            string pattern = "^(?=.*[A-Z])(?=.*[\\d])(?=.*[\\W_])[a-zA-Z0-9\\[~!\\.@_#\\$%^\\/&*()+\\-{}:\"<>?\\]]{8,}$";
            if (Regex.IsMatch(password, pattern))
            {
                Console.WriteLine("password is valid");
                Nlog.SuccessLog("password is valid  " + password);
                return password;
            }
            else
            {
                Console.WriteLine("password is Invalid");
                Nlog.ErrorInfo("passwordis Invalid  " + password);
                return password;
            }
        };
    }
}

