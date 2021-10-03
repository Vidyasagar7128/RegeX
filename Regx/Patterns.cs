using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Regx
{
   public class Patterns
    {
        public void Pattern()
        {
            ///FName
            Console.Write("Enter First Name(John): ");
            string name = Console.ReadLine();
            Regex rxName = new Regex(@"^[A-Z]{1}[a-z]{3,}$");
            //LName
            Console.Write("Enter Last Name(Doe): ");
            string lastName = Console.ReadLine();
            Regex rxLName = new Regex(@"^[A-Z]{1}[a-z]{3,}$");
            //Mobile Number
            Console.Write("Enter Mobile(91 9876543210): ");
            string mobile = Console.ReadLine();
            Regex rxMobile = new Regex(@"^[1-9]+\s[0-9]{10,10}$");
            //Enter Email
            Console.Write("Enter Email(john.doe@gmail.co.in): ");
            string email = Console.ReadLine();
            Regex rxEmail = new Regex(@"^[a-z]+[.]?[a-z]+[@]+[a-z]+[.]+[a-z]+[.]?[a-z]+$");
            //Enter Password
            Console.Write("Enter password(Min 8 char): ");
            string pass = Console.ReadLine();
            Regex rxPass = new Regex(@"^(?=.*[a-zA-Z])(?=.*[0-9]){8,}.+$");
            Console.WriteLine($"First Name is: {rxName.Match(name)}");
            Console.WriteLine($"last Name is: {rxName.Match(lastName)}");
            Console.WriteLine($"Mobile is: {rxMobile.Match(mobile)}");
            Console.WriteLine($"Email is : {rxEmail.Match(email)}");
            if (rxPass.IsMatch(pass))
                Console.WriteLine($"Password: {pass}");
            else
                Console.WriteLine($"Password length min 8");
            Console.WriteLine("---------------------------------");
            Pattern();
        }
    }
}

