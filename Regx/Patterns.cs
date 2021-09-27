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
            string name = Console.ReadLine();
            string rx = @"^[A-Z]{1}[a-z]{3,}$";
            Regex rxName = new Regex(rx);
            Console.WriteLine($"Name is: {rxName.Match(name)}");
        }
    }
}
