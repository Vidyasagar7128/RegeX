using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Regx
{
   public class Patterns
    {
        public void Pattern()
        {
            ///FisrtName
            Console.Write("Enter First Name(John): ");
            string name = Console.ReadLine();
            Regex rxName = new Regex(@"^[A-Z]{1}[a-z]{3,}$");
            try
            {
                if (name == "")
                    throw new CustomE(CustomE.Errors.EmptyString, "Empty First Name");
                if(name.Length<3)
                    throw new CustomE(CustomE.Errors.MinLength, "It's too Short");
                if (!rxName.IsMatch(name))
                    throw new CustomE(CustomE.Errors.InvalidName, "Invalid Name");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //LName
            Console.Write("Enter Last Name(Doe): ");
            string lastName = Console.ReadLine();
            Regex rxLName = new Regex(@"^[A-Z]{1}[a-z]{3,}$");
            try
            {
                if (lastName == "")
                    throw new CustomE(CustomE.Errors.EmptyString, "Empty Last Name");
                if (lastName.Length < 3)
                    throw new CustomE(CustomE.Errors.MinLength, "It's too Short");
                if (!rxLName.IsMatch(name))
                    throw new CustomE(CustomE.Errors.InvalidName, "Invalid Name");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Mobile Number
            Console.Write("Enter Mobile(91 9876543210): ");
            string mobile = Console.ReadLine();
            Regex rxMobile = new Regex(@"^[1-9]+\s[0-9]{10,10}$");
            try
            {
                if (mobile == "")
                    throw new CustomE(CustomE.Errors.EmptyString, "Empty Number");
                if (mobile.Length<=10)
                    throw new CustomE(CustomE.Errors.MinLength, "It's too Short");
                if (!rxMobile.IsMatch(mobile))
                    throw new CustomE(CustomE.Errors.InvalidNumber, "Invalid Number");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Enter Email
            Console.Write("Enter Email(john.doe@gmail.co.in): ");
            string email = Console.ReadLine();
            Regex rxEmail = new Regex(@"^[a-z]+[.]?[a-z]+[@]+[a-z]+[.]+[a-z]+[.]?[a-z]+$");
            try
            {
                if (email == "")
                    throw new CustomE(CustomE.Errors.EmptyString, "Empty Email");
                if (!rxEmail.IsMatch(email))
                    throw new CustomE(CustomE.Errors.InvalidEmail, "Invalid Email");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Enter Password
            Console.Write("Enter password(Min 8 char): ");
            string pass = Console.ReadLine();
            Regex rxPass = new Regex(@"^(?=.*[a-zA-Z])(?=.*[0-9]){8,}.+$");
            try
            {
                if (pass == "")
                    throw new CustomE(CustomE.Errors.EmptyString, "Empty Password");
                if (!rxPass.IsMatch(pass))
                    throw new CustomE(CustomE.Errors.InvalidPassword, "Invalid Password");
                if (pass.Length < 8)
                    throw new CustomE(CustomE.Errors.InvalidPassword, "Password Length should be greater than 8");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

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

