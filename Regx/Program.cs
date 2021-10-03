using System;

namespace Regx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RegeX Programs!");
            Patterns patterns = new Patterns();
            Emails emails = new Emails();
            patterns.Pattern();
            emails.EmailsFormatter();
        }
    }
}
