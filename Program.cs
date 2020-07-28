using System;
using System.Text.RegularExpressions;

namespace _07272020_REGEX_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = ValidateName("Hello! Please input a valid name.");
            string email = ValidateEmail("Please input your e-mail address.");
            string phone = ValidatePhone("Please enter your phone number with dashes. ex 555-555-5555");
            string date = ValidateDate("Please input a valid date including /. Ex: dd/mm/yyyy");
        }
        public static string ValidateName(string message)
        {
            bool validate = false;
            string input = "";
            input = GetUserInfo(message);
            while (validate == false)
            {

                if (Regex.IsMatch(input, "^[A-Z]{1}[a-z]{1,29}$"))
                {
                    Console.WriteLine("Name is valid!");
                    break;
                }
                else
                {
                    input = GetUserInfo("Please input a valid name, with proper capitalization. ex. John, Joanne");
                }
            }
            return input;
        }
        public static string ValidateEmail(string message)
        {
            bool validate = false;
            string input = GetUserInfo(message);
            while (validate == false)
            {
                input = GetUserInfo(message);
                if (Regex.IsMatch(input, "^[A-Za-z0-9]{5,30}[@][A-Za-z0-9]{5,10}[.]{1}[a-zA-Z0-9]{2,3}$"))
                {
                    Console.WriteLine("E-mail is valid!");
                    break;
                }
                else
                {
                    input = GetUserInfo("Please input a valid e-mail. ex. trogdor@burninate.com");
                }
            }
            return input;
        }
        public static string ValidatePhone(string message)
        {
            bool validate = false;
            string input = GetUserInfo(message);
            while (validate == false)
            {
                input = GetUserInfo(message);
                if (Regex.IsMatch(input, "^[0-9]{3}[-]{1}[0-9]{3}[-]{1}[0-9]{4}$"))
                {
                    Console.WriteLine("Phone entry is valid!");
                    break;
                }
                else
                {
                    input = GetUserInfo("Please input a valid phone number with dahes. Ex. 555-555-5555");
                }
            }
            return input;
        }
        public static string ValidateDate(string message)
        {
            bool validate = false;
            string input = GetUserInfo(message);
            while (validate == false)
            {

                if (Regex.IsMatch(input, "^(([3]{1}[01]{1})|([21]{1}[0-9]{1})|([0]{1}[1-9]{1}))[/](([1]{1}[012]{1})|([0]{1}[1-9]{1}))[/](([12]{1}[0-9]{3}))$"))
                {
                    Console.WriteLine("Date is valid!");
                    break;
                }
                else
                {
                    input = GetUserInfo("Please input a valid date in the format with slashes. ex: dd/mm/yyyy");
                }
            }
            return input;
        }
        public static string ValidateHTML(string message)
        {
            bool validate = false;
            string input = GetUserInfo(message);
            while (validate == false)
            {

                if (Regex.IsMatch(input, "[<]{1}[/]{0,1}[a-zA-Z0-9]{1,3}[>]{1}"))
                {
                    Console.WriteLine("HTML expresion is valid!");
                    break;
                }
                else
                {
                    input = GetUserInfo("Please input a valid HTML expression. ex: (<p> or </p> ");
                }
            }
            return input;
        }
        public static string PullREGEX(string dataType)
        {
            if (dataType == "date")
            {
                return "x";
            }
            else if (dataType == "name")
            {
                return "x";
            }
            else if (dataType == "phone")
            {
                return "x";
            }
            else if (dataType == "e-mail")
            {
                return "x";
            }
            else
            {
                return "ok";
            }

        }
        public static string GetUserInfo(string message)
        {
            string input = "";
            Console.WriteLine(message);
            input = Console.ReadLine();
            return input;
        }
    }
}
