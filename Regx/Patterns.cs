using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Regx
{
    class Patterns
    {
        public void Pattern()
        {
            Console.Write("Enter Mobile: ");
            string mobile = Console.ReadLine();
            string rxM = @"^[1-9]+\s[0-9]{10,10}$";
            Regex rxMobile = new Regex(rxM);
            Console.WriteLine($"Mobile is: {rxMobile.Match(mobile)}");
            Pattern();
        }
    }
}
