using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regx
{
    class Emails
    {
        public void EmailsFormatter()
        {
            Console.WriteLine("1) abc@yahoo.com, 2) abc-100@yahoo.com,3) abc.100@yahoo.com,4) abc111@abc.com,5) abc-100@abc.net,6) abc.100@abc.com.au,7) abc@1.com,8) abc@gmail.com.com,9) abc+100@gmail.com");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.Write("Enter Email: ");
                    string email = Console.ReadLine();
                    Regex rxE = new Regex(@"^[a-z]+[@]+[a-z]+[.]+[a-z]{3}$");
                        Message(rxE.IsMatch(email),email);
                    EmailsFormatter();
                    break;
                case 2:
                    Console.Write("Enter Email: ");
                    string email1 = Console.ReadLine();
                    Regex rxE1 = new Regex(@"^[a-z]+[-]+[0-9]+[@]+[a-z]+[.]+[a-z]{3}$");
                    Message(rxE1.IsMatch(email1), email1);
                    EmailsFormatter();
                    break;
                case 3:
                    Console.Write("Enter Email: ");
                    string email3 = Console.ReadLine();
                    Regex rxE3 = new Regex(@"^[a-z]+[.]+[0-9]+[@]+[a-z]+[.]+[a-z]{3}$");
                    Message(rxE3.IsMatch(email3), email3);
                    EmailsFormatter();
                    break;
                case 4:
                    Console.Write("Enter Email: ");
                    string email4 = Console.ReadLine();
                    Regex rxE4 = new Regex(@"^[a-z]+[0-9]+[@]+[a-z]+[.]+[a-z]{3}$");
                    Message(rxE4.IsMatch(email4), email4);
                    EmailsFormatter();
                    break;
                case 5:
                    Console.Write("Enter Email: ");
                    string email5 = Console.ReadLine();
                    Regex rxE5 = new Regex(@"^[a-z]+[-]+[0-9]+[@]+[a-z]+[.]+[a-z]{3}$");
                    Message(rxE5.IsMatch(email5), email5);
                    EmailsFormatter();
                    break;
                case 6:
                    Console.Write("Enter Email: ");
                    string email6 = Console.ReadLine();
                    Regex rxE6 = new Regex(@"^[a-z]+[.]+[0-9]+[@]+[a-z]+[.]+[a-z]{3}[.]+[a-z]{2}$");
                    Message(rxE6.IsMatch(email6), email6);
                    EmailsFormatter();
                    break;
                case 7:
                    Console.Write("Enter Email: ");
                    string email7 = Console.ReadLine();
                    Regex rxE7 = new Regex(@"^[a-z]+[@]+[0-9]+[.]+[a-z]{3}$");
                    Message(rxE7.IsMatch(email7), email7);
                    EmailsFormatter();
                    break;
                case 8:
                    Console.Write("Enter Email: ");
                    string email8 = Console.ReadLine();
                    Regex rxE8 = new Regex(@"^[a-z]+[@]+[a-z]+[.]+[a-z]{3}[.]+[a-z]{3}$");
                    Message(rxE8.IsMatch(email8), email8);
                    EmailsFormatter();
                    break;
                case 9:
                    Console.Write("Enter Email: ");
                    string email9 = Console.ReadLine();
                    Regex rxE9 = new Regex(@"^[a-z]+[+]+[0-9]+[@]+[a-z]+[.]+[a-z]{3}$");
                    Message(rxE9.IsMatch(email9), email9);
                    EmailsFormatter();
                    break;
                default:
                    Console.WriteLine("Numbers Between 1 to 9");
                    break;
            }
        }
        public void Message(bool rX, string data)
        {
            if (rX == true)
                Console.WriteLine(data);
            else
                Console.WriteLine("Invalid Email Provided by you!");
            Console.WriteLine("--------------------------------");
        }
    }
}
