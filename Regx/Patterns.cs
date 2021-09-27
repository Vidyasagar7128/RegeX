using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Regx
{
    class Patterns
    {
        public void Pattern()
        {
            Console.Write("Enter Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter LastName: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            string rx = @"^[A-Z]{1}[a-z]{3,}$";
            string rxE = @"^[a-z]+[.]?[a-z]+[@]+[a-z]+[.]+[a-z]+[.]?[a-z]+$";
            Regex rxName = new Regex(rx);
            Regex rxLast = new Regex(rx);
            Regex rxEmail = new Regex(rxE);
            Console.WriteLine($"Name is: {rxName.Match(firstName)} Surname : {rxLast.Match(lastName)} Email : {rxEmail.Match(email)}");
            Pattern();
        }
    }
}
